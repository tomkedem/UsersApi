using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class UserModel
{
    public int Id { get; set; }
    
    public string? User_id { get; set; }
    [Required]
    public string? F_name { get; set; }
    [Required]
    public string? L_name { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 5, ErrorMessage = "שם להדפסה צריך להיות בין מינימום 5 תווים ומקסימום 30 תווים")]
    public string? Name_for_print { get; set; }
    public int Gender_id { get; set; } = 1;
    public int Prefix_id { get; set; }
    public string? Gender { get; set; }
    public string? prefix { get; set; }
    [Required(ErrorMessage = "חובה לעדכן כתובת מייל")]
    [EmailAddress(ErrorMessage = "בבקשה לעדכן כתובת מייל תקינה")]
    public string? mail { get; set; }
    [EmailAddress(ErrorMessage = "בבקשה לעדכן כתובת מייל תקינה")]
    public string? mail2 { get; set; } = string.Empty;
    [Phone]
    public string? cellphone { get; set; }

    public string? id_number { get; set; }
    public string? en_f_name { get; set; }
    public string? en_l_name { get; set; }
    public DateTime? birth_date { get; set; }

    public string? job_address { get; set; }
    public string? home_address { get; set; }
    [Phone]
    public string? home_phone { get; set; }
    [Phone]
    public string? job_phone { get; set; }
    public string? organization { get; set; }
    public string? following_by { get; set; }
    public bool is_active { get; set; }

    public string? Insert_user_id { get; set; }

    public DateTime? Insert_date { get; set; }
    public string? Update_user_id { get; set; }
    public DateTime? Update_date { get; set; }

}
