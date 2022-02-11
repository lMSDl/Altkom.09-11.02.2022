using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(string message)
        {
            message = PrepareMessage(message);
            AfterPrepareMessage();
            T info = ConvertMessage(message);
            using (TService service = GetService())
            {
                LogMessage(service, info);
            }
            AfterLogMessage();
        }

        protected virtual void AfterLogMessage()
        {
        }

        protected virtual void AfterPrepareMessage()
        {
        }

        protected virtual string PrepareMessage(string message)
        {
            return $"{DateTime.Now}: {message}";
        }

        protected abstract void LogMessage(TService service, T info);
        protected abstract TService GetService();
        protected abstract T ConvertMessage(string message);
    }
}
