/*
    Calcule a média aritmética das 3 notas de um aluno e mostre, além do valor da média,
    uma mensagem de "Aprovado", caso a média seja igual ou superior a 6, ou a
    mensagem "reprovado", caso contrário.
 */
namespace LebenCode.Logica.Exemplos.Condicionais
{
    public class Condicional2 : Exemplo
    {
        public Condicional2()
        {
            Nome = "Calcular média";
        }

        public override void Executar()
        {

            int nota1 = 7;
            int nota2 = 8;
            int nota3 = 10;

            int somaDaMedia = nota1 + nota2 + nota3;

            int calculoMedia = somaDaMedia / 3;

            if (calculoMedia > 6)
            {
                Console.WriteLine($"O aluno foi aprovado com a média de: {calculoMedia}");
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado com a média de: {calculoMedia}");
            }


        }
    }
}
