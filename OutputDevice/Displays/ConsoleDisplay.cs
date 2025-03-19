using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.DisplayDrivers;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.Displays;

public class ConsoleDisplay : IDisplay
{
    private readonly Color _color;
    private readonly IDisplayDriver _displayDriver;
    private string _text;

    public ConsoleDisplay(string text, Color color, IDisplayDriver displayDriver)
    {
        _text = text;
        _color = color;
        _displayDriver = displayDriver;
    }

    public void SetText(string message)
    {
        _text = message;
    }

    public void OutputMessage(Message message)
    {
        _displayDriver.OutputMessage(message);
        _displayDriver.SetColor(_color);
        _displayDriver.SetText(_text);
    }

    public void Clear()
    {
        Console.Clear();
    }
}