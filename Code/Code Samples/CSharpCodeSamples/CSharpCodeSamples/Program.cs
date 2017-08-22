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


            var atmosphereResult = numberOfStars + floatingOnAir - decimalAir;
            var atmosphereResultString = $"Atmospheric result is {atmosphereResult}";
            Console.WriteLine(atmosphereResultString);

            Console.WriteLine($"Number of words: {atmosphereResultString.Split(' ').Length}");


            Console.WriteLine("Hello from C#");
            Console.ReadLine();
        }
    }
}
