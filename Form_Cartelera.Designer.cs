namespace TP_grupoA_Cine
{
    partial class Form_Cartelera
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
            btnmostrar_funciones = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            cantidadentradas = new NumericUpDown();
            btncomprar = new Button();
            label7 = new Label();
            cbCosto = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbPelicula = new ComboBox();
            cbUbicacion = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnBusqueda = new Button();
            funcion_seleccionada = new TextBox();
            label9 = new Label();
            btncerrar = new Button();
            panel2 = new Panel();
            btnmodificarusuario = new Button();
            btnvolver_cartelera = new Button();
            id = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            poster = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnmostrar_funciones
            // 
            btnmostrar_funciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmostrar_funciones.Location = new Point(643, 111);
            btnmostrar_funciones.Name = "btnmostrar_funciones";
            btnmostrar_funciones.Size = new Size(147, 30);
            btnmostrar_funciones.TabIndex = 70;
            btnmostrar_funciones.Text = "BUSCAR FUNCION";
            btnmostrar_funciones.UseVisualStyleBackColor = true;
            btnmostrar_funciones.Click += btnmostrar_funciones_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, pelicula, sala, fecha, costo, poster });
            dataGridView1.Location = new Point(357, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Size = new Size(565, 162);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 255);
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(399, 12);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 57;
            label5.Text = "CARTELERA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cantidadentradas);
            panel1.Controls.Add(btncomprar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbCosto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbPelicula);
            panel1.Controls.Add(cbUbicacion);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 525);
            panel1.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 255);
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(631, 51);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 85;
            label8.Text = "Cantidad";
            // 
            // cantidadentradas
            // 
            cantidadentradas.Location = new Point(612, 74);
            cantidadentradas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cantidadentradas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadentradas.Name = "cantidadentradas";
            cantidadentradas.Size = new Size(120, 23);
            cantidadentradas.TabIndex = 84;
            cantidadentradas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btncomprar
            // 
            btncomprar.FlatAppearance.BorderColor = Color.Red;
            btncomprar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btncomprar.FlatAppearance.MouseOverBackColor = Color.Red;
            btncomprar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btncomprar.Location = new Point(738, 41);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(182, 66);
            btncomprar.TabIndex = 83;
            btncomprar.Text = "COMPRAR";
            btncomprar.UseVisualStyleBackColor = true;
            btncomprar.Click += btncomprar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 192, 255);
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 87);
            label7.Name = "label7";
            label7.Size = new Size(580, 20);
            label7.TabIndex = 81;
            label7.Text = "Para comprar haga doble clic en la funcion deseada y aprete el boton COMPRAR";
            // 
            // cbCosto
            // 
            cbCosto.FormattingEnabled = true;
            cbCosto.Location = new Point(511, 122);
            cbCosto.Name = "cbCosto";
            cbCosto.Size = new Size(121, 23);
            cbCosto.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 192, 255);
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(454, 124);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 79;
            label6.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(236, 124);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 78;
            label4.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 77;
            label3.Text = "Ubicacion";
            // 
            // cbPelicula
            // 
            cbPelicula.FormattingEnabled = true;
            cbPelicula.Location = new Point(304, 122);
            cbPelicula.Name = "cbPelicula";
            cbPelicula.Size = new Size(121, 23);
            cbPelicula.TabIndex = 76;
            // 
            // cbUbicacion
            // 
            cbUbicacion.FormattingEnabled = true;
            cbUbicacion.Location = new Point(103, 124);
            cbUbicacion.Name = "cbUbicacion";
            cbUbicacion.Size = new Size(121, 23);
            cbUbicacion.TabIndex = 75;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(36, 159);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 44);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 44);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "ACA EL NOMBRE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(btnBusqueda);
            panel3.Controls.Add(funcion_seleccionada);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btncerrar);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnmodificarusuario);
            panel3.Controls.Add(btnvolver_cartelera);
            panel3.Controls.Add(btnmostrar_funciones);
            panel3.Location = new Point(10, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 463);
            panel3.TabIndex = 87;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBusqueda.Location = new Point(488, 361);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(206, 31);
            btnBusqueda.TabIndex = 91;
            btnBusqueda.Text = "BUSQUEDA AVANZADA";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // funcion_seleccionada
            // 
            funcion_seleccionada.Location = new Point(523, 326);
            funcion_seleccionada.Name = "funcion_seleccionada";
            funcion_seleccionada.ReadOnly = true;
            funcion_seleccionada.Size = new Size(112, 23);
            funcion_seleccionada.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 255);
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(347, 329);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 88;
            label9.Text = "Funcion Seleccionada:";
            // 
            // btncerrar
            // 
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.Location = new Point(761, 358);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(149, 37);
            btncerrar.TabIndex = 82;
            btncerrar.Text = "CERRAR SESION";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(593, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 77);
            panel2.TabIndex = 86;
            // 
            // btnmodificarusuario
            // 
            btnmodificarusuario.FlatAppearance.BorderColor = Color.Red;
            btnmodificarusuario.FlatAppearance.BorderSize = 15;
            btnmodificarusuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnmodificarusuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnmodificarusuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmodificarusuario.Location = new Point(257, 361);
            btnmodificarusuario.Name = "btnmodificarusuario";
            btnmodificarusuario.Size = new Size(179, 34);
            btnmodificarusuario.TabIndex = 73;
            btnmodificarusuario.Text = "MODIFICAR USUARIO";
            btnmodificarusuario.UseVisualStyleBackColor = true;
            btnmodificarusuario.Click += btnmodificarusuario_Click;
            // 
            // btnvolver_cartelera
            // 
            btnvolver_cartelera.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvolver_cartelera.Location = new Point(26, 364);
            btnvolver_cartelera.Name = "btnvolver_cartelera";
            btnvolver_cartelera.Size = new Size(198, 31);
            btnvolver_cartelera.TabIndex = 72;
            btnvolver_cartelera.Text = "VOLVER";
            btnvolver_cartelera.UseVisualStyleBackColor = true;
            btnvolver_cartelera.Click += btnvolver_cartelera_Click;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // pelicula
            // 
            pelicula.Frozen = true;
            pelicula.HeaderText = "Pelicula";
            pelicula.Name = "pelicula";
            pelicula.ReadOnly = true;
            // 
            // sala
            // 
            sala.Frozen = true;
            sala.HeaderText = "Sala";
            sala.Name = "sala";
            sala.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.Frozen = true;
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // costo
            // 
            costo.Frozen = true;
            costo.HeaderText = "Costo";
            costo.Name = "costo";
            costo.ReadOnly = true;
            // 
            // poster
            // 
            poster.Frozen = true;
            poster.HeaderText = "Poster";
            poster.ImageLayout = DataGridViewImageCellLayout.Stretch;
            poster.Name = "poster";
            poster.ReadOnly = true;
            poster.Resizable = DataGridViewTriState.True;
            poster.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Cartelera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 482);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cartelera";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnmostrar_funciones;
        private DataGridView dataGridView1;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnvolver_cartelera;
        private Button btnmodificarusuario;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private Label label3;
        private ComboBox cbPelicula;
        private ComboBox cbUbicacion;
        private ComboBox cbCosto;
        private Label label6;
        private Label label7;
        private Button btncerrar;
        private Button btncomprar;
        private Label label8;
        private NumericUpDown cantidadentradas;
        private Panel panel2;
        private Panel panel3;
        private TextBox funcion_seleccionada;
        private Label label9;
        private Button btnBusqueda;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewImageColumn poster;
    }
}