using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5412_Trabalho_Prático
{
    class Carro : Veiculo
    {

        // Encapsulamento
        
        public List<Carro> carros { get; set; }
        public int Portas { get; set; }

        public string Caixa { get; set; }
        //public int Portas
        //{
        //    get => portas;

        //    set
        //    {
        //        if (value != 3 && value != 5)    // Usar value ou o nome do método de encapsulamento é igual.
        //        {
        //            portas = 3;
        //            //Console.WriteLine("Volte a inserir um valor válido: (3 ou 5)");     // Atenção Verificar
        //            //Portas = int.Parse(Console.ReadLine());
        //        }
        //        else
        //        {
        //            portas = value;
        //        }

        //    }
        //}
        //public string Caixa 
        //{
        //    get => caixa;
        //    set
        //    {
        //        if(value != "manual" && value != "automatica")
        //        {
        //            caixa = "manual";
        //        }
        //        else
        //        {
        //            caixa = value;
        //        }
        //    }
        //}

        //Construtores

        public Carro() : base()
        {
            Portas = 0;
            Caixa = "Não definida";
        }

        public Carro(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, int portas, string caixa) : base(nome, tipo, cor, combustivel, precoDia, estado)
        {
            Portas = portas;
            Caixa = caixa;
        }

        public Carro(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, DateTime data, int portas, string caixa) : base(nome, tipo, cor, combustivel, precoDia, estado, data)
        {
            Portas = portas;
            Caixa = caixa;
        }

        public Carro(Carro c) : base(c)
        {
            Portas = c.Portas;
            Caixa = c.Caixa;
        }



        //Overrides

        public override string ToString()
        {
            return base.ToString() + $"\tNºPortas: {Portas}\tCaixa: {Caixa}";
        }
    }
}
