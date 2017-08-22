using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText("Data.txt");

            Console.WriteLine($"File content is: {fileContent}");


            using (var http = new HttpClient())
            {
                var content = http.GetStringAsync("http://www.google.com").Result;
                Console.WriteLine("Google content is:");
                Console.WriteLine(content);

                File.WriteAllText("google.html", content);
            }


            Console.ReadLine();
        }
    }
}
