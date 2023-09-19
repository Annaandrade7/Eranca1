using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{
    internal class ContaEmpresarial: Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set;}
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo,
            int nconta, string agencia, string titular, double saldo):
            base(nconta, agencia, titular, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public override void Saque(double valor)
        {
            if( valor <= Saldo)
            {
                Saldo -= valor;
                if(valor >= 5000)
                {
                    Saldo -= 5;
                }
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
            // base.Saque(valor);  
        }

        public void RealizarEmprestimo(double valor) 
        { 
            if(valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
            }
            else
            {
                Console.WriteLine("Valor indisponivel!");
            }
        }

    }
}
