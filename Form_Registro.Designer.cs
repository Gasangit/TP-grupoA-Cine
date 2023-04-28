namespace TP_grupoA_Cine
{
    partial class Form_Registro
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
            monthCalendar1 = new MonthCalendar();
            btnRegistrarse = new Button();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbEsAdmin = new ComboBox();
            tbApellido = new TextBox();
            tbContraseña = new TextBox();
            tbMail = new TextBox();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(btnRegistrarse);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbEsAdmin);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbContraseña);
            panel1.Controls.Add(tbMail);
            panel1.Controls.Add(tbDNI);
            panel1.Controls.Add(tbNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(465, 255);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.Info;
            btnRegistrarse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.Location = new Point(166, 353);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(175, 38);
            btnRegistrarse.TabIndex = 4;
            btnRegistrarse.Text = "REGISTRARSE";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(389, 96);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 3;
            label6.Text = "E-Mail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(58, 268);
            label9.Name = "label9";
            label9.Size = new Size(148, 20);
            label9.TabIndex = 3;
            label9.Text = "¿Es Administrador?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(389, 157);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 3;
            label8.Text = "Contraseña";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 157);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 3;
            label7.Text = "Apellido";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 214);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 100);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 23);
            label2.Name = "label2";
            label2.Size = new Size(298, 26);
            label2.TabIndex = 2;
            label2.Text = "Registro de Nuevo Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 61);
            label1.Name = "label1";
            label1.Size = new Size(436, 20);
            label1.TabIndex = 2;
            label1.Text = "Para registrarse por favor complete todos los campos";
            // 
            // cbEsAdmin
            // 
            cbEsAdmin.FormattingEnabled = true;
            cbEsAdmin.Items.AddRange(new object[] { "SI", "NO" });
            cbEsAdmin.Location = new Point(252, 265);
            cbEsAdmin.Name = "cbEsAdmin";
            cbEsAdmin.Size = new Size(89, 23);
            cbEsAdmin.TabIndex = 1;
            cbEsAdmin.SelectedIndexChanged += cbEsAdmin_SelectedIndexChanged;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(167, 154);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(172, 23);
            tbApellido.TabIndex = 0;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(539, 154);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(174, 23);
            tbContraseña.TabIndex = 0;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(539, 97);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(174, 23);
            tbMail.TabIndex = 0;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(167, 211);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(174, 23);
            tbDNI.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(164, 97);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 226);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha Nacimiento";
            // 
            // Form_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Registro";
            Text = "Form_Registro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbContraseña;
        private TextBox tbMail;
        private TextBox tbDNI;
        private TextBox tbNombre;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbEsAdmin;
        private TextBox tbApellido;
        private Button btnRegistrarse;
        private MonthCalendar monthCalendar1;
        private Label label5;
    }
}