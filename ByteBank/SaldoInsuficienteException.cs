using System;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperaçãoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque):this("Saldo insuficiente: "+saldo +"\nTentativa de saque no valor de "+valorSaque)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message, Exception excecaoInterna) : base(message, excecaoInterna)
        {
        }
    }
}
