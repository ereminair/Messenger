using Itmo.ObjectOrientedProgramming.Lab2.Repositories;

namespace Itmo.ObjectOrientedProgramming.Lab2.Users;

public class User : IEntity
{
    public Guid UserId { get; }

    public string UserName { get; }

    public User(string userName)
    {
        UserId = Guid.NewGuid();
        UserName = userName;
    }

    public Guid Id => UserId;
}