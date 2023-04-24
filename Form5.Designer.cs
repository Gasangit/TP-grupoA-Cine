namespace TP_grupoA_Cine
{
    partial class Form5
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            ubicacion = new DataGridViewTextBoxColumn();
            capacidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ubicacion, capacidad });
            dataGridView1.Location = new Point(258, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(244, 192);
            dataGridView1.TabIndex = 38;
            // 
            // button3
            // 
            button3.Location = new Point(341, 101);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 37;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(441, 101);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(230, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 35;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 11);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 34;
            label5.Text = "SALAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 66);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 33;
            label4.Text = "Capacidad";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 30;
            label1.Text = "Ubicación";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(454, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 66);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 40;
            label2.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 40);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 39;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // ubicacion
            // 
            ubicacion.Frozen = true;
            ubicacion.HeaderText = "Ubicación";
            ubicacion.Name = "ubicacion";
            ubicacion.ReadOnly = true;
            // 
            // capacidad
            // 
            capacidad.Frozen = true;
            capacidad.HeaderText = "Capacidad";
            capacidad.Name = "capacidad";
            capacidad.ReadOnly = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ubicacion;
        private DataGridViewTextBoxColumn capacidad;
    }
}