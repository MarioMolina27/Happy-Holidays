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
    public partial class GestionarCadenes : Form
    {
        public char estatModAdd;
        public GestionarCadenes()
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
            GestionarHotels hotels = new GestionarHotels();
            hotels.Show();
            hotels.TopMost = true;
            this.Close();
        }

        //Events botó Gestionar Cadenes
        private void panelCadenes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ja et trobes al menú de gestió de cadenes", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void GestionarCadenes_Load(object sender, EventArgs e)
        {
            panelEditAdd.Visible= false;
            bindingSourceCadenes.DataSource = CadenesOrm.SelectAll();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible= true;
            textBoxCIF.ReadOnly=true;
            estatModAdd = 'm';
            fillAllTextBoxs();

        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = true;
            textBoxCIF.ReadOnly = false;
            estatModAdd = 'a';
            buidarTextBoxs();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = false;
            if(estatModAdd == 'a')
            {
                if (textBoxCIF.Text.Length > 0 && textBoxNom.Text.Length > 0 && textBoxDif.Text.Length > 0) 
                {
                    String missatge = afegirCadena();
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (textBoxNom.Text.Length > 0 && textBoxDif.Text.Length > 0)
                {
                    String missatge = actualitzarCadena((cadenas)dataGridViewCadenes.CurrentRow.DataBoundItem);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Registre modificat correctament!", "MODIFICACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tots els camps han d'estar omplerts per modificar cadena", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (estatModAdd == 'm')
            {
                DialogResult a = MessageBox.Show("Estas segur que vols eliminar el registre","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(a == DialogResult.OK)
                {
                    String missatge = CadenesOrm.DeleteCadena((cadenas)dataGridViewCadenes.CurrentRow.DataBoundItem);
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

        private void textBoxBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!textBoxBuscador.Text.Equals(""))
                {
                    String nom = textBoxBuscador.Text;

                    bindingSourceCadenes.DataSource = CadenesOrm.SelectByNom(nom);

                    if (bindingSourceCadenes.Count <= 0)
                    {
                        MessageBox.Show("No s'han trobat resultats");
                        bindingSourceCadenes.DataSource = CadenesOrm.SelectAll();
                    }
                }
                else
                {
                    bindingSourceCadenes.DataSource = CadenesOrm.SelectAll();
                }

            }
        }

        private void fillAllTextBoxs()
        {
            cadenas c = (cadenas)dataGridViewCadenes.CurrentRow.DataBoundItem;
            textBoxCIF.Text = c.cif;
            textBoxNom.Text = c.nombre;
            textBoxDif.Text = c.dir_fis;
        }
        private void buidarTextBoxs()
        {
            textBoxCIF.Text = "";
            textBoxNom.Text = "";
            textBoxDif.Text = "";
        }

        private void dataGridViewCadenes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.estatModAdd == 'm')
            {
                if(bindingSourceCadenes.Count!=0)
                {
                    fillAllTextBoxs();
                }
            }
        }

        private String actualitzarCadena(cadenas c)
        {
            String missatge = CadenesOrm.UpdateCadena(c,textBoxNom.Text,textBoxDif.Text);
            updateDataGrid();
            return missatge;
            
        }
        private String afegirCadena()
        {
            String missatge = "";
            if (textBoxCIF.Text.Length == 9)
            {
                cadenas c = new cadenas();
                c.cif = textBoxCIF.Text;
                c.nombre = textBoxNom.Text;
                c.dir_fis = textBoxDif.Text;
                missatge = CadenesOrm.InsertCadena(c);
                updateDataGrid();
            }
            else
            {
                MessageBox.Show("El CIF ha de tenir 9 caràcters", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return missatge;
        }
        private void updateDataGrid()
        {
            this.estatModAdd = 'a';
            bindingSourceCadenes.DataSource = null;
            bindingSourceCadenes.DataSource = CadenesOrm.SelectAll();
        }
    }
}
