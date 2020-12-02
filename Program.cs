using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            Console.WriteLine("Digite a cor do celular");
            celular1.color = Console.ReadLine();
            Console.WriteLine("Digite o modelo do celular");
            celular1.model = Console.ReadLine();
            Console.WriteLine("Digite o tamanho do celular");
            celular1.size = Console.ReadLine();
            Console.WriteLine("O celular esta ligado?");
            string ligado = Console.ReadLine().ToUpper();
            if(ligado == "S"){
                celular1.ligado = true;
            } else if (ligado == "N"){
                celular1.ligado = false;
                Console.WriteLine("O celular so pode ser usado se estiver ligado. Ligar?");
                ligado = Console.ReadLine().ToUpper();
            }
            if(ligado == "S") {
                while (celular1.ligado == true) {
                    Console.WriteLine("Celular ligado. escolha o que quer fazer");
                    Console.WriteLine("Digite 1 para ligar para o numero salvo ou desligar a ligação");
                    Console.WriteLine("Digite 2 para mandar uma mensagem para o numero salvo");
                    Console.WriteLine("Digite 0 para sair");

                    switch(Console.ReadLine()) {
                        case "0":
                        Console.WriteLine("Saindo");
                        celular1.ligado = false;
                            break;
                        case "1":
                            celular1.Ligacao();
                            break;
                        case "2":
                            celular1.MandarMensagem();
                            break;
                        default:
                        Console.WriteLine("Caractere inválido");
                            break;
                    }
                }
            } else if (ligado == "N") {
                Console.WriteLine("Saindo");
            }
        }
    }
}
