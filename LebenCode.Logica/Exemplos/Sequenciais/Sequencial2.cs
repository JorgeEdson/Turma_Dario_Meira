/*
 * Escreva um algoritmo para ler um valor (do teclado) e mostrar (na tela) o seu antecessor. 
 */
namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public  class Sequencial2 : Exemplo
    {
        public Sequencial2()
        {
            Nome = "Mostra antecessor";
        }

        public override void Executar()
        {
            //Entrada de dados
            Console.WriteLine("Digite um valor para ser calculado seu antecessor:");
            int valor = int.Parse(Console.ReadLine());
            
            //Processamento
            int antecessor = valor - 1;

            //Saída de dados
            Console.WriteLine($"O antecessor de {valor} é {antecessor}");
        }
    }
}
