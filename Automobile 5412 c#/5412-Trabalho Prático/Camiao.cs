using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5412_Trabalho_Prático
{
    class Camiao : Veiculo
    {
        //Encapsulamento
        //private int peso;

        public int _peso { get; set; }
        //public int _peso
        //{
        //    get => peso;
        //    set
        //    {
        //        if(_peso < 900)
        //        {
        //            peso = 900;
        //        }
        //        else
        //        {
        //            peso = value;
        //        }
        //    }
        //}


        //Construtores 

        public Camiao() : base()
        {
            _peso = 900;
        }

        public Camiao(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, int peso) : base(nome, tipo, cor, combustivel, precoDia, estado)
        {
            _peso = peso;
        }

        public Camiao(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, DateTime data, int peso) : base(nome, tipo, cor, combustivel, precoDia, estado,  data)
        {
            _peso = peso;
        }

        public Camiao(Camiao c) : base(c)
        {
            _peso = c._peso;
        }


        
        //Override

        public override string ToString()
        {
            return base.ToString() + $"\tPeso máximo: {_peso}Kg";
        }

    }
}
