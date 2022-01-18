using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCsharp
{
    public class Carro
    {
        //atributos do Carro
        public int Portas { get; }
        public string Modelo { get; }
        public Cor Cor { get; }
        private bool ligado = false;

        public bool Ligado // propriedade. define uma maneira de acessar o atributos
        {
            get
            {
                return ligado;
            }
           
        }


        // metodo construtor da classe
        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
            
        }


        // Comportamento do carro
        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado.";
        }
        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado.";
        }
        public string Andar()
        {
            return "O carro esta em movimento.";
        }
    }
}
