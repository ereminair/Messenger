using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.OutputNavigators;

public interface IPrinter
{
    public void ClearAll();

    public void PrintLine(string text, Message message, Color color);

    public void ResetTextColor();
}