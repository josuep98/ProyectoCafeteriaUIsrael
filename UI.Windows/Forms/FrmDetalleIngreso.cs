using Aplication.ServicesEntity;
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
    public partial class FrmDetalleIngreso : Form
    {
        DetalleIngresoController detalleIngresoController;
        DetalleIngresoViewModel detalleIngresoViewModel;
        public FrmDetalleIngreso()
        {
            detalleIngresoController = new DetalleIngresoController();
            InitializeComponent();
        }

        private void Insertar()
        {
            if (detalleIngresoController.InsertarDetalleIngreso(detalleIngresoViewModel))
            {
                MessageBox.Show("Detalle del ingreso/egreso insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el detalle del ingreso/egreso");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            detalleIngresoViewModel = new DetalleIngresoViewModel();
            detalleIngresoViewModel.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            detalleIngresoViewModel.PrecioUnitario = Convert.ToDecimal(TxtPrecioUnitario.Text);
            detalleIngresoViewModel.PrecioFinal = Convert.ToDecimal(TxtPrecioFinal.Text);
            detalleIngresoViewModel.Descripcion = TxtDescripcion.Text;
            detalleIngresoViewModel.ProductoId = Convert.ToInt32(TxtPrecioFinal.Text);
            detalleIngresoViewModel.IngresoEgresoId = Convert.ToInt32(TxtIngresoEgresoId.Text);
            detalleIngresoViewModel.Estado = 1;
            Insertar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
