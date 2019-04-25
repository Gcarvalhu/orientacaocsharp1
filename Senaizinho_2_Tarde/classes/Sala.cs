namespace Senaizinho_2_Tarde {
    public class Sala {
        public int NumeroSala { get; private set; }
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public Aluno[] Alunos { get; set; }

        public Sala (int numeroSala, int capacidadeTotal) {
            this.NumeroSala = numeroSala;
            this.CapacidadeTotal = capacidadeTotal;
        }

        public string AlocarAluno (Aluno aluno, string mensagem) {
            if (CapacidadeAtual > 0) {
                CapacidadeAtual--;
                for (int i = 0; i < alunos.Length; i++) {
                    if (alunos[i] == null ||"".Equals (alunos[i])) {
                        alunos[i] = Aluno;
                        mensagem = $"Aluno {Aluno} alocado com sucesso!";
                        return true;
                    }
                }
            }
            mensagem = $"Capacidade da sala {NumeroSala} excedida!";
            return false;
        }

        public string RemoverAluno (string nomeAluno, out string mensagem) {
            if (this.CapacidadeAtual > 0) {

                for (int i = 0; i < alunos.Length; i++) {
                    if (alunos[i] != null && nomeAluno.Equals (alunos[i])) {
                        alunos[i] = null;
                        CapacidadeAtual++;
                        return $"Aluno {nomeAluno} removido com sucesso!";
                    }
                }
            }
            return $"{nomeAluno} não foi encontrado";
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

    }
}