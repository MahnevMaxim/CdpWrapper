using System.IO;

namespace Mybot.ChromeDevTools
{
    public interface IDirectoryCleaner
    {
        void Delete(DirectoryInfo dir);
    }
}