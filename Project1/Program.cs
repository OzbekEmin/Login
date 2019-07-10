using Project1.Business;
using System;
using System.IO;
using System.Linq;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new BusUser();
            bus.Login();          
        }
    }
}
