using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repositories;

public interface IRepository<T>
{
    public ResultType Add(T entity);

    public T? GetEntityById(Guid id);

    public ResultType Update(T entity);

    public ResultType Delete(Guid id);

    public IEnumerable<T> GetAll();

    public IEnumerable<T> Find(Func<T, bool> predicate);
}