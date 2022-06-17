using System;

namespace ProjetoInterrogacao.Interrogacao.Model
{
    public class Customer : User
    {
        public ETypeCustomer TypeCustomer { get; set; } 
        public string Address { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }        
    }

    public enum ETypeCustomer
    {
        CPF = 1,
        CNPJ = 2
    }
}