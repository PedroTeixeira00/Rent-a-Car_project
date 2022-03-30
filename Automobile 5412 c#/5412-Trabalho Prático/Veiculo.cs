using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5412_Trabalho_Prático
{
    class Veiculo
    {
        // Encapsulamento

        public string MarcaMod { get; set; }

        public string Tipo { get; set; }

        public string Cor { get; set; }

        public string Combustivel { get; set; }

        public double _precoDia { get; private set; }

        public string Estado { get; set; }

        public DateTime Data { get; set; }


        // Construtores

        public Veiculo()
        {
            MarcaMod = "";
            Tipo = "Não Definido";
            Cor = "";
            Combustivel = "";
            _precoDia = 0.0;
            Estado = "Disponivel";
            Data = DateTime.Parse(DateTime.Now.ToShortDateString());
        }

        public Veiculo(string nome, string tipo, string cor, string combustivel, double precoDia, string estado) : this() 
        {
            MarcaMod = nome;
            Tipo = tipo;
            Cor = cor;
            Combustivel = combustivel;
            _precoDia = precoDia;
            Estado = estado;
        }

        public Veiculo(string nome, string tipo, string cor, string combustivel, double precoDia, string estado, DateTime data) : this()
        {
            MarcaMod = nome;
            Tipo = tipo;
            Cor = cor;
            Combustivel = combustivel;
            _precoDia = precoDia;
            Estado = estado;
            Data = data;
        }

        public Veiculo(Veiculo v) :this()
        {
            MarcaMod = v.MarcaMod;
            Tipo = v.Tipo;
            Cor = v.Cor;
            Combustivel =v.Combustivel;
            _precoDia = v._precoDia;
            Estado = v.Estado;
        }


        

        

        // Overrides


        public override string ToString()
        {
            return $"Marca/Modelo: {MarcaMod} \tTipo: {Tipo} \tCor: {Cor} \tCombustível: {Combustivel} \tPreço/dia: {_precoDia} \tEstado: {Estado} \tData para Disponibilidade: {Data.ToShortDateString()}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static implicit operator List<object>(Veiculo v)
        {
            throw new NotImplementedException();
        }
    }
}
