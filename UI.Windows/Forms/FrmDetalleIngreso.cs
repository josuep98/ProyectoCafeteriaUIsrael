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
                ListarDetalleIngresoEgresoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el detalle del ingreso/egreso");
        }

        private void Actualizar()
        {
            if (detalleIngresoController.InsertarDetalleIngreso(detalleIngresoViewModel))
            {
                MessageBox.Show("Detalle del ingreso/egreso actualizado correctamente!");
                ListarDetalleIngresoEgresoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo actualizar el detalle del ingreso/egreso");
        }

        private void ListarDetalleIngresoEgresoActivo()
        {
            DgvDetalleIngresoEgreso.DataSource = detalleIngresoController.ListarDetalleIngresoEgresoActivo();
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

            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                detalleIngresoViewModel.DetalleIngresoId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalleIngreso_Load(object sender, EventArgs e)
        {
            ListarDetalleIngresoEgresoActivo();
        }

        private void DgvDetalleIngresoEgreso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvDetalleIngresoEgreso.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[0].Value.ToString();
                TxtCantidad.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[1].Value.ToString();
                TxtPrecioUnitario.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[2].Value.ToString();
                TxtPrecioFinal.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[3].Value.ToString();
                TxtDescripcion.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[4].Value.ToString();
                TxtProductoId.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[5].Value.ToString();
                TxtIngresoEgresoId.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[6].Value.ToString();
                BtnGuardar.Text = "Actualizar";
            }
        }
    }
}
