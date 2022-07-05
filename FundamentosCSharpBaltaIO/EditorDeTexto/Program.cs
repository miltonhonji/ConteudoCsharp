using System;
using System.IO;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Console.WriteLine("Hello World");
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Abrir arquivos");
            Console.WriteLine("2 - Editar arquivos");
            Console.WriteLine("0 - Sair");

            Console.Write("O que você deseja fazer? ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 3: System.Environment.Exit(0); break;
                default: Console.WriteLine("Em Construção"); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Selecione o arquivo que você deseja abrir?");
            string caminho = Console.ReadLine();

            using(var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }   
            
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo ao editor de texto");
            Console.WriteLine("---------------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.F4);
            //while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
            //Console.WriteLine(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Em qual lugar você deseja salvar o seu texto?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquivo { caminho } salvo com sucesso!");
            Console.ReadLine();
        }
    }
}
