using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : StringLogger<StreamWriter>
    {
        //public void Log(object message)
        //{
        //    string messageToLog = SerializeMessage(message);
        //    OpenFile();
        //    WriteLogMessage(messageToLog);
        //    CloseFile();
        //}
        //private string SerializeMessage(object message)
        //{
        //    Console.WriteLine("Serializing message");
        //    return message.ToString();
        //}
        //private void OpenFile()
        //{
        //    Console.WriteLine("Opening File.");
        //}
        //private void WriteLogMessage(string message)
        //{
        //    Console.WriteLine("Appending Log message to file : " + message);
        //}
        //private void CloseFile()
        //{
        //    Console.WriteLine("Close File.");
        //}

        protected override StreamWriter GetService()
        {
            var stream = new MemoryStream();
            return new StreamWriter(stream);
        }

        protected override void LogMessage(StreamWriter service, string info)
        {
            service.WriteLine(info);
        }
    }
}
