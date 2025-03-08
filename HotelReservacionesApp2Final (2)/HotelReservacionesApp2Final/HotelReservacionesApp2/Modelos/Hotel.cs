using System.Collections.Generic;

namespace HotelReservacionesApp.Modelos
{
    public class Hotel
    {
        public List<Habitacion> Habitaciones { get; set; }
        public List<Cliente> Clientes { get; set; }
        public Dictionary<int, Reservacion> Reservaciones { get; set; }

        public Hotel()
        {
            Habitaciones = new List<Habitacion>();
            Clientes = new List<Cliente>();
            Reservaciones = new Dictionary<int, Reservacion>();
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }

        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void CrearReservacion(Reservacion reservacion)
        {
            Reservaciones.Add(reservacion.Id, reservacion);
            reservacion.Habitacion.Disponible = false;
        }

        public void CancelarReservacion(int idReservacion)
        {
            if (Reservaciones.ContainsKey(idReservacion))
            {
                Reservaciones[idReservacion].Habitacion.Disponible = true;
                Reservaciones.Remove(idReservacion);
            }
        }
    }
}