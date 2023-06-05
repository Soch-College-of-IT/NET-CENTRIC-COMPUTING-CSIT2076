--Get Product by ID
CREATE PROCEDURE SP_Get_Product_By_Id
-- Add the parameters for the stored procedure here
@id int
AS
BEGIN
SET NOCOUNT ON;
SELECT id as Id, 
product_name as ProductName,
product_desc as ProductDescription,
cost as ProductCost,
stock as Stock
FROM Product_Master 
WHERE id = @id
END