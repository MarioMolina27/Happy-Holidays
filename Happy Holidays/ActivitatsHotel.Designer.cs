namespace Happy_Holidays
{
    partial class ActivitatsHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitatsHotel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxActivitats = new System.Windows.Forms.ComboBox();
            this.bindingSourceActivitats = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewActivitats = new System.Windows.Forms.DataGridView();
            this.idactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActivitatsHotel = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitatsHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 48);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = global::Happy_Holidays.Properties.Resources.x;
            this.pictureBoxExit.Location = new System.Drawing.Point(1207, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(38, 48);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 672);
            this.panel2.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.comboBoxActivitats);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.buttonAfegir);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(448, 168);
            this.panel7.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Grau";
            // 
            // comboBoxActivitats
            // 
            this.comboBoxActivitats.DataSource = this.bindingSourceActivitats;
            this.comboBoxActivitats.DisplayMember = "descripcion";
            this.comboBoxActivitats.FormattingEnabled = true;
            this.comboBoxActivitats.Location = new System.Drawing.Point(28, 41);
            this.comboBoxActivitats.Name = "comboBoxActivitats";
            this.comboBoxActivitats.Size = new System.Drawing.Size(203, 24);
            this.comboBoxActivitats.TabIndex = 22;
            this.comboBoxActivitats.ValueMember = "id_act";
            // 
            // bindingSourceActivitats
            // 
            this.bindingSourceActivitats.DataSource = typeof(Happy_Holidays.Models.actividades);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 110);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(143)))), ((int)(((byte)(41)))));
            this.buttonAfegir.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAfegir.ImageKey = "plus.png";
            this.buttonAfegir.ImageList = this.imageList1;
            this.buttonAfegir.Location = new System.Drawing.Point(257, 0);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(191, 168);
            this.buttonAfegir.TabIndex = 21;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diskette.png");
            this.imageList1.Images.SetKeyName(1, "trash-can.png");
            this.imageList1.Images.SetKeyName(2, "pencil.png");
            this.imageList1.Images.SetKeyName(3, "plus.png");
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(143)))), ((int)(((byte)(41)))));
            this.buttonEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEliminar.ImageKey = "trash-can.png";
            this.buttonEliminar.ImageList = this.imageList1;
            this.buttonEliminar.Location = new System.Drawing.Point(0, 542);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(448, 81);
            this.buttonEliminar.TabIndex = 25;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 623);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 49);
            this.panel6.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(448, 64);
            this.panel8.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 64);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 559);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 671);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 49);
            this.panel4.TabIndex = 8;
            // 
            // dataGridViewActivitats
            // 
            this.dataGridViewActivitats.AllowUserToAddRows = false;
            this.dataGridViewActivitats.AllowUserToDeleteRows = false;
            this.dataGridViewActivitats.AutoGenerateColumns = false;
            this.dataGridViewActivitats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActivitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivitats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idactDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn});
            this.dataGridViewActivitats.DataSource = this.bindingSourceActivitatsHotel;
            this.dataGridViewActivitats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActivitats.Location = new System.Drawing.Point(41, 112);
            this.dataGridViewActivitats.Name = "dataGridViewActivitats";
            this.dataGridViewActivitats.ReadOnly = true;
            this.dataGridViewActivitats.RowHeadersWidth = 51;
            this.dataGridViewActivitats.RowTemplate.Height = 24;
            this.dataGridViewActivitats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivitats.Size = new System.Drawing.Size(756, 559);
            this.dataGridViewActivitats.TabIndex = 10;
            this.dataGridViewActivitats.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewActivitats_CellFormatting);
            // 
            // idactDataGridViewTextBoxColumn
            // 
            this.idactDataGridViewTextBoxColumn.DataPropertyName = "id_act";
            this.idactDataGridViewTextBoxColumn.HeaderText = "id_act";
            this.idactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idactDataGridViewTextBoxColumn.Name = "idactDataGridViewTextBoxColumn";
            this.idactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "grado";
            this.gradoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            this.gradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceActivitatsHotel
            // 
            this.bindingSourceActivitatsHotel.DataSource = typeof(Happy_Holidays.Models.act_hotel);
            // 
            // ActivitatsHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 720);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewActivitats);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivitatsHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivitatsHotel";
            this.Load += new System.EventHandler(this.ActivitatsHotel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivitatsHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxActivitats;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource bindingSourceActivitatsHotel;
        private System.Windows.Forms.DataGridView dataGridViewActivitats;
        private System.Windows.Forms.BindingSource bindingSourceActivitats;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
    }
}