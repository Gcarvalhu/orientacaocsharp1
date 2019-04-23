using System;
namespace DesafioPizzaria {
    public class Produto {
        static Produto[] ArrayTodosProdutos = new Produto[1000];
        static int contProduto = 0;
        public string Categoria { get; set; }
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public DateTime DataCriacao { get; set; }
        public static void Cadastrar () {
            string nome;
            string descricao;
            float preco;
            string Categoria;
            DateTime DataCriacao;

            System.Console.WriteLine ("Escolha sua opção:\nPizza\nBebida");
            if (Console.ReadLine ().Equals ("Pizza")) {
                Categoria = Console.ReadLine ();
            } else if (Console.ReadLine ().Equals ("Bebida")) {
                Categoria = Console.ReadLine ();
            }

            System.Console.WriteLine ("Qual o nome de seu produto?");
            nome = Console.ReadLine ();

            System.Console.WriteLine ("Insira uma descrição:");
            descricao = Console.ReadLine ();

            System.Console.WriteLine ("Coloque agora o preço:");
            preco = float.Parse (Console.ReadLine ());

            Produto produtos = new Produto ();
            produtos.id = contProduto + 1;
            produtos.Nome = nome;
            produtos.Descricao = descricao;
            produtos.Preco = preco;
            produtos.DataCriacao = DateTime.Now;

            ArrayTodosProdutos[contProduto] = produtos;

            contProduto++;

        }
        public static void ListarProdutos () {
            foreach (var item in ArrayTodosProdutos) {
                if (item != null) {
                    Console.WriteLine ($"ID: {item.id} nome: {item.Nome}");
                }
            }
        }
        public static void BuscarPorId () { 
            System.Console.WriteLine("Digite o produto desejado:");
            int idDesejado = int.Parse(Console.ReadLine());
            foreach (var item in  ArrayTodosProdutos)
            {
                if(item == null){
                    break;
                }
                if ()
                {
                    
                }
            }
        }
    }
}