using System;
using System.Globalization;
using TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Depositar(ContaCorrente contaCorrente)
        {
            var contaDestino = new ContaCorrente;

            try
            {
                contaCorrente.Agencia = 2206;
                contaCorrente.NumeroConta = "180386-6";
                contaCorrente.Banco = "Banco dos Devs";
                contaCorrente.CodigoBanco = 17;
                contaCorrente.TipoCOnta = ETipoConta.ContaCorrente;

                Console.Clear();
                Console.WriteLine("Insira o valor que você deseja depositar: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Agora você insira o número da agência de destino: ");
                contaDestino.Agencia = int.Parse(Console.ReadLine());

                contaDestino.Nome = "Juliana Ayumi Oshiro Akamine";
                contaDestino.Banco = "Banco dos Adms";
                Console.Clear();
                Console.Wr
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<ContaCorrente> ObterExtratoConta()
        {
            throw new NotImplementedException();
        }

        public void CadastrarPix(string chave, double valor)
        {
            var contaCorrente = new ContaCorrente();

            try
            {
                Console.Clear();
                Console.WriteLine("--- Banco dos Dev's - Cadastrar Chave Pix ---");
                Console.WriteLine();
                Console.WriteLine("Digite o número de seu CPF: ");
                chave = Console.ReadLine();

                contaCorrente.Cpf = chave;               
                Console.WriteLine($"A sua chave Pix é: { contaCorrente.Cpf } ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Save(ContaCorrente entity)
        {
            try
            {               
                entity.Agencia = 2206;
                entity.NumeroConta = "180386-6";
                entity.Banco = "Banco dos Devs";
                entity.CodigoBanco = 17;
                entity.TipoConta = ETipoConta.ContaCorrente;

                Console.Clear();            
                Console.WriteLine("--- Banco dos Dev's - Vamos abrir a sua conta? ---");
                Console.WriteLine();
                Console.WriteLine("Insira o seu nome: ");
                string nome = Console.ReadLine();
            
                Console.WriteLine("Insira o seu Cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Por fim, deseja depositar dinheiro na conta: ");
                double saldo = double.Parse(Console.ReadLine());

                entity.Nome = nome;
                entity.Cpf = cpf;
                entity.Saldo = saldo;

                Console.Clear();
                Console.WriteLine("Cadastro efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine($"Nome: { entity.Nome }, CPF: { entity.Cpf } ");
                Console.WriteLine($"Tipo de conta do cliente: { entity.TipoConta }.");
                Console.WriteLine($"O Código da Agência é: { entity.CodigoBanco }");
                Console.WriteLine($"O Número da Agência é: { entity.Agencia } ");
                Console.WriteLine($"O Número da Conta é: { entity.NumeroConta } ");
                Console.WriteLine($"Saldo inicial é de: {entity.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
                Console.ReadKey(); 

                //CadastrarPix(cpf, saldo); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        } 
    }
} 