using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.Displays;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay _display;

    public AddresseeDisplay(IDisplay display)
    {
        _display = display;
    }

    public void SendMessage(Message message)
    {
        _display.SetText(message.FormatText());
        _display.OutputMessage(message);
    }
}