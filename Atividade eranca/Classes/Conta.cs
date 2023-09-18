using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{
    internal class Conta
    {
        public int nConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int nConta, string agencia, string titular, double saldo)
        {
            this.nConta = nConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
