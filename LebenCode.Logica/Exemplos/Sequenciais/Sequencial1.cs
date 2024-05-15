/*
    1) Escreva um algoritmo que armazene o valor 10 em uma variável A 
    e o valor 20 em uma variável B. A seguir 
    (utilizando apenas atribuições entre variáveis) 
    troque os seus conteúdos fazendo com que o valor que está em A passe para B 
    e vice-versa. Ao final, escrever os valores que ficaram armazenados nas variáveis. 
 */

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial1 : Exemplo
    {
        public Sequencial1()
        {
            Nome = "Troca entre A e B";
        }

        public override void Executar()
        {
            //Entrada de dados
            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            //Processamento
            int aux = a;
            a = b;
            b = aux;

            //Saída de Dados
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
        }
    }
}
