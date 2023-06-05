-- Get all product
CREATE PROCEDURE SP_Get_ProductList
-- Add the parameters for the stored procedure here
AS
BEGIN
SET NOCOUNT ON;
SELECT id as Id,
product_name as ProductName,
product_desc as ProductDescription,
cost as ProductCost,
stock as Stock
FROM Product_Master
END