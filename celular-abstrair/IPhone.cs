using System;
using System.Collections.Generic;
using System.Text;

namespace celular_abstrair {
    class IPhone : Smartphone {

        public IPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {

        }
        public override void InstalarAplicativo(string app) {
            Console.WriteLine($"Instalando {app}.");
        }
    }
}
