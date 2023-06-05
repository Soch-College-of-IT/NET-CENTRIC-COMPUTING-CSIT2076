CREATE PROCEDURE SP_Add_New_Product
-- Add the parameters for the stored procedure here
@ProductName nvarchar(200),
@ProductDescription nvarchar(200),
@ProductCost decimal(18,2),
@Stock int
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements
SET NOCOUNT ON;
-- Insert statements for procedure here
INSERT INTO Product_Master (product_name, product_desc, cost, stock)
VALUES (@ProductName, @ProductDescription, @ProductCost, @Stock)
END