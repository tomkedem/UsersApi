CREATE PROCEDURE [dbo].[spUser_Update]
	
  @id int,
  @user_id nvarchar(15),
  @f_name nvarchar(15),
  @l_name nvarchar(15),
  @name_for_print nvarchar(50),
  @gender_id int,
  @prefix_id int,
  @gender nvarchar(15),
  @prefix nvarchar(15),
  @mail nvarchar(15),
  @mail2 nvarchar(15),
  @cellphone nvarchar(15),
  @id_number nvarchar(15),
  @en_f_name nvarchar(15),
  @en_l_name nvarchar(15),
  @birth_date date,
  @job_address nvarchar(15),
  @home_address nvarchar(15),
  @home_phone nvarchar(15),
  @job_phone nvarchar(15),
  @organization nvarchar(50),
  @following_by nvarchar(15),
  @is_active bit,
  @insert_user_id nvarchar(15),
  @insert_date datetime,
  @update_user_id nvarchar(15),
  @update_date datetime
AS
begin
	update dbo.directory
	set [f_name]=@f_name 
	,[l_name]=@l_name 
	,[name_for_print]=@name_for_print 
	,[gender_id] =@gender_id
	,[prefix_id]=@prefix_id
	,[mail]=@mail 
	,[mail2] = @mail2
	,[cellphone]=@cellphone 
	,[id_number]=@id_number 
	,[en_f_name] =@en_f_name
	,[en_l_name] =@en_l_name
	,[birth_date]=@birth_date
	,[job_address]=@job_address 
	,[home_address]=@home_address 
	,[home_phone] =@home_phone
	,[job_phone] = @job_phone
	,[organization]=@organization
	,update_date=GETDATE()
	,update_user_id=@update_user_id
	where id=@id;
end
