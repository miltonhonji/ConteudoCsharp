using System;

namespace StopWatchDoMiltaoReverso
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Coelhinho da Pascoa");
            //Start();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao cronometro ao contrário");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("S = Segundos => 10s => 10 segundos");
            Console.WriteLine("M = Minutos => 1m => 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Selecione uma opção acima: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            //Console.WriteLine(data);
            Console.WriteLine(type);
            Console.WriteLine(time);

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);
        }

        static void Start(int receivedTime)
        {
            int currencyTime = 0;

            for (int time = receivedTime; time >= currencyTime; time--)
            {
                Console.Clear();
                //time--;
                Console.WriteLine(time);
                Thread.Sleep(1000);
                //Console.WriteLine("Obrigado por usar o cronometro do Milton");
            }

            Menu();
        }
    }
}
