namespace TP_grupoA_Cine
{
    partial class Form_Usuario_Funciones
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnvolver = new Button();
            idFuncion = new DataGridViewTextBoxColumn();
            fechaFuncion = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            costoCompra = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 44);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 3;
            label1.Text = "Mis Funciones";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idFuncion, fechaFuncion, pelicula, sala, cantidad, costoCompra });
            dataGridView1.Location = new Point(88, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(768, 241);
            dataGridView1.TabIndex = 4;
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(424, 404);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(113, 37);
            btnvolver.TabIndex = 5;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // idFuncion
            // 
            idFuncion.Frozen = true;
            idFuncion.HeaderText = "ID Funcion";
            idFuncion.Name = "idFuncion";
            idFuncion.ReadOnly = true;
            // 
            // fechaFuncion
            // 
            fechaFuncion.Frozen = true;
            fechaFuncion.HeaderText = "Fecha Funcion";
            fechaFuncion.Name = "fechaFuncion";
            fechaFuncion.ReadOnly = true;
            // 
            // pelicula
            // 
            pelicula.Frozen = true;
            pelicula.HeaderText = "Pelicula";
            pelicula.Name = "pelicula";
            pelicula.ReadOnly = true;
            // 
            // sala
            // 
            sala.Frozen = true;
            sala.HeaderText = "Sala";
            sala.Name = "sala";
            sala.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.Frozen = true;
            cantidad.HeaderText = "Cantidad Entradas";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // costoCompra
            // 
            costoCompra.Frozen = true;
            costoCompra.HeaderText = "Costo Compra";
            costoCompra.Name = "costoCompra";
            costoCompra.ReadOnly = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(88, 104);
            button1.Name = "button1";
            button1.Size = new Size(133, 27);
            button1.TabIndex = 6;
            button1.Text = "VER FUNCIONES";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_Usuario_Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 528);
            Controls.Add(button1);
            Controls.Add(btnvolver);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Usuario_Funciones";
            Text = "Form_Usuario_Funciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnvolver;
        private DataGridViewTextBoxColumn idFuncion;
        private DataGridViewTextBoxColumn fechaFuncion;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn costoCompra;
        private Button button1;
    }
}