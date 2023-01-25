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
    public partial class FrmProducto : Form
    {
        private ProductoController productoController;
        private ProductoViewModel productoViewModel;
        public FrmProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void Insertar()
        {
            if (productoController.InsertarProducto(productoViewModel))
            {
                MessageBox.Show("Producto insertado correctamente!");
                ListarProductoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el producto");
        }

        private void Actualizar()
        {
            if (productoController.ModificarProducto(productoViewModel))
            {
                MessageBox.Show("Producto modificado correctamente!");
                ListarProductoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo modificador el producto");
        }

        private void ListarProductoActivo()
        {
            DgvProducto.DataSource = productoController.ListarProductoActivo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            productoViewModel = new ProductoViewModel();
            productoViewModel.Nombre = TxtNombre.Text;
            productoViewModel.Descripcion = TxtDescripcion.Text;
            productoViewModel.Stock = Convert.ToInt32(TxtStock.Text);
            productoViewModel.Pvp = Convert.ToDecimal(TxtPvp.Text);
            productoViewModel.CategoriaId = Convert.ToInt32(TxtCategoriaId.Text);
            productoViewModel.Estado = 1;

            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                productoViewModel.ProductoId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductoActivo();
        }

        private void DgvProducto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvProducto.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgvProducto.CurrentRow.Cells[1].Value.ToString();
                TxtDescripcion.Text = DgvProducto.CurrentRow.Cells[2].Value.ToString();
                TxtStock.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                TxtPvp.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                TxtCategoriaId.Text = DgvProducto.CurrentRow.Cells[5].Value.ToString();
                BtnGuardar.Text = "Actualizar";
            }
        }
    }
}
