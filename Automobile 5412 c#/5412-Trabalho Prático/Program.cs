using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace _5412_Trabalho_Prático
{
    internal class Program
    {
        static List<Veiculo> veiculo;
        static List<Veiculo> carros;
        static List<Veiculo> motas = new List<Veiculo>();
        static List<Veiculo> camioes = new List<Veiculo>();
        static List<Veiculo> camionetas = new List<Veiculo>();
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            stockBase();

            int x = 1;

            while (x != 0)
            {
                Console.Clear();
                Console.WriteLine("Seja Bem-Vindo à AUTOMOBILE");

                Console.Write("Pressione a tecla (1) para prosseguir...");
                int opcao = int.Parse(Console.ReadLine());

                while (opcao > 1)
                {
                    Console.Write("Pressione uma tecla válida!");
                    opcao = int.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 1:
                        MenuPrincipal();
                        break;
                }

            }


        }


        public static void MenuPrincipal()
        {
            int x = 1;
            while (x != 0)
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir um veículo");
                Console.WriteLine("2 - Alterar estado de um veículo");
                Console.WriteLine("3 - Veículos disponiveis para reserva");
                Console.WriteLine("4 - Veículos em manutenção");
                Console.WriteLine("5 - Reserva de veículos");
                Console.WriteLine("6 - Exportar tabela para ficheiro HTML");
                Console.WriteLine("7 - Ver Veiculos");
                Console.WriteLine("0 - Sair");

                Console.Write("\nInsira a opção: ");
                int a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    break;
                }
                else
                {
                    switch (a)
                    {
                        case 1:
                            InserirVeiculo();
                            break;
                        case 2:
                            AlterarEstadoVeiculo();
                            break;
                        case 3:
                            VeiculosDisponiveisAlguer();
                            break;
                        case 4:
                            VeiculosManutencao();
                            break;
                        case 5:
                            ReservaVeiculos();
                            break;
                        case 6:
                            ExportarFicheiro();
                            break;
                        case 7:
                            VerVeiculos();
                            break;
                        //case 0:
                        //    break;
                        default:
                            Console.WriteLine("Insira uma opção válida!");
                            break;

                    }
                }





            }
        }


        // Inserção e Veículos

        private static void InserirVeiculo()
        {
            int a = 1;

            while (a != 0)
            {
                Console.Clear();
                Console.WriteLine("Insira o veículo que quer inserir");
                Console.WriteLine("1 - Inserir Carro");
                Console.WriteLine("2 - Inserir Mota");
                Console.WriteLine("3 - Inserir Camião");
                Console.WriteLine("4 - Inserir Camioneta");
                Console.WriteLine("0 - Sair");

                Console.Write("\nInsira uma opção: ");
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    break;
                }
                else
                {
                    switch (b)
                    {
                        case 1:
                            InserirCarro();
                            break;
                        case 2:
                            InserirMota();
                            break;
                        case 3:
                            InserirCamiao();
                            break;
                        case 4:
                            InserirCamioneta();
                            break;

                        default:
                            Console.WriteLine("Insira uma opção válida");
                            break;
                    }
                }

            }
        }

        private static void InserirCarro()
        {
            string tipo = "Carro";

            Console.Clear();
            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
            Console.Write("Marca e Modelo: ");
            string marcaModelo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Combustivel: ");
            string combustivel = Console.ReadLine();
            Console.Write("Preço/dia: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if(preco < 0)
            //{
            while (preco < 0)
            {
                Console.Write("Insira um preço válido: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //}
            Console.Write("Nº Portas  (3 ou 5) : ");
            int portas = int.Parse(Console.ReadLine());
            //if(portas != 3 && portas != 5)
            //{
            while (portas != 3 && portas != 5)
            {
                Console.Write("Insira um Nº Portas válido: ");
                portas = int.Parse(Console.ReadLine());
            }

            //}
            Console.Write("Insira o tipo de caixa do veículo: ");
            string caixa = Console.ReadLine();

            Console.WriteLine("Estado do Veículo:");
            Console.WriteLine("\t1 - Disponivel");
            Console.WriteLine("\t2 - Alugado");
            Console.WriteLine("\t3 - Reservado");
            Console.WriteLine("\t4 - Em Manutenção");

            Console.Write("Insira a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Insira uma opção válida!");
                Console.WriteLine("Estado do Veículo:");
                Console.WriteLine("\t1 - Disponivel");
                Console.WriteLine("\t2 - Alugado");
                Console.WriteLine("\t3 - Reservado");
                Console.WriteLine("\t4 - Em Manutenção");

                Console.Write("Insira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            string estado = "Disponivel";
            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());

            switch (opcao)
            {
                case 1:
                    estado = "Disponivel";

                    break;
                case 2:
                    estado = "Alugado";
                    dataPrevista = ColocarData();

                    break;
                case 3:
                    estado = "Reservado";
                    dataPrevista = ColocarData();

                    break;
                case 4:
                    estado = "Em Manutenção";
                    dataPrevista = ColocarData();
                    break;
            }

            veiculo.Add(new Carro(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, portas, caixa));
        }

        private static void InserirMota()
        {
            string tipo = "Mota";

            Console.Clear();
            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
            Console.Write("Marca e Modelo: ");
            string marcaModelo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Combustivel: ");
            string combustivel = Console.ReadLine();
            Console.Write("Preço/dia: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if(preco < 0)
            //{
            while (preco < 0)
            {
                Console.Write("Insira um preço válido: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //}
            Console.Write("Insira a Cilindrada do Veículo: ");
            int cilindrada = int.Parse(Console.ReadLine());
            while (cilindrada != 50 && cilindrada != 125 && cilindrada != 300)
            {
                Console.Write("Insira uma Cilindrada válida (50, 125 ou 300) : ");
                cilindrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Estado do Veículo:");
            Console.WriteLine("\t1 - Disponivel");
            Console.WriteLine("\t2 - Alugado");
            Console.WriteLine("\t3 - Reservado");
            Console.WriteLine("\t4 - Em Manutenção");

            Console.Write("Insira a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Insira uma opção válida!");
                Console.WriteLine("Estado do Veículo:");
                Console.WriteLine("\t1 - Disponivel");
                Console.WriteLine("\t2 - Alugado");
                Console.WriteLine("\t3 - Reservado");
                Console.WriteLine("\t4 - Em Manutenção");

                Console.Write("Insira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            string estado = "Disponivel";
            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());
            switch (opcao)
            {
                case 1:
                    estado = "Disponivel";
                    break;
                case 2:
                    estado = "Alugado";
                    dataPrevista = ColocarData();
                    break;
                case 3:
                    estado = "Reservado";
                    dataPrevista = ColocarData();
                    break;
                case 4:
                    estado = "Em Manutenção";
                    dataPrevista = ColocarData();
                    break;


            }
            veiculo.Add(new Mota(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, cilindrada));
        }

        private static void InserirCamiao()
        {
            string tipo = "Camião";

            Console.Clear();
            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
            Console.Write("Marca e Modelo: ");
            string marcaModelo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Combustivel: ");
            string combustivel = Console.ReadLine();
            Console.Write("Preço/dia: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if(preco < 0)
            //{
            while (preco < 0)
            {
                Console.Write("Insira um preço válido: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //}
            Console.Write("Peso Máximo: ");
            int pesoMaximo = int.Parse(Console.ReadLine());

            while (pesoMaximo < 100)
            {
                Console.Write("Insira um Peso Máximo válido: ");
                pesoMaximo = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Estado do Veículo:");
            Console.WriteLine("\t1 - Disponivel");
            Console.WriteLine("\t2 - Alugado");
            Console.WriteLine("\t3 - Reservado");
            Console.WriteLine("\t4 - Em Manutenção");

            Console.Write("Insira a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Insira uma opção válida!");
                Console.WriteLine("Estado do Veículo:");
                Console.WriteLine("\t1 - Disponivel");
                Console.WriteLine("\t2 - Alugado");
                Console.WriteLine("\t3 - Reservado");
                Console.WriteLine("\t4 - Em Manutenção");

                Console.Write("Insira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            string estado = "Disponivel";
            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());
            switch (opcao)
            {
                case 1:
                    estado = "Disponivel";
                    break;
                case 2:
                    estado = "Alugado";
                    dataPrevista = ColocarData();
                    break;
                case 3:
                    estado = "Reservado";
                    dataPrevista = ColocarData();
                    break;
                case 4:
                    estado = "Em Manutenção";
                    dataPrevista = ColocarData();
                    break;

            }

            veiculo.Add(new Camiao(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, pesoMaximo));
        }

        private static void InserirCamioneta()
        {
            string tipo = "Camioneta";

            Console.Clear();
            Console.WriteLine("Preencha as seguintes informações sobre a viatura:");
            Console.Write("Marca e Modelo: ");
            string marcaModelo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Combustivel: ");
            string combustivel = Console.ReadLine();
            Console.Write("Preço/dia: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if(preco < 0)
            //{
            while (preco < 0)
            {
                Console.Write("Insira um preço válido: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //}
            Console.Write("Nº Eixos: ");
            int eixos = int.Parse(Console.ReadLine());

            while (eixos != 3 && eixos != 2)
            {
                Console.Write("Insira um Nº Eixos válido (2 ou 3) : ");
                eixos = int.Parse(Console.ReadLine());
            }

            Console.Write("Insira o Nº Passageiros: ");
            int passageiros = int.Parse(Console.ReadLine());

            while (passageiros < 5)
            {
                Console.Write("Insira um Nº Passageiros Válido: ");
                passageiros = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Estado do Veículo:");
            Console.WriteLine("\t1 - Disponivel");
            Console.WriteLine("\t2 - Alugado");
            Console.WriteLine("\t3 - Reservado");
            Console.WriteLine("\t4 - Em Manutenção");

            Console.Write("Insira a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Insira uma opção válida!");
                Console.WriteLine("Estado do Veículo:");
                Console.WriteLine("\t1 - Disponivel");
                Console.WriteLine("\t2 - Alugado");
                Console.WriteLine("\t3 - Reservado");
                Console.WriteLine("\t4 - Em Manutenção");

                Console.Write("Insira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            string estado = "Disponivel";
            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());
            switch (opcao)
            {
                case 1:
                    estado = "Disponivel";
                    break;
                case 2:
                    estado = "Alugado";
                    dataPrevista = ColocarData();
                    break;
                case 3:
                    estado = "Reservado";
                    dataPrevista = ColocarData();
                    break;
                case 4:
                    estado = "Em Manutenção";
                    dataPrevista = ColocarData();
                    break;

            }

            veiculo.Add(new Camioneta(marcaModelo, tipo, cor, combustivel, preco, estado, dataPrevista, eixos, passageiros));

        }

        private static DateTime ColocarData()
        {
            DateTime data;

            Console.WriteLine("Insira a Data Prevista para Disponibilidade:");
            Console.Write("Data (dd/mm/aaaa): ");
            data = DateTime.Parse(Console.ReadLine());

            int verif = DateTime.Compare(data, DateTime.Now);

            while (verif < 0)
            {
                Console.WriteLine("Insira uma data válida!");
                Console.Write("Data (dd/mm/aaaa): ");
                data = DateTime.Parse(Console.ReadLine());
                verif = DateTime.Compare(data, DateTime.Now);
            }


            return data;
        }




        //Alterar Estado de Veículos                  

        private static void AlterarEstadoVeiculo()
        {
            int opcao = ListagemVeiculos();

           

            Console.Write("Insira o código do Veículo que deseja alterar: ");
            int cod = int.Parse(Console.ReadLine());


            while (cod < 0 || cod > veiculo.Count)
            {
                Console.WriteLine("\nO Código que inseriu não se encontra na lista!");
                Console.WriteLine("Insira um código válido para proseguir com a operação:");
                Console.Write("Código Veículo: ");
                cod = int.Parse(Console.ReadLine());
            }



            int hashCode = veiculo[cod - 1].GetHashCode();



            switch (opcao)
            {
                case 1:
                    hashCode = veiculo[cod - 1].GetHashCode();  /*ListagemCompleta();*/
                    break;
                case 2:
                    hashCode = carros[cod - 1].GetHashCode();    //ListaCarros();
                    break;
                case 3:
                    hashCode = motas[cod - 1].GetHashCode();     //ListaMotas();
                    break;
                case 4:
                    hashCode = camioes[cod - 1].GetHashCode();     //ListaCamioes();
                    break;
                case 5:
                    hashCode = camionetas[cod - 1].GetHashCode();     //ListaCamionetas();
                    break;
                case 0:
                    break;
            }



            ALterarEstado(hashCode);

        }
        private static void ALterarEstado(int hashCode)
        {
            int codigoVeiculo = hashCode;

            Console.Clear();

            Console.WriteLine("Alterar estado:");
            Console.WriteLine("\t1 - Disponivel");
            Console.WriteLine("\t2 - Alugado");
            Console.WriteLine("\t3 - Reservado");
            Console.WriteLine("\t4 - Em Manutenção");

            Console.Write("Insira a opção: ");
            int opcao = int.Parse(Console.ReadLine());


            while (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Insira uma opção válida!");
                Console.WriteLine("Estado do Veículo:");
                Console.WriteLine("\t1 - Disponivel");
                Console.WriteLine("\t2 - Alugado");
                Console.WriteLine("\t3 - Reservado");
                Console.WriteLine("\t4 - Em Manutenção");

                Console.Write("Insira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            string estado = "Disponivel";
            DateTime dataPrevista = DateTime.Parse(DateTime.Now.ToShortDateString());

            switch (opcao)
            {
                case 1:
                    estado = "Disponivel";

                    break;
                case 2:
                    estado = "Alugado";
                    dataPrevista = ColocarData();

                    break;
                case 3:
                    estado = "Reservado";
                    dataPrevista = ColocarData();

                    break;
                case 4:
                    estado = "Em Manutenção";
                    dataPrevista = ColocarData();
                    break;
            }

            for (int i = 0; i < veiculo.Count; i++)
            {
                if (veiculo[i].GetHashCode() == codigoVeiculo)
                {
                    veiculo[i].Estado = estado;
                    veiculo[i].Data = dataPrevista;
                }
            }

            Console.WriteLine("Estado do Veículo alterado com Sucesso!");
            Console.Write("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();

        }



        // Listagem De Veículos


        private static int ListagemVeiculos()
        {
            Console.Clear();
            Console.WriteLine("\nPara fazer a alteração pretende ver: \n");
            Console.WriteLine("1 - Listagem Completa");
            Console.WriteLine("2 - Lista de Carros");
            Console.WriteLine("3 - Lista de Motas");
            Console.WriteLine("4 - Lista de Camiões");
            Console.WriteLine("5 - Lista de Camionetas");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("\nInsira a sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 5)
            {
                Console.Clear();
                Console.WriteLine("\nInsira uma opção válida!");

                Console.WriteLine("\nInsira a sua opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1:
                    ListagemCompleta();
                    break;
                case 2:
                    ListaCarros();
                    break;
                case 3:
                    ListaMotas();
                    break;
                case 4:
                    ListaCamioes();
                    break;
                case 5:
                    ListaCamionetas();
                    break;
                case 0:
                    break;
            }

           

            return opcao;
        }

        private static void ListaCamionetas()
        {
            camionetas = veiculo.FindAll(veiculo => veiculo.Tipo.ToLower() == "camioneta");

            Console.Clear();

            if (camionetas.Count > 0)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------LISTA DE CAMIONETAS-----------");
                Console.WriteLine("-----------------------------------------");

                for (int i = 0; i < camionetas.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cód: {i + 1} \t" + camionetas[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Ainda não existem Carros por apresentar");
            }

            Console.Write("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();
        }
        private static void ListaCamioes()
        {
            camioes = veiculo.FindAll(veiculo => veiculo.Tipo.ToLower() == "camião");

            Console.Clear();

            if (camioes.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-----------LISTA DE CAMIÕES------------");
                Console.WriteLine("---------------------------------------");

                for (int i = 0; i < camioes.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cód: {i + 1} \t" + camioes[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Ainda não existem Carros por apresentar");
            }

            Console.Write("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

        private static void ListaMotas()
        {
            motas = veiculo.FindAll(veiculo => veiculo.Tipo.ToLower() == "mota");

            Console.Clear();

            if (motas.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-----------LISTA DE MOTAS--------------");
                Console.WriteLine("---------------------------------------");

                for (int i = 0; i < motas.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cód: {i + 1} \t" + motas[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Ainda não existem Carros por apresentar");
            }

            Console.Write("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

        private static void ListaCarros()
        {
            carros = veiculo.FindAll(veiculo => veiculo.Tipo.ToLower() == "carro");
            
            Console.Clear();

            if (carros.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-----------LISTA DE CARROS-------------");
                Console.WriteLine("---------------------------------------");

                for (int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cód: {i + 1} \t" + carros[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Ainda não existem Carros por apresentar");
            }

            Console.Write("\nPressione qualquer tecla para prosseguir...");
            
            Console.ReadKey();
        }

        private static void ListagemCompleta()
        {
            Console.Clear();

            if (veiculo.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-----------LISTA DE VEICULOS-----------");
                Console.WriteLine("---------------------------------------");

                for (int i = 0; i < veiculo.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cód: {i + 1} \t" + veiculo[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Ainda não existem veiculos por apresentar");
            }

            Console.Write("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();
        }



        // Disponibilidade de Veículos


        private static void VeiculosDisponiveisAlguer()       
        {
            Console.Clear();
            Console.WriteLine("Ver veículos disponiveis");
            Console.WriteLine("1 - Todos os veículos");
            Console.WriteLine("2 - Carros");
            Console.WriteLine("3 - Motas");
            Console.WriteLine("4 - Camiões");
            Console.WriteLine("5 - Camionetas");
            Console.WriteLine("0 - Sair");

            Console.Write("\nInsira a opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    VerificarDisponibilidade(opcao);
                    break;
                case 2:
                    VerificarDisponibilidade(opcao);
                    break;
                case 3:
                    VerificarDisponibilidade(opcao);
                    break;
                case 4:
                    VerificarDisponibilidade(opcao);
                    break;
                case 5:
                    VerificarDisponibilidade(opcao);
                    break;
                case 0:
                    break;

            }
        }

        private static void VerificarDisponibilidade(int opcao)
        {
            int op = opcao;

            Console.WriteLine("\nInsira a data que pretenda:\n");
            Console.WriteLine("1 - Data Atual");
            //Console.WriteLine("2 - Inserir outra Data");
            Console.WriteLine("0 - Sair");

            Console.Write("\nInsira a sua opção: ");
            int escolha = int.Parse(Console.ReadLine());

            DateTime dataDisponibilidade = DateTime.Parse(DateTime.Now.ToShortDateString());

            switch (escolha)
            {
                case 1:
                    dataDisponibilidade = DateTime.Parse(DateTime.Now.ToShortDateString());
                    break;
                //case 2:
                //    dataDisponibilidade = ColocarData();
                //    break;
                case 0:
                    break;
            }

            Disponibilidade(dataDisponibilidade, op);


        }

        private static void Disponibilidade(DateTime data, int opcao)
        {
            int op = opcao;

            DateTime dataRequerida = DateTime.Parse(DateTime.Now.ToShortDateString());

            int pos = 1;

            Console.Clear();

            switch (op)
            {
                case 1:
                    for (int i = 0; i < veiculo.Count; i++)
                    {
                        if (veiculo[i].Estado.ToLower() == "disponivel")
                        {
                            Console.WriteLine($"ID: {pos}\t" + veiculo[i].ToString());
                            Console.WriteLine("----------------------------------------");
                            pos++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < carros.Count; i++)
                    {
                        if (carros[i].Estado.ToLower() == "disponivel")
                        {
                            Console.WriteLine($"ID: {pos}\t" + carros[i].ToString());
                            Console.WriteLine("----------------------------------------");
                            pos++;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < motas.Count; i++)
                    {
                        if (motas[i].Estado.ToLower() == "disponivel")
                        {
                            Console.WriteLine($"ID: {pos}\t" + motas[i].ToString());
                            Console.WriteLine("----------------------------------------");
                            pos++;
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < camioes.Count; i++)
                    {
                        if (camioes[i].Estado.ToLower() == "disponivel")
                        {
                            Console.WriteLine($"ID: {pos}\t" + camioes[i].ToString());
                            Console.WriteLine("----------------------------------------");
                            pos++;
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < camionetas.Count; i++)
                    {
                        if (camionetas[i].Estado.ToLower() == "disponivel")
                        {
                            Console.WriteLine($"ID: {pos}\t" + camionetas[i].ToString());
                            Console.WriteLine("----------------------------------------");
                            pos++;
                        }
                    }
                    break;
                case 0:
                    break;


                    //else
                    //{
                    //    int resultado = DateTime.Compare(dataRequerida, veiculo[i].Data);
                    //    if (resultado > 0)
                    //    {
                    //        Console.WriteLine($"{pos}\t" + veiculo[i].ToString());
                    //        Console.WriteLine("----------------------------------------");       
                    //        pos++;
                    //    }
                    //    else
                    //    {

                    //    }
                    //}

            }

            Console.ReadKey();



            //for (int i = 0; i < veiculo.Count; i++)
            //{
            //    if (veiculo[i].Estado.ToLower() == "disponivel")
            //    {
            //        veiculoDisponiveis.Add(new Veiculo(veiculo[i]));
            //    }
            //    else
            //    {
            //        int resultado = DateTime.Compare(dataRequerida, veiculo[i].Data);
            //        if (resultado < 0)
            //        {
            //            veiculoDisponiveis.Add(new Veiculo(veiculo[i]));
            //        }
            //    }
            //}
        }


        //Veiculos em Manutenção

        private static void VeiculosManutencao()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Ver veículos Em Manutenção");
                Console.WriteLine("1 - Todos os veículos");
                Console.WriteLine("2 - Carros");
                Console.WriteLine("3 - Motas");
                Console.WriteLine("4 - Camiões");
                Console.WriteLine("5 - Camionetas");
                Console.WriteLine("0 - Sair");

                Console.Write("\nInsira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao < 0 || opcao > 5);



            Manutencao(opcao);
        }

        private static void Manutencao(int opcao)
        {


            Console.WriteLine("\nInsira a data que pretenda:\n");
            Console.WriteLine("1 - Data Atual");
            //Console.WriteLine("2 - Inserir outra Data");
            Console.WriteLine("0 - Sair");

            Console.Write("\nInsira a sua opção: ");
            int escolha = int.Parse(Console.ReadLine());

            DateTime dataDisponibilidade = DateTime.Parse(DateTime.Now.ToShortDateString());

            switch (escolha)
            {
                case 1:
                    dataDisponibilidade = DateTime.Parse(DateTime.Now.ToShortDateString());
                    break;
                //case 2:
                //    dataDisponibilidade = ColocarData();
                //    break;
                case 0:
                    break;
            }

            AtualmenteEmManutencao(dataDisponibilidade, opcao);
        }

        private static void AtualmenteEmManutencao(DateTime data, int opcao)
        {


            DateTime dataRequerida = DateTime.Parse(DateTime.Now.ToShortDateString());

            int pos = 1;

            Console.Clear();

            bool flag = false;
            string txt = "";

            if (opcao == 1)
            {

                for (int i = 0; i < veiculo.Count; i++)
                {
                    if (veiculo[i].Estado.ToLower() == "em manutenção")
                    {
                        Console.WriteLine($"ID: {pos}\t" + veiculo[i].ToString());
                        Console.WriteLine("----------------------------------------");
                        pos++;
                        flag = true;
                    }
                }
                txt = "veiculos";

            }
            else
            {

                List<Veiculo> tipoVeiculo = new List<Veiculo>();
                switch (opcao)
                {
                    case 2:
                        tipoVeiculo = carros;
                        txt = "Carros";
                        break;
                    case 3:
                        tipoVeiculo = motas;
                        txt = "Motas";
                        break;
                    case 4:
                        tipoVeiculo = camioes;
                        txt = "Camiões";
                        break;
                    case 5:
                        tipoVeiculo = camionetas;
                        txt = "Camionetas";
                        break;

                }

                for (int i = 0; i < tipoVeiculo.Count; i++)
                {
                    if (tipoVeiculo[i].Estado.ToLower() == "em manutenção")
                    {
                        Console.WriteLine($"ID: {pos}\t" + tipoVeiculo[i].ToString());
                        Console.WriteLine("----------------------------------------");
                        pos++;
                        flag = true;
                    }

                }


            }

            if (!flag)
            {

                Console.WriteLine($"Não existe de momento {txt} em Manutenção!");

            }



            Console.ReadKey();
        }


        // Reserva de veículos

        private static void ReservaVeiculos()
        {
            int opcao;
            int hashCode = 0;
            int cod;
            do
            {
                Console.Clear();
                Console.WriteLine("Ver veículos para Reservar");
                Console.WriteLine("1 - Todos os veículos");
                Console.WriteLine("2 - Carros");
                Console.WriteLine("3 - Motas");
                Console.WriteLine("4 - Camiões");
                Console.WriteLine("5 - Camionetas");
                Console.WriteLine("0 - Sair");

                Console.Write("\nInsira a opção: ");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao < 0 || opcao > 5);

            switch (opcao)
            {
                case 1:
                    ListagemCompleta();
                    break;
                case 2:
                    ListaCarros();
                    break;
                case 3:
                    ListaMotas();
                    break;
                case 4:
                    ListaCamioes();
                    break;
                case 5:
                    ListaCamionetas();
                    break;
                case 0:
                    break;
            }

            Console.Write("\nInsira o Id do veículo: ");
            cod = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    hashCode = veiculo[cod - 1].GetHashCode();  
                    break;
                case 2:
                    hashCode = carros[cod - 1].GetHashCode();    
                    break;
                case 3:
                    hashCode = motas[cod - 1].GetHashCode();     
                    break;
                case 4:
                    hashCode = camioes[cod - 1].GetHashCode();     
                    break;
                case 5:
                    hashCode = camionetas[cod - 1].GetHashCode();     
                    break;
                case 0:
                    break;
            }

            DateTime dataInicio, dataFim;

            Console.WriteLine("\nInsira a Data de Inicio de Reserva:");
            Console.Write("Data (dd/mm/aaaa): ");
            dataInicio = DateTime.Parse(Console.ReadLine());

            int verif = DateTime.Compare(dataInicio, DateTime.Now);

            while (verif < 0)
            {
                Console.WriteLine("Insira uma data válida!");
                Console.Write("Data (dd/mm/aaaa): ");
                dataInicio = DateTime.Parse(Console.ReadLine());
                verif = DateTime.Compare(dataInicio, DateTime.Now);
            }

            Console.WriteLine("\nInsira a Data de Fim de Reserva:");
            Console.Write("Data (dd/mm/aaaa): ");
            dataFim = DateTime.Parse(Console.ReadLine());

            verif = DateTime.Compare(dataFim, DateTime.Now);

            while (verif < 0)
            {
                Console.WriteLine("Insira uma data válida!");
                Console.Write("Data (dd/mm/aaaa): ");
                dataFim = DateTime.Parse(Console.ReadLine());
                verif = DateTime.Compare(dataFim, DateTime.Now);
            }

            int resultado = DateTime.Compare(dataFim, dataInicio);

            while(resultado <= 0)
            {
                Console.WriteLine("\nNão é possível inserir uma data de Fim de Reserva anterior ou igual a de Inicio!");
                Console.Write("Insira uma data válida: ");
                dataFim = DateTime.Parse(Console.ReadLine());
                resultado = DateTime.Compare(dataFim, dataInicio);
            }

            double preco = 0.0;

            for(int i = 0; i < veiculo.Count; i++)
            {
                if(veiculo[i].GetHashCode() == hashCode)
                {
                    preco = veiculo[i]._precoDia;
                }
            }

            TimeSpan totalDias = dataFim.Subtract(dataInicio);

            double precoTotal = totalDias.Days * preco;


            Console.Write($"\nA reserva teria um preço final de: {precoTotal.ToString("N2")} €");   // Vera questão do Simbolo do euro

            Console.Write("\nPressione qualquer tecla para prosseguir...");

            Console.ReadKey();
        }

        
        // Exportar ficheiro para HTML

        private static void ExportarFicheiro()
        {
            
            StreamWriter wr = new StreamWriter(@"veiculos.html");

          

            wr.WriteLine("<!DOCTYPE html>");
            wr.WriteLine("<html>");
            wr.WriteLine("<body> ");
            wr.WriteLine("<style> ");
            wr.WriteLine("body{ text-align: center; background-color: blanchedalmond;}");
            wr.WriteLine("#empresa {font-size: 50px;}");
            wr.WriteLine(" table, th, td {border: 1px solid black;border-collapse: collapse;}");
            wr.WriteLine(" th {background-color: black;color: white;}");
            wr.WriteLine(" th,td {width: 150px; text-align: center;}");
            wr.WriteLine(" table {text-align: center; margin: auto;}");
            wr.WriteLine("p { text-align: center; padding-top: 60px;}");
            wr.WriteLine("</style> ");

            
            wr.WriteLine("<h1 id = " + "empresa" + "> Automobile </h1>");
            wr.WriteLine("<h1> Carros </h1> ");
            wr.WriteLine("<table>");

            Cabecalho(wr, 1);

            for (int i = 0; i < veiculo.Count; i++)
            {
               
                if(typeof(Carro) == veiculo[i].GetType())
                {
                    linhasTabela(wr, 1, i);
                }
                    
                    
               
            }
            wr.WriteLine("</table>");

            wr.WriteLine("<h1> Motas </h1> ");
            wr.WriteLine("<table>");

            Cabecalho(wr, 2);

            for (int i = 0; i < veiculo.Count; i++)
            {

                if (typeof(Mota) == veiculo[i].GetType())
                {
                    linhasTabela(wr, 2, i);
                }


            }
            wr.WriteLine("</table>");

            wr.WriteLine("<h1> Camiões </h1> ");
            wr.WriteLine("<table>");

            Cabecalho(wr, 3);

            for (int i = 0; i < veiculo.Count; i++)
            {

                if (typeof(Camiao) == veiculo[i].GetType())
                {
                    linhasTabela(wr, 3, i);
                }


            }
            wr.WriteLine("</table>");

            wr.WriteLine("<h1> Camionetas </h1> ");
            wr.WriteLine("<table>");

            Cabecalho(wr, 4);

            for (int i = 0; i < veiculo.Count; i++)
            {

                if (typeof(Camioneta) == veiculo[i].GetType())
                {
                    linhasTabela(wr, 4, i);
                }


            }
            wr.WriteLine("</table>");

            wr.WriteLine("<p> &copy;Todos os direitos reservados a Automobile");


            wr.WriteLine("</body>");
            wr.WriteLine("</html>");

            wr.Close();

            Console.WriteLine("\nFicheiro exportado com Sucesso");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();

        }

        private static void Cabecalho(StreamWriter wr, int opcao)
        {
            wr.WriteLine("<tr>");
            wr.WriteLine("<th> Marca/Modelo </th>");
            wr.WriteLine("<th> Cor </th>");
            wr.WriteLine("<th> Combustivel </th>");
            wr.WriteLine("<th> Preço ao Dia </th>");
            wr.WriteLine("<th> Estado </th>");
            wr.WriteLine("<th> Data Disponibilidade </th>");
           
            switch (opcao)
            {
                case 1:
                    wr.WriteLine("<th> Nº Portas </th>");
                    wr.WriteLine("<th> Caixa </th>");
                    break;
                case 2:
                    wr.WriteLine("<th> Cilindrada </th>");
                    break;
                case 3:
                    wr.WriteLine("<th> Peso </th>");
                    break;
                case 4:
                    wr.WriteLine("<th> Nº Eixos </th>");
                    wr.WriteLine("<th> Nº Passageiros </th>");
                    break;
            }

            wr.WriteLine("</tr>");
        }

        private static void linhasTabela(StreamWriter wr, int tipo, int pos)
        {
            wr.WriteLine("<tr>");
            wr.WriteLine("<td>" + veiculo[pos].MarcaMod + "</td> ");
            wr.WriteLine("<td>" + veiculo[pos].Cor + "</td> ");
            wr.WriteLine("<td>" + veiculo[pos].Combustivel + "</td> ");
            wr.WriteLine("<td>" + veiculo[pos]._precoDia + "</td> ");
            wr.WriteLine("<td>" + veiculo[pos].Estado + "</td> ");
            wr.WriteLine("<td>" + veiculo[pos].Data.ToShortDateString() + "</td> ");
            

            switch(tipo)
            {
                case 1:
                    wr.WriteLine("<td>" + ((Carro)veiculo[pos]).Portas + "</td>");
                    wr.WriteLine("<td>" + ((Carro)veiculo[pos]).Caixa + "</td>");
                    break;
                case 2:
                    wr.WriteLine("<td>" + ((Mota)veiculo[pos]).Cilindrada + "</td>");
                    break;
                case 3:
                    wr.WriteLine("<td>" + ((Camiao)veiculo[pos])._peso + "</td>");
                    break;
                case 4:
                    wr.WriteLine("<td>" + ((Camioneta)veiculo[pos]).Eixos + "</td>");
                    wr.WriteLine("<td>" + ((Camioneta)veiculo[pos]).Nrpassageiros + "</td>");
                    break;

            }
            wr.WriteLine("</tr>");
        }


        // Ver todos os veículos

        private static void VerVeiculos()
        {
            Console.Clear();

            if (veiculo.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-----------LISTA DE VEICULOS-----------");
                Console.WriteLine("---------------------------------------");

                for (int i = 0; i < veiculo.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"ID: {i + 1}" + veiculo[i].ToString());
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Não existem ainda veiculos por apresentar");
            }
            Console.ReadKey();
        }



        // Inserção do Stock Base 
        private static void stockBase()
        {
            veiculo = new List<Veiculo>();
            
            veiculo.Add(new Carro("Audi A1", "Carro", "Branco", "Gasoleo", 20, "Disponivel", 5, "Manual"));
            veiculo.Add(new Carro("Audi A3", "Carro", "Preto", "Gasolina", 42.50, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Audi A1", "Carro", "Cinzento", "Gasolina", 25.60, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Audi A1", "Carro", "Vermelho", "Gasóleo", 34.61, "Disponivel", 5, "Automatica"));
            veiculo.Add(new Carro("BMW", "Carro", "Amarelo", "Gasoleo", 51.35, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("BMW", "Carro", "Branco", "Gasolina", 48.96, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Mazda", "Carro", "Branco", "Gasolina", 64.36, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Mazda", "Carro", "Amarelo", "Gasóleo", 25.96, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Mazda", "Carro", "Verde", "Gasolina", 24.65, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Mazda", "Carro", "Laranja", "Gasolina", 36.26, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Porsche", "Carro", "Preto", "Gasolina", 250.30, "Disponivel", 5, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Azul", "Gasolina", 25.63, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Amarelo", "Gasolina", 24.67, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Renault", "Carro", "Verde", "Gasolina", 25.89, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Branco", "Gasóleo", 45.68, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Cinzento", "Gasolina", 24.87, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Preto", "Gasolina", 25.64, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Renault", "Carro", "Branco", "Elétrico", 25, "Disponivel", 5, "Automática"));
            veiculo.Add(new Carro("Toyota", "Carro", "Preto", "Híbrido", 27, "Disponivel", 5, "Automática"));
            veiculo.Add(new Carro("Toyota", "Carro", "Verde", "Gasolina", 24.89, "Disponivel", 3, "Manual"));
            veiculo.Add(new Carro("Toyota", "Carro", "Amarelo", "Gasóleo", 28, "Alugado", 3, "Automatica"));
            veiculo.Add(new Carro("Toyota", "Carro", "Azul", "Gasolina", 32, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Toyota", "Carro", "Preto", "Gasolina", 35.68, "Disponivel", 3, "Automatica"));
            veiculo.Add(new Carro("Seat", "Carro", "Preto", "Gasóleo", 23, "Disponivel", 3, "Manual"));
            veiculo.Add(new Mota("Honda", "Mota", "Amarelo", "Gasolina", 24.68, "Disponivel", 125));
            veiculo.Add(new Mota("Kawasaki", "Mota", "Vermelho", "Gasolina", 35.68, "Disponivel", 300));
            veiculo.Add(new Camioneta("Irizar", "Camioneta", "Preto", "Gasóleo", 560.68, "Disponivel", 3, 150));
            veiculo.Add(new Camiao("MAN", "Camião", "Preto", "Gasóleo", 400.57, "Disponivel", 2000));
            veiculo.Add(new Camiao("Mercedes", "Camião", "Preto", "Gasóleo", 680.67, "Disponivel", 2500));
            veiculo.Add(new Camiao("Scania", "Camião", "Preto", "Gasóleo", 780.96, "Disponivel", 1750));
        }
    }
}
