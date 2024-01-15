using C_PresentationLayer.DTOs.TraineeDTOs;

namespace C_PresentationLayer.DTOs.TrainerDTOs;

public class ReturnedTrainer
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public Guid Id { get; set; }
    
    public ICollection<ReturnedTraineeForTrainer> Trainees { get; set; }
}