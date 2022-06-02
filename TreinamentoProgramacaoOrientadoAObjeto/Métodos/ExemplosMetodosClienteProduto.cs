using System;
using System.Globalization;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Métodos
{
    public class ExemplosMetodosClienteProduto
    {
        public void Execucao()
        {
            Console.Clear();
            Classe.Cliente cliente = new Classe.Cliente()
            {
                Nome = "Milton Honji",
                Idade = 36,
                Telefone = "(11) 99999-9999",
                Email = "miltonhonji@gmail.com",
                Ativo = true
            };

            Classe.Produto produto1 = new Classe.Produto()
            {
                Id = 1,
                Nome = "Natura Homem",
                Descricao = "Perfume Masculino",
                Preco = 102m
            };

            Classe.Produto produto2 = new Classe.Produto()
            {
                Id = 2,
                Nome = "Tupperware Novo",
                Descricao = "Pote de gente rica",
                Preco = 60m
            };

            Console.WriteLine(" --- Cliente ---");
            Console.WriteLine($"Nome: { cliente.Nome } ");
            Console.WriteLine($"Idade: {cliente.Idade } ");
            Console.WriteLine($"Telefone: {cliente.Telefone } ");
            Console.WriteLine($"Email: { cliente.Email } ");
            Console.WriteLine($"Ativo?: {cliente.Ativo } ");

            Console.WriteLine();

            Console.WriteLine(" --- Produto 1 ---");
            Console.WriteLine($"Id: { produto1.Id } ");
            Console.WriteLine($"Nome: { produto1.Nome }");
            Console.WriteLine($"Descrição: { produto1.Descricao }");
            Console.WriteLine($"Preço: { produto1.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }");
            
            Console.WriteLine();
            
            Console.WriteLine(" --- Produto 2 ---");
            Console.WriteLine($"Id: { produto2.Id } ");
            Console.WriteLine($"Nome: { produto2.Nome }");
            Console.WriteLine($"Descrição: { produto2.Descricao }");
            Console.WriteLine($"Preço: { produto2.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }");

            VerificarCliente(cliente);
        }

        public static void VerificarCliente(Cliente cliente)
        {
            if(cliente != null)
            {
                Console.WriteLine("Temos um cliente");
            }
            else
            {
                Console.WriteLine("Ixi, Deu ruim");
            }
        }
    }
}