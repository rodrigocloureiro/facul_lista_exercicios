namespace listaexercicios2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("( 1 ) - Exercício 1");
                    Console.WriteLine("( 2 ) - Exercício 2");
                    Console.WriteLine("( 3 ) - Exercício 3");
                    Console.WriteLine("( 4 ) - Exercício 4");
                    Console.WriteLine("( 0 ) - Sair");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 0) break;

                    switch (opcao)
                    {
                        case 1:
                            Exercicio1 exercicio1 = new Exercicio1();
                            Console.Write("Informe a hora: ");
                            int hora = int.Parse(Console.ReadLine());
                            if (hora < 0 || hora > 24) throw new Exception("Hora inválida!");
                            Console.WriteLine(exercicio1.Saudacao(hora));
                            break;
                        case 2:
                            Exercicio2 exercicio2 = new Exercicio2();
                            Console.Write("Informe o nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe a idade: ");
                            int.TryParse(Console.ReadLine(), out int idade);
                            exercicio2.Nome = nome;
                            exercicio2.Idade = idade;
                            Console.WriteLine(exercicio2.ExibeConsole());
                            break;
                        case 3:
                            Exercicio3 exercicio3;
                            Console.Write("Informe o nome: ");
                            string nomeEx3 = Console.ReadLine();
                            Console.Write("Informe a data de nascimento (DD/MM/AAAA): ");
                            string dataNasc = Console.ReadLine();
                            exercicio3 = new Exercicio3(nomeEx3, dataNasc);
                            Console.WriteLine(exercicio3.ExibeConsole());
                            break;
                        case 4:
                            Console.WriteLine("Exercício 4");
                            Leao leao = new Leao();
                            Console.WriteLine($"O leão está {leao.Respirar()}");
                            Console.WriteLine($"O leão está {leao.Comer()}");
                            Console.WriteLine($"O leão está irritado.. {leao.Rugir()}");
                            Gato gato = new Gato();
                            Console.WriteLine($"O gato está {gato.Respirar()}");
                            Console.WriteLine($"O gato está {gato.Comer()}");
                            Console.WriteLine($"O gato está triste.. {gato.Ronronar()}");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.ReadKey();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
