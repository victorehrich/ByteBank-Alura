// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Numero { get; }

        private double _saldo = 100;
        public int Agencia { get; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        public static double TaxaOperacao { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public ContaCorrente(int agenciaBancaria, int numeroConta)
        {
            if (agenciaBancaria <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que zero!",nameof(agenciaBancaria));
            }
            else if (numeroConta <= 0)
            {
                throw new ArgumentException("O número deve ser maior que zero!", nameof(numeroConta));
            }

            Agencia = agenciaBancaria;
            Numero = numeroConta;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para saques", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo,valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferencia", nameof(valor));
            }
            try
            {
                Sacar(valor); 

            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperaçãoFinanceiraException("Opercao não realizada", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}
