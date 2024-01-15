using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DataAccessLayer.Models;

[Table("trainers")]
public class Trainer : BaseModel
{
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }


    // public ICollection<string>? Certificates { get; set; } = new List<string>();
    
    public ICollection<Trainee>? Trainees { get; set; } = new List<Trainee>();
}