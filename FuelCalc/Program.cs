using System.Linq.Expressions;

namespace FuelCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoEtanol = 0.00;
            double precoGasolina = 0.00;
            double consumoEtanol = 0.0;
            double consumoGasolina = 0.0;
            int respostaUser = 0;
            bool editaDadosStatus = false; //quando o usuário selecionar a opção edita dados o valor será definido como true.

            double porcentagemDesempenho = 0.7;
            double resultadoCalc = 0.0;

            Console.WriteLine("Digite a opção desejada: \n 1.Calcular combustível. \n 2.Editar dados. \n 3.Sair do Programa");
            respostaUser = Convert.ToInt32(Console.ReadLine());
            switch (respostaUser)
            {
                case 1:
                    Console.WriteLine("Selecione o Tipo do seu carro: \n 1.Etanol \n 2.Gasolina \n 3. Flex");
                    respostaUser = Convert.ToInt32(Console.ReadLine());
                    switch (respostaUser)
                    {
                        case 1:
                            Console.WriteLine("O combustivel mais vantajoso para o seu carro é o Etanol");
                            break;
                        case 2:
                            Console.WriteLine("O combustivel mais vantajoso para o seu carro é a Gasolina");
                            break;
                        case 3:
                            Console.WriteLine("Digite o valor da Gasolina: ");
                            precoGasolina = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Digite o valor do Etanol: ");
                            precoEtanol = Convert.ToDouble(Console.ReadLine());

                            


                            break;
                    }

                    

                    

                    break;
                case 2:



                    break;
                case 3:



                    break;
            }

            

            




        }
    }
}
