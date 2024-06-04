/* 
 Desenvolva um algoritmo que receba 2 números e informe se eles são iguais ou
informe quem é o menor e quem é o maior
*/

namespace LebenCode.Logica.Exemplos.Condicionais
{
    public class Condicional3 : Exemplo
    {

        public Condicional3()
        {
            Nome = "Compara Numeros";
        }

        public override void Executar()
        {

            
            Console.WriteLine("Digite o valor de A: ");
            decimal A = decimal.Parse (Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            decimal B = decimal.Parse (Console.ReadLine());


            if (A == B)
            {
                Console.WriteLine("Os numeros são iguais.");
            }
            else if (A > B)
            {
                Console.WriteLine($"O valor {A} é maior");
                Console.WriteLine($"E o valor {B} é menor");
            }
            else if (A < B)
            {
                Console.WriteLine($"O valor {B} é maior");
                Console.WriteLine($"E o valor {A} é menor");

            }
            else;





        }
    }
}
