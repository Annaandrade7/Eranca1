using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{
    internal class ContaEstudante : Conta
    {
        public double LimitechequeEsp { get; set; } 
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante(double limitechequeEsp, string cpf, string nomeInstituicao,
            int nconta, string agencia, string titular, double saldo):
            base(nconta, agencia, titular, saldo)
        {
            LimitechequeEsp = limitechequeEsp;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }

        public override void Saque(double valor)
        {
            if(valor <= Saldo + LimitechequeEsp)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }
    }
}
