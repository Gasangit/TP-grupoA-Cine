namespace TP_grupoA_Cine
{
    partial class Form_Usuario_Activo
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
            tbId = new TextBox();
            tbCredito = new TextBox();
            label2 = new Label();
            btnActualizarDatos = new Button();
            btnFunciones = new Button();
            mcNacimiento = new MonthCalendar();
            tbContrasenia = new TextBox();
            tbEmail = new TextBox();
            tbDNI = new TextBox();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            labelCredito = new Label();
            labelFechaNacimiento = new Label();
            labelMail = new Label();
            labelDni = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            label1 = new Label();
            btnMostrarDatos = new Button();
            btnvolver = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(tbCredito);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnActualizarDatos);
            panel1.Controls.Add(btnFunciones);
            panel1.Controls.Add(mcNacimiento);
            panel1.Controls.Add(tbContrasenia);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbDNI);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(labelCredito);
            panel1.Controls.Add(labelFechaNacimiento);
            panel1.Controls.Add(labelMail);
            panel1.Controls.Add(labelDni);
            panel1.Controls.Add(labelApellido);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMostrarDatos);
            panel1.Controls.Add(btnvolver);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 534);
            panel1.TabIndex = 0;
            // 
            // tbId
            // 
            tbId.Location = new Point(672, 110);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(247, 23);
            tbId.TabIndex = 21;
            tbId.Visible = false;
            // 
            // tbCredito
            // 
            tbCredito.Location = new Point(785, 50);
            tbCredito.Name = "tbCredito";
            tbCredito.ReadOnly = true;
            tbCredito.Size = new Size(99, 23);
            tbCredito.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(626, 51);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 19;
            label2.Text = "SALDO CREDITO";
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarDatos.Location = new Point(407, 463);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(142, 27);
            btnActualizarDatos.TabIndex = 18;
            btnActualizarDatos.Text = "ACTUALIZAR DATOS";
            btnActualizarDatos.UseVisualStyleBackColor = true;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // btnFunciones
            // 
            btnFunciones.Location = new Point(575, 463);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(103, 27);
            btnFunciones.TabIndex = 17;
            btnFunciones.Text = "MIS FUNCIONES";
            btnFunciones.UseVisualStyleBackColor = true;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // mcNacimiento
            // 
            mcNacimiento.Location = new Point(419, 288);
            mcNacimiento.Name = "mcNacimiento";
            mcNacimiento.TabIndex = 16;
            // 
            // tbContrasenia
            // 
            tbContrasenia.Location = new Point(419, 254);
            tbContrasenia.Name = "tbContrasenia";
            tbContrasenia.Size = new Size(247, 23);
            tbContrasenia.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(419, 219);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(247, 23);
            tbEmail.TabIndex = 14;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(419, 184);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(247, 23);
            tbDNI.TabIndex = 13;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(419, 149);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(247, 23);
            tbApellido.TabIndex = 12;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(419, 110);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(247, 23);
            tbNombre.TabIndex = 11;
            // 
            // labelCredito
            // 
            labelCredito.AutoSize = true;
            labelCredito.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCredito.Location = new Point(239, 253);
            labelCredito.Name = "labelCredito";
            labelCredito.Size = new Size(92, 20);
            labelCredito.TabIndex = 8;
            labelCredito.Text = "Contraseña";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFechaNacimiento.Location = new Point(239, 288);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(159, 20);
            labelFechaNacimiento.TabIndex = 7;
            labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(239, 218);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(53, 20);
            labelMail.TabIndex = 6;
            labelMail.Text = "E-Mail";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDni.Location = new Point(239, 183);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(37, 20);
            labelDni.TabIndex = 5;
            labelDni.Text = "DNI";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelApellido.Location = new Point(239, 148);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(65, 20);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(239, 113);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(65, 20);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 21);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 2;
            label1.Text = "Perfil de Usuario";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarDatos.Location = new Point(407, 72);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(142, 27);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "MOSTRAR DATOS";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(251, 463);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(94, 27);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // Form_Usuario_Activo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 530);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Usuario_Activo";
            Text = "Form_Usuario_Activo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMostrarDatos;
        private Button btnvolver;
        private Label labelDni;
        private Label labelApellido;
        private Label labelNombre;
        private Label label1;
        private Label labelCredito;
        private Label labelFechaNacimiento;
        private Label labelMail;
        private MonthCalendar mcNacimiento;
        private TextBox tbContrasenia;
        private TextBox tbEmail;
        private TextBox tbDNI;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private Button btnFunciones;
        private Button btnActualizarDatos;
        private Label label2;
        private TextBox tbCredito;
        private TextBox tbId;
    }
}