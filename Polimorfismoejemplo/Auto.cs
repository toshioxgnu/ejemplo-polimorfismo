namespace Polimorfismoejemplo
{
    public class Auto : Vehiculo
    {
        private string marca;
        private float cilindrada;

        public Auto(int ruedas, int pasajeros, string tipo) : base(ruedas, pasajeros, tipo)
        {

        }

        public Auto(int ruedas, int pasajeros, string tipo, string marca, double cilindrada) : base(ruedas, pasajeros, tipo)
        {
            this.marca = marca;
            this.cilindrada = (float) cilindrada;
        }

        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public float Cilindrada
        {
            get => cilindrada;
            set => cilindrada = value;
        }
    }
}