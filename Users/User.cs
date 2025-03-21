<<<<<<< HEAD
﻿using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.ResultTypes;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users;

public class User : IUser
{
    private readonly Dictionary<Message, MessageStatus> _messages;

    public string UserName { get; }

    public string Name { get; }

    public User(string userName, string name)
    {
        UserName = userName;
        Name = name;
        _messages = [];
    }

    public void SendMessage(Message message)
    {
        _messages.Add(message, new MessageUnread());
    }

    public ReadMessageResult MarkMessageRead(Message message)
    {
        if (_messages.ContainsKey(message) == false)
        {
            return new ReadMessageResult.MessageNotFound();
        }

        if (_messages[message] is MessageRead)
        {
            return new ReadMessageResult.AlreadyRead();
        }

        _messages[message] = new MessageRead();
        return new ReadMessageResult.MessageReadSuccess();
    }

    public int CountMessage()
    {
        return _messages.Count;
    }

    public bool IsMessageRead(Message message)
    {
        return _messages[message] is MessageRead;
    }
=======
﻿using Itmo.ObjectOrientedProgramming.Lab2.Repositories;

namespace Itmo.ObjectOrientedProgramming.Lab2.Users;

public class User : IEntity
{
    public Guid UserId { get; }

    public string UserName { get; }

    public User(string userName)
    {
        UserId = Guid.NewGuid();
        UserName = userName;
    }

    public Guid Id => UserId;
>>>>>>> c6b0d8992de1967eb546b96fb6d01a41cbc0f59e
}