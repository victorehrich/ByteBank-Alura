using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperaçãoFinanceiraException : Exception
    {
        public OperaçãoFinanceiraException()
        {
        }

        public OperaçãoFinanceiraException(string message) : base(message)
        {
        }
        public OperaçãoFinanceiraException(string message, Exception excecaoInterna) :base(message, excecaoInterna)
        {
        }
    }
}
