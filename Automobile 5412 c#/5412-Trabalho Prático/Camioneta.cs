using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5412_Trabalho_Prático
{
    class Camioneta : Veiculo
    {
        //Encapsulamento

        //private int eixos;
        //private int nrpassageiros;

        public int Eixos { get; set; }
        public int Nrpassageiros { get; set; }

        //public int Eixos 
        //{
        //    get => eixos;
        //    set
        //    {
        //        if(Eixos != 2 && Eixos != 3)
        //        {
        //            eixos = 2;
        //        }
        //        else
        //        {
        //            eixos = value;
        //        }
        //    }
        //} 
        //public int Nrpassageiros 
        //{
        //    get => nrpassageiros;
        //    set
        //    {
        //        if(Nrpassageiros!= 0)
        //        {
        //            nrpassageiros = 10;
        //        }
        //        else
        //        {
        //            nrpassageiros = value;
        //        }
        //    }
        //}

        //Construtores

        public Camioneta() : base()
        {
            Eixos = 0;
            Nrpassageiros = 0;
        }
        
        public Camioneta(string nome, string tipo, string cor, string combustivel, double precoDia, string estado,  int eixos, int passageiros) : base(nome, tipo, cor, combustivel, precoDia, estado)
        {
            Eixos = eixos;
            Nrpassageiros = passageiros;
        }

        public Camioneta(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, DateTime data, int eixos, int passageiros) : base(nome, tipo, cor, combustivel, precoDia, estado, data)
        {
            Eixos = eixos;
            Nrpassageiros = passageiros;
        }

        public Camioneta(Camioneta camioneta) : base(camioneta)
        {
            Eixos = camioneta.Eixos;
            Nrpassageiros = camioneta.Nrpassageiros;
        }


        //Override

        public override string ToString()
        {
            return base.ToString() + $"\tNºeixos: {Eixos}\tNºPass: {Nrpassageiros}";
        }


    }
}
