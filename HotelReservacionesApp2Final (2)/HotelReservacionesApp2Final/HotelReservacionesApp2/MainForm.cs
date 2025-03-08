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
    public partial class MainForm: Form
    {      
        

        public MainForm()
        {
            InitializeComponent();
            
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private Hotel hotel = new Hotel();

        private void button1_Click(object sender, EventArgs e)
        {
            GestionHabitacionesForm frm = new GestionHabitacionesForm(hotel);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionClientesForm frma = new GestionClientesForm(hotel);
            frma.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GestionReservacionesForm frme = new GestionReservacionesForm(hotel);
            frme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
