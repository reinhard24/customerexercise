CREATE PROCEDURE [dbo].[spCustomer_GetAll]
	@CusId int
AS
BEGIN
	SELECT *
	FROM dbo.Customer
	WHERE CusId = @CusId;
END