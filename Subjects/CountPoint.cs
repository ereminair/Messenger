namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects;

public struct CountPoint
{
    public decimal Value { get; }

    public CountPoint(decimal value)
    {
        if (value < 0 || value > 100)
        {
            throw new ArgumentException("CountPoint must be between 0 and 100.");
        }

        Value = value;
    }
}
