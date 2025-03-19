using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.Displays;

public interface IDisplay
{
    public void SetText(string message);

    public void OutputMessage(Message message);
}