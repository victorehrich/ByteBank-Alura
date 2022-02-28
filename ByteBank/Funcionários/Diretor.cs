using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Diretor : FuncionárioAutenticavel
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override void AumentarSalário()
        {
            Salario *= 1.15;
        }
        public override double getBonification()
        {
            return Salario *0.5;
        }
    }
}
