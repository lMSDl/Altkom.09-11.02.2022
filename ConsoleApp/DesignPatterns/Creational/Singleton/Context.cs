﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        //private static Context _instance;
        //public static Context GetInstance()
        //{
        //    if (_instance == null)
        //        _instance = new Context();
        //    return _instance;
        //}

        //private static object locker = new object();
        //public static Context GetInstance()
        //{
        //    lock (locker) { 
        //        if (_instance == null)
        //            _instance = new Context();
        //        return _instance;
        //    }
        //}

        //public static Context GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        lock (locker)
        //        {
        //            if (_instance == null)
        //                _instance = new Context();
        //        }
        //    }
        //    return _instance;
        //}

        static Context()
        {

        }

        //public static Context Instance { get; } = new Context();

        private static Lazy<Context> _instance { get; } = new Lazy<Context>(() => new Context());
        public static Context Instance => _instance.Value;
    }
}
