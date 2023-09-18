using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{
    internal class ContaEmpresarial
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set;}
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }
    }
}
