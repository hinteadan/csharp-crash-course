﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteMe = 2;
            int numberOfStars = 42;
            float floatingOnAir = 3.1415f;
            double decimalAir = 3.141542;
            string myName = "Can't remember";

            var random = new Random();

            var time = DateTime.Now;


            if(numberOfStars == 42)
            {
                Console.WriteLine("I see 42 stars");
            }

            if (numberOfStars > 42)
            {
                Console.WriteLine("I see more than 42 stars");
            }
            else
            {
                Console.WriteLine("I see 42 stars or less");
            }


            Console.WriteLine("Hello from C#");
            Console.ReadLine();
        }
    }
}
