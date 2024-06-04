/*
 Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo
por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele
vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
vendido. Calcule e escreva o salário final do vendedor.
 
 */

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial8 : Exemplo
    {

        public Sequencial8()
        {
            Nome = "Salario do Vendedor";
        }

        public override void Executar()
        {
            // Entrada de dados
            Console.WriteLine("Digite quantos carros foram vendidos: ");
            int numCarros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor total de vendas: ");
            double valorTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salario fixo do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido por carro vendido: ");
            double comissaoPorCarro = double.Parse(Console.ReadLine());

            // Processamento

            double salarioFinal = salarioFixo + (numCarros * comissaoPorCarro) + (valorTotal * 0.05);

            //Saida de dados
            Console.WriteLine($"O salario final do vendedor é: {salarioFinal} ");
        }
    }
}
