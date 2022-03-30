//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _5412_Trabalho_Prático
//{
//    class Functions
//    {
//        List<Veiculo> veiculo = new List<Veiculo>();
//        internal static void InserirVeiculo()
//        {
//            int a = 1;

//            while (a != 0)
//            {
//                Console.Clear();
//                Console.WriteLine("Insira o veículo que quer inserir");
//                Console.WriteLine("1 - Inserir Carro");
//                Console.WriteLine("2 - Inserir Mota");
//                Console.WriteLine("3 - Inserir Camião");
//                Console.WriteLine("4 - Inserir Camioneta");
//                Console.WriteLine("0 - Sair");

//                Console.Write("\nInsira uma opção: ");
//                int b = int.Parse(Console.ReadLine());

//                if (b == 0)
//                {
//                    break;
//                }
//                else
//                {
//                    switch (b)
//                    {
//                        case 1:
//                            InserirCarro();
//                            break;
//                        case 2:
//                            InserirMota();
//                            break;
//                        case 3:
//                            InserirCamiao();
//                            break;
//                        case 4:
//                            InserirCamioneta();
//                            break;

//                        default:
//                            Console.WriteLine("Insira uma opção válida");
//                            break;
//                    }
//                }

//            }
//        }

        

//        internal static void AlterarEstadoVeiculo()
//            {
//                throw new NotImplementedException();
//            }

//            internal static void VeiculosDisponiveisAlguer()
//            {
//                throw new NotImplementedException();
//            }

//            internal static void VeiculosManutencao()
//            {
//                throw new NotImplementedException();
//            }

//            internal static void ReservaVeiculos()
//            {
//                throw new NotImplementedException();
//            }

//            internal static void ExportarFicheiro()
//            {
//                throw new NotImplementedException();
//            }

//            internal static void VerVeiculos()
//            {
//                throw new NotImplementedException();
//            }
        

//        private static void InserirCarro()
//        {
//            string tipo = "Carro";

//            Console.Clear();
//            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
//            Console.Write("Marca e Modelo: ");
//            string marcaModelo = Console.ReadLine();
//            Console.Write("Cor: ");
//            string cor = Console.ReadLine();
//            Console.Write("Combustivel: ");
//            string combustivel = Console.ReadLine();
//            Console.Write("Preço/dia: ");
//            double preco = double.Parse(Console.ReadLine());
//            //if(preco < 0)
//            //{
//            while (preco < 0)
//            {
//                Console.Write("Insira um preço válido: ");
//                preco = double.Parse(Console.ReadLine());
//            }

//            //}
//            Console.Write("Nº Portas  (3 ou 5) : ");
//            int portas = int.Parse(Console.ReadLine());
//            //if(portas != 3 && portas != 5)
//            //{
//            while (portas != 3 && portas != 5)
//            {
//                Console.Write("Insira um Nº Portas válido: ");
//                portas = int.Parse(Console.ReadLine());
//            }

//            //}
//            Console.Write("Insira o tipo de caixa do veículo: ");
//            string caixa = Console.ReadLine();

//            Console.WriteLine("Estado do Veículo:");
//            Console.WriteLine("\t1 - Disponivel");
//            Console.WriteLine("\t2 - Alugado");
//            Console.WriteLine("\t3 - Reservado");
//            Console.WriteLine("\t4 - Em Manutenção");

//            Console.Write("Insira a opção: ");
//            int opcao = int.Parse(Console.ReadLine());

//            while (opcao < 0 || opcao > 4)
//            {
//                Console.WriteLine("Insira uma opção válida!");
//                Console.WriteLine("Estado do Veículo:");
//                Console.WriteLine("\t1 - Disponivel");
//                Console.WriteLine("\t2 - Alugado");
//                Console.WriteLine("\t3 - Reservado");
//                Console.WriteLine("\t4 - Em Manutenção");

//                Console.Write("Insira a opção: ");
//                opcao = int.Parse(Console.ReadLine());
//            }

//            string estado = "Disponivel";
//            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());

//            switch (opcao)
//            {
//                case 1:
//                    estado = "Disponivel";
//                    veiculo.Add(new Carro(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, portas, caixa));
//                    break;
//                case 2:
//                    estado = "Alugado";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Carro(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, portas, caixa));
//                    break;
//                case 3:
//                    estado = "Reservado";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Carro(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, portas, caixa));
//                    break;
//                case 4:
//                    estado = "Em Manutenção";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Carro(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, portas, caixa));
//                    break;
//            }


//        }

//        private static void InserirMota()
//        {
//            string tipo = "Mota";

//            Console.Clear();
//            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
//            Console.Write("Marca e Modelo: ");
//            string marcaModelo = Console.ReadLine();
//            Console.Write("Cor: ");
//            string cor = Console.ReadLine();
//            Console.Write("Combustivel: ");
//            string combustivel = Console.ReadLine();
//            Console.Write("Preço/dia: ");
//            double preco = double.Parse(Console.ReadLine());
//            //if(preco < 0)
//            //{
//            while (preco < 0)
//            {
//                Console.Write("Insira um preço válido: ");
//                preco = double.Parse(Console.ReadLine());
//            }

//            //}
//            Console.Write("Insira a Cilindrada do Veículo: ");
//            int cilindrada = int.Parse(Console.ReadLine());
//            while (cilindrada != 50 && cilindrada != 125 && cilindrada != 300)
//            {
//                Console.Write("Insira uma Cilindrada válida (50, 125 ou 300) : ");
//                cilindrada = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Estado do Veículo:");
//            Console.WriteLine("\t1 - Disponivel");
//            Console.WriteLine("\t2 - Alugado");
//            Console.WriteLine("\t3 - Reservado");
//            Console.WriteLine("\t4 - Em Manutenção");

//            Console.Write("Insira a opção: ");
//            int opcao = int.Parse(Console.ReadLine());

//            while (opcao < 0 || opcao > 4)
//            {
//                Console.WriteLine("Insira uma opção válida!");
//                Console.WriteLine("Estado do Veículo:");
//                Console.WriteLine("\t1 - Disponivel");
//                Console.WriteLine("\t2 - Alugado");
//                Console.WriteLine("\t3 - Reservado");
//                Console.WriteLine("\t4 - Em Manutenção");

//                Console.Write("Insira a opção: ");
//                opcao = int.Parse(Console.ReadLine());
//            }

//            string estado = "Disponivel";
//            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());
//            switch (opcao)
//            {
//                case 1:
//                    estado = "Disponivel";
//                    veiculo.Add(new Mota(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, cilindrada));
//                    break;
//                case 2:
//                    estado = "Alugado";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Mota(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, cilindrada));
//                    break;
//                case 3:
//                    estado = "Reservado";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Mota(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, cilindrada));
//                    break;
//                case 4:
//                    estado = "Em Manutenção";
//                    dataPrevista = ColocarData();
//                    veiculo.Add(new Mota(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, cilindrada));
//                    break;

//            }
//        }
//    }
