using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.OutputNavigators;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class Messenger : IMessenger
{
    private readonly IPrinter _printer;
    private readonly Color _color;
    private string? _lastMessage;

    public Messenger(IPrinter printer, Color color)
    {
        _printer = printer;
        _color = color;
    }

    public void PrintLine(Message message)
    {
        if (_lastMessage is null)
        {
            _printer.PrintLine($"Messenger: no message found", message, _color);
            _printer.ResetTextColor();
        }
        else
        {
            _printer.PrintLine($"Messenger: {_lastMessage}", message,  _color);
            _printer.ResetTextColor();
        }
    }

    public void SendText(string text, Message message)
    {
        _lastMessage = text;
        _printer.PrintLine(_lastMessage, message, _color);
        _printer.ResetTextColor();
    }
}