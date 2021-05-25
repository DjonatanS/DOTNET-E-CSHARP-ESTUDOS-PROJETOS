

namespace Classes_e_Metodos
{
    class Funcionarios
    {
        public string Nome;
        public string Cargo;
        public double Salario;
        public double Imposto;
        public double Aux;
    

        public double SalarioLiquido()
        {
            return Salario = Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Aux = Salario / porcentagem;
            Salario = Salario + Aux;
            
        }

        public override string ToString()
        {
            return $"Salario atual {Salario} ";
        }
    }

}
