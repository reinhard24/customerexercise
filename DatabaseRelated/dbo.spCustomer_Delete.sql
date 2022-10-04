CREATE PROCEDURE [dbo].[spCustomer_Delete]
	@CheckId int
AS
BEGIN
	DELETE FROM dbo.Customer
	WHERE CusId = @CheckId
END