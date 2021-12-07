CREATE PROCEDURE [dbo].[spUser_Get]
		@Id int
AS
begin
	SELECT  d.id, d.user_id, d.f_name, d.l_name, d.name_for_print, d.gender_id, d.prefix_id, d.mail, d.mail2, d.cellphone, d.id_number,
       d.en_f_name, d.en_l_name, d.birth_date, d.job_address, d.home_address, d.home_phone, d.job_phone, 
       d.organization, d.following_by, d.is_active, d.insert_date, d.insert_user_id, d.update_date, 
      d.update_user_id, p.description AS prefix, g.description AS gender
    FROM            dbo.directory AS d LEFT OUTER JOIN
                             dbo.prefixes AS p ON d.prefix_id = p.id LEFT OUTER JOIN
                             dbo.gender g ON d.gender_id = g.id
	where d.id=@Id and is_active=1;
end