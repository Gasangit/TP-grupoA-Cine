using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_grupoA_Cine
{
    public partial class Form_Usuario_Activo : Form
    {

        public TransfDelegado TransfEvento_UsuarioActivoCartelera;
        private Cine cine;
        private int selectedUserActive;

        public Form_Usuario_Activo()
        {
            InitializeComponent();
            cine = Cine.Instancia;
            selectedUserActive = -1;
        }

        public delegate void TransfDelegado();

        //private void button(object sender, EventArgs e)
        //{
        //    refreshData();
        //    selectedUserActive = -1;
        //}

        //private void refreshData()
        //{
        //    dataGridView1.Rows.Clear();

        //    foreach (Usuario u in cine.mostrarUsuarios())
        //        dataGridView1.Rows.Add(u.ToString());

        //    mailusuario.Text = "";
        //    passwordusuario.Text = "";

        //}

        //private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string ID = dataGridView1[0, e.RowIndex].Value.ToString();
        //    string mailUser = dataGridView1[1, e.RowIndex].Value.ToString();
        //    string passUser = dataGridView1[2, e.RowIndex].Value.ToString();

        //    selectedUserActive = int.Parse(ID);
        //    mailusuario.Text = mailUser;
        //    passwordusuario.Text = passUser;

        //}


        //private void botonmodificar(object sender, EventArgs e)
        //{
        //    if (selectedUserActive != -1)
        //    {
        //        if (cine.modificacionUsuarioActual(selectedUserActive, mailusuario.Tex, passwordusuario.Text))
        //            MessageBox.Show("Tu usuario fue modificado con éxito");
        //        else
        //            MessageBox.Show("error al modificar");
        //    }
        //}

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioActivoCartelera();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
