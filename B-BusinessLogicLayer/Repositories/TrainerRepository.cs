﻿using A_DataAccessLayer.Contexts;
using A_DataAccessLayer.Models;
using B_BusinessLogicLayer.A_Generic;
using B_BusinessLogicLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B_BusinessLogicLayer.Repositories;

public class TrainerRepository : GenericRepository<Trainer> , ITrainerRepository
{
    public TrainerRepository(GymContext context) : base(context)
    {
        
    }
    
    // public void AddTrainee(Trainee trainee)
    // {
    //     _context.Trainees.Add(trainee);
    // }


    public ICollection<Trainer> GetTrainersWithTrainees()
    {
        return _context.Trainers
            .Include(t => t.Trainees)
            .ToList();
    }
}