using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MainService;

public interface ISendMessage
{
    public void SendMessage(Message message);
}