using CdpWrapper.Extensions;
using Mybot.ChromeDevTools;
using Mybot.ChromeDevTools.Protocol.Chrome.Profiler;
using NUnit.Framework;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using static Mybot.ChromeDevTools.Protocol.Chrome.ProtocolName;

namespace CdpWrapper.Tests
{
    public class Tests
    {
        ChromeMod chromeInstance;
        string profilePath;

        [SetUp]
        public async Task Setup()
        {
            string localAppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ChromeModTests");
            profilePath = Path.Combine(localAppDir, Path.GetRandomFileName());

            chromeInstance = new ChromeMod(Logger, true, profilePath);

            IChromeSession result =
                await chromeInstance.GetChromeSession();
        }

        public void Logger(string mess, Exception ex)
        {
            System.Console.WriteLine($"{mess}\n{ex?.Message}");
        }

        [Test]
        public void NavigateTest()
        {
            try
            {
                var res = chromeInstance.Navigate("http://mybot.su");
                //
                Thread.Sleep(100000);
                //Task taskClick = chromeInstance.Click("a[href=\"/Account/Login\"]");
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
            // assert
            Assert.Pass();
        }

        //[Test]
        //[Order(1)]
        //public void ClickTest()
        //{
        //    try
        //    {
        //        chromeInstance.Click("a[href=\"/Account/Login\"]");
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Console.WriteLine(ex.Message);
        //    }

        //    // assert
        //    Assert.Pass();
        //}

        //[Test]
        //[Order(2)]
        //public void CloseTest()
        //{
        //    try
        //    {
        //        //chromeInstance.Navigate("mybot.su");
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Console.WriteLine(ex.Message);
        //    }

        //    // assert
        //    Assert.Pass();
        //}

        //[Test]
        //[Order(3)]
        //public void ScrollTestTest()
        //{
        //    try
        //    {
        //        //chromeInstance.Navigate("mybot.su");
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Console.WriteLine(ex.Message);
        //    }

        //    // assert
        //    Assert.Pass();
        //}
    }
}