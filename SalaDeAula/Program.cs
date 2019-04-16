using System;

namespace SalaDeAula {
    class Program {
        static void Main (string[] args) {

            Aluno[] alunos = new Aluno[4];
            bool repetir = false;
            do {
                for (int i = 0; i < Length; i++) {

                    System.Console.WriteLine ("Bem-vindo ao SENAIZINHO escolha uma das opções a seguir:");
                    System.Console.WriteLine ("1 - Cadastrar Aluno");
                    System.Console.WriteLine ("2 - Cadastrar Sala");
                    System.Console.WriteLine ("3 - Alocar Aluno");
                    System.Console.WriteLine ("4 - Remover Aluno");
                    System.Console.WriteLine ("5 - Verificar Salas");
                    System.Console.WriteLine ("6 - Verificar Alunos");
                    System.Console.WriteLine ("0 - Sair");

                    int comando = int.Parse (Console.ReadLine ());

                    switch (comando) {
                        case 1:
                            if (contadorAluno < 4) {

                                Aluno aluno1 = new Aluno ();
                                System.Console.Write ("Digite seu nome completo: ");
                                aluno1.Nome = Console.ReadLine ();

                                System.Console.Write ("Digite a sua Data de Nacimento: ");
                                aluno1.DataNascimento = DateTime.Parse (Console.ReadLine ());

                                System.Console.Write ("Digite seu Curso: ");
                                aluno1.Curso = Console.ReadLine ();

                                System.Console.Write ("Digite o Número da Sala: ");
                                aluno1.NumeroSala = int.Parse (Console.ReadLine ());

                                alunos[contadorAluno] = a;
                                contadorAluno++;
                            }
                            break;
                    }
                }

            } while (repetir == false);
        }
    }
}