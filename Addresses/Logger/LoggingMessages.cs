using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses.Logger;

public class LoggingMessages : IAddressee
{
    private readonly ILogger _logger;
    private readonly IAddressee _addressee;

    public LoggingMessages(ILogger logger, IAddressee addressee)
    {
        _logger = logger;
        _addressee = addressee;
    }

    public void SendMessage(Message message)
    {
        _addressee.SendMessage(message);
        _logger.Log(message.FormatText());
    }
}