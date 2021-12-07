CREATE FUNCTION [dbo].[FnUser_Get_IdBy_user_id]
(
	@user_id nvarchar(15)
)
RETURNS int
AS
BEGIN
 
 
	RETURN (select id from directory 
			               where user_id=@user_id)
END
