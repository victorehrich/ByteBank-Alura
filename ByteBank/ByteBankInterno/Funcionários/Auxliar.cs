using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Auxliar : Funcionario
    {
        public Auxliar(string cpf) : base(cpf, 2000)
        {

        }
        public override void AumentarSalário()
        {
            Salario *= 1.10;
        }
        public override double getBonification()
        {
            return Salario *0.2;
        }
    }
}
