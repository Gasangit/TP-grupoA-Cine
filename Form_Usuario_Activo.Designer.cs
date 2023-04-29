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
            labelDni = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            label1 = new Label();
            btnactualizar = new Button();
            btnvolver = new Button();
            labelMail = new Label();
            labelFechaNacimiento = new Label();
            labelCredito = new Label();
            labelMisFunciones = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(labelMisFunciones);
            panel1.Controls.Add(labelCredito);
            panel1.Controls.Add(labelFechaNacimiento);
            panel1.Controls.Add(labelMail);
            panel1.Controls.Add(labelDni);
            panel1.Controls.Add(labelApellido);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnactualizar);
            panel1.Controls.Add(btnvolver);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 534);
            panel1.TabIndex = 0;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Location = new Point(269, 206);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(50, 15);
            labelDni.TabIndex = 5;
            labelDni.Text = "dni aqui";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(269, 165);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(75, 15);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "apellido aqui";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(269, 130);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(75, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "nombre aqui";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(338, 36);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 2;
            label1.Text = "Esta es su información";
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(540, 434);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(142, 27);
            btnactualizar.TabIndex = 1;
            btnactualizar.Text = "ACTUALIZAR DATOS";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(269, 434);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(94, 27);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(269, 237);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(56, 15);
            labelMail.TabIndex = 6;
            labelMail.Text = "mail aqui";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(269, 308);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(125, 15);
            labelFechaNacimiento.TabIndex = 7;
            labelFechaNacimiento.Text = "fecha nacimiento aqui";
            // 
            // labelCredito
            // 
            labelCredito.AutoSize = true;
            labelCredito.Location = new Point(269, 274);
            labelCredito.Name = "labelCredito";
            labelCredito.Size = new Size(70, 15);
            labelCredito.TabIndex = 8;
            labelCredito.Text = "credito aqui";
            // 
            // labelMisFunciones
            // 
            labelMisFunciones.AutoSize = true;
            labelMisFunciones.Location = new Point(599, 130);
            labelMisFunciones.Name = "labelMisFunciones";
            labelMisFunciones.Size = new Size(83, 15);
            labelMisFunciones.TabIndex = 9;
            labelMisFunciones.Text = "Mis Funciones";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(599, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 10;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnactualizar;
        private Button btnvolver;
        private Label labelDni;
        private Label labelApellido;
        private Label labelNombre;
        private Label label1;
        private Label labelCredito;
        private Label labelFechaNacimiento;
        private Label labelMail;
        private DataGridView dataGridView1;
        private Label labelMisFunciones;
    }
}