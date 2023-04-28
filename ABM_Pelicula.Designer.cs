namespace TP_grupoA_Cine
{
    partial class ABM_Pelicula
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
            nombre_pelicula = new TextBox();
            duracion_pelicula = new TextBox();
            poster_pelicula = new TextBox();
            sinopsis_pelicula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnaltapelicula = new Button();
            btnmodificarpelicula = new Button();
            btnbajapelicula = new Button();
            dataGridView1 = new DataGridView();
            idpelicula = new DataGridViewTextBoxColumn();
            nombrepelicula = new DataGridViewTextBoxColumn();
            sinopsispelicula = new DataGridViewTextBoxColumn();
            posterpelicula = new DataGridViewImageColumn();
            duracionpelicula = new DataGridViewTextBoxColumn();
            poster = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnvolver_peliculas = new Button();
            btnmostrarpelicula = new Button();
            label6 = new Label();
            id_pelicula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nombre_pelicula
            // 
            nombre_pelicula.Location = new Point(206, 57);
            nombre_pelicula.Name = "nombre_pelicula";
            nombre_pelicula.Size = new Size(100, 23);
            nombre_pelicula.TabIndex = 0;
            // 
            // duracion_pelicula
            // 
            duracion_pelicula.Location = new Point(616, 57);
            duracion_pelicula.Name = "duracion_pelicula";
            duracion_pelicula.Size = new Size(100, 23);
            duracion_pelicula.TabIndex = 1;
            // 
            // poster_pelicula
            // 
            poster_pelicula.Location = new Point(474, 57);
            poster_pelicula.Name = "poster_pelicula";
            poster_pelicula.Size = new Size(100, 23);
            poster_pelicula.TabIndex = 2;
            // 
            // sinopsis_pelicula
            // 
            sinopsis_pelicula.Location = new Point(335, 57);
            sinopsis_pelicula.Name = "sinopsis_pelicula";
            sinopsis_pelicula.Size = new Size(100, 23);
            sinopsis_pelicula.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(218, 83);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(625, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Duración";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(488, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Poster";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(352, 83);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Sinopsis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(391, 19);
            label5.Name = "label5";
            label5.Size = new Size(134, 26);
            label5.TabIndex = 8;
            label5.Text = "PELICULAS";
            // 
            // btnaltapelicula
            // 
            btnaltapelicula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaltapelicula.Location = new Point(248, 123);
            btnaltapelicula.Name = "btnaltapelicula";
            btnaltapelicula.Size = new Size(86, 31);
            btnaltapelicula.TabIndex = 9;
            btnaltapelicula.Text = "ALTA";
            btnaltapelicula.UseVisualStyleBackColor = true;
            btnaltapelicula.Click += btnaltapelicula_Click;
            // 
            // btnmodificarpelicula
            // 
            btnmodificarpelicula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmodificarpelicula.Location = new Point(535, 123);
            btnmodificarpelicula.Name = "btnmodificarpelicula";
            btnmodificarpelicula.Size = new Size(115, 31);
            btnmodificarpelicula.TabIndex = 10;
            btnmodificarpelicula.Text = "MODIFICAR";
            btnmodificarpelicula.UseVisualStyleBackColor = true;
            btnmodificarpelicula.Click += btnmodificarpelicula_Click;
            // 
            // btnbajapelicula
            // 
            btnbajapelicula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbajapelicula.Location = new Point(390, 123);
            btnbajapelicula.Name = "btnbajapelicula";
            btnbajapelicula.Size = new Size(86, 31);
            btnbajapelicula.TabIndex = 11;
            btnbajapelicula.Text = "BAJA";
            btnbajapelicula.UseVisualStyleBackColor = true;
            btnbajapelicula.Click += btnbajapelicula_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idpelicula, nombrepelicula, sinopsispelicula, posterpelicula, duracionpelicula, poster });
            dataGridView1.Location = new Point(144, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(645, 187);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // idpelicula
            // 
            idpelicula.Frozen = true;
            idpelicula.HeaderText = "id";
            idpelicula.Name = "idpelicula";
            idpelicula.ReadOnly = true;
            idpelicula.Visible = false;
            // 
            // nombrepelicula
            // 
            nombrepelicula.Frozen = true;
            nombrepelicula.HeaderText = "Nombre";
            nombrepelicula.Name = "nombrepelicula";
            nombrepelicula.ReadOnly = true;
            // 
            // sinopsispelicula
            // 
            sinopsispelicula.Frozen = true;
            sinopsispelicula.HeaderText = "Sinopsis";
            sinopsispelicula.Name = "sinopsispelicula";
            sinopsispelicula.ReadOnly = true;
            // 
            // posterpelicula
            // 
            posterpelicula.Frozen = true;
            posterpelicula.HeaderText = "Poster";
            posterpelicula.Name = "posterpelicula";
            posterpelicula.ReadOnly = true;
            posterpelicula.Resizable = DataGridViewTriState.True;
            posterpelicula.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // duracionpelicula
            // 
            duracionpelicula.Frozen = true;
            duracionpelicula.HeaderText = "Duración";
            duracionpelicula.Name = "duracionpelicula";
            duracionpelicula.ReadOnly = true;
            // 
            // poster
            // 
            poster.HeaderText = "Poster";
            poster.Name = "poster";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnvolver_peliculas);
            panel1.Controls.Add(btnmostrarpelicula);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(id_pelicula);
            panel1.Controls.Add(nombre_pelicula);
            panel1.Controls.Add(sinopsis_pelicula);
            panel1.Controls.Add(btnmodificarpelicula);
            panel1.Controls.Add(poster_pelicula);
            panel1.Controls.Add(btnbajapelicula);
            panel1.Controls.Add(duracion_pelicula);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnaltapelicula);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 534);
            panel1.TabIndex = 13;
            // 
            // btnvolver_peliculas
            // 
            btnvolver_peliculas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvolver_peliculas.Location = new Point(376, 445);
            btnvolver_peliculas.Name = "btnvolver_peliculas";
            btnvolver_peliculas.Size = new Size(198, 31);
            btnvolver_peliculas.TabIndex = 17;
            btnvolver_peliculas.Text = "VOLVER A BOTONERA";
            btnvolver_peliculas.UseVisualStyleBackColor = true;
            btnvolver_peliculas.Click += btnvolver_peliculas_Click;
            // 
            // btnmostrarpelicula
            // 
            btnmostrarpelicula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmostrarpelicula.Location = new Point(361, 187);
            btnmostrarpelicula.Name = "btnmostrarpelicula";
            btnmostrarpelicula.Size = new Size(164, 31);
            btnmostrarpelicula.TabIndex = 16;
            btnmostrarpelicula.Text = "MOSTRAR SALAS";
            btnmostrarpelicula.UseVisualStyleBackColor = true;
            btnmostrarpelicula.Click += btnmostrarpelicula_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(92, 83);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 15;
            label6.Text = "ID Pelicula";
            // 
            // id_pelicula
            // 
            id_pelicula.Location = new Point(76, 57);
            id_pelicula.Name = "id_pelicula";
            id_pelicula.ReadOnly = true;
            id_pelicula.Size = new Size(100, 23);
            id_pelicula.TabIndex = 14;
            // 
            // ABM_Pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 534);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ABM_Pelicula";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nombre_pelicula;
        private TextBox duracion_pelicula;
        private TextBox poster_pelicula;
        private TextBox sinopsis_pelicula;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnaltapelicula;
        private Button btnmodificarpelicula;
        private Button btnbajapelicula;
        private DataGridView dataGridView1;
        //private DataGridViewTextBoxColumn ID;
        //private DataGridViewTextBoxColumn nombre;
        //private DataGridViewTextBoxColumn sinopsis;
        //private DataGridViewTextBoxColumn poster;
        //private DataGridViewTextBoxColumn duracion;
        private Panel panel1;
        private Label label6;
        private TextBox id_pelicula;
        private Button btnmostrarpelicula;
        private Button btnvolver_peliculas;
        private DataGridViewTextBoxColumn idpelicula;
        private DataGridViewTextBoxColumn nombrepelicula;
        private DataGridViewTextBoxColumn sinopsispelicula;
        private DataGridViewImageColumn posterpelicula;
        private DataGridViewTextBoxColumn duracionpelicula;
        private DataGridViewImageColumn poster;
    }
}