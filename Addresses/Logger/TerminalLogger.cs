namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses.Logger;

public class TerminalLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}