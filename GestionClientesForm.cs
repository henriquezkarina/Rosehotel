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
    public partial class GestionClientesForm: Form
    {
        private Hotel hotel;
        public GestionClientesForm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            ActualizarListaClientes();
        }
        private void ActualizarListaClientes()
        {
            
                lstClientes.Items.Clear();
                foreach (var cliente in hotel.Clientes)
                {
                    lstClientes.Items.Add($"ID: {cliente.Id} - {cliente.Nombre} - Tel: {cliente.Telefono}");
                }
        }
        private void GestionClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;

                Cliente cliente = new Cliente(id, nombre, telefono);
                hotel.AgregarCliente(cliente);
                ActualizarListaClientes();

                // Limpiar campos después de agregar
                txtId.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
