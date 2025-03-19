namespace Itmo.ObjectOrientedProgramming.Lab2.ResultsType;

public abstract record ResultType
{
    private ResultType() { }

    public sealed record Success : ResultType;

    public sealed record ChangeIsNotMadeByAuthor : ResultType;

    public sealed record EntityDoesNotExist : ResultType;

    public sealed record EntityAlreadyExists : ResultType;
}