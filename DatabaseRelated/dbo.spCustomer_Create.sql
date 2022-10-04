CREATE PROCEDURE [dbo].[spCustomer_Create]
	@CusName nchar(50),
	@CusAddress nchar(100),
	@CusPhone nvarchar(20)
AS
BEGIN
	INSERT INTO dbo.Customer (CusName, CusAddress, CusPhone)
	VALUES (@CusName, @CusAddress, @CusPhone)

	SELECT *
	FROM dbo.Customer
	WHERE CusId = SCOPE_IDENTITY(); -- is more accurate
END