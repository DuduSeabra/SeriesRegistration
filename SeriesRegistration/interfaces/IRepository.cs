using System.Collections.Generic;

namespace SeriesRegistration.interfaces
{
    public interface IRepository<T>
    {
         List<T> List();
         T ReturnsById(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
    }
}