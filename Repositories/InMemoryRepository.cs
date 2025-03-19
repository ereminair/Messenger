using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repositories;

public class InMemoryRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly Dictionary<Guid, T> _entities = new();

    public ResultType Add(T entity)
    {
        if (!_entities.TryAdd(entity.Id, entity))
        {
            return new ResultType.EntityAlreadyExists();
        }

        return new ResultType.Success();
    }

    public T? GetEntityById(Guid id)
    {
        _entities.TryGetValue(id, out T? entity);
        return entity;
    }

    public ResultType Update(T entity)
    {
        if (!_entities.ContainsKey(entity.Id))
        {
            return new ResultType.EntityDoesNotExist();
        }

        _entities[entity.Id] = entity;
        return new ResultType.Success();
    }

    public ResultType Delete(Guid id)
    {
        if (!_entities.Remove(id))
        {
            return new ResultType.EntityDoesNotExist();
        }

        return new ResultType.Success();
    }

    public IEnumerable<T> GetAll()
    {
        return _entities.Values;
    }

    public IEnumerable<T> Find(Func<T, bool> predicate)
    {
        return _entities.Values.Where(predicate);
    }
}