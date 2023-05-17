using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Holidays
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Events botó HOME
        private void panelHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ja et trobes al menú home", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Events botó Gestionar Hotels
        private void panelHotels_Click(object sender, EventArgs e)
        {
            GestionarHotels hotels = new GestionarHotels();
            hotels.Show();
            hotels.TopMost= true;
            this.Hide();
        }

      
        //Events botó Gestionar Cadenes
        private void panelCadenes_Click(object sender, EventArgs e)
        {
            GestionarCadenes cadenes = new GestionarCadenes();
            cadenes.Show();
            cadenes.TopMost= true;
            this.Hide();
        }

        //Events botó Gestionar Cadenes
        private void panelActivitats_Click(object sender, EventArgs e)
        {
            GestionarActivitats activitats = new GestionarActivitats();
            activitats.Show();
            activitats.TopMost= true;
            this.Hide();
        }
       


        //Events Exit App
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vols tancar la aplicació?", "Tancar Aplicació", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void panelExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vols tancar la aplicació?", "Tancar Aplicació", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
