namespace LebenCode.Logica.Menu
{
    public class Menu
    {
        public void ExibirMenu()
        {
            //Apresentaçao do menu
            Console.WriteLine("Bem vindo aos exemplos de LebenCodeLogic");
            Console.WriteLine("Insira o número correspondente ao tipo de exemplos:\n ");
            Console.Write("1 - Sequenciais\t");
            Console.Write("2 - Condicionais\t");
            Console.Write("3 - Repetição\t");
            Console.WriteLine("\n\n");

            //Entrada de dados e criaçao da variavel do tipo int
            int opcao = int.Parse(Console.ReadLine());

            //concatençao de string
            Console.WriteLine("A opçao escolhida foi: " + opcao);

        }
    }
}