using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.SendMessageOtherMessenger;

public interface IOtherMessenger
{
    public void TransmitMessage(Message message);
}