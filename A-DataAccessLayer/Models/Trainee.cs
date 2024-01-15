using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DataAccessLayer.Models;


[Table("trainees")]
public class Trainee : BaseModel
{
    // [Required(ErrorMessage = "Trainer Id is required")]
    public Guid? TrainerId { get; set; }
    public Trainer? Trainer { get; set; } = default!;
}

// [Required(ErrorMessage = "Subscription Duration Months is required")]
// public int SubscriptionDurationMonths { get; set; }
    
// [Required(ErrorMessage = "Subscription Start Date is required")]
// public DateTime? SubscriptionStartDate { get; set; }

// [Required(ErrorMessage = "Subscription End Date is required")]
// public DateTime? SubscriptionEndDate { get; set; } 
