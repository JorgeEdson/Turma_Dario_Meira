namespace LebenCode.Logica.Exemplos.Sequenciais
{
    internal class Sequencial4 : Exemplo
    {
        public Sequencial4()
        {
            Nome = "Area Retangulo";
        }

        public override void Executar()
        {
            //Entrada de dados
            Console.WriteLine("Digite a base do retângulo:");
            decimal baseRetangulo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo:");
            decimal alturaRetangulo = decimal.Parse(Console.ReadLine());

            //processamento
            decimal areaRetangulo = baseRetangulo * alturaRetangulo;

            //Saída de Dados
            Console.WriteLine($"A área do retângulo é {areaRetangulo}");
        }
    }
}
