using HotelReservacionesApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservacionesApp2
{
    public partial class GestionReservacionesForm: Form
    {
        private Hotel hotel;
        public GestionReservacionesForm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            CargarClientes();
            CargarHabitacionesDisponibles();
            ActualizarListaReservaciones();
        }
        private void GestionReservacionesForm_Load(object sender, EventArgs e)
        {

        }
        private void CargarClientes()
        {
            cmbClientes.Items.Clear();
            foreach (var cliente in hotel.Clientes)
            {
                cmbClientes.Items.Add(cliente);
            }
            cmbClientes.DisplayMember = "Nombre";
        }

        private void CargarHabitacionesDisponibles()
        {
            cmbHabitaciones.Items.Clear();
            foreach (var habitacion in hotel.Habitaciones.Where(h => h.Disponible))
            {
                cmbHabitaciones.Items.Add(habitacion);
            }
            cmbHabitaciones.DisplayMember = "Numero";
        }
      
        private void ActualizarListaReservaciones()
        {
            lstReservaciones.Items.Clear();
            foreach (var reservacion in hotel.Reservaciones.Values)
            {
                lstReservaciones.Items.Add($"Reserva {reservacion.Id} - Habitación {reservacion.Habitacion.Numero} - Cliente {reservacion.Cliente.Nombre}");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearReservacion_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)cmbClientes.SelectedItem;
                Habitacion habitacion = (Habitacion)cmbHabitaciones.SelectedItem;
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                int idReservacion = hotel.Reservaciones.Count + 1; // ID autoincremental
                Reservacion reservacion = new Reservacion(idReservacion, cliente, habitacion, fechaInicio, fechaFin);
                hotel.CrearReservacion(reservacion);

                ActualizarListaReservaciones();
                CargarHabitacionesDisponibles(); // Actualizar habitaciones disponibles
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
