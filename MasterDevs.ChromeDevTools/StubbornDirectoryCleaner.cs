using System.IO;
using System.Threading;

namespace Mybot.ChromeDevTools
{
    public class StubbornDirectoryCleaner : IDirectoryCleaner
    {
        public void Delete(DirectoryInfo dir)
        {
            while (true)
            {
                try
                {
                    dir.Delete(true);
                    return;
                }
                catch
                {
                    Thread.Sleep(500);
                }
            }
        }
    }
}