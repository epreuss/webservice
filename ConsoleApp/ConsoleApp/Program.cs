using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp.ServiceRef;
using ConsoleApp.IPServiceRef;
using ConsoleApp.GodRef;
using ConsoleApp.com.w3schools.www;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to webservice...");
            BibleWebserviceSoapClient client = new BibleWebserviceSoapClient();
            //MathServiceSoapClient web = new MathServiceSoapClient();
            //Console.WriteLine(web.Add(1, 2));
            Console.WriteLine("Connected. Asking service...");
            Console.WriteLine();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
