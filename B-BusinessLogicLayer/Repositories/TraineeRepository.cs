using A_DataAccessLayer.Contexts;
using A_DataAccessLayer.Models;
using B_BusinessLogicLayer.A_Generic;
using B_BusinessLogicLayer.Interfaces;

namespace B_BusinessLogicLayer.Repositories;
public class TraineeRepository : GenericRepository<Trainee> , ITraineeRepository
{
    public TraineeRepository(GymContext context) : base(context)
    {
        
    }
}