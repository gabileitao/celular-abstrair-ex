using System;
using System.Collections.Generic;
using System.Text;

namespace celular_abstrair {
    public abstract class Smartphone {

        public string Numero;
        public string Modelo;
        public string IMEI;
        public int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria) {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar() {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string app);

    }
}
