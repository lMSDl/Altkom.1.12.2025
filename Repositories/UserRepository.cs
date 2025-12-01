using Models;

namespace Repositories;

public class UserRepository : IRepository<User>
{
    private readonly List<User> _users = new();
    private int _nextId = 1;

    public IEnumerable<User> GetAll()
    {
        return _users;
    }

    public User? GetById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public User Create(User entity)
    {
        entity.Id = _nextId++;
        _users.Add(entity);
        return entity;
    }

    public User? Update(int id, User entity)
    {
        var existingUser = GetById(id);
        if (existingUser == null)
            return null;

        existingUser.Username = entity.Username;
        existingUser.Password = entity.Password;
        return existingUser;
    }

    public bool Delete(int id)
    {
        var user = GetById(id);
        if (user == null)
            return false;

        _users.Remove(user);
        return true;
    }
}
