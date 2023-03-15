USE [p2603381]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_SelectALL]
		@param2 = NULL

SELECT	@return_value as 'Return Value'

GO
