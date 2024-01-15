using A_DataAccessLayer.Models;
using C_PresentationLayer.DTOs.TrainerDTOs;

namespace C_PresentationLayer.DTOs.TraineeDTOs;

public class ReturnedTrainee
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public Guid Id { get; set; }
    
    public Guid TrainerId { get; set; }
    
    public ReturnedTrainer Trainer { get; set; }
    
    public DateTime CreatedAt { get; set; }

}