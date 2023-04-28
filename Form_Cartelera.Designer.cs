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
            imgPoster = new DataGridViewImageColumn();
            pelicula = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            cbCosto = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbPelicula = new ComboBox();
            cbUbicacion = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            btncomprar = new Button();
            btnvolver_cartelera = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnmostrar_funciones
            // 
            btnmostrar_funciones.Location = new Point(123, 334);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgPoster, pelicula, sala, fecha, costo });
            dataGridView1.Location = new Point(383, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(565, 162);
            dataGridView1.TabIndex = 61;
            // 
            // imgPoster
            // 
            imgPoster.Frozen = true;
            imgPoster.HeaderText = "Poster";
            imgPoster.Name = "imgPoster";
            imgPoster.ReadOnly = true;
            imgPoster.Resizable = DataGridViewTriState.True;
            imgPoster.SortMode = DataGridViewColumnSortMode.Automatic;
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
            costo.HeaderText = "Costo";
            costo.Name = "costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(410, 9);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 57;
            label5.Text = "CARTELERA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbCosto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbPelicula);
            panel1.Controls.Add(cbUbicacion);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(btncomprar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnvolver_cartelera);
            panel1.Controls.Add(btnmostrar_funciones);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 525);
            panel1.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(173, 77);
            label7.Name = "label7";
            label7.Size = new Size(534, 20);
            label7.TabIndex = 81;
            label7.Text = "Para buscar una funcion puede buscar por ubicacio, pelicula, costo y fecha";
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
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(446, 125);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 79;
            label6.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 125);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 78;
            label4.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 125);
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
            cbUbicacion.Location = new Point(92, 125);
            cbUbicacion.Name = "cbUbicacion";
            cbUbicacion.Size = new Size(121, 23);
            cbUbicacion.TabIndex = 75;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(71, 160);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 74;
            // 
            // btncomprar
            // 
            btncomprar.FlatAppearance.BorderColor = Color.Red;
            btncomprar.FlatAppearance.BorderSize = 15;
            btncomprar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btncomprar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btncomprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncomprar.Location = new Point(788, 44);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(125, 53);
            btncomprar.TabIndex = 73;
            btncomprar.Text = "COMPRAR";
            btncomprar.UseVisualStyleBackColor = true;
            // 
            // btnvolver_cartelera
            // 
            btnvolver_cartelera.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvolver_cartelera.Location = new Point(398, 388);
            btnvolver_cartelera.Name = "btnvolver_cartelera";
            btnvolver_cartelera.Size = new Size(198, 31);
            btnvolver_cartelera.TabIndex = 72;
            btnvolver_cartelera.Text = "VOLVER";
            btnvolver_cartelera.UseVisualStyleBackColor = true;
            btnvolver_cartelera.Click += btnvolver_cartelera_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 44);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "ACA EL NOMBRE";
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
        private Button btncomprar;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private Label label3;
        private ComboBox cbPelicula;
        private ComboBox cbUbicacion;
        private ComboBox cbCosto;
        private Label label6;
        private Label label7;
        private DataGridViewImageColumn imgPoster;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn costo;
    }
}