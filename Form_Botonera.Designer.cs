namespace TP_grupoA_Cine
{
    partial class Form_Botonera
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnFunciones = new Button();
            btnSalas = new Button();
            panel2 = new Panel();
            btnPeliculas = new Button();
            btnUsuarios = new Button();
            btnCartelera = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFunciones);
            panel1.Controls.Add(btnSalas);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 534);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(428, 97);
            label3.Name = "label3";
            label3.Size = new Size(159, 26);
            label3.TabIndex = 4;
            label3.Text = "Cines FLAGG";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(402, 138);
            label2.Name = "label2";
            label2.Size = new Size(228, 26);
            label2.TabIndex = 3;
            label2.Text = "Panel Administrador";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 170);
            label1.Name = "label1";
            label1.Size = new Size(504, 26);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido, seleccione la opcion que desea utilizar";
            // 
            // btnFunciones
            // 
            btnFunciones.BackColor = SystemColors.Info;
            btnFunciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFunciones.Location = new Point(412, 328);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(187, 33);
            btnFunciones.TabIndex = 0;
            btnFunciones.Text = "ABM Funciones";
            btnFunciones.UseVisualStyleBackColor = false;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // btnSalas
            // 
            btnSalas.BackColor = SystemColors.Info;
            btnSalas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalas.Location = new Point(412, 278);
            btnSalas.Name = "btnSalas";
            btnSalas.Size = new Size(187, 33);
            btnSalas.TabIndex = 0;
            btnSalas.Text = "ABM Salas";
            btnSalas.UseVisualStyleBackColor = false;
            btnSalas.Click += btnSalas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnPeliculas);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnCartelera);
            panel2.Location = new Point(173, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 263);
            panel2.TabIndex = 2;
            // 
            // btnPeliculas
            // 
            btnPeliculas.BackColor = SystemColors.Info;
            btnPeliculas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculas.Location = new Point(239, 20);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(187, 33);
            btnPeliculas.TabIndex = 0;
            btnPeliculas.Text = "ABM Peliculas";
            btnPeliculas.UseVisualStyleBackColor = false;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.Info;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(239, 169);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(187, 33);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "ABM Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCartelera
            // 
            btnCartelera.BackColor = SystemColors.Info;
            btnCartelera.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCartelera.Location = new Point(239, 215);
            btnCartelera.Name = "btnCartelera";
            btnCartelera.Size = new Size(187, 33);
            btnCartelera.TabIndex = 0;
            btnCartelera.Text = "Ir a Cartelera";
            btnCartelera.UseVisualStyleBackColor = false;
            btnCartelera.Click += btnCartelera_Click;
            // 
            // Form_Botonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(954, 532);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Botonera";
            Text = "Form8";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCartelera;
        private Button btnUsuarios;
        private Button btnFunciones;
        private Button btnSalas;
        private Button btnPeliculas;
        private Panel panel2;
    }
}