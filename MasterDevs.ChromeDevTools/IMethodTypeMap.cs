using System;

namespace Mybot.ChromeDevTools
{
    public interface IMethodTypeMap
    {
        Type GetCommand(string method);

        Type GetCommandResponse(string method);

        Type GetEvent(string method);
    }
}