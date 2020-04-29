using System;

namespace Polimorfismoejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = new Vehiculo[3];
            
            vehiculos[1] = new Moto( 2, 2, "Enduro", "Honda", 0.8); 
            vehiculos[2] = new Auto( 2, 2, "Enduro", "Mercedez benz", 2.0); 
            
            Console.WriteLine(vehiculos[1].Ruedas);
        }
    }
}