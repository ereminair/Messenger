using Itmo.ObjectOrientedProgramming.Lab3.Addresses;
using Itmo.ObjectOrientedProgramming.Lab3.MainService;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageTopics;

public class Topic : ISendMessage
{
    private readonly List<IAddressee> _addressee;

    public string Name { get; }

    public void AddAddressee(IAddressee addressee)
    {
        _addressee.Add(addressee);
    }

    public Topic(string name)
    {
        Name = name;
        _addressee = new List<IAddressee>();
    }

    public void SendMessage(Message message)
    {
        foreach (IAddressee addressee in _addressee)
        {
            addressee.SendMessage(message);
        }
    }
}