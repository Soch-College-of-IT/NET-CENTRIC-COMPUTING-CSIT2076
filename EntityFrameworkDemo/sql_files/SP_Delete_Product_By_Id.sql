-- Delete Product by Id
CREATE PROCEDURE SP_Delete_Product_By_Id
@id int
AS
BEGIN
SET NOCOUNT ON;
DELETE FROM Product_Master
WHERE id = @id
END