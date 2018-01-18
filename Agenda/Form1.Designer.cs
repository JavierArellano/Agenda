namespace Agenda {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.Medad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tEdad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Mdir = new System.Windows.Forms.TextBox();
            this.Memail = new System.Windows.Forms.TextBox();
            this.Mnom2 = new System.Windows.Forms.TextBox();
            this.Mtel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Bnom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(425, 433);
            this.bMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(208, 48);
            this.bMostrar.TabIndex = 0;
            this.bMostrar.Text = "Mostrar";
            this.bMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.edad,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactoBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(21, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1053, 404);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "edad";
            this.edad.Name = "edad";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 592);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.bMostrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1125, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mostrar datos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.Medad);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tEdad);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Mdir);
            this.tabPage2.Controls.Add(this.Memail);
            this.tabPage2.Controls.Add(this.Mnom2);
            this.tabPage2.Controls.Add(this.Mtel);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.Bnom);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.insertar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tDireccion);
            this.tabPage2.Controls.Add(this.tEmail);
            this.tabPage2.Controls.Add(this.tNombre);
            this.tabPage2.Controls.Add(this.tTelefono);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1125, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operaciones";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Edad";
            // 
            // Medad
            // 
            this.Medad.Location = new System.Drawing.Point(504, 221);
            this.Medad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medad.Name = "Medad";
            this.Medad.Size = new System.Drawing.Size(135, 22);
            this.Medad.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Edad";
            // 
            // tEdad
            // 
            this.tEdad.Location = new System.Drawing.Point(136, 222);
            this.tEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tEdad.Name = "tEdad";
            this.tEdad.Size = new System.Drawing.Size(177, 22);
            this.tEdad.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agenda.Properties.Resources.BotonBD;
            this.pictureBox1.Location = new System.Drawing.Point(893, 369);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 47);
            this.button3.TabIndex = 49;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nombre";
            // 
            // Mdir
            // 
            this.Mdir.Location = new System.Drawing.Point(504, 272);
            this.Mdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mdir.Name = "Mdir";
            this.Mdir.Size = new System.Drawing.Size(135, 22);
            this.Mdir.TabIndex = 41;
            // 
            // Memail
            // 
            this.Memail.Location = new System.Drawing.Point(504, 298);
            this.Memail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memail.Name = "Memail";
            this.Memail.Size = new System.Drawing.Size(135, 22);
            this.Memail.TabIndex = 42;
            // 
            // Mnom2
            // 
            this.Mnom2.Location = new System.Drawing.Point(504, 196);
            this.Mnom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mnom2.Name = "Mnom2";
            this.Mnom2.Size = new System.Drawing.Size(135, 22);
            this.Mnom2.TabIndex = 44;
            // 
            // Mtel
            // 
            this.Mtel.Location = new System.Drawing.Point(504, 247);
            this.Mtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mtel.Name = "Mtel";
            this.Mtel.Size = new System.Drawing.Size(135, 22);
            this.Mtel.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label11.Location = new System.Drawing.Point(421, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 52);
            this.label11.TabIndex = 40;
            this.label11.Text = "Operaciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label13.Location = new System.Drawing.Point(844, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 30);
            this.label13.TabIndex = 38;
            this.label13.Text = "Borrar contacto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 226);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 39);
            this.button2.TabIndex = 33;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(800, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Nombre";
            // 
            // Bnom
            // 
            this.Bnom.Location = new System.Drawing.Point(864, 191);
            this.Bnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bnom.Name = "Bnom";
            this.Bnom.Size = new System.Drawing.Size(135, 22);
            this.Bnom.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(456, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Modificar contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(77, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Añadir contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono";
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(120, 330);
            this.insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(149, 48);
            this.insertar.TabIndex = 13;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(136, 273);
            this.tDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(177, 22);
            this.tDireccion.TabIndex = 3;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(136, 300);
            this.tEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(177, 22);
            this.tEmail.TabIndex = 4;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(136, 196);
            this.tNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(177, 22);
            this.tNombre.TabIndex = 1;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(136, 248);
            this.tTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(177, 22);
            this.tTelefono.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1125, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráfico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.contactoBindingSource1, "edad", true));
            this.chart1.DataSource = this.contactoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(157, 111);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(678, 310);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactoBindingSource1
            // 
            this.contactoBindingSource1.DataSource = typeof(Agenda.Contacto);
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataSource = typeof(Agenda.Contacto);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 601);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Bnom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Mdir;
        private System.Windows.Forms.TextBox Memail;
        private System.Windows.Forms.TextBox Mnom2;
        private System.Windows.Forms.TextBox Mtel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tEdad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Medad;
        private System.Windows.Forms.BindingSource contactoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource contactoBindingSource;
    }
}

