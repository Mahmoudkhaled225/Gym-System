using A_DataAccessLayer.Models;
using B_BusinessLogicLayer.A_Generic;

namespace B_BusinessLogicLayer.Interfaces;

public interface ITraineeRepository: IGenericRepository<Trainee>
{
    
    public Trainee getTraineeByIdWithTrainer(Guid id); 
}