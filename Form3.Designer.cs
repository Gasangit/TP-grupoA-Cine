namespace TP_grupoA_Cine
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            sinopsis = new DataGridViewTextBoxColumn();
            poster = new DataGridViewTextBoxColumn();
            duracion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(549, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(271, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 76);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Duración";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 76);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Poster";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 76);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Sinopsis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 9);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "PELICULAS";
            // 
            // button1
            // 
            button1.Location = new Point(260, 109);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(471, 109);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(371, 109);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, sinopsis, poster, duracion });
            dataGridView1.Location = new Point(168, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(446, 192);
            dataGridView1.TabIndex = 12;
         
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nombre
            // 
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // sinopsis
            // 
            sinopsis.Frozen = true;
            sinopsis.HeaderText = "sinopsis";
            sinopsis.Name = "sinopsis";
            sinopsis.ReadOnly = true;
            // 
            // poster
            // 
            poster.Frozen = true;
            poster.HeaderText = "Poster";
            poster.Name = "poster";
            poster.ReadOnly = true;
            // 
            // duracion
            // 
            duracion.Frozen = true;
            duracion.HeaderText = "Duración";
            duracion.Name = "duracion";
            duracion.ReadOnly = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn sinopsis;
        private DataGridViewTextBoxColumn poster;
        private DataGridViewTextBoxColumn duracion;
    }
}