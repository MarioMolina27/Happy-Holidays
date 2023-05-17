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
    public partial class GestionarHotels : Form
    {
        public char estatModAdd;
        hoteles hotel;
        public GestionarHotels()
        {
            InitializeComponent();
        }

        // Events botó HOME
        private void panelHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        //Events botó Gestionar Hotels
        private void panelHotels_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ja et trobes al menú de gestió dels hotels", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Events botó Gestionar Cadenes
        private void panelCadenes_Click(object sender, EventArgs e)
        {
            GestionarCadenes cadenes = new GestionarCadenes();
            cadenes.Show();
            cadenes.TopMost = true;
            this.Close();
        }

        //Events botó Gestionar Activitats
        private void panelActivitats_Click(object sender, EventArgs e)
        {
            GestionarActivitats activitats = new GestionarActivitats();
            activitats.Show();
            activitats.TopMost = true;
            this.Close();
        }

      

        //Events Exit App
        private void panelExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vols tancar la aplicació?", "Tancar Aplicació", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBoxExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vols tancar la aplicació?", "Tancar Aplicació", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = true;
            estatModAdd = 'm';
            fillAllTextBoxs();
            textBoxNom.ReadOnly= true;
            comboBoxCiutat.Enabled = false;
            buttonActivitats.Visible= true;
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = true;
            buidarTextBoxs();
            estatModAdd = 'a';
            textBoxNom.ReadOnly = false;
            comboBoxCiutat.Enabled = true;
            this.hotel = new hoteles();
            buttonActivitats.Visible = false;
        }

        private void GestionarHotels_Load(object sender, EventArgs e)
        {
            panelEditAdd.Visible = false;
            bindingSourceHotels.DataSource = HotelsOrm.SelectAll();
            bindingSourceCiutats.DataSource = CiutatsOrm.SelectAll();
            bindingSourceCadena.DataSource = CadenesOrm.SelectAll();
            buttonActivitats.Visible = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = false;
            if (estatModAdd == 'a')
            {
                if (textBoxNom.Text.Length > 0 && textBoxDireccio.Text.Length > 0 && textBoxTelefono.Text.Length > 0 && comboBoxCategoria.Text.Length>0 && comboBoxTipo.Text.Length > 0)
                {
                    String missatge = afegirHotel(this.hotel);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("error");
                    }
                    else
                    {
                        MessageBox.Show("Registre afegit correctament!", "NOU REGISTRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tots els camps han d'estar omplerts per afegir una nova cadena", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String missatge = actualitzarHotel((hoteles)dataGridViewHotels.CurrentRow.DataBoundItem);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registre modificat correctament!", "MODIFICACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (estatModAdd == 'm')
            {
                DialogResult a = MessageBox.Show("Estas segur que vols eliminar el registre", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (a == DialogResult.OK)
                {
                    String missatge = HotelsOrm.DeleteHotel((hoteles)dataGridViewHotels.CurrentRow.DataBoundItem);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Registre eliminat correctament!", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelEditAdd.Visible = false;
                        updateDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Acció d'eliminar cancel·lada", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El registre no es pot eliminar ja que com s'està creant no es pot eliminar", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonActivitats_Click(object sender, EventArgs e)
        {
            ActivitatsHotel a = new ActivitatsHotel(this.hotel);
            this.TopMost = false;
            a.ShowDialog();
        }

        private void textBoxBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!textBoxBuscador.Text.Equals(""))
                {
                    String nom = textBoxBuscador.Text;

                    bindingSourceHotels.DataSource = null;
                    bindingSourceHotels.DataSource = HotelsOrm.SelectByNom(nom);

                    if (bindingSourceHotels.Count <= 0)
                    {
                        MessageBox.Show("No s'han trobat resultats");
                        bindingSourceHotels.DataSource = HotelsOrm.SelectAll();
                    }
                }
                else
                {
                    bindingSourceHotels.DataSource = HotelsOrm.SelectAll();
                }
            }
        }

        private void updateDataGrid()
        {
            this.estatModAdd = 'a';
            bindingSourceHotels.DataSource = null;
            bindingSourceHotels.DataSource = HotelsOrm.SelectAll();
        }

        private String afegirHotel(hoteles h)
        {
            String missatge = "";
            ciudades c = (ciudades)comboBoxCiutat.SelectedItem;
            cadenas cadena = (cadenas)comboBoxCadena.SelectedItem; 
            h.id_ciudad = c.id_ciudad;
            h.nombre = textBoxNom.Text;
            h.direccion = textBoxDireccio.Text;
            h.telefono = Int32.Parse(textBoxTelefono.Text);
            h.cif = cadena.cif;
            h.tipo = comboBoxTipo.Text;
            h.categoria = Int32.Parse(comboBoxCategoria.Text[0].ToString());
            missatge = HotelsOrm.InsertHotel(h);
            updateDataGrid();
            return missatge;
        }

        private void buidarTextBoxs()
        {
            textBoxNom.Text = "";
            textBoxDireccio.Text = "";
            textBoxTelefono.Text = "";
            comboBoxCiutat.SelectedIndex = 0;
            comboBoxCadena.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxCategoria.SelectedIndex = 0;
        }

        private void dataGridViewHotels_SelectionChanged(object sender, EventArgs e)
        {
            if (this.estatModAdd == 'm')
            {
                if (bindingSourceHotels.Count != 0)
                {
                    fillAllTextBoxs();
                }
            }
        }

        private void fillAllTextBoxs()
        {
            if(dataGridViewHotels.Rows.Count != 0)
            {
                hoteles h = (hoteles)dataGridViewHotels.CurrentRow.DataBoundItem;
                this.hotel = h;
                textBoxNom.Text = h.nombre;
                textBoxTelefono.Text = h.telefono.ToString();
                textBoxDireccio.Text = h.direccion;
                if (h.tipo.Equals("PLAYA"))
                {
                    comboBoxTipo.SelectedIndex = 0;
                }
                else
                {
                    comboBoxTipo.SelectedIndex = 1;
                }
                switch (h.categoria)
                {
                    case 1:
                        comboBoxCategoria.SelectedIndex = 0;
                        break;
                    case 2:
                        comboBoxCategoria.SelectedIndex = 1;
                        break;
                    case 3:
                        comboBoxCategoria.SelectedIndex = 2;
                        break;
                    case 4:
                        comboBoxCategoria.SelectedIndex = 3;
                        break;
                    case 5:
                        comboBoxCategoria.SelectedIndex = 4;
                        break;
                    default:
                        comboBoxCategoria.SelectedIndex = 0;
                        break;
                }
                if(bindingSourceCiutats != null&& bindingSourceCadena !=null)
                {
                    fillCiudadComboBox(h);
                    fillCadenaComboBox(h);
                }
            }

        }
        public void fillCiudadComboBox (hoteles h)
        {
            int i = 0;
            bool trobat = false;
            do
            {
                ciudades c = (ciudades)bindingSourceCiutats[i];
                if (c.id_ciudad == h.id_ciudad)
                {
                    trobat = true;
                    comboBoxCiutat.SelectedIndex = i;
                }
                i++;
            } while (!trobat);
        }

        public void fillCadenaComboBox(hoteles h)
        {
            int i = 0;
            bool trobat = false;
            do
            {
                cadenas c = (cadenas)bindingSourceCadena[i];
                if (c.cif.Equals(h.cif))
                {
                    trobat = true;
                    comboBoxCadena.SelectedIndex = i;
                }
                i++;
            } while (!trobat);
        }

        private String actualitzarHotel(hoteles h)
        {
            ciudades c =(ciudades)comboBoxCiutat.SelectedItem;
            cadenas cadena =(cadenas)comboBoxCadena.SelectedItem;
            String missatge = HotelsOrm.UpdateHotel(h, Int32.Parse(comboBoxCategoria.Text[0].ToString()),textBoxDireccio.Text, Int32.Parse(textBoxTelefono.Text),comboBoxTipo.Text,cadena.cif);
            updateDataGrid();
            return missatge;

        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxCadenas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadenas cadenas = (cadenas)comboBoxCadena.SelectedItem;

            bindingSourceHotels.DataSource = HotelsOrm.SelectByCadena(cadenas.cif);
        }
    }
}
