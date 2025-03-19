namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message : IEquatable<Message>
{
    public string Heading { get; }

    public string Body { get; }

    public int ImportanceLevel { get; }

    public Message(string heading, string body, int levelImportance)
    {
        Heading = heading;
        Body = body;
        ImportanceLevel = levelImportance;
    }

    public string FormatText()
    {
        return $"{Heading}:\n{Body}";
    }

    public bool Equals(Message? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Heading == other.Heading && Body == other.Body && ImportanceLevel == other.ImportanceLevel;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Message)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Heading, Body, ImportanceLevel);
    }
}