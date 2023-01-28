using System;
using System.Collections.Generic;
using System.Text;

namespace celular_abstrair {

    public class Nokia : Smartphone {

        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria) {

        }

        public override void InstalarAplicativo(string app) {
            Console.WriteLine($"Instalando {app}.");
        }
    }

}