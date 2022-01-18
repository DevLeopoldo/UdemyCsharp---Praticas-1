using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.verde, 4, "SLK350"); //Criando Carro
            //exibir atributos carro
            Console.WriteLine(" o carro é um " + carro.Modelo + " cor " + carro.Cor + " e tem " + carro.Portas + " portas.");
            
            Console.WriteLine(carro.Ligar()); // Ligar carro
            Console.WriteLine("Ligado? " + carro.Ligado);
            Console.WriteLine(carro.Andar()); // Andar com o carro
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
        }
    }
}
