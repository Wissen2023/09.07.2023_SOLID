using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._07._2023_SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Single_Responsibility single_Responsibility = new Single_Responsibility();
            //single_Responsibility.Send();
            //single_Responsibility.SendSMS();

            Open_Closed open_Closed = new Open_Closed();
            open_Closed.Send();

            Console.ReadLine();
        }
    }
}
