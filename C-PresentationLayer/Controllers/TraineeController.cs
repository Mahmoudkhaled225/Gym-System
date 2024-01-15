using A_DataAccessLayer.Models;
using AutoMapper;
using B_BusinessLogicLayer.Interfaces;
using C_PresentationLayer.DTOs.TraineeDTOs;
using Microsoft.AspNetCore.Mvc;

namespace C_PresentationLayer.Controllers;

public class TraineeController : ApiControllerBase
{
    private readonly ITraineeRepository _repository;
    private readonly IMapper _mapper;

    public TraineeController(ITraineeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    [HttpPost("{create}")]
    public IActionResult Create([FromBody] CreateTrainee dto)
    {
        var trainee = new Trainee
        {
            Name = dto.Name,
            Email = dto.Email,
            Phone = dto.Phone,
            Address = dto.Address,
            TrainerId = dto.TrainerId
        };
        _repository.create(trainee);

        var mappedTrainee = _mapper.Map<ReturnedTrainee>(trainee);

        return Ok(mappedTrainee);
    }

    [HttpGet("{id:guid}")]
    public IActionResult getOneById([FromRoute] Guid id)
    {
        var trainee = _repository.getById(id);
        if (trainee == null)
            return NotFound();
        var mappedTrainee = _mapper.Map<ReturnedTrainee>(trainee);
        return Ok(mappedTrainee);
    }    
    
}