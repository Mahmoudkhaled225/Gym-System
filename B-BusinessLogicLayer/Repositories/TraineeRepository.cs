using A_DataAccessLayer.Contexts;
using A_DataAccessLayer.Models;
using B_BusinessLogicLayer.A_Generic;
using B_BusinessLogicLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B_BusinessLogicLayer.Repositories;
public class TraineeRepository : GenericRepository<Trainee> , ITraineeRepository
{
    public TraineeRepository(GymContext context) : base(context)
    {
        
    }
    
    public Trainee getTraineeByIdWithTrainer(Guid id) =>
        _context.Trainees.Include(t => t.Trainer).FirstOrDefault(t => t.Id == id);
    
    
}