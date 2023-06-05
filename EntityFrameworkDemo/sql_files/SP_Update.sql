-- Update a Product
CREATE PROCEDURE SP_Update_Product
@id int,
@ProductName nvarchar(100),
@ProductDescription nvarchar(100),
@ProductCost decimal(18,2),
@Stock int
AS
BEGIN
SET NOCOUNT ON;
UPDATE Product_Master
SET product_name = @ProductName,
product_desc = @ProductDescription,
cost = @ProductCost,
stock = @Stock
WHERE id = @id
END
