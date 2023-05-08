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
            idFuncion = new DataGridViewTextBoxColumn();
            fechaFuncion = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            costoCompra = new DataGridViewTextBoxColumn();
            btnvolver = new Button();
            btnmostrarFunciones = new Button();
            funcion_seleccionada = new TextBox();
            label9 = new Label();
            button1 = new Button();
            label2 = new Label();
            cantidadentradas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).BeginInit();
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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
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
            // btnvolver
            // 
            btnvolver.Location = new Point(743, 396);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(113, 37);
            btnvolver.TabIndex = 5;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btnmostrarFunciones
            // 
            btnmostrarFunciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmostrarFunciones.Location = new Point(88, 104);
            btnmostrarFunciones.Name = "btnmostrarFunciones";
            btnmostrarFunciones.Size = new Size(133, 27);
            btnmostrarFunciones.TabIndex = 6;
            btnmostrarFunciones.Text = "VER FUNCIONES";
            btnmostrarFunciones.UseVisualStyleBackColor = true;
            btnmostrarFunciones.Click += btnmostrarFunciones_Click;
            // 
            // funcion_seleccionada
            // 
            funcion_seleccionada.Location = new Point(264, 404);
            funcion_seleccionada.Name = "funcion_seleccionada";
            funcion_seleccionada.ReadOnly = true;
            funcion_seleccionada.Size = new Size(112, 23);
            funcion_seleccionada.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(88, 407);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 90;
            label9.Text = "Funcion Seleccionada:";
            // 
            // button1
            // 
            button1.Location = new Point(382, 427);
            button1.Name = "button1";
            button1.Size = new Size(113, 37);
            button1.TabIndex = 92;
            button1.Text = "Devolver Entradas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 440);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 93;
            label2.Text = "Cantidad a Devolver:";
            // 
            // cantidadentradas
            // 
            cantidadentradas.Location = new Point(264, 436);
            cantidadentradas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cantidadentradas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadentradas.Name = "cantidadentradas";
            cantidadentradas.Size = new Size(112, 23);
            cantidadentradas.TabIndex = 94;
            cantidadentradas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form_Usuario_Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 528);
            Controls.Add(cantidadentradas);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(funcion_seleccionada);
            Controls.Add(label9);
            Controls.Add(btnmostrarFunciones);
            Controls.Add(btnvolver);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Usuario_Funciones";
            Text = "Form_Usuario_Funciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadentradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnvolver;
        private Button btnmostrarFunciones;
        private DataGridViewTextBoxColumn idFuncion;
        private DataGridViewTextBoxColumn fechaFuncion;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn costoCompra;
        private TextBox funcion_seleccionada;
        private Label label9;
        private Button button1;
        private Label label2;
        private NumericUpDown cantidadentradas;
    }
}