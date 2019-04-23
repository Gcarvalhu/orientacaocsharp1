using System;
using System.Threading;
namespace Pizzaria {
    class Program {
        static void Main (string[] args) {
            bool sair = false;
            Usuario usuarios = new Usuario ();
            do {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine ("Bem-vindo a pizzaria do jorgin");
                Console.ResetColor ();
                System.Console.WriteLine ("Escolha uma opção:");
                System.Console.WriteLine ("1-Cadastre-se");
                System.Console.WriteLine ("2-Efetuar login");
                System.Console.WriteLine ("3-Lista de usuarios");
                System.Console.WriteLine ("9-Sair");
                System.Console.WriteLine ("-------------------------------------");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1: //cadastrar
                        for (int i = 0; i < .Length; i++) {
                            usuarios[i] = Usuario.Inserir ();
                        }
                        System.Console.WriteLine(usuarios[i]);
                        break;

                    case 2: //login

                        break;

                    case 3: //lista de usuarios

                        break;

                    case 9: //sair
                        System.Console.WriteLine ("Saindo...");
                        Thread.Sleep (2000);
                        sair = true;
                        break;

                    default:
                        System.Console.WriteLine ("Código invalido,voltando ao menu...");
                        Thread.Sleep (2000);
                        Console.Clear ();
                        sair = false;
                        break;
                }

            } while (!sair);
        }
    }
}