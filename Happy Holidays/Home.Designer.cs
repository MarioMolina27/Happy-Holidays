namespace Happy_Holidays
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panelActivitats = new System.Windows.Forms.Panel();
            this.pictureBoxActivitats = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelActivitats = new System.Windows.Forms.Label();
            this.panelHotels = new System.Windows.Forms.Panel();
            this.pictureBoxHotels = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHotels = new System.Windows.Forms.Label();
            this.panelCadenes = new System.Windows.Forms.Panel();
            this.pictureBoxCadenes = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCadenes = new System.Windows.Forms.Label();
            this.labelBenvingut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panelActivitats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivitats)).BeginInit();
            this.panel9.SuspendLayout();
            this.panelHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotels)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelCadenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenes)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.panelGeneral.Controls.Add(this.panel2);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(361, 1033);
            this.panelGeneral.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.panelExit);
            this.panel2.Controls.Add(this.panelHome);
            this.panel2.Controls.Add(this.panelActivitats);
            this.panel2.Controls.Add(this.panelHotels);
            this.panel2.Controls.Add(this.panelCadenes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 1033);
            this.panel2.TabIndex = 5;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.pictureBoxLogOut);
            this.panelExit.Controls.Add(this.panel6);
            this.panelExit.Controls.Add(this.labelExit);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExit.Location = new System.Drawing.Point(0, 933);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(361, 100);
            this.panelExit.TabIndex = 6;
            this.panelExit.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Image = global::Happy_Holidays.Properties.Resources.logout;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(25, 15);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 5;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(361, 100);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(231, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Home";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExit.Location = new System.Drawing.Point(120, 42);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(67, 26);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "Sortir";
            this.labelExit.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(143)))), ((int)(((byte)(41)))));
            this.panelHome.Controls.Add(this.panel3);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Controls.Add(this.pictureBoxHome);
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(361, 100);
            this.panelHome.TabIndex = 0;
            this.panelHome.Click += new System.EventHandler(this.panelHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 100);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(231, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Home";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHome.Location = new System.Drawing.Point(120, 42);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(70, 26);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.panelHome_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::Happy_Holidays.Properties.Resources.house;
            this.pictureBoxHome.Location = new System.Drawing.Point(25, 13);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.panelHome_Click);
            // 
            // panelActivitats
            // 
            this.panelActivitats.Controls.Add(this.pictureBoxActivitats);
            this.panelActivitats.Controls.Add(this.panel9);
            this.panelActivitats.Controls.Add(this.labelActivitats);
            this.panelActivitats.Location = new System.Drawing.Point(3, 305);
            this.panelActivitats.Name = "panelActivitats";
            this.panelActivitats.Size = new System.Drawing.Size(361, 100);
            this.panelActivitats.TabIndex = 4;
            this.panelActivitats.Click += new System.EventHandler(this.panelActivitats_Click);
            // 
            // pictureBoxActivitats
            // 
            this.pictureBoxActivitats.Image = global::Happy_Holidays.Properties.Resources.activitats;
            this.pictureBoxActivitats.Location = new System.Drawing.Point(25, 15);
            this.pictureBoxActivitats.Name = "pictureBoxActivitats";
            this.pictureBoxActivitats.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxActivitats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxActivitats.TabIndex = 5;
            this.pictureBoxActivitats.TabStop = false;
            this.pictureBoxActivitats.Click += new System.EventHandler(this.panelActivitats_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(0, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(361, 100);
            this.panel9.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(231, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Home";
            // 
            // labelActivitats
            // 
            this.labelActivitats.AutoSize = true;
            this.labelActivitats.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelActivitats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelActivitats.Location = new System.Drawing.Point(120, 42);
            this.labelActivitats.Name = "labelActivitats";
            this.labelActivitats.Size = new System.Drawing.Size(209, 26);
            this.labelActivitats.TabIndex = 0;
            this.labelActivitats.Text = "Gestionar Activitats";
            this.labelActivitats.Click += new System.EventHandler(this.panelActivitats_Click);
            // 
            // panelHotels
            // 
            this.panelHotels.Controls.Add(this.pictureBoxHotels);
            this.panelHotels.Controls.Add(this.panel5);
            this.panelHotels.Controls.Add(this.labelHotels);
            this.panelHotels.Location = new System.Drawing.Point(3, 105);
            this.panelHotels.Name = "panelHotels";
            this.panelHotels.Size = new System.Drawing.Size(361, 100);
            this.panelHotels.TabIndex = 2;
            this.panelHotels.Click += new System.EventHandler(this.panelHotels_Click);
            // 
            // pictureBoxHotels
            // 
            this.pictureBoxHotels.Image = global::Happy_Holidays.Properties.Resources.hotel;
            this.pictureBoxHotels.Location = new System.Drawing.Point(25, 10);
            this.pictureBoxHotels.Name = "pictureBoxHotels";
            this.pictureBoxHotels.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxHotels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotels.TabIndex = 3;
            this.pictureBoxHotels.TabStop = false;
            this.pictureBoxHotels.Click += new System.EventHandler(this.panelHotels_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 100);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(231, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Home";
            // 
            // labelHotels
            // 
            this.labelHotels.AutoSize = true;
            this.labelHotels.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelHotels.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHotels.Location = new System.Drawing.Point(120, 39);
            this.labelHotels.Name = "labelHotels";
            this.labelHotels.Size = new System.Drawing.Size(179, 26);
            this.labelHotels.TabIndex = 0;
            this.labelHotels.Text = "Gestionar Hotels";
            this.labelHotels.Click += new System.EventHandler(this.panelHotels_Click);
            // 
            // panelCadenes
            // 
            this.panelCadenes.Controls.Add(this.pictureBoxCadenes);
            this.panelCadenes.Controls.Add(this.panel7);
            this.panelCadenes.Controls.Add(this.labelCadenes);
            this.panelCadenes.Location = new System.Drawing.Point(3, 206);
            this.panelCadenes.Name = "panelCadenes";
            this.panelCadenes.Size = new System.Drawing.Size(361, 100);
            this.panelCadenes.TabIndex = 3;
            this.panelCadenes.Click += new System.EventHandler(this.panelCadenes_Click);
            // 
            // pictureBoxCadenes
            // 
            this.pictureBoxCadenes.Image = global::Happy_Holidays.Properties.Resources.cadena;
            this.pictureBoxCadenes.Location = new System.Drawing.Point(25, 14);
            this.pictureBoxCadenes.Name = "pictureBoxCadenes";
            this.pictureBoxCadenes.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxCadenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCadenes.TabIndex = 4;
            this.pictureBoxCadenes.TabStop = false;
            this.pictureBoxCadenes.Click += new System.EventHandler(this.panelCadenes_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(0, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(361, 100);
            this.panel7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(231, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Home";
            // 
            // labelCadenes
            // 
            this.labelCadenes.AutoSize = true;
            this.labelCadenes.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelCadenes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCadenes.Location = new System.Drawing.Point(120, 40);
            this.labelCadenes.Name = "labelCadenes";
            this.labelCadenes.Size = new System.Drawing.Size(199, 26);
            this.labelCadenes.TabIndex = 0;
            this.labelCadenes.Text = "Gestionar Cadenes";
            this.labelCadenes.Click += new System.EventHandler(this.panelCadenes_Click);
            // 
            // labelBenvingut
            // 
            this.labelBenvingut.AutoSize = true;
            this.labelBenvingut.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenvingut.Location = new System.Drawing.Point(1000, 400);
            this.labelBenvingut.Name = "labelBenvingut";
            this.labelBenvingut.Size = new System.Drawing.Size(370, 85);
            this.labelBenvingut.TabIndex = 2;
            this.labelBenvingut.Text = "Benvingut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(944, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Et trobes a l\'aplicació d\'administració de SOHO";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hotel.png");
            this.imageList1.Images.SetKeyName(1, "house.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(361, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 48);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = global::Happy_Holidays.Properties.Resources.x;
            this.pictureBoxExit.Location = new System.Drawing.Point(1503, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(38, 48);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1103, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "SOlo HOteleros";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBenvingut);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Happy Holidays";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panelActivitats.ResumeLayout(false);
            this.panelActivitats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivitats)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelHotels.ResumeLayout(false);
            this.panelHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotels)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelCadenes.ResumeLayout(false);
            this.panelCadenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenes)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label labelBenvingut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelActivitats;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelActivitats;
        private System.Windows.Forms.Panel panelCadenes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCadenes;
        private System.Windows.Forms.Panel panelHotels;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHotels;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxHotels;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxActivitats;
        private System.Windows.Forms.PictureBox pictureBoxCadenes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label5;
    }
}

