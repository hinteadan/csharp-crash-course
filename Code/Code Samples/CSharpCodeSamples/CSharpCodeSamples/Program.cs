using System;
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


            if (numberOfStars == 42)
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

            while (DateTime.Now < time + TimeSpan.FromSeconds(1))
            {
                Console.WriteLine("while...");
            }

            do
            {
                Console.WriteLine("do while...");
            }
            while (DateTime.Now < time + TimeSpan.FromSeconds(2));

            Console.WriteLine("For");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ForEach");
            var wordsList = new List<string>(new string[] { "C#", "is", "awesome" });
            foreach (var word in wordsList)
            {
                Console.WriteLine("Word is: " + word);
            }

            wordsList.ForEach(Console.WriteLine);


            Console.WriteLine("Hello from C#");
            Console.ReadLine();
        }
    }
}
