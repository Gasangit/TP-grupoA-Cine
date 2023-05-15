namespace TP_grupoA_Cine
{
    partial class Form_PeliculasSalas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            idsala = new DataGridViewTextBoxColumn();
            ubicacionSala = new DataGridViewTextBoxColumn();
            capacidadSala = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            idPelicula = new DataGridViewTextBoxColumn();
            nombrePelicula = new DataGridViewTextBoxColumn();
            sinopsisPelicula = new DataGridViewTextBoxColumn();
            duracionPelicula = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            idFuncion = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            salaFuncion = new DataGridViewTextBoxColumn();
            fechaFuncion = new DataGridViewTextBoxColumn();
            costoFuncion = new DataGridViewTextBoxColumn();
            btnMostrar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            cantidadentradas = new NumericUpDown();
            btncomprar = new Button();
            funcion_seleccionada = new TextBox();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 222);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(593, 194);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Salas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idsala, ubicacionSala, capacidadSala });
            dataGridView1.Location = new Point(50, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(489, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // idsala
            // 
            idsala.Frozen = true;
            idsala.HeaderText = "ID";
            idsala.Name = "idsala";
            idsala.ReadOnly = true;
            // 
            // ubicacionSala
            // 
            ubicacionSala.Frozen = true;
            ubicacionSala.HeaderText = "Ubicacion";
            ubicacionSala.Name = "ubicacionSala";
            ubicacionSala.ReadOnly = true;
            // 
            // capacidadSala
            // 
            capacidadSala.Frozen = true;
            capacidadSala.HeaderText = "Capacidad";
            capacidadSala.Name = "capacidadSala";
            capacidadSala.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(593, 194);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Peliculas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idPelicula, nombrePelicula, sinopsisPelicula, duracionPelicula });
            dataGridView2.Location = new Point(39, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(514, 150);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // idPelicula
            // 
            idPelicula.Frozen = true;
            idPelicula.HeaderText = "ID";
            idPelicula.Name = "idPelicula";
            idPelicula.ReadOnly = true;
            // 
            // nombrePelicula
            // 
            nombrePelicula.Frozen = true;
            nombrePelicula.HeaderText = "Nombre";
            nombrePelicula.Name = "nombrePelicula";
            nombrePelicula.ReadOnly = true;
            // 
            // sinopsisPelicula
            // 
            sinopsisPelicula.Frozen = true;
            sinopsisPelicula.HeaderText = "Sinopsis";
            sinopsisPelicula.Name = "sinopsisPelicula";
            sinopsisPelicula.ReadOnly = true;
            // 
            // duracionPelicula
            // 
            duracionPelicula.Frozen = true;
            duracionPelicula.HeaderText = "Duracion";
            duracionPelicula.Name = "duracionPelicula";
            duracionPelicula.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idFuncion, pelicula, salaFuncion, fechaFuncion, costoFuncion });
            dataGridView3.Location = new Point(12, 310);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(601, 150);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // idFuncion
            // 
            idFuncion.Frozen = true;
            idFuncion.HeaderText = "ID Funcion";
            idFuncion.Name = "idFuncion";
            idFuncion.ReadOnly = true;
            // 
            // pelicula
            // 
            pelicula.Frozen = true;
            pelicula.HeaderText = "Pelicula";
            pelicula.Name = "pelicula";
            pelicula.ReadOnly = true;
            // 
            // salaFuncion
            // 
            salaFuncion.Frozen = true;
            salaFuncion.HeaderText = "Sala";
            salaFuncion.Name = "salaFuncion";
            salaFuncion.ReadOnly = true;
            // 
            // fechaFuncion
            // 
            fechaFuncion.Frozen = true;
            fechaFuncion.HeaderText = "Fecha Funcion";
            fechaFuncion.Name = "fechaFuncion";
            fechaFuncion.ReadOnly = true;
            // 
            // costoFuncion
            // 
            costoFuncion.Frozen = true;
            costoFuncion.HeaderText = "Costo";
            costoFuncion.Name = "costoFuncion";
            costoFuncion.ReadOnly = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.Location = new Point(698, 106);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(160, 33);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(732, 429);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 31);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 23);
            label1.Name = "label1";
            label1.Size = new Size(396, 30);
            label1.TabIndex = 4;
            label1.Text = "Busqueda Avanzada por Sala o Pelicula";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cantidadentradas);
            panel2.Controls.Add(btncomprar);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(619, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 77);
            panel2.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(25, 14);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 88;
            label8.Text = "Cantidad";
            // 
            // cantidadentradas
            // 
            cantidadentradas.Location = new Point(6, 37);
            cantidadentradas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cantidadentradas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadentradas.Name = "cantidadentradas";
            cantidadentradas.Size = new Size(120, 23);
            cantidadentradas.TabIndex = 87;
            cantidadentradas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btncomprar
            // 
            btncomprar.FlatAppearance.BorderColor = Color.Red;
            btncomprar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btncomprar.FlatAppearance.MouseOverBackColor = Color.Red;
            btncomprar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btncomprar.Location = new Point(132, 4);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(182, 66);
            btncomprar.TabIndex = 86;
            btncomprar.Text = "COMPRAR";
            btncomprar.UseVisualStyleBackColor = true;
            btncomprar.Click += btncomprar_Click;
            // 
            // funcion_seleccionada
            // 
            funcion_seleccionada.Location = new Point(809, 242);
            funcion_seleccionada.Name = "funcion_seleccionada";
            funcion_seleccionada.ReadOnly = true;
            funcion_seleccionada.Size = new Size(112, 23);
            funcion_seleccionada.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(633, 245);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 90;
            label9.Text = "Funcion Seleccionada:";
            // 
            // Form_PeliculasSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(952, 502);
            Controls.Add(funcion_seleccionada);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView3);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_PeliculasSalas";
            Text = "Form_PeliculasSalas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idsala;
        private DataGridViewTextBoxColumn ubicacionSala;
        private DataGridViewTextBoxColumn capacidadSala;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idPelicula;
        private DataGridViewTextBoxColumn nombrePelicula;
        private DataGridViewTextBoxColumn sinopsisPelicula;
        private DataGridViewTextBoxColumn duracionPelicula;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn idFuncion;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn salaFuncion;
        private DataGridViewTextBoxColumn fechaFuncion;
        private DataGridViewTextBoxColumn costoFuncion;
        private Button btnMostrar;
        private Button btnVolver;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private NumericUpDown cantidadentradas;
        private Button btncomprar;
        private TextBox funcion_seleccionada;
        private Label label9;
    }
}