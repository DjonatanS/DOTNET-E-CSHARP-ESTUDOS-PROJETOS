using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CompararObjetos.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(','); //separar o argumento baseado na virgula
            Name = vect[0]; //antes da virgula;
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture); //dps da vurgula
        }

        public override string ToString()
        {
            return $"Name : {Name} Salary : {Salary}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Argument is not an Employee");
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
