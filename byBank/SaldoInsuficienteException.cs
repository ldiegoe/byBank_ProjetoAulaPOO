using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {   
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {   
        }
        public SaldoInsuficienteException (string mensagem, Exception innerException) : base(mensagem, innerException)
        {
        }
    }
}
