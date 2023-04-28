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
            btnbaja_sala = new Button();
            btnmodificar_sala = new Button();
            btnalta_sala = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            capacidadsala_text = new TextBox();
            ubicacionsala_text = new TextBox();
            label2 = new Label();
            idsala_text = new TextBox();
            panel1 = new Panel();
            btnvolver_salas = new Button();
            btnmostrar_sala = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ubicacion, capacidad });
            dataGridView1.Location = new Point(287, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(394, 185);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
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
            // btnbaja_sala
            // 
            btnbaja_sala.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbaja_sala.Location = new Point(429, 113);
            btnbaja_sala.Name = "btnbaja_sala";
            btnbaja_sala.Size = new Size(84, 27);
            btnbaja_sala.TabIndex = 37;
            btnbaja_sala.Text = "BAJA";
            btnbaja_sala.UseVisualStyleBackColor = true;
            btnbaja_sala.Click += btnbaja_sala_Click;
            // 
            // btnmodificar_sala
            // 
            btnmodificar_sala.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmodificar_sala.Location = new Point(519, 113);
            btnmodificar_sala.Name = "btnmodificar_sala";
            btnmodificar_sala.Size = new Size(113, 27);
            btnmodificar_sala.TabIndex = 36;
            btnmodificar_sala.Text = "MODIFICAR";
            btnmodificar_sala.UseVisualStyleBackColor = true;
            btnmodificar_sala.Click += btnmodificar_sala_Click;
            // 
            // btnalta_sala
            // 
            btnalta_sala.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnalta_sala.Location = new Point(329, 113);
            btnalta_sala.Name = "btnalta_sala";
            btnalta_sala.Size = new Size(86, 27);
            btnalta_sala.TabIndex = 35;
            btnalta_sala.Text = "ALTA";
            btnalta_sala.UseVisualStyleBackColor = true;
            btnalta_sala.Click += btnalta_sala_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(434, 17);
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
            label4.Location = new Point(562, 72);
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
            label1.Location = new Point(434, 72);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 30;
            label1.Text = "Ubicación";
            // 
            // capacidadsala_text
            // 
            capacidadsala_text.Location = new Point(547, 46);
            capacidadsala_text.Name = "capacidadsala_text";
            capacidadsala_text.Size = new Size(100, 23);
            capacidadsala_text.TabIndex = 29;
            // 
            // ubicacionsala_text
            // 
            ubicacionsala_text.Location = new Point(429, 46);
            ubicacionsala_text.Name = "ubicacionsala_text";
            ubicacionsala_text.Size = new Size(100, 23);
            ubicacionsala_text.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 72);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 40;
            label2.Text = "Id";
            // 
            // idsala_text
            // 
            idsala_text.Location = new Point(303, 46);
            idsala_text.Name = "idsala_text";
            idsala_text.ReadOnly = true;
            idsala_text.Size = new Size(100, 23);
            idsala_text.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnvolver_salas);
            panel1.Controls.Add(btnmostrar_sala);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idsala_text);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(ubicacionsala_text);
            panel1.Controls.Add(capacidadsala_text);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnalta_sala);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnmodificar_sala);
            panel1.Controls.Add(btnbaja_sala);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 534);
            panel1.TabIndex = 41;
            // 
            // btnvolver_salas
            // 
            btnvolver_salas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvolver_salas.Location = new Point(382, 396);
            btnvolver_salas.Name = "btnvolver_salas";
            btnvolver_salas.Size = new Size(198, 31);
            btnvolver_salas.TabIndex = 42;
            btnvolver_salas.Text = "VOLVER A BOTONERA";
            btnvolver_salas.UseVisualStyleBackColor = true;
            btnvolver_salas.Click += btnvolver_salas_Click;
            // 
            // btnmostrar_sala
            // 
            btnmostrar_sala.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmostrar_sala.Location = new Point(393, 153);
            btnmostrar_sala.Name = "btnmostrar_sala";
            btnmostrar_sala.Size = new Size(167, 29);
            btnmostrar_sala.TabIndex = 41;
            btnmostrar_sala.Text = "MOSTRAR DATOS";
            btnmostrar_sala.UseVisualStyleBackColor = true;
            btnmostrar_sala.Click += btnmostrar_sala_Click;
            // 
            // ABM_Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 534);
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
        private Button btnbaja_sala;
        private Button btnmodificar_sala;
        private Button btnalta_sala;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox capacidadsala_text;
        private TextBox ubicacionsala_text;
        private Label label2;
        private TextBox idsala_text;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ubicacion;
        private DataGridViewTextBoxColumn capacidad;
        private Panel panel1;
        private Button btnvolver_salas;
        private Button btnmostrar_sala;
    }
}