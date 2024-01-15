using A_DataAccessLayer.Models;
using AutoMapper;
using B_BusinessLogicLayer.Interfaces;
using C_PresentationLayer.DTOs.TrainerDTOs;
using Microsoft.AspNetCore.Mvc;

namespace C_PresentationLayer.Controllers;

public class TrainerController : ApiControllerBase
{

    private readonly ITrainerRepository _repository;
    private readonly IMapper _mapper;
    public TrainerController(ITrainerRepository repository, IMapper mapper) 
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    
    [HttpPost("{create}")]
    public IActionResult Create([FromBody] CreateTrainer dto)
    {
        var trainer = new Trainer
        {
            Name = dto.Name,
            Email = dto.Email,
            Phone = dto.Phone,
            Address = dto.Address,
            Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
        };
        _repository.create(trainer);
        
        var mappedTrainer = _mapper.Map<ReturnedTrainer>(trainer);
        return Ok(mappedTrainer);
    }
    
    [HttpGet("{id:guid}")]
    public IActionResult getOneById([FromRoute] Guid id)
    {
        var trainer = _repository.getById(id);
        if (trainer == null)
            return NotFound();
        var mappedTrainer = _mapper.Map<ReturnedTrainer>(trainer);
        return Ok(mappedTrainer);
    }
    
    [HttpGet("{all}")]
    public IActionResult GetAll()
    {
        var trainers = _repository.getAll();
        if (trainers == null)
            return NotFound();
        var mappedTrainers = _mapper.Map<IEnumerable<ReturnedTrainer>>(trainers);
        return Ok(mappedTrainers);
    }
    
    // [HttpPatch("{id:guid}")]
    // public IActionResult Update([FromBody] UpdateTrainer dto, [FromRoute] Guid id)
    // {
    //     var trainer = _repository.getById(id);
    //     if (trainer == null)
    //         return NotFound();
    //     
    //     trainer.Name = dto.Name;
    //     trainer.Email = dto.Email;
    //     trainer.Phone = dto.Phone;
    //     trainer.Address = dto.Address;
    //     trainer.Password = BCrypt.Net.BCrypt.HashPassword(dto?.Password);
    //     
    //     _repository.update(trainer);
    //     
    //     var mappedTrainer = _mapper.Map<ReturnedTrainer>(trainer);
    //     return Ok(mappedTrainer);
    // }
    
    [HttpDelete("{id:guid}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        var trainer = _repository.getById(id);
        if (trainer == null)
            return NotFound();
        _repository.delete(trainer);
        return Ok(trainer);
    }
    
}