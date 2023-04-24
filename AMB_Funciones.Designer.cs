namespace TP_grupoA_Cine
{
    partial class AMB_Funciones
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            cantidadEspectadores = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, sala, pelicula, fecha, costo, cantidadEspectadores });
            dataGridView1.Location = new Point(46, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(703, 256);
            dataGridView1.TabIndex = 25;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // sala
            // 
            sala.Frozen = true;
            sala.HeaderText = "Sala";
            sala.Name = "sala";
            sala.ReadOnly = true;
            // 
            // pelicula
            // 
            pelicula.Frozen = true;
            pelicula.HeaderText = "Película";
            pelicula.Name = "pelicula";
            pelicula.ReadOnly = true;
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
            // cantidadEspectadores
            // 
            cantidadEspectadores.Frozen = true;
            cantidadEspectadores.HeaderText = "Cantidad Espectadores";
            cantidadEspectadores.Name = "cantidadEspectadores";
            cantidadEspectadores.ReadOnly = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(330, 97);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 24;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(481, 97);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 23;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(191, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 22;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(318, 9);
            label5.Name = "label5";
            label5.Size = new Size(142, 26);
            label5.TabIndex = 21;
            label5.Text = "FUNCIONES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(305, 76);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 20;
            label4.Text = "Pelicula";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(441, 76);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 19;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(578, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 18;
            label2.Text = "Costo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 76);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 17;
            label1.Text = "Sala";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(409, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(548, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 26;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn cantidadEspectadores;
        private Panel panel1;
    }
}