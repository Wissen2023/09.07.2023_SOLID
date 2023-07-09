using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._07._2023_SOLID
{
    public class Single_Responsibility
    {
        public void Send()
        {
            Console.WriteLine("Email gönderildi.");
            //Console.WriteLine("SMS gönderildi.");
        }
        public void SendSMS()
        {
            Console.WriteLine("Artık SMS gönderildi burada");
        }
    }
}
