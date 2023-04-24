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
            button4 = new Button();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            admin = new DataGridViewTextBoxColumn();
            bloqueado = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(672, 127);
            button4.Name = "button4";
            button4.Size = new Size(116, 23);
            button4.TabIndex = 70;
            button4.Text = "MOSTRAR DATOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 97);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 69;
            label9.Text = "Bloqueado?";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SI", "NO" });
            comboBox2.Location = new Point(253, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 97);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 67;
            label8.Text = "Admin?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 44);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 66;
            label7.Text = "Fecha Nacimiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SI", "NO" });
            comboBox1.Location = new Point(391, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 65;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(603, 18);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 44);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 63;
            label6.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(497, 18);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 62;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, dni, mail, password, fechaNacimiento, admin, bloqueado });
            dataGridView1.Location = new Point(34, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(725, 192);
            dataGridView1.TabIndex = 61;
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
            // apellido
            // 
            apellido.Frozen = true;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.Frozen = true;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // mail
            // 
            mail.Frozen = true;
            mail.HeaderText = "Mail";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // password
            // 
            password.Frozen = true;
            password.HeaderText = "Password";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Frozen = true;
            fechaNacimiento.HeaderText = "Fecha Nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // admin
            // 
            admin.Frozen = true;
            admin.HeaderText = "Administrador?";
            admin.Name = "admin";
            admin.ReadOnly = true;
            // 
            // bloqueado
            // 
            bloqueado.Frozen = true;
            bloqueado.HeaderText = "Bloqueado?";
            bloqueado.Name = "bloqueado";
            bloqueado.ReadOnly = true;
            // 
            // button3
            // 
            button3.Location = new Point(357, 127);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 60;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(457, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 59;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(246, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 58;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 57;
            label5.Text = "ESTO SERIA LA CARTELERA";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 44);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 56;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 45);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 55;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 44);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 54;
            label2.Text = "Mail";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(179, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(285, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 51;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(391, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 71;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewTextBoxColumn bloqueado;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel1;
    }
}