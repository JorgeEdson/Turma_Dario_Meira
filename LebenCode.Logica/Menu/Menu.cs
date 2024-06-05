using LebenCode.Logica.Exemplos.Condicionais;
using LebenCode.Logica.Exemplos.Sequenciais;

namespace LebenCode.Logica.Menu
{
    public class Menu
    {
        //Variaveis
        bool ContinuaPrograma = true;

        //Exemplos sequencias
        private Sequencial1 sequencial1 = new Sequencial1();
        private Sequencial2 sequencial2 = new Sequencial2();
        private Sequencial3 sequencial3 = new Sequencial3();
        private Sequencial4 sequencial4 = new Sequencial4();
        private Sequencial7 sequencial7 = new Sequencial7();
        private Sequencial8 sequencial8 = new Sequencial8();


        //Exemplos condicionais
        private Condicional1 condicional1 = new Condicional1();
        private Condicional3 condicional3 = new Condicional3();

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
            Console.WriteLine($"1 - {sequencial1.Nome}\t | 2 - {sequencial2.Nome }\t | 3 - {sequencial3.Nome}");
            Console.WriteLine($"4 - {sequencial4.Nome}\t | 7 - {sequencial7.Nome} \t | 8 - {sequencial8.Nome}");
            



            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 10)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Digite o número correspondente ao exemplo:");
            }

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    sequencial1.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 2:
                    Console.Clear();
                    sequencial2.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 3:
                    Console.Clear();
                    sequencial3.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 4:
                    Console.Clear();
                    sequencial4.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 7:
                    Console.Clear();
                    sequencial7.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 8:
                    Console.Clear();
                    sequencial8.Executar();
                    PerguntaSeQuerContinuar();
                    break;
            }
        }

        private void ExibirExemplosDeCondicionais()
        {
            Console.Clear();
            Console.WriteLine("Digite o número correspondente do exemplo Condicional:\n ");
            Console.WriteLine($"1 - {condicional1.Nome}\t | 3 - {condicional3.Nome}\t |");

            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 10)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Digite o número correspondente ao exemplo:");
            }

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    condicional1.Executar();
                    PerguntaSeQuerContinuar();
                    break;
                case 3:
                    Console.Clear();
                    condicional3.Executar();
                    PerguntaSeQuerContinuar();
                    break;
            }

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