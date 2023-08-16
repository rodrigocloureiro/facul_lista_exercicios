namespace listaexercicios2
{
    public class Exercicio1
    {
        public Exercicio1() { }

        public string Saudacao(int horas)
        {
            if (horas >= 5 && horas < 12) return "Bom dia!";
            else if (horas >= 12 && horas < 18) return "Boa tarde!";
            else return "Boa noite!";
        }
    }
}
