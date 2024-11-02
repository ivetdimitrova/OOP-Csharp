using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class SmartPhone:ICaller,IBrowser
    {
        public void Calling(string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
        public void Browsing(string URL)
        {
            Console.WriteLine($"Browsing: {URL}!");
        }
    }
}
