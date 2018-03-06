using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using CommonLibrary;
using CommonLibrary.Helpers;
using DotNetCoreConsole.Utils;

namespace DotNetCoreConsole
{
    public class MainTask
    {
        
        delegate void dosth(string s);
        
        public void run(string[] args)
        {
            Console.WriteLine("Main threadId is:" + Thread.CurrentThread.ManagedThreadId);
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(SayHelloToXiaohouye);
            Thread thread=new Thread(threadStart);
            thread.Start("Xiaohouye");
        }
        
        //注意参数一定要用object 类型，否则报错
        private void SayHelloToXiaohouye(object name)
        {
            //使用时候需要转换
            Console.Write("Hello my name is {0}",name.ToString());
        }
        
        private static string getName(int i)
        {
            return "wjh" + i.ToString();
        }
    }
}