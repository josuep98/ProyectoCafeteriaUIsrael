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
    public partial class FrmCliente : Form
    {
        private ClienteController clienteController;
        private ClienteViewModel clienteViewModel;

        public FrmCliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void Insertar()
        {
            if (clienteController.InsertarCliente(clienteViewModel))
            {
                MessageBox.Show("Cliente insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el cliente");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            clienteViewModel = new ClienteViewModel();
            clienteViewModel.Nombres = TxtNombres.Text;
            clienteViewModel.Direccion = TxtDireccion.Text;
            clienteViewModel.Telefono = TxtTelefono.Text;
            clienteViewModel.Identificacion = TxtIdentificacion.Text;
            clienteViewModel.TipoIdentificacion = (short?)Convert.ToInt32(TxtTipoIdentificacion.Text);
            clienteViewModel.Estado = 1;
            Insertar();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
