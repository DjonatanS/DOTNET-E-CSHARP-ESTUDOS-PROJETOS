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

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) //por cada Contrato na lista de contratos
            {
                //se o ano do contrato for igual a "year" e se o mes for igual "month" recebido em Income;
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
