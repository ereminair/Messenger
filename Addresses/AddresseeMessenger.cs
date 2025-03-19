using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.SendMessageOtherMessenger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses;

public class AddresseeMessenger : IAddressee
{
    private readonly IOtherMessenger _messenger;

    public AddresseeMessenger(IOtherMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(Message message)
    {
        _messenger.TransmitMessage(message);
    }
}