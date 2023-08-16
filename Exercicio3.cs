namespace listaexercicios2
{
    public class Exercicio3
    {
        private string _nome, _dataNasc;

        public Exercicio3() { }

        public Exercicio3(string nome, string dataNasc)
        {
            _nome = nome;
            _dataNasc = dataNasc;
        }

        private int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int anoNasc = int.Parse(_dataNasc.Substring(_dataNasc.LastIndexOf("/") +1));
            return dataAtual.Year - anoNasc;
        }

        public string ExibeConsole()
        {
            return $"Nome: {_nome} --- Idade: {CalcularIdade()}";
        }
    }
}
