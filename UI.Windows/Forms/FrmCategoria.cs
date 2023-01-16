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
    public partial class FrmCategoria : Form
    {
        private CategoriaController categoriaController;
        private CategoriaViewModel categoriaViewModel;

        public FrmCategoria()
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
        }

        private void Insertar()
        {
            if (categoriaController.InsertarCategoria(categoriaViewModel))
            {
                MessageBox.Show("Categoria insertada correctamente!");
                ListarCategoriasActivas();
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar la categoria");
        }

        private void ListarCategoriasActivas()
        {
            DgvCategoria.DataSource = categoriaController.ListarCategoriasActivas();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            categoriaViewModel = new CategoriaViewModel();
            categoriaViewModel.Descripcion = TxtDescripcion.Text;
            categoriaViewModel.Estado = 1;
            Insertar();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ListarCategoriasActivas();
        }
    }
}
