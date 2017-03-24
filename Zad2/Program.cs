using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.Core.Services;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            IIpValidator validator = new IpValidator();
            
            Console.WriteLine("Podaj adres IP");
            var input = Console.ReadLine();

            if (validator.Validate(input))
            {
                Console.WriteLine("Poprawny");
            }
            else
            {
                Console.WriteLine("Bledny");
            }

            Console.ReadLine();
        }
    }
}
