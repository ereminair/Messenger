namespace Itmo.ObjectOrientedProgramming.Lab3.ResultTypes;

public record ReadMessageResult
{
    private ReadMessageResult() { }

    public sealed record MessageReadSuccess : ReadMessageResult;

    public sealed record MessageNotFound : ReadMessageResult;

    public sealed record AlreadyRead : ReadMessageResult;
}