namespace LebenCode.Logica.Exemplos.Condicionais
{
    public class Condicional1 : Exemplo
    {
        public Condicional1()
        {
            Nome = "Mostra SE soma menor";
        }
        public override void Executar()
        {
            //Entrada de dados
            string resultado = "";
            Console.WriteLine("Digite o valor de A:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            decimal c = decimal.Parse(Console.ReadLine());

            //processamento
            decimal somaAb = a + b;

            if (somaAb < c) 
            {
                resultado = $"A soma entre {a} + {b} é menor que {c}";
            }

            //Saída de Dados
            Console.WriteLine(resultado);
        }
    }
}
