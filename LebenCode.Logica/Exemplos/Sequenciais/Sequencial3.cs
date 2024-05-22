/*
 Escreva um algoritmo que converta metros para centímetros. Lembrando que 1m = 100cm. 
 */

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial3 : Exemplo
    {
        public Sequencial3()
        {
            Nome = "Converte Metros";
        }

        public override void Executar()
        {
            //Entrada de dados
            Console.WriteLine("Digite o valor em metros:");
            decimal metros = decimal.Parse(Console.ReadLine());

            //Processamento
            decimal centimetros = metros * 100;

            //Saída de Dados
            Console.WriteLine($"{metros} metros é igual a {centimetros} centímetros");
        }
    }
}
