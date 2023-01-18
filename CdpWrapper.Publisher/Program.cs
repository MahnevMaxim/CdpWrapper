using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace CdpWrapper.Publisher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PublishChromeDevTools();
            PublishCdpWrapper();
        }

        private static void PublishChromeDevTools()
        {
            //RunScript("cd C:\\Users\\Maxxx\\source\\repos\\CdpWrapper\\MasterDevs.ChromeDevTools");
            //Thread.Sleep(5000);
            //RunScript("dotnet pack");
        }

        private static void PublishCdpWrapper()
        {
            throw new NotImplementedException();
        }

        //static string RunScript(string scriptText)
        //{
        //    create Powershell runspace

        //   Runspace runspace = RunspaceFactory.CreateRunspace();

        //    open it

        //    runspace.Open();

        //    create a pipeline and feed it the script text

        //   Pipeline pipeline = runspace.CreatePipeline();
        //    pipeline.Commands.AddScript(scriptText);

        //    add an extra command to transform the script
        //     output objects into nicely formatted strings

        //     remove this line to get the actual objects
        //     that the script returns. For example, the script

        //     "Get-Process" returns a collection
        //     of System.Diagnostics.Process instances.

        //    pipeline.Commands.Add("Out-String");

        //    execute the script

        //   var results = pipeline.Invoke();

        //    close the runspace

        //    runspace.Close();

        //    convert the script result into a single string

        //   StringBuilder stringBuilder = new StringBuilder();
        //    foreach (PSObject obj in results)
        //    {
        //        stringBuilder.AppendLine(obj.ToString());
        //    }

        //    return stringBuilder.ToString();
        //}
    }
}
