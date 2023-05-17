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
    public partial class GestionarActivitats : Form
    {
        public char estatModAdd;
        public GestionarActivitats()
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
            hotels.TopMost= true;
            this.Close();
        }

        //Events botó Gestionar Cadenes
        private void panelCadenes_Click(object sender, EventArgs e)
        {
            GestionarCadenes cadenes = new GestionarCadenes();
            cadenes.Show();
            cadenes.TopMost= true;
            this.Close();
        }

        //Events botó Gestionar Activitats
        private void panelActivitats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ja et trobes al menú de gestió d'activitats", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void GestionarActivitats_Load(object sender, EventArgs e)
        {
            panelEditAdd.Visible = false;
            bindingSourceActivitats.DataSource = ActivitatsOrm.SelectAll();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (estatModAdd == 'm')
            {
                DialogResult a = MessageBox.Show("Estas segur que vols eliminar el registre", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (a == DialogResult.OK)
                {
                    String missatge = ActivitatsOrm.DeleteActivitat((actividades)dataGridViewActivitats.CurrentRow.DataBoundItem);
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = false;
            if (estatModAdd == 'a')
            {
                if(textBoxDescripcio.Text.Length> 0)
                {
                    String missatge = afegirActivitats();
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Registre afegit correctament!", "NOU REGISTRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if(textBoxDescripcio.Text.Length > 0)
                {
                    String missatge = actualitzarActivitat((actividades)dataGridViewActivitats.CurrentRow.DataBoundItem);
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
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            panelEditAdd.Visible = true;
            buidarTextBoxs();
            this.estatModAdd = 'a';
        }

        private void textBoxBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!textBoxBuscador.Text.Equals(""))
                {
                    String nom = textBoxBuscador.Text;

                    bindingSourceActivitats.DataSource = ActivitatsOrm.SelectByNom(nom);

                    if (bindingSourceActivitats.Count <= 0)
                    {
                        MessageBox.Show("No s'han trobat resultats");
                        bindingSourceActivitats.DataSource = ActivitatsOrm.SelectAll();
                    }
                }
                else
                {
                    bindingSourceActivitats.DataSource = ActivitatsOrm.SelectAll();
                }

            }
        }

        private void fillAllTextBoxs()
        {
            actividades c = (actividades)dataGridViewActivitats.CurrentRow.DataBoundItem;
            textBoxDescripcio.Text = c.descripcion;
        }

        private void dataGridViewActivitats_SelectionChanged(object sender, EventArgs e)
        {
            if (this.estatModAdd == 'm')
            {
                if (bindingSourceActivitats.Count != 0)
                {
                    fillAllTextBoxs();
                }
            }
        }
        private void buidarTextBoxs()
        {
            textBoxDescripcio.Text = "";
        }

        private void updateDataGrid()
        {
            this.estatModAdd = 'a';
            dataGridViewActivitats.DataSource = null;
            dataGridViewActivitats.DataSource = ActivitatsOrm.SelectAll();
        }
        private String afegirActivitats()
        {
            String missatge = "";
            actividades c = new actividades();
            c.id_act = ActivitatsOrm.SelectLastId() + 1;
            c.descripcion = textBoxDescripcio.Text;
            missatge = ActivitatsOrm.InsertActivitat(c);
            updateDataGrid();
           
            return missatge;
        }

        private String actualitzarActivitat(actividades c)
        {
            String missatge = ActivitatsOrm.UpdateActivitat(c, textBoxDescripcio.Text);
            updateDataGrid();
            return missatge;

        }
    }
}

