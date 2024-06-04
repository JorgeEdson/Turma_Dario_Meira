//Escreva um algoritmo para ler o salário atual de um funcionário e o percentual de reajuste.
//Calcular e escrever o valor do novo salário.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial6 : Exemplo
    {
        public override void Executar()
        {
            decimal salarioAtual = 1320.00m;
            decimal porcentagemReajuste = 0.10m;

            decimal ValorReajuste = salarioAtual * porcentagemReajuste;
            decimal salarioComReajuste = salarioAtual + ValorReajuste;

            Console.WriteLine($"Salário Atual: {salarioAtual:c}"); //O ":c" dentro da variável serve para formatar e exibir o valor de forma monetária.
            Console.WriteLine($"Reajuste a ser aplicado de: {porcentagemReajuste:P0}"); //O "P0" usado para formatar em porcentagem sem casas decimais. O P(percente) irá formatar ao multiplicar por 100, adicionando o simbolo de porcentagem % no final. ||  O "0" indica que deve ser formatado sem casas decimais
            Console.WriteLine($"O novo salário com reajuste ficará: {salarioComReajuste:c}");
        }
    }
}
