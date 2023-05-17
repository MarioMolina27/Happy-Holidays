using Happy_Holidays.Models;
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
    public partial class ActivitatsHotel : Form
    {
        hoteles hotel;
        public ActivitatsHotel()
        {
            InitializeComponent();
        }

        public ActivitatsHotel(hoteles h)
        {
            InitializeComponent();
            this.hotel = h;
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivitatsHotel_Load(object sender, EventArgs e)
        {
            bindingSourceActivitatsHotel.DataSource = ActHotelsOrm.SelectByHotel(this.hotel);
            bindingSourceActivitats.DataSource = ActivitatsOrm.SelectAll();
        }

        private void updateDataGrid()
        {
            bindingSourceActivitatsHotel.DataSource = null;
            bindingSourceActivitatsHotel.DataSource = ActHotelsOrm.SelectByHotel(this.hotel);
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >0) 
            {
                actividades activitat = (actividades)comboBoxActivitats.SelectedItem;
                act_hotel a = new act_hotel();
                a.id_act = activitat.id_act;
                a.nombre = this.hotel.nombre;
                a.id_ciudad = this.hotel.id_ciudad;
                a.grado = Int32.Parse(textBox1.Text);
                String missatge = ActHotelsOrm.InsertActivitat(a);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    updateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Has d'introduir un grau d'activitat","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Estas segur que vols eliminar el registre", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                String missatge = ActHotelsOrm.DeleteActivitat((act_hotel)dataGridViewActivitats.CurrentRow.DataBoundItem);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registre eliminat correctament!", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Acció d'eliminar cancel·lada", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewActivitats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                act_hotel act = (act_hotel)dataGridViewActivitats.Rows[e.RowIndex].DataBoundItem;
                if (act != null)
                {
                    e.Value = act.actividades.descripcion;
                }

            }
        }
    }
}
