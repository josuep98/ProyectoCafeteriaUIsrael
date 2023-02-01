using Aplication.ServicesEntity;
using Dominio.Model.Entities;
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
        ProductoController productoController;
        IngresoEgresoController ingresoEgresoController;

        public FrmDetalleIngreso()
        {
            detalleIngresoController = new DetalleIngresoController();
            productoController = new ProductoController();
            ingresoEgresoController = new IngresoEgresoController();
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

        private void Eliminar()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                id = Convert.ToInt32(TxtId.Text);
                if (detalleIngresoController.Eliminar(id))
                {
                    MessageBox.Show("Detalle eliminado correctamente!");
                    ListarDetalleIngresoEgresoActivo();
                }
                else
                    MessageBox.Show("ERROR! No se pudo eliminar el detalle");
            }
            else
                MessageBox.Show("ERROR! No se pudo eliminar, seleccione una fila");
        }

        private void ListarCombos()
        {
            //Combo Producto
            CbProducto.DataSource = productoController.ListarProductoActivo();
            CbProducto.ValueMember = "ProductoId";
            CbProducto.DisplayMember = "Nombre";
            //Combo Tipo de transacción
            CbIngresoEgreso.DataSource = ingresoEgresoController.ListarIngresoEgresoActivo();
            CbIngresoEgreso.ValueMember = "IngresoEgresoId";
            CbIngresoEgreso.DisplayMember = "Descripcion";

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
            detalleIngresoViewModel.ProductoId = Convert.ToInt32(CbProducto.SelectedValue);
            detalleIngresoViewModel.IngresoEgresoId = Convert.ToInt32(CbIngresoEgreso.SelectedValue);
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
            ListarCombos();
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
                CbProducto.SelectedValue = DgvDetalleIngresoEgreso.CurrentRow.Cells[5].Value;
                CbIngresoEgreso.SelectedValue = DgvDetalleIngresoEgreso.CurrentRow.Cells[6].Value;
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void DgvDetalleIngresoEgreso_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvDetalleIngresoEgreso.SelectedRows.Count > 0)
                TxtId.Text = DgvDetalleIngresoEgreso.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
