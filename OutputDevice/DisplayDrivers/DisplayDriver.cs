using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.OutputNavigators;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.DisplayDrivers;

public class DisplayDriver : IDisplayDriver
{
    private readonly IPrinter _printer;
    private Color _color;
    private string _text;

    public DisplayDriver(string text, IPrinter printer, Color color)
    {
        _text = text;
        _printer = printer;
        _color = color;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public void OutputMessage(Message message)
    {
        _printer.PrintLine(_text, message, _color);
        _printer.ResetTextColor();
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

    public void Clear()
    {
        if (!string.IsNullOrEmpty(_text))
        {
            Console.Clear();
            _text = string.Empty;
        }
    }

    public void ResetTextColor()
    {
        Console.ResetColor();
    }
}