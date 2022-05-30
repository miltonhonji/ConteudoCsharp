using System.Globalization;
using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Objetos
{
    public class ExemplosClassesEObjetos
    {
        public void Execucao()
        {
            Console.Clear();

            Classe.Conta conta = new Classe.Conta()
            {
                Agencia = 006,
                Banco = "Banco dos Devs",
                NumeroDaConta = 123,
                Saldo = 10000m
            };

            Classe.Cliente cliente = new Classe.Cliente()
            {
                Nome = "Milton Honji",
                Idade = 36,
                Email = "miltonhonji@gmail.com",
                Telefone = "55+(11)999999"
            };

            Console.WriteLine("Banco Dev - Banco dos desenvolvedores");
            Console.WriteLine();
            Console.WriteLine("Informações do Banco \n");
            Console.WriteLine($"Agência: { conta.Agencia }");
            Console.WriteLine($"Banco: { conta.Banco } ");
            Console.WriteLine($"Número da Conta: {conta.NumeroDaConta } ");
            Console.WriteLine($"Saldo em Conta: { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }");
            //Console.WriteLine("Saldo em Conta: " + conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine();
            Console.WriteLine("Informações do Cliente \n");
            Console.WriteLine($"Nome do Cliente: { cliente.Nome }");
            Console.WriteLine($"Idade: { cliente.Idade } anos");
            Console.WriteLine($"E-mail: {cliente.Email} ");
            Console.WriteLine($"Telefone para contato: {cliente.Telefone}");
            Console.ReadKey();
        }
    }
}