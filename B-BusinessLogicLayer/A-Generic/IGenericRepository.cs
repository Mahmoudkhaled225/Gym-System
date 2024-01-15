using A_DataAccessLayer.Models;

namespace B_BusinessLogicLayer.A_Generic;

public interface IGenericRepository<T> where T : BaseModel
{
    int create(T entity);
    
    T getById(Guid id);
    
    ICollection<T> getAll();
    
    int update(T entity);
    
    int updateById(Guid id);
    
    int delete(T entity);
    
    int deleteById(Guid id);
    
    bool exists(Guid id);
}