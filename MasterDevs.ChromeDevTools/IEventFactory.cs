namespace Mybot.ChromeDevTools
{
    public interface IEventFactory
    {
        IEvent Create(byte[] responseBytes);

        IEvent Create(string responseText);
    }
}