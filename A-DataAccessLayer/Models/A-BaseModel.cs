using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DataAccessLayer.Models;

public class BaseModel
{
    [Key]
    [Column("_id", Order = 0)]    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    
    // [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string? Email { get; set; }
    
    // [Required(ErrorMessage = "Phone is required")]
    [Phone(ErrorMessage = "Phone is not valid")]
    public string? Phone { get; set; }
    
    // [Required(ErrorMessage = "Address is required")]
    public string? Address { get; set; }
    
    [Column("_created_at")]
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
    
    [Column("_updated_at")]
    public DateTime? UpdatedAt { get; set; } = DateTime.Now;
}