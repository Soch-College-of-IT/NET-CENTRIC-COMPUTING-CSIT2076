using EntityFrameworkDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EntityFrameworkDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            List<Product> productList = new List<Product>();
            var dbconfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            try
            {
                string dbconnectionStr = dbconfig["ConnectionStrings:DefaultConnection"];
                string sql = "SP_Get_ProductList";
                using (SqlConnection connection = new SqlConnection(dbconnectionStr))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Product product = new Product();
                            product.Id = Convert.ToInt32(dataReader["Id"]);
                            product.ProductName = Convert.ToString(dataReader["ProductName"]);
                            product.ProductDescription = Convert.ToString(dataReader["ProductDescription"]);
                            product.ProductCost = Convert.ToDecimal(dataReader["ProductCost"]);
                            product.Stock = Convert.ToInt32(dataReader["Stock"]);
                            productList.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(productList);
        }

        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dbconfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json").Build();
                    if (!string.IsNullOrEmpty(dbconfig.ToString()))
                    {
                        string dbconnectionStr = dbconfig["ConnectionStrings:DefaultConnection"];
                        using (SqlConnection connection = new SqlConnection(dbconnectionStr))
                        {
                            string sql = "SP_Add_New_Product";
                            using (SqlCommand cmd = new SqlCommand(sql, connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                                cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                                cmd.Parameters.AddWithValue("@ProductCost", product.ProductCost);
                                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                                connection.Open();
                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Product");
        }

        public IActionResult ProductUpdate(int id)
        {
            var dbconfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            string dbconnectionStr = dbconfig["ConnectionStrings:DefaultConnection"];
            Product product = new Product();
            using (SqlConnection connection = new SqlConnection(dbconnectionStr))
            {
                string sql = "SP_Get_Product_By_Id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            product.Id = Convert.ToInt32(dataReader["Id"]);
                            product.ProductName = Convert.ToString(dataReader["ProductName"]);
                            product.ProductDescription = Convert.ToString(dataReader["ProductDescription"]);
                            product.ProductCost = Convert.ToDecimal(dataReader["ProductCost"]);
                            product.Stock = Convert.ToInt32(dataReader["Stock"]);
                        }
                    }
                }
                connection.Close();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dbconfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json").Build();
                    if (!string.IsNullOrEmpty(dbconfig.ToString()))
                    {
                        string dbconnectionStr = dbconfig["ConnectionStrings:DefaultConnection"];
                        using (SqlConnection connection = new SqlConnection(dbconnectionStr))
                        {
                            string sql = "SP_Update_Product";
                            using (SqlCommand cmd = new SqlCommand(sql, connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Id", product.Id);
                                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                                cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                                cmd.Parameters.AddWithValue("@ProductCost", product.ProductCost);
                                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                                connection.Open();
                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Product");
        }

        public IActionResult ProductDelete(int id)
        {
            var dbconfig = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json").Build();

            string dbconnectionStr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(dbconnectionStr))
            {
                string sql = "SP_Delete_Product_By_Id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    connection.Close();
                }
            }
            return RedirectToAction("Product");
        }
    }
}
