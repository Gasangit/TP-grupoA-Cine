namespace TP_grupoA_Cine
{
    partial class ABM_Usuarios
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
            dataGridViewTextBoxColumn1 = new DataGridViewCheckBoxColumn();
            bloqueado = new DataGridViewCheckBoxColumn();
            btnbaja_usuario = new Button();
            btnmodificar_usuario = new Button();
            btnalta_usuario = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            apellidousuario = new TextBox();
            dniusuario = new TextBox();
            mailusuario = new TextBox();
            nombreusuario = new TextBox();
            label6 = new Label();
            passwordusuario = new TextBox();
            nacimientousuario = new TextBox();
            esadmin = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            usuariobloqueado = new ComboBox();
            btnmostrar_usuarios = new Button();
            panel1 = new Panel();
            btnvolver_usuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, dni, mail, password, fechaNacimiento, dataGridViewTextBoxColumn1, bloqueado });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 225);
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Administrador?";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // bloqueado
            // 
            bloqueado.Frozen = true;
            bloqueado.HeaderText = "Bloqueado?";
            bloqueado.Name = "bloqueado";
            bloqueado.ReadOnly = true;
            bloqueado.Resizable = DataGridViewTriState.True;
            bloqueado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnbaja_usuario
            // 
            btnbaja_usuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbaja_usuario.Location = new Point(529, 413);
            btnbaja_usuario.Name = "btnbaja_usuario";
            btnbaja_usuario.Size = new Size(132, 36);
            btnbaja_usuario.TabIndex = 37;
            btnbaja_usuario.Text = "BAJA";
            btnbaja_usuario.UseVisualStyleBackColor = true;
            btnbaja_usuario.Click += btnbaja_usuario_Click;
            // 
            // btnmodificar_usuario
            // 
            btnmodificar_usuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmodificar_usuario.Location = new Point(391, 413);
            btnmodificar_usuario.Name = "btnmodificar_usuario";
            btnmodificar_usuario.Size = new Size(112, 36);
            btnmodificar_usuario.TabIndex = 36;
            btnmodificar_usuario.Text = "MODIFICAR";
            btnmodificar_usuario.UseVisualStyleBackColor = true;
            btnmodificar_usuario.Click += btnmodificar_usuario_Click;
            // 
            // btnalta_usuario
            // 
            btnalta_usuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnalta_usuario.Location = new Point(228, 413);
            btnalta_usuario.Name = "btnalta_usuario";
            btnalta_usuario.Size = new Size(137, 36);
            btnalta_usuario.TabIndex = 35;
            btnalta_usuario.Text = "ALTA";
            btnalta_usuario.UseVisualStyleBackColor = true;
            btnalta_usuario.Click += btnalta_usuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(404, 9);
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
            label4.Location = new Point(53, 292);
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
            label3.Location = new Point(301, 346);
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
            label2.Location = new Point(301, 292);
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
            label1.Location = new Point(53, 346);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // apellidousuario
            // 
            apellidousuario.Location = new Point(53, 315);
            apellidousuario.Name = "apellidousuario";
            apellidousuario.Size = new Size(216, 23);
            apellidousuario.TabIndex = 29;
            // 
            // dniusuario
            // 
            dniusuario.Location = new Point(293, 369);
            dniusuario.Name = "dniusuario";
            dniusuario.Size = new Size(149, 23);
            dniusuario.TabIndex = 28;
            // 
            // mailusuario
            // 
            mailusuario.Location = new Point(293, 315);
            mailusuario.Name = "mailusuario";
            mailusuario.Size = new Size(401, 23);
            mailusuario.TabIndex = 27;
            // 
            // nombreusuario
            // 
            nombreusuario.Location = new Point(53, 369);
            nombreusuario.Name = "nombreusuario";
            nombreusuario.Size = new Size(216, 23);
            nombreusuario.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 401);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 40;
            label6.Text = "Password";
            // 
            // passwordusuario
            // 
            passwordusuario.Location = new Point(53, 422);
            passwordusuario.Name = "passwordusuario";
            passwordusuario.Size = new Size(137, 23);
            passwordusuario.TabIndex = 39;
            // 
            // nacimientousuario
            // 
            nacimientousuario.Location = new Point(471, 369);
            nacimientousuario.Name = "nacimientousuario";
            nacimientousuario.Size = new Size(223, 23);
            nacimientousuario.TabIndex = 43;
            // 
            // esadmin
            // 
            esadmin.FormattingEnabled = true;
            esadmin.Items.AddRange(new object[] { "SI", "NO" });
            esadmin.Location = new Point(737, 325);
            esadmin.Name = "esadmin";
            esadmin.Size = new Size(121, 23);
            esadmin.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(471, 346);
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
            label8.Location = new Point(736, 303);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 46;
            label8.Text = "Admin?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(736, 354);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 48;
            label9.Text = "Bloqueado?";
            // 
            // usuariobloqueado
            // 
            usuariobloqueado.FormattingEnabled = true;
            usuariobloqueado.Items.AddRange(new object[] { "SI", "NO" });
            usuariobloqueado.Location = new Point(737, 377);
            usuariobloqueado.Name = "usuariobloqueado";
            usuariobloqueado.Size = new Size(121, 23);
            usuariobloqueado.TabIndex = 47;
            // 
            // btnmostrar_usuarios
            // 
            btnmostrar_usuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmostrar_usuarios.Location = new Point(12, 26);
            btnmostrar_usuarios.Name = "btnmostrar_usuarios";
            btnmostrar_usuarios.Size = new Size(168, 36);
            btnmostrar_usuarios.TabIndex = 49;
            btnmostrar_usuarios.Text = "MOSTRAR DATOS";
            btnmostrar_usuarios.UseVisualStyleBackColor = true;
            btnmostrar_usuarios.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnvolver_usuarios);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnmodificar_usuario);
            panel1.Controls.Add(btnbaja_usuario);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnalta_usuario);
            panel1.Controls.Add(usuariobloqueado);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnmostrar_usuarios);
            panel1.Controls.Add(esadmin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(nacimientousuario);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(nombreusuario);
            panel1.Controls.Add(apellidousuario);
            panel1.Controls.Add(dniusuario);
            panel1.Controls.Add(passwordusuario);
            panel1.Controls.Add(mailusuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 534);
            panel1.TabIndex = 50;
            // 
            // btnvolver_usuarios
            // 
            btnvolver_usuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvolver_usuarios.Location = new Point(678, 411);
            btnvolver_usuarios.Name = "btnvolver_usuarios";
            btnvolver_usuarios.Size = new Size(180, 38);
            btnvolver_usuarios.TabIndex = 52;
            btnvolver_usuarios.Text = "VOLVER A BOTONERA";
            btnvolver_usuarios.UseVisualStyleBackColor = true;
            btnvolver_usuarios.Click += btnvolver_usuario_Click;
            // 
            // ABM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 534);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABM_Usuarios";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnbaja_usuario;
        private Button btnmodificar_usuario;
        private Button btnalta_usuario;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox apellidousuario;
        private TextBox dniusuario;
        private TextBox mailusuario;
        private TextBox nombreusuario;
        private Label label6;
        private TextBox passwordusuario;
        private TextBox nacimientousuario;
        private ComboBox esadmin;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox usuariobloqueado;
        private Button btnmostrar_usuarios;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn bloqueado;
        private Button btnvolver_usuarios;
    }
}