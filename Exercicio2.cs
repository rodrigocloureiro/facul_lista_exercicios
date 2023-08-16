namespace listaexercicios2
{
    public class Exercicio2
    {
        private string _nome;
        private int _idade;

        public Exercicio2() { }

        public Exercicio2(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade;  }
            set { _idade = value; }
        }

        public string ExibeConsole()
        {
            return $"Nome: {_nome} --- Idade: {_idade}";
        }
    }
}
