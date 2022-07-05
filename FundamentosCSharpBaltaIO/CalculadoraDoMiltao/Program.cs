using System;

namespace CalculadoraDoMiltao
{
    class Program
    {        
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            float v1 = 0f;
            float v2 = 0f;
            
            Console.Clear();
            Console.WriteLine("Calculadora do Tio Milton");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Calculadora IMC");
            Console.WriteLine("6 - Menu");
            Console.WriteLine("0 - Sair");
            
            Console.WriteLine("");
            
            Console.WriteLine("Escolha uma opção: ");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Soma(v1, v2); break;
                case 2: Subtracao(v1, v2); break;
                case 3: Divisao(v1, v2); break;
                case 4: Multiplicacao(v1, v2); break;
                case 5: CalcularImc(); break;
                case 6: Menu(); break;
                default: System.Environment.Exit(0); break;
            }       
            Console.ReadKey();
        }

        static void Soma(float valor1, float valor2)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor é: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor é: ");
            valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(float valor1, float valor2)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor é: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor é: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = valor1 - valor2;

            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Divisao(float valor1, float valor2)
        {
            Console.Clear();
            Console.WriteLine("O primeiro valor é: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("O segundo valor é: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da divisão é: " + (valor1 / valor2));
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(float valor1, float valor2)
        {
            Console.Clear();
            Console.WriteLine("O primeiro valor é: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("O segundo valor é: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O valor da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void CalcularImc()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu Peso: ");
            decimal peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura: ");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal imc =  peso / (altura * altura);
            
            string classificacaoImc = "";

            if (imc < 18.5m) {
                classificacaoImc = "Abaixo do Peso";
            }
            else if(imc > 18.5m && imc < 25.4m) {
                classificacaoImc = "Peso Normal";
            }
            else if(imc > 25 && imc < 29.9m) {
                classificacaoImc = "Sobrepeso";
            }
            else if(imc > 30 && imc < 34.9m){
                classificacaoImc = "Obesidade Grau 1";
            }
            else if(imc > 35 && imc < 39.9m) {
                classificacaoImc = "Obesidade Grau 2";
            }
            else {
                classificacaoImc = "Obesidade Grau 3";
            }

            Console.WriteLine($"O paciente: { nome } tem { idade } idade e o seu imc é: { imc }");
            Console.WriteLine($"Você está com a classificação: { classificacaoImc } ");

            Console.ReadKey();
            Menu();

        }
    }
}
