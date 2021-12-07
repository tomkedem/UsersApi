CREATE PROCEDURE [dbo].[spGetNameforprintUsingLikeOperator]
	@nameforprint nvarchar(30)
AS

begin
	SELECT top (50) name_for_print 
	from directory 
	where name_for_print like '%'+@nameforprint+'%' and is_active =1
end
