using A_DataAccessLayer.Contexts;
using A_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace B_BusinessLogicLayer.A_Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    /*
     * If it's private and readonly,
     * the benefit is that you can't inadvertently change it 
     * from another part of that class after it is initialized. 
     * The readonly modifier ensures the field can only be given a value 
     * during its initialization or in its class constructor.
     * If something functionally should not change after initialization,
     * it's always good practice to use available language constructs to enforce that.
     * 
    */
    public GymContext _context;
    
    public GenericRepository(GymContext context) =>
        this._context = context;
    
    
    public int create(T entity)
    {
        _context.Set<T>().Add(entity);
        return _context.SaveChanges();
    }

    public T getById(Guid id) =>
        _context.Set<T>().Find(id);
    
    public ICollection<T> getAll() =>
        _context.Set<T>().ToList();
    
    public int update(T entity)
    {
        _context.Set<T>().Update(entity);
        return _context.SaveChanges();
    }

    public int updateById(Guid id)
    {
        _context.Set<T>().Update(getById(id));
        return _context.SaveChanges();
        
    }

    public int delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        return _context.SaveChanges();
    }

    public int deleteById(Guid id)
    {
        _context.Set<T>().Remove(getById(id));
        return _context.SaveChanges();
    }

    public bool exists(Guid id)
    {
        return _context.Set<T>().Any(e => e.Id == id);
    }
}