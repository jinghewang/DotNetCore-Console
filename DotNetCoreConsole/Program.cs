using System;
using System.IO;
using System.IO.Compression;
using CommonLibrary;
using CommonLibrary.Helpers;
using DotNetCoreConsole.Utils;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MainTask mainTask = new MainTask();
            mainTask.run(args);
        }
    }
}