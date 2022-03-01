using ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Register(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.getBonification();
        }
        public void Register(Diretor diretor)
        {
            _totalBonificacao += diretor.getBonification();
        }
        public double getTotalBonificacao()
        {
            return _totalBonificacao;
        }    


    }
}
