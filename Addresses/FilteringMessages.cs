using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses;

public class FilteringMessages : IAddressee
{
    private readonly int _priorityMessage;
    private readonly IAddressee _addressee;

    public FilteringMessages(int priorityMessage, IAddressee addressee)
    {
        _priorityMessage = priorityMessage;
        _addressee = addressee;
    }

    public void SendMessage(Message message)
    {
        if (message.ImportanceLevel >= _priorityMessage)
        {
            _addressee.SendMessage(message);
        }
    }
}