using System;

namespace ProgramacaoOrientadosAObjetosComCarros.Model
{
    public class Car
    {
        public Guid IdCar { get; set; }
        public string BoardCar { get; set; }
        public string BrandCar { get; set; }
        public string YearCar { get; set; }
        public int HorsePowerCar { get; set; }
        public decimal WeightCar { get; set; }
        public decimal MaximiumTorqueCar { get; set; }
        public decimal LenghtCar { get; set; }
        public decimal WidthCar { get; set; }
        public decimal HeightCar { get;set; }
        public decimal EngineCapacity { get; set; }
        public EEngineType EngineType { get;set; }
        public decimal PrizeCar { get; set; }
        public bool AcquiredCar { get; set; }             
    }

    public enum EEngineType
    {
        Turbo = 1,
        Aspirated
    }

}