using System;

namespace HotelReservacionesApp.Modelos
{
    public class Reservacion
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Reservacion(int id, Cliente cliente, Habitacion habitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            Id = id;
            Cliente = cliente;
            Habitacion = habitacion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}