using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CSHARP_E_DOTNET.Modelos
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public  string Nome { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} \n" +
             $" e tenho {Idade} anos");
             // " + $" isso não quebra frase exibida, apenas organiza melhor o código
             // \n dentro do string quebra linha
        }
    }
}