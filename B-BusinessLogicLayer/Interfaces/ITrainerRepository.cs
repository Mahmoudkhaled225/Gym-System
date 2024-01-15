using A_DataAccessLayer.Models;
using B_BusinessLogicLayer.A_Generic;

namespace B_BusinessLogicLayer.Interfaces;

public interface ITrainerRepository : IGenericRepository<Trainer>
{
    //add trainee to trainer collection
    // public void AddTrainee(Trainee trainee);
    
    public ICollection<Trainer> GetTrainersWithTrainees();
    
}