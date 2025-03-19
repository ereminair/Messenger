using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.OutputDevice.DisplayDrivers;

public interface IDisplayDriver
{
    public void OutputMessage(Message message);

    public void SetColor(Color color);

    public void SetText(string text);

    public void Clear();
}