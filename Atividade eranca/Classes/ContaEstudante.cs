using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{
    internal class ContaEstudante
    {
        public double LimitechequeEsp { get; set; } 
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante(double limitechequeEsp, string cpf, string nomeInstituicao)
        {
            LimitechequeEsp = limitechequeEsp;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }
    }
}
