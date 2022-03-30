using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5412_Trabalho_Prático
{
    class Mota : Veiculo
    {

        //Encapsulamento

        //private string cilindrada;

        public int Cilindrada 
        {
            get; set;
        }

        //Construtores

        public Mota() : base()
        {
            Cilindrada = 0;
        }

        public Mota(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, int cilindrada) : base(nome, tipo, cor, combustivel, precoDia, estado)
        {
            Cilindrada = cilindrada;
        }

        public Mota(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, DateTime data, int cilindrada) : base(nome, tipo, cor, combustivel, precoDia, estado, data)
        {
            Cilindrada = cilindrada;
        }

        public Mota(Mota m) : base(m)
        {
            Cilindrada = m.Cilindrada;
        }



        //Overrides
        public override string ToString()
        {
            return base.ToString() + $"\tCilindrada: {Cilindrada}cc";
        }

    }
}
