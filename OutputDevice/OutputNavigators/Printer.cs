using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.OutputNavigators;

public class Printer : IPrinter
{
    public void ClearAll()
    {
        Console.Clear();
    }

    public void PrintLine(string text, Message message, Color color)
    {
        Console.WriteLine(Crayon.Output.Rgb(color.R, color.G, color.B).Text(text + message.Body));
    }

    public void ResetTextColor()
    {
        Console.ResetColor();
    }
}