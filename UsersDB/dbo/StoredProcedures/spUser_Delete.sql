CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int,
	@Update_user_id nvarchar(15) = null
AS
begin
	update dbo.directory
	set is_active = 0 ,update_date=GETDATE(),update_user_id=@Update_user_id
	where id=@Id;
end
