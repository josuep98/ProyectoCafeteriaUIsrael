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
        private CategoriaController categoriaController;
        public FrmProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
            categoriaController = new CategoriaController();
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

        private void Eliminar()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                id = Convert.ToInt32(TxtId.Text);
                if (productoController.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado correctamente!");
                    ListarProductoActivo();
                }
                else
                    MessageBox.Show("ERROR! No se pudo eliminar el producto");
            }
            else
                MessageBox.Show("ERROR! No se pudo eliminar, seleccione una fila");
        }

        private void ListarProductoActivo()
        {
            DgvProducto.DataSource = productoController.ListarProductoActivo();
        }

        private void ListarCombo()
        {
            CbCategoria.DataSource = categoriaController.ListarCategoriasActivas();
            CbCategoria.ValueMember = "CategoriaId";
            CbCategoria.DisplayMember = "Descripcion";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            productoViewModel = new ProductoViewModel();
            productoViewModel.Nombre = TxtNombre.Text;
            productoViewModel.Descripcion = TxtDescripcion.Text;
            productoViewModel.Stock = Convert.ToInt32(TxtStock.Text);
            productoViewModel.Pvp = Convert.ToDecimal(TxtPvp.Text);
            productoViewModel.CategoriaId = Convert.ToInt32(CbCategoria.SelectedValue);
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
            ListarCombo();
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
                CbCategoria.SelectedValue = DgvProducto.CurrentRow.Cells[5].Value;
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void DgvProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
                TxtId.Text = DgvProducto.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

    }
}
