using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresses;

public class AddresseeGroup : IAddressee
{
    private readonly IList<IAddressee> _addressees;

    public AddresseeGroup(IList<IAddressee> addressees)
    {
        _addressees = addressees;
    }

    public static Builder Build => new();

    public void SendMessage(Message message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }

    public class Builder
    {
        private readonly IList<IAddressee> _addressees = [];

        public Builder WithAddressee(IAddressee addressee)
        {
            _addressees.Add(addressee);
            return this;
        }

        public AddresseeGroup Build()
        {
            return new AddresseeGroup(_addressees);
        }
    }
}