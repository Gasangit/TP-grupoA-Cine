using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP_grupoA_Cine.AMB_Funciones;

namespace TP_grupoA_Cine
{
    public partial class ABM_Usuarios : Form //Form de Usuarios
    {
        public DelegadoUsuario TransfEvento_UsuarioBotonera;
        private Cine cine;
        private int selectedUser;
        public ABM_Usuarios()
        {
            InitializeComponent();
            cine = Cine.Instancia;
            selectedUser = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedUser = -1;
        }

        private void refreshData()
        {
            //borro los datos
            dataGridView1.Rows.Clear();
            //agrego lo nuevo
            foreach (Usuario u in cine.mostrarUsuarios())
                dataGridView1.Rows.Add(u.ToString());

            //borro los datos en los text box
            nombreusuario.Text = "";
            apellidousuario.Text = "";
            dniusuario.Text = "";
            mailusuario.Text = "";
            passwordusuario.Text = "";
            nacimientousuario.Text = "";
            esadmin.Text = "";
            usuariobloqueado.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string nombreUser = dataGridView1[1, e.RowIndex].Value.ToString();
            string apellidoUser = dataGridView1[2, e.RowIndex].Value.ToString();
            string dniUser = dataGridView1[3, e.RowIndex].Value.ToString();
            string mailUser = dataGridView1[4, e.RowIndex].Value.ToString();
            string passUser = dataGridView1[5, e.RowIndex].Value.ToString();
            string fecNacUser = dataGridView1[6, e.RowIndex].Value.ToString();
            string adminUser = dataGridView1[7, e.RowIndex].Value.ToString();
            string bloqUser = dataGridView1[8, e.RowIndex].Value.ToString();


            selectedUser = int.Parse(ID);
            nombreusuario.Text = nombreUser;
            apellidousuario.Text = apellidoUser;
            dniusuario.Text = dniUser;
            mailusuario.Text = mailUser;
            passwordusuario.Text = passUser;
            nacimientousuario.Text = fecNacUser;
            esadmin.Text = adminUser;
            usuariobloqueado.Text = bloqUser;
        }


        private void btnvolver_usuario_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioBotonera();
        }

        private void btnalta_usuario_Click(object sender, EventArgs e)
        {

            bool esAdmin;
            bool bloqueado;

            if (esadmin.Text.ToLower() == "no") { esAdmin = false; }
            else { esAdmin = true; }

            if (usuariobloqueado.Text.ToLower() == "no") { bloqueado = false; }
            else { bloqueado = true; }

            //  if (esadmin.Text.ToLower() == "si") esAdmin = true;

            if (mailusuario.Text == "" || dniusuario.Text == "" || mailusuario.Text == null || dniusuario.Text == null ||
                nombreusuario.Text == "" || apellidousuario.Text == "" || nombreusuario.Text == null || apellidousuario.Text == null ||
                passwordusuario.Text == "" || nacimientousuario.Text == "" || passwordusuario.Text == null || nacimientousuario.Text == null)
            {
                MessageBox.Show("Debe completar los datos para agregar", "ERROR");
            }
            else if (dniusuario.Text.Length != 8 && dniusuario.Text.Length != 7)

            {
                MessageBox.Show("Difiere la cantidad de digitos en el DNI. Deben ser 8 o 7 digitos");
            }
            else
            {
                if (cine.altaUsuario(int.Parse(dniusuario.Text), nombreusuario.Text, apellidousuario.Text, mailusuario.Text, passwordusuario.Text, DateTime.Parse(nacimientousuario.Text), esAdmin, bloqueado))
                {

                    MessageBox.Show("Agregado con éxito", "OK");
                }
                else
                {
                    MessageBox.Show("Problemas al agregar o DNI ya existente", "ERROR");

                }
            }
        }

        private void btnmodificar_usuario_Click(object sender, EventArgs e)
        {
            bool esAdmin;
            bool bloqueado;

            if (esadmin.Text.ToLower() != "true") { esAdmin = false; }
            else { esAdmin = true; }

            if (usuariobloqueado.Text.ToLower() != "true") { bloqueado = false; }
            else { bloqueado = true; }


            if (selectedUser != -1)
            {
                if (cine.modificarUsuario(selectedUser, int.Parse(dniusuario.Text), nombreusuario.Text, apellidousuario.Text, mailusuario.Text, passwordusuario.Text, DateTime.Parse(nacimientousuario.Text), esAdmin, bloqueado))
                    MessageBox.Show("Usuario modificado con éxito", "OK");
                else
                    MessageBox.Show("Error al modificar","ERROR!!");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "ERROR");
            }

        }

        private void btnbaja_usuario_Click(object sender, EventArgs e)
        {
            if (selectedUser != -1)
            {
                cine.eliminarUsuario(selectedUser);
                MessageBox.Show("Usuario Eliminado con éxito", "OK");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "ERROR");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public delegate void DelegadoUsuario();


    }
}
