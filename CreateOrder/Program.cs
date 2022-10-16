using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            while (true)
            {
                Console.WriteLine("Choose actio bro;\n 1. Publish message.\n 2. Close App");
                var ele = Console.ReadLine();
                switch (ele)
                {
                    case "1":
                        Console.WriteLine("Input product name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Input product quantity");
                        var msg = Console.ReadLine();
                       //publish message
                        break;
                    case "2":
                        Console.WriteLine("Application closed");
                        return;
                        break;
                    default:
                        Console.WriteLine("You have two option: 1 or 2.");
                        break;
                }
            }
        }

        /// <summary>
        /// metode do tworzenia powtórzyć dla wszystkich typów z zadania
        /// </summary>
        public static void SetUp()
        {
          //tutaj set up
        }

        /// <summary>
        /// metode do publikacji powtórzyc dla wszystkich rodzajów z zadania
        /// </summary>
        public static void PublishMessageHeader(string name, string msg)
        {
            //tutaj publish
        }
    }
}
