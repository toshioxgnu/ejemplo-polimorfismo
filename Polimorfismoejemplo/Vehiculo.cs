namespace Polimorfismoejemplo
{
    public class Vehiculo
    {
        private int ruedas;
        private int pasajeros;
        private string tipo;

        public Vehiculo(int ruedas, int pasajeros, string tipo)
        {
            this.ruedas = ruedas;
            this.pasajeros = pasajeros;
            this.tipo = tipo;
        }

        public int Ruedas
        {
            get => ruedas;
            set => ruedas = value;
        }

        public int Pasajeros
        {
            get => pasajeros;
            set => pasajeros = value;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }
    }
}