using System;

namespace ProjetoInterrogacao.Interrogacao.Model
{
    public class User
    {
        public string Name { get; set; }
        public EGender Gender { get; set; }
        public DateTime BirthDate { get; set;}   
        public string Document { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set;}      
        public string Telephone { get; set; }
        public EMarriageStatus MarriageStatus { get; set; }
        public string Email { get; set; } 
        public string Password { get;set; }          
    }

    public enum EGender
    {
        Female = 1,
        Male = 2
    }

    public enum EMarriageStatus
    {
        Sigle = 1,
        Married = 2,
        Widow = 3
    }
}