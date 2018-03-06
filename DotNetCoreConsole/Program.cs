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
            //test
            Test test = new Test();
            Console.WriteLine(test.Hello("wjh"));
            
            //utils
            UtilsHelper test2 = new UtilsHelper();
            Console.WriteLine(test2.Hello("wjh"));
            
            //path
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            
            string separatorChar = FileUtils.getDirectorySeparatorChar(path);
            string newPath = path + separatorChar + "123";
            Console.WriteLine(newPath);

            return ;
            
            DirectoryInfo dinfo = Directory.CreateDirectory(newPath);
            for(int i=0;i<10;i++){
                Console.WriteLine("Hello World!");
            }
        }
        
        
        private static string getName(int i)
        {
            return "wjh" + i.ToString();
        }
        
    }
}