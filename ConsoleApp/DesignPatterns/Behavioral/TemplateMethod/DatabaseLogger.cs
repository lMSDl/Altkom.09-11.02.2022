using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<LogEntity, DbService>
    {
        //public void Log(string message)
        //{
        //    string messageToLog = SerializeMessage(message);
        //    ConnectToDatabase();
        //    InsertLogMessageToTable(messageToLog);
        //    CloseDbConnection();
        //}
        //private string SerializeMessage(object message)
        //{
        //    Console.WriteLine("Serializing message");
        //    return message.ToString();
        //}
        //private void ConnectToDatabase()
        //{
        //    Console.WriteLine("Connecting to Database.");
        //}
        //private void InsertLogMessageToTable(string message)
        //{
        //    Console.WriteLine("Inserting Log Message to DB table : " + message);
        //}
        //private void CloseDbConnection()
        //{
        //    Console.WriteLine("Closing DB connection.");
        //}

        protected override void LogMessage(DbService service, LogEntity info)
        {
            service.Create(info);
        }

        protected override DbService GetService()
        {
            return new DbService();
        }

        protected override LogEntity ConvertMessage(string message)
        {
            return new LogEntity { DateTime = DateTime.Now, Message = message };
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }
    }
}
