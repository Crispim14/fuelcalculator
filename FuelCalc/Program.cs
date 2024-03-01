using System.Linq.Expressions;

namespace FuelCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoEtanol = 0.00;
            double precoGasolina = 0.00;
            string auxPreco = "";
            double consumoEtanol = 0.0;
            double consumoGasolina = 0.0;
            int respostaUser = 0;
            bool editaDadosStatus = false; //quando o usuário selecionar a opção edita dados o valor será definido como true.

            double porcentagemDesempenho = 0.7;
            double resultadoCalc = 0.0;

            inicioSist();
            void editaDados()
            {
                
                Console.WriteLine("Digite o consumo do seu carro na Gasolina (Km/L), separando os decimais por vírgula");
                auxPreco = Console.ReadLine();
                try
                {
                    if (!auxPreco.Contains(",") || auxPreco.Contains("-"))
                    {
                        Console.WriteLine("A Entrada está inválida, verifique se está positivo ou se os decimais estão separados por vírgula.");
                        editaDados();
                    }
                    consumoGasolina = Convert.ToDouble(auxPreco);
                }
                catch (FormatException valInvalido)
                {
                    Console.WriteLine("Digite apenas números", valInvalido.Message);
                    editaDados();

                }

                Console.WriteLine("Digite o consumo do seu carro na Etanol (Km/L), separando os decimais por vírgula");
                auxPreco = Console.ReadLine();
                try
                {
                    if (!auxPreco.Contains(",") || auxPreco.Contains("-"))
                    {
                        Console.WriteLine("A Entrada está inválida, verifique se está positivo ou se os decimais estão separados por vírgula.");
                        editaDados();
                    }
                    consumoEtanol = Convert.ToDouble(auxPreco);
                }
                catch (FormatException valInvalido)
                {
                    Console.WriteLine("Digite apenas números", valInvalido.Message);
                    editaDados();

                }

                if (consumoEtanol < consumoGasolina)
                    porcentagemDesempenho = consumoEtanol / consumoGasolina;
                else
                    porcentagemDesempenho = consumoGasolina / consumoEtanol;

                inicioSist();
            }

            void calculaComb()
            {
                resultadoCalc = porcentagemDesempenho * precoGasolina;

                if (resultadoCalc > precoEtanol)
                {
                    Console.WriteLine("No valor de " + precoEtanol.ToString("C") + ", o combustível mais vantajoso é o Etanol e deixará de ser o mais benéfico se estiver acima de " + resultadoCalc.ToString("C"));
                }
                else
                {
                    Console.WriteLine("No valor de " + precoGasolina.ToString("C") + ", o combustível mais vantajoso é a Gasolina e deixará de ser o mais benéfico se o preço do Etanol estiver abaixo ou igual a R$" + resultadoCalc);
                }
                Console.WriteLine("Pressione Enter para retornar a tela inicial");
                Console.ReadLine();
                inicioSist();
            }

            void fechaSist()
            {
                Environment.Exit(0);
            }

            void inicioSist() 
            { 
                Console.WriteLine("Digite a opção desejada: \n 1.Calcular combustível. \n 2.Editar dados. \n 3.Sair do Programa");
                try
                {
                    respostaUser = Convert.ToInt32(Console.ReadLine());
                    if(respostaUser < 1 ||  respostaUser > 3)
                    {
                        Console.WriteLine("Digite apenas números dentre as opções disponíveis");
                        inicioSist();
                    }
                }
                catch (FormatException valInvalido)
                {
                    Console.WriteLine("Digite apenas números dentre as opções disponíveis", valInvalido.Message);
                    inicioSist();
                }
                switch (respostaUser)
                {
                    case 1:
                        Console.WriteLine("Selecione o Tipo do seu carro: \n 1.Etanol \n 2.Gasolina \n 3. Flex");
                        
                        try
                        {
                            respostaUser = Convert.ToInt32(Console.ReadLine());
                            if (respostaUser < 1 || respostaUser > 3)
                            {
                                Console.WriteLine("Digite apenas números dentre as opções disponíveis");
                                inicioSist();
                            }
                        }
                        catch (FormatException valInvalido)
                        {
                            Console.WriteLine("Digite apenas números dentre as opções disponíveis", valInvalido.Message);
                            inicioSist();
                        }
                        switch (respostaUser)
                        {
                            
                            case 1:
                                Console.WriteLine("O combustivel mais vantajoso para o seu carro é o Etanol");
                                Console.WriteLine("Pressione Enter para retornar a tela inicial");
                                Console.ReadLine();
                                inicioSist();
                                break;
                            case 2:
                                Console.WriteLine("O combustivel mais vantajoso para o seu carro é a Gasolina");
                                Console.WriteLine("Pressione Enter para retornar a tela inicial");
                                Console.ReadLine();
                                inicioSist();
                                break;
                            case 3:
                                Console.WriteLine("Digite o valor da Gasolina separando os decimais com vírgula: ");
                                auxPreco = Console.ReadLine();

                                if (!auxPreco.Contains(",") || auxPreco.Contains("-"))
                                {
                                    Console.WriteLine("A Entrada está inválida, verifique se está positivo ou se os decimais estão separados por vírgula.");
                                    inicioSist();
                                }
                                else
                                {
                                    try
                                    {
                                        precoGasolina = Convert.ToDouble(auxPreco);
                                    }
                                    catch (FormatException valInvalido)
                                    {
                                        Console.WriteLine("A Entrada está inválida, verifique o número digitado.", valInvalido.Message);
                                        inicioSist();
                                    }
                                }
                                Console.WriteLine("Digite o valor do Etanol separando os decimais com vírgula: ");
                                auxPreco = Console.ReadLine();
                                if (!auxPreco.Contains(",") || auxPreco.Contains("-"))
                                {
                                    Console.WriteLine("A Entrada está inválida, verifique se está positivo ou se os decimais estão separados por vírgula.");
                                    inicioSist();
                                }
                                else
                                {
                                    try
                                    {
                                        precoEtanol = Convert.ToDouble(auxPreco);
                                    }
                                    catch (FormatException valInvalido)
                                    {
                                        Console.WriteLine("A Entrada está inválida, verifique o número digitado.", valInvalido.Message);
                                        inicioSist();
                                    }
                                }
                                if(precoEtanol == precoGasolina && consumoEtanol == consumoGasolina)
                                {
                                    Console.WriteLine("Ambos os combústíveis possuem o mesmo consumo e valor, portanto use o de sua preferência.");
                                    Console.WriteLine("Pressione Enter para retornar a tela inicial");
                                    Console.ReadLine();
                                    inicioSist();
                                }
                                calculaComb();                                
                                break;
                        }


                        break;
                    case 2:
                        editaDados();
                        break;

                    case 3:
                        Console.WriteLine("Deseja mesmo encerrar a aplicação? \n 1.Sair \n 2.Não");
                        respostaUser = Convert.ToInt32(Console.ReadLine());
                        try {
                            if (respostaUser == 1)
                                Environment.Exit(0);
                            else
                                inicioSist();
                            }
                        catch (FormatException valInvalido)
                        {
                            Console.WriteLine("Digite apenas números dentre as opções disponíveis", valInvalido.Message);
                            inicioSist();
                        }
                        break;
                }
            }

            

            




        }
    }
}
