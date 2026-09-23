using System.ComponentModel.Design;

namespace ourGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string idCarro = "";
            string marcaCarro = "";
            string modeloCarro = "";
            string corCarro = "";

            int garageMax = 4;

            string[,] nossaGaragem = new string[garageMax, 4];
            // linhas , colunas - Altura e largura
            int i;

            for (i = 0; i < garageMax; i++)
            {
                switch (i)
                {
                    case 0:
                        idCarro = "1";
                        marcaCarro = "Volkswagen";
                        modeloCarro = "Gol";
                        corCarro = "Preto";
                        break;
                    case 1:
                        idCarro = "2";
                        marcaCarro = "Honda";
                        modeloCarro = "Civic";
                        corCarro = "Prata";
                        break;
                    default:
                        idCarro = "";
                        marcaCarro = "";
                        modeloCarro = "";
                        corCarro = "";
                        break;
                }

                nossaGaragem[i, 0] = "Id: " + idCarro;
                nossaGaragem[i, 1] = "Marca: " + marcaCarro;
                nossaGaragem[i, 2] = "Modelo: " + modeloCarro;
                nossaGaragem[i, 3] = "Cor: " + corCarro;
            }

            string? opcaoDigitada;
            opcaoDigitada = "";



            do
            {
                Console.WriteLine("Bem vindo a Garagem Lot !");
                Console.WriteLine("1 para ver os carros estacionados");
                Console.WriteLine("2 para ver a capacidade total da garagem");
                Console.WriteLine("3 para Registrar um novo carro");
                Console.WriteLine("Digite a sua opção ou 'sair' para fechar");
                opcaoDigitada = Console.ReadLine();

                switch (opcaoDigitada?.ToLower())
                {


                    case "1":
                        for (i = 0; i < garageMax; i++)
                        {
                            if (nossaGaragem[i, 0] != "Id: ")
                            {
                                for (int j = 0; j < 4; j++)
                                    Console.WriteLine($"Verificando...{nossaGaragem[i, j]} ");
                                // o for interno vai percorrer até chegar em 3, enquanto o for externo ( do i ) vai executar depois só, logo ele vai
                                // dar as linhas 1 , 0 ... 1, 1 etc.
                            }
                            else { }
                        }
                        break;
                    case "2":

                        Console.WriteLine(garageMax);
                        break;
                    case "3":

                        int contadorDeCarro = 0;
                        for (i = 0; i < garageMax; i++)
                        {
                            if (nossaGaragem[i, 0] != "Id: ")
                            {
                                contadorDeCarro++;
                            }
                        }
                        if (contadorDeCarro < garageMax)
                        {

                            idCarro = $"{contadorDeCarro + 1}";
                            nossaGaragem[contadorDeCarro, 0] = idCarro;
                            Console.WriteLine("Digite o modelo do carro: ");
                            modeloCarro = Console.ReadLine();
                            nossaGaragem[contadorDeCarro, 1] = modeloCarro;
                            Console.WriteLine("Digite a marca do carro: ");
                            marcaCarro = Console.ReadLine();
                            nossaGaragem[contadorDeCarro, 2] = marcaCarro;
                            Console.WriteLine("Digite a cor do carro: ");
                            corCarro = Console.ReadLine();
                            nossaGaragem[contadorDeCarro, 3] = corCarro;

                        }
                        else
                        {
                            Console.WriteLine("Garagem cheia !");
                            break;
                        }

                        break;
                    case "sair":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada, favor tentar novamente");
                        break;

                }
            } while (opcaoDigitada != "sair");
        }
    }
}
