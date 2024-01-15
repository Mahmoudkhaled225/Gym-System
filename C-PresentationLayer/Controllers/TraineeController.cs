using A_DataAccessLayer.Models;
using AutoMapper;
using B_BusinessLogicLayer.Interfaces;
using C_PresentationLayer.DTOs.TraineeDTOs;
using Microsoft.AspNetCore.Mvc;

namespace C_PresentationLayer.Controllers;

public class TraineeController : ApiControllerBase
{
    private readonly ITraineeRepository _repository;
    private readonly ITrainerRepository _trainerRepository;
    private readonly IMapper _mapper;

    public TraineeController(ITraineeRepository repository,ITrainerRepository trainerRepository,IMapper mapper)
    {
        _repository = repository;
        _trainerRepository = trainerRepository;
        _mapper = mapper;
    }
    
    [HttpPost("{create}")]
    [ProducesResponseType(typeof(ReturnedTrainee), StatusCodes.Status201Created)]    
    public IActionResult Create([FromBody] CreateTrainee dto)
    {
        var trainee = new Trainee
        {
            Name = dto.Name,
            Email = dto.Email,
            Phone = dto.Phone,
            Address = dto.Address,
            TrainerId = dto.TrainerId,
            // Trainer = _trainerRepository.getById((Guid)dto.TrainerId)
        };
        _repository.create(trainee);

        var mappedTrainee = _mapper.Map<ReturnedTrainee>(trainee);

        return Ok(mappedTrainee);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(ReturnedTrainee), StatusCodes.Status200OK)]
    public IActionResult getOneById([FromRoute] Guid id)
    {
        var trainee = _repository.getTraineeByIdWithTrainer(id);
        if (trainee == null)
            return NotFound();
        var mappedTrainee = _mapper.Map<ReturnedTrainee>(trainee);
        return Ok(mappedTrainee);
    }    
    
}