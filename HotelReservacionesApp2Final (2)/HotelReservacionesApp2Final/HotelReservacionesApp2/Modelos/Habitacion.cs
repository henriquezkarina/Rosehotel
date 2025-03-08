﻿namespace HotelReservacionesApp.Modelos
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }

        public Habitacion(int numero, string tipo, decimal precio)
        {
            Numero = numero;
            Tipo = tipo;
            Precio = precio;
            Disponible = true;
        }
    }
}