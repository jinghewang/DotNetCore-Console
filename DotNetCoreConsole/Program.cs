using System;
using System.IO;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            
            string separatorChar = getDirectorySeparatorChar(path);
            string newPath = path + separatorChar + "123";
            DirectoryInfo dinfo = Directory.CreateDirectory(newPath);
            for(int i=0;i<10;i++){
                Console.WriteLine("Hello World!");
            }
        }
        
        
        public static string getDirectorySeparatorChar(string path){
            if(string.IsNullOrWhiteSpace(path)){
                return "/";
            }else{
                return path.Substring(0,1);
            }
        }
        
        
        private static string getName(int i)
        {
            return "wjh" + i.ToString();
        }
        
    }
}