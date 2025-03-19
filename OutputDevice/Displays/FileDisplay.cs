using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.Displays;

public class FileDisplay : IDisplay
{
    private readonly string _fileName;
    private readonly Color _color;
    private readonly Message _message;
    private string _text;

    public FileDisplay(string fileName, string text, Message message, Color color)
    {
        _fileName = fileName;
        _text = text;
        _message = message;
        _color = color;
    }

    public void SetText(string message)
    {
        _text = message;
    }

    public void OutputMessage(Message message)
    {
        string text = $"{Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(_text)}\n{_message.FormatText()}";
        File.WriteAllText(_fileName, text);
    }
}