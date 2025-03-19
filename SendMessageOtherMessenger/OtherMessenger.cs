using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.SendMessageOtherMessenger;

public class OtherMessenger
{
    private readonly IMessenger _messenger;

    public OtherMessenger(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void TransmitMessage(Message message)
    {
        _messenger.PrintLine(message);
    }
}