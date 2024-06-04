/*
  Escreva um algoritmo que calcule a área de um quadrado (lado*lado), em seguida mostre o
dobro desta área para o usuário.
*/

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial7 : Exemplo
    {

        public Sequencial7()
        {
            Nome = "Area Quadrado";
        }

        public override void Executar()
    {
            //Entrada de Dados
            Console.WriteLine("Digite o comprimento do lado do quadrado: ");
            decimal lado = decimal.Parse(Console.ReadLine());

            // Processamento de Dados
            decimal areaQuadrado = lado * 2;
            decimal dobroArea = areaQuadrado * 2;

            // Saida de Dados
            Console.WriteLine($"A área do quadrado é: {areaQuadrado}");
            Console.WriteLine($"O dobro da área do quadrado é: {dobroArea}");



        }
    }
}
