using System;
namespace Pizzaria {
    public class Usuario {
        public static int quantUsuarios = 0;

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }
        public DateTime dataCriacao { get; set; }

        public static void Inserir () {

            string nome;
            string email;
            string senha;
            DateTime dataCriacao = DateTime.Now;
            System.Console.Write ("Digite seu nome Completo: ");
            nome = Console.ReadLine ();
            do {

                System.Console.Write ("Digite seu E-mail: ");
                email = Console.ReadLine ();
                if (!email.Contains ("@") || !email.Contains (".")) {
                    System.Console.WriteLine ("E-mail não encontrado");
                }

            } while (!email.Contains ("@") || !email.Contains ("."));
            do {
                System.Console.Write ("Digite sua senha: ");
                senha = Console.ReadLine ();
                if (senha.Length < 6) {
                    System.Console.WriteLine ("Senha muito curta!");
                }
            } while (senha.Length < 6);
            System.Console.WriteLine ($"Usuario cadastrado com sucesso as: {dataCriacao} ");
            quantUsuarios++;
        }
    }
}