CREATE FUNCTION [dbo].[FnUser_Get_NameForPrintBy_user_id]
(
	@user_id nvarchar(15)
)
RETURNS nvarchar(15)
AS
BEGIN
 
 RETURN (select name_for_print from directory 
			               where user_id=@user_id)
END
