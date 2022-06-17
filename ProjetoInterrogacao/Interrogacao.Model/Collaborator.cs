using System;

namespace ProjetoInterrogacao.Interrogacao.Model
{
    public class Collaborator : User
    {
        public string CustormerOffice { get; set; }
        public EAccessType AccessType { get; set; }
        public string EmployeeTraining { get; set; }
        public string Department { get; set; }        
    }

    public enum EAccessType
    {
        Administrator = 1,
        Management = 2,
        Financial = 3,
        Commercial = 4,
        Technician = 5,
        InformationTechnology = 6,
        Quality = 7
    }
}