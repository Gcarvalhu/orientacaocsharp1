using System;
using ExCorrecaoSala.classes;
namespace ExCorrecaoSala {
    class Program {
        static void Main (string[] args) {

            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];
            bool sair = false;
            int contadorAluno = 0, contadorSala = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("||        *** SENAIzinho ***     ||");
                Console.ResetColor ();
                System.Console.WriteLine ("||         Seja bem-vindo(a)     ||");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("Escolha uma opção");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    #region Cadastrar_aluno
                    case 1:
                        //cadastrar aluno
                        if (contadorAluno < 4) {
                            Aluno a = new Aluno ();
                            Console.WriteLine ("Digite o nome do aluno:");
                            a.Nome = Console.ReadLine ();
                            Console.WriteLine ("Digite a Data de Nascimento:");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite o nome do Curso:");
                            a.Curso = Console.ReadLine ();
                            Console.WriteLine ("Digite o numero da sala");
                            a.NumeroSala = int.Parse (Console.ReadLine ());
                            alunos[contadorAluno] = a;
                            contadorAluno++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine ("Cadastro efetuado com sucesso");
                            Console.ResetColor ();
                        } //fim if

                        break;

                        #endregion
                        #region Cadastrar_SALA
                    case 2:
                        //cadastrar sala

                        if (contadorSala < 1) {
                            Sala s = new Sala ();
                            Console.WriteLine ("Digite o número da sala:");
                            s.NumeroSala = int.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite a capacidade total:");
                            s.CapacidadeTotal = int.Parse (Console.ReadLine ());
                            s.CapacidadeAtual = s.CapacidadeTotal;
                            s.Alunos = new string[s.CapacidadeTotal];
                            salas[contadorSala] = s;
                            contadorSala++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            MostrarMensagem ("Cadastro efetuado com sucesso", TipoMensagemEnum.SUCESSO);
                            Console.ResetColor ();

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                        } //fim if
                        break;
                        #endregion
                        #region Alocar_ALUNO
                    case 3:
                        if (contadorAluno == 0) {

                            MostrarMensagem ("Não há um aluno cadastrado", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        } //fim if
                        if (contadorSala == 0) {

                            MostrarMensagem ("Não há sala cadastrada", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;

                        }
                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();
                        Aluno alunoRecuperadoAloc = ProcurarAlunoPornome(nomeAluno, alunos);
                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAluno.Equals (item.Nome)) {
                                alunoRecuperadoAloc = item;
                                break;
                            }
                        }
                        if (alunoRecuperadoAloc == null) {

                            MostrarMensagem ("Não há sala cadastrada", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse (Console.ReadLine ());
                        Sala salaRecuperadaAloc = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaAloc.Equals (item.NumeroSala)) {
                                salaRecuperadaAloc = item;
                                break;
                            }
                        }
                        if (salaRecuperadaAloc == null) {

                            MostrarMensagem ($"Não há sala cadastrada com o numero {numeroSalaAloc}", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        }

                        MostrarMensagem (salaRecuperadaAloc.AlocarAluno (alunoRecuperadoAloc.Nome), TipoMensagemEnum.SUCESSO);

                        break;
                        #endregion
                        #region Remover_ALUNO
                    case 4:
                        if (contadorAluno == 0) {

                            MostrarMensagem ("Não há um aluno cadastrado", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        } //fim if
                        if (contadorSala == 0) {

                            MostrarMensagem ("Não há sala cadastrada", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;

                        }
                        System.Console.WriteLine ("Digite o nome do aluno");
                        string numeroSalaRem = Console.ReadLine ();
                        Sala salaRecuperadaRem = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRem.Equals (item.Sala)) {
                                salaRecuperadaRem = item;
                                break;
                            }
                        }
                        if (salaRecuperadaRem == null) {

                            MostrarMensagem ("Não há sala cadastrada", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaRem = int.Parse (Console.ReadLine ());
                        Sala salaRecuperadaRem = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRem.Equals (item.NumeroSala)) {
                                salaRecuperadaAloc = item;
                                break;
                            }
                        }
                        if (salaRecuperadaAloc == null) {

                            MostrarMensagem ($"Não há sala cadastrada com o numero {numeroSalaAloc}", TipoMensagemEnum.ALERTA);

                            MostrarMensagem ("Aperte a tecla ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
                            Console.ReadLine ();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine (salaRecuperadaAloc.AlocarAluno (salaRecuperadaRem.Sala));
                        break;
                        #endregion
                        #region Listar_SALAS
                    case 5:
                        //Listar salas
                        foreach (var item in salas) {
                            if (item != null) {

                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Número da sala {item.NumeroSala}");
                                Console.WriteLine ($"Vagas Disponíveis {item.CapacidadeAtual}");
                                Console.WriteLine ("----------------");
                            } //fim if

                        } //fim foreach
                        MostrarMensagem ("Aperte ENTER para continuar", TipoMensagemEnum.DESTAQUE);
                        Console.ReadLine ();
                        break;
                        #endregion
                        #region Listar_ALUNOS

                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                Console.WriteLine ($"Curso: {item.Curso}");
                                Console.WriteLine ("----------------");
                            }

                        }
                        Console.WriteLine ("Aperte entre para continuar");
                        Console.ReadLine ();
                        break;
                    default:

                        break;
                        #endregion
                }

            } while (!sair);
        }

        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            MostrarMensagem ("Aperte ENTER para voltar ao menu", TipoMensagemEnum.DESTAQUE);
            Console.ReadLine ();
        }

        static bool ValidarAlocarOuRemover (int alunosCadastrados, int salasCadastradas) {
            if (alunosCadastrados == 0) {
                MostrarMensagem ("Nenhum aluno cadastrado!", TipoMensagemEnum.ALERTA);
                return false;
            } else if (salasCadastradas == 0) {
                MostrarMensagem ("Nenhuma sala cadastrada!", TipoMensagemEnum.ALERTA);
                return false;
            }
            return true;
        }
        
        static void ProcurarAlunoPornome (string nomeAluno, Aluno[] alunos) {
            foreach (Aluno item in alunos) {
                if (item != null && nomeAluno.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }
    }
}