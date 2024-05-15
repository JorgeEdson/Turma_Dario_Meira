using LebenCode.Logica.Exemplos.Sequenciais;

namespace LebenCode.Logica.Menu
{
    public class Menu
    {
        //Variaveis
        bool ContinuaPrograma = true;

        //Exemplos sequencias
        private Sequencial1 sequencial1 = new Sequencial1();

        //Exemplos condicionais

        //Exemplos repetição


        public void ExibirMenu()
        {
            if (ContinuaPrograma)
            {
                //Apresentaçao do menu
                Console.WriteLine("Bem vindo aos exemplos de LebenCodeLogic");
                Console.WriteLine("Insira o número correspondente ao tipo de exemplos:\n ");
                Console.Write("1 - Sequenciais\t");
                Console.Write("2 - Condicionais\t");
                Console.Write("3 - Repetição\t");
                Console.WriteLine("\n\n");

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.Write("Digite o número correspondente ao tipo de exemplo:");
                }

                ExibirSubMenu(opcao);
            }
            else 
            { 
                Console.WriteLine("Obrigado por usar o LebenCode.Logic!");
            }
        }

        public void ExibirSubMenu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    ExibirExemplosDeSequenciais();
                    break;
                case 2:
                    ExibirExemplosDeCondicionais();
                    break;
                case 3:
                    ExibirExemplosDeRepeticao();
                    break;               
            }
        }

        private void ExibirExemplosDeSequenciais() 
        {
            Console.Clear();
            Console.WriteLine("Digite o número correspondente do exemplo Sequencial:\n ");
            Console.Write($"1 - {sequencial1.Nome}\t");
            

            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 10)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Digite o número correspondente ao exemplo:");
            }

            switch (opcao)
            {
                case 1:
                    sequencial1.Executar();
                    PerguntaSeQuerContinuar();
                    break;
            }
        }

        private void ExibirExemplosDeCondicionais()
        {
            Console.Clear();
        }

        private void ExibirExemplosDeRepeticao()
        {
            Console.Clear();
        }

        private void PerguntaSeQuerContinuar() 
        {
            Console.WriteLine("Você quer continuar o LebenCode.Logic? (S/N)\n");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "N")
            {
                ContinuaPrograma = false;
                Console.Clear();
                ExibirMenu();
            }
            else
            {
                Console.Clear();
                ExibirMenu();
            }
        }
    }
}