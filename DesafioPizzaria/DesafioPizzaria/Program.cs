using System;

namespace DesafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("C.A Pizzas");
            int resposta = 0;
            int respostaLogado = 0;
            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Cadastrar Novo Usuário");
                Console.WriteLine ("2 - Efetuar Login");
                Console.WriteLine ("3 - Listar Usuários");
                Console.WriteLine ("9 - Sair");
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                        //Cadastrar usuário
                        Usuario.Inserir ();
                        break;

                    case 2:
                        //Login
                        Usuario.EfetuarLogin ();
                        do {
                            Console.WriteLine ("Outro Menu");
                            Console.WriteLine ("Selecione uma opção:");
                            System.Console.WriteLine (" 1 - cadastre seu produto(apenas funcionarios)");
                            System.Console.WriteLine (" 2 - Lista de produtos");
                            System.Console.WriteLine (" 3 - Buscar por ID");
                            Console.ReadLine ();
                        } while (true);

                        switch (respostaLogado) {
                            case 1:
                                Produto.Cadastrar ();
                                break;
                            
                            case 2:
                                Produto.ListarProdutos();
                                break;

                            case 3:
                                Produto.BuscarPorId();
                                break;
                        }
                        break;
                    case 3:
                        //Listar usuário
                        Usuario.ListarUsuario ();

                        break;

                    case 9:
                        //sair
                        break;
                    default:
                        Console.WriteLine ("Valor Inválido!");
                        break;
                }

            } while (resposta != 9);
        }
    }
}