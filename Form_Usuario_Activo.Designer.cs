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
            btnactualizar = new Button();
            btnvolver = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnactualizar);
            panel1.Controls.Add(btnvolver);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 534);
            panel1.TabIndex = 0;
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
            // Form_Usuario_Activo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Usuario_Activo";
            Text = "Form_Usuario_Activo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnactualizar;
        private Button btnvolver;
    }
}