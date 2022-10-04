CREATE PROCEDURE [dbo].[spCustomer_Update]
	@CusName nchar(50),
	@CheckId int
AS
BEGIN
	update dbo.Customer
	SET CusName = @CusName
	WHERE CusId = @CheckId
END