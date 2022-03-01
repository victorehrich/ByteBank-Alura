using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class GerenteDeConta : FuncionárioAutenticavel
    {

        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }
        public override void AumentarSalário()
        {
            Salario *= 1.05;
        }
        public override double getBonification()
        {
            return Salario *0.25;
        }
    }
}
