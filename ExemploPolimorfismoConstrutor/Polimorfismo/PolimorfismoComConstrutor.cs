using System;

namespace ExemploPolimorfismoConstrutor.Polimorfismo
{
    public class PolimorfismoComConstrutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        
        public PolimorfismoComConstrutor(int id, string nome, string chave)
        {
            Id = id;
            Nome = nome;
            Chave = chave;
        }

        public PolimorfismoComConstrutor()
        {        
        }

        public void Execucao()
        {
        }

        public class Teste
        {
            PolimorfismoComConstrutor polimorfismoComConstrutor = new PolimorfismoComConstrutor(1, "testes", "1012x52");
        }
    }
}