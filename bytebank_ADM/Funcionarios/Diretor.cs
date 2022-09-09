using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public override double getBonificacao()
        {
            return Salario * 0.5;
        }

        public Diretor(String cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
