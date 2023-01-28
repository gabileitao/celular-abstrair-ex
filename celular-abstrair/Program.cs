using System;

namespace celular_abstrair {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Celular Nokia:");
            Smartphone nokia = new Nokia("123456", "Modelo Novo", "11111111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Candy Crush");

            Console.WriteLine("\n");

            Console.WriteLine("Celular Iphone:");
            Smartphone iphone = new IPhone("789123", "Modelo Antigo", "22222222", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Fortnite");

        }
    }
}
