﻿namespace Mybot.ChromeDevTools
{
    public interface ICommandResponseFactory
    {
        ICommandResponse Create(byte[] responseBytes);

        ICommandResponse Create(string responseText);
    }
}