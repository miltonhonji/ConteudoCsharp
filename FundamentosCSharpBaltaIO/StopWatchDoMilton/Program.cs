using System;
using System.Threading;

namespace StopWatchDoMilton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start(8);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo ao cronometro");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Digite a quantidade de tempo que deseja usar: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if ('m' == 60)
                multiplier = 60;

            if (type == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier); //Conversão implicita          

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            //int time = 10;
            int currencyTime = 0;

            while (currencyTime != time)
            {
                Console.Clear();
                currencyTime++;
                Console.WriteLine(currencyTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Obrigado por usar este app!");
            Thread.Sleep(2000);

            Menu();
        }
    }
}