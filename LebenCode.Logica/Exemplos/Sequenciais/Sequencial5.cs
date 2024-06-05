using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.Logica.Exemplos.Sequenciais
{
    public class Sequencial5 : Exemplo
    {
        public override void Executar()
        {
            DateTime idadePessoa = new DateTime(1999, 03, 25);
            DateTime dataAtual = DateTime.Now;

            TimeSpan diferenca = dataAtual.Subtract(idadePessoa);
            int idadeEmDias = diferenca.Days;

            Console.WriteLine("A idade da pessoa em dias é: " + idadeEmDias);
            Console.WriteLine("A data de nascimento desta pessoa é: " + idadePessoa);



            
        }
    }
}
