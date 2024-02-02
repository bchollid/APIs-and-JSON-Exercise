using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            RonVSKanyeAPI ronVKanye = new RonVSKanyeAPI();
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine($"Kanye: {ronVKanye.GenerateKanyeSentence()}");
                Console.WriteLine($"Ron: {ronVKanye.GenerateRonSentence()}");
            }
        }
    }
}
