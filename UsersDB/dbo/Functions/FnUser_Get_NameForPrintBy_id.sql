CREATE FUNCTION [dbo].[FnUser_Get_NameForPrintBy_id]
(
	@Id int
)
RETURNS nvarchar(15)
AS
BEGIN
 
 RETURN (select name_for_print from directory 
			               where id=@Id)
END
