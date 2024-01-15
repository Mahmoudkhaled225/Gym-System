using AutoMapper;

namespace C_PresentationLayer;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<A_DataAccessLayer.Models.Trainer, DTOs.TrainerDTOs.CreateTrainer>().ReverseMap();
        CreateMap<A_DataAccessLayer.Models.Trainer, DTOs.TrainerDTOs.ReturnedTrainer>().ReverseMap();
        
        CreateMap<A_DataAccessLayer.Models.Trainee, DTOs.TraineeDTOs.CreateTrainee>().ReverseMap();
        CreateMap<A_DataAccessLayer.Models.Trainee, DTOs.TraineeDTOs.ReturnedTrainee>().ReverseMap();
        CreateMap<A_DataAccessLayer.Models.Trainee, DTOs.TrainerDTOs.ReturnedTraineeForTrainer>().ReverseMap();

    }
}