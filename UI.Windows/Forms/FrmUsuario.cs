using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows.Forms
{
    public partial class FrmUsuario : Form
    {

        private UsuarioController usuarioController;
        private UsuarioViewModel usuarioViewModel;
        public FrmUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void Insertar()
        {
            if (usuarioController.InsertarUsuario(usuarioViewModel))
            {
                MessageBox.Show("Usuario insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el usuario");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.NombreUsuario = TxtNombreUsuario.Text;
            usuarioViewModel.Nombres = TxtNombres.Text;
            usuarioViewModel.Pass = TxtPass.Text;
            usuarioViewModel.Rol = TxtRol.Text;
            usuarioViewModel.Estado = 1;
            Insertar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
