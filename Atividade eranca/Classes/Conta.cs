﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_eranca.Classes
{

    internal class Conta
    {
        public int NConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(){ }

        public Conta(int nConta, string agencia, string titular, double saldo)
        {
            this.NConta = nConta;
            this.Agencia = agencia;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public virtual void Saque(double valor)
        {
            if (this.Saldo >= 0)
            {
                Saldo = Saldo - valor;  
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }

        public void Depositar(double valor)
        {
            if(valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Operação invalida!");
            }
        }
    }
}
