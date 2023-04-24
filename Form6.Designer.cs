namespace TP_grupoA_Cine
{
    partial class Form6
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
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, dni, mail, password, fechaNacimiento, admin, bloqueado });
            dataGridView1.Location = new Point(7, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(784, 225);
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
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(360, 146);
            button3.Name = "button3";
            button3.Size = new Size(75, 36);
            button3.TabIndex = 37;
            button3.Text = "BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(460, 146);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 36;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(256, 146);
            button1.Name = "button1";
            button1.Size = new Size(68, 36);
            button1.TabIndex = 35;
            button1.Text = "ALTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(351, 10);
            label5.Name = "label5";
            label5.Size = new Size(128, 26);
            label5.TabIndex = 34;
            label5.Text = "USUARIOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(205, 63);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 33;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 32;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(426, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 31;
            label2.Text = "Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 64);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(182, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(394, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(496, 56);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 40;
            label6.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(500, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 39;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(606, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 43;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SI", "NO" });
            comboBox1.Location = new Point(394, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(603, 63);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 45;
            label7.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(425, 116);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 46;
            label8.Text = "Admin?";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(287, 116);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 48;
            label9.Text = "Bloqueado?";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SI", "NO" });
            comboBox2.Location = new Point(256, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 47;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(8, 139);
            button4.Name = "button4";
            button4.Size = new Size(168, 36);
            button4.TabIndex = 49;
            button4.Text = "MOSTRAR DATOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(4, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 431);
            panel1.TabIndex = 50;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
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
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewTextBoxColumn bloqueado;
        private Button button4;
        private Panel panel1;
    }
}