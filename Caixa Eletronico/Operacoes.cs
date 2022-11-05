using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    internal class Operacoes
    {
        private double _saldo;
        public double Saque;
        public double Deposito;

        public Operacoes()
        {
            _saldo = 1500.00;
        }

       

        public double OpSaque(double saque)
        {
            return _saldo -= saque;
        }

        public void OpDeposito(double deposito)
        {
            _saldo += deposito;
        }

        public double Saldo
        {
            get { return _saldo; }
        }
        
    }
}
