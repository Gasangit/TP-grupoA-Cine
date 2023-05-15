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
            sinopsis_pelicula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnaltapelicula = new Button();
            btnmodificarpelicula = new Button();
            btnbajapelicula = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            tbPoster = new TextBox();
            btnvolver_peliculas = new Button();
            btnmostrarpelicula = new Button();
            label6 = new Label();
            id_pelicula = new TextBox();
            idpelicula = new DataGridViewTextBoxColumn();
            nombrepelicula = new DataGridViewTextBoxColumn();
            sinopsispelicula = new DataGridViewTextBoxColumn();
            duracionpelicula = new DataGridViewTextBoxColumn();
            posterp = new DataGridViewImageColumn();
            urlPoster = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nombre_pelicula
            // 
            nombre_pelicula.Location = new Point(185, 58);
            nombre_pelicula.Name = "nombre_pelicula";
            nombre_pelicula.Size = new Size(100, 23);
            nombre_pelicula.TabIndex = 0;
            // 
            // duracion_pelicula
            // 
            duracion_pelicula.Location = new Point(436, 58);
            duracion_pelicula.Name = "duracion_pelicula";
            duracion_pelicula.Size = new Size(100, 23);
            duracion_pelicula.TabIndex = 1;
            // 
            // sinopsis_pelicula
            // 
            sinopsis_pelicula.Location = new Point(314, 58);
            sinopsis_pelicula.Name = "sinopsis_pelicula";
            sinopsis_pelicula.Size = new Size(100, 23);
            sinopsis_pelicula.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 84);
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
            label2.Location = new Point(457, 84);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Duración";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(331, 84);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Sinopsis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(391, 19);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idpelicula, nombrepelicula, sinopsispelicula, duracionpelicula, posterp, urlPoster });
            dataGridView1.Location = new Point(144, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Size = new Size(645, 187);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPoster);
            panel1.Controls.Add(btnvolver_peliculas);
            panel1.Controls.Add(btnmostrarpelicula);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(id_pelicula);
            panel1.Controls.Add(nombre_pelicula);
            panel1.Controls.Add(sinopsis_pelicula);
            panel1.Controls.Add(btnmodificarpelicula);
            panel1.Controls.Add(btnbajapelicula);
            panel1.Controls.Add(duracion_pelicula);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnaltapelicula);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 534);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(697, 84);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 19;
            label3.Text = "URL Poster";
            // 
            // tbPoster
            // 
            tbPoster.Location = new Point(580, 58);
            tbPoster.Name = "tbPoster";
            tbPoster.Size = new Size(317, 23);
            tbPoster.TabIndex = 18;
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
            btnmostrarpelicula.Size = new Size(191, 31);
            btnmostrarpelicula.TabIndex = 16;
            btnmostrarpelicula.Text = "MOSTRAR PELICULAS";
            btnmostrarpelicula.UseVisualStyleBackColor = true;
            btnmostrarpelicula.Click += btnmostrarpelicula_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 84);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 15;
            label6.Text = "ID Pelicula";
            // 
            // id_pelicula
            // 
            id_pelicula.Location = new Point(55, 58);
            id_pelicula.Name = "id_pelicula";
            id_pelicula.ReadOnly = true;
            id_pelicula.Size = new Size(100, 23);
            id_pelicula.TabIndex = 14;
            // 
            // idpelicula
            // 
            idpelicula.Frozen = true;
            idpelicula.HeaderText = "id";
            idpelicula.Name = "idpelicula";
            idpelicula.ReadOnly = true;
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
            // duracionpelicula
            // 
            duracionpelicula.Frozen = true;
            duracionpelicula.HeaderText = "Duración";
            duracionpelicula.Name = "duracionpelicula";
            duracionpelicula.ReadOnly = true;
            // 
            // posterp
            // 
            posterp.Frozen = true;
            posterp.HeaderText = "Poster";
            posterp.ImageLayout = DataGridViewImageCellLayout.Zoom;
            posterp.Name = "posterp";
            posterp.ReadOnly = true;
            // 
            // urlPoster
            // 
            urlPoster.Frozen = true;
            urlPoster.HeaderText = "URL Poster";
            urlPoster.Name = "urlPoster";
            urlPoster.ReadOnly = true;
            urlPoster.Visible = false;
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
        private TextBox sinopsis_pelicula;
        private Label label1;
        private Label label2;
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
        private Label label3;
        private TextBox tbPoster;
        private DataGridViewTextBoxColumn idpelicula;
        private DataGridViewTextBoxColumn nombrepelicula;
        private DataGridViewTextBoxColumn sinopsispelicula;
        private DataGridViewTextBoxColumn duracionpelicula;
        private DataGridViewImageColumn posterp;
        private DataGridViewTextBoxColumn urlPoster;
    }
}