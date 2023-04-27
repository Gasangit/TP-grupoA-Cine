namespace TP_grupoA_Cine
{
    partial class ABM_Salas
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
            ubicacion = new DataGridViewTextBoxColumn();
            capacidad = new DataGridViewTextBoxColumn();
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ubicacion, capacidad });
            dataGridView1.Location = new Point(182, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(394, 235);
            dataGridView1.TabIndex = 38;
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
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(324, 105);
            button3.Name = "button3";
            button3.Size = new Size(84, 27);
            button3.TabIndex = 37;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(414, 105);
            button2.Name = "button2";
            button2.Size = new Size(113, 27);
            button2.TabIndex = 36;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(224, 105);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 35;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(329, 9);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 34;
            label5.Text = "SALAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(457, 64);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 33;
            label4.Text = "Capacidad";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 30;
            label1.Text = "Ubicación";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(442, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(224, 64);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 40;
            label2.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 38);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 41;
            // 
            // ABM_Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABM_Salas";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}