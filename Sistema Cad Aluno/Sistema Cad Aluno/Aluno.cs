using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cad_Aluno
{
    struct Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }

        public override string ToString()
        {
            return $"Nome {Nome} Nota {Nota}";
        }
    }
}
