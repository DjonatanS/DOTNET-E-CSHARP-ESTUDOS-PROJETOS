using System;
using System.Collections.Generic;
using Composição.Entities.Enums;
namespace Composição.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Associação entre Classes
        public Department Department { get; set; } 

        //Criação Lista de Contratos
        public List<HourContract> Contracts = new List<HourContract>(); 

        //Construtores
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
    }
}
