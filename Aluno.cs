using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Nota_Aluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double SomaNota()
        {
            double Notas = (Nota1 + Nota2 + Nota3) / 3;

            return Notas;
        }

        public double FaltaNota()
        {
            double Restante = 6 - SomaNota();

            return Restante;
        }
    }
}
