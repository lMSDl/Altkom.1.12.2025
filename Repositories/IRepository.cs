namespace Repositories;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    T Create(T entity);
    T? Update(int id, T entity);
    bool Delete(int id);
}
