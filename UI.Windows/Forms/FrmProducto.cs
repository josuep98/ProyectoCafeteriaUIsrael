﻿using System;
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
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el producto");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            productoViewModel = new ProductoViewModel();
            productoViewModel.Nombre = TxtNombre.Text;
            productoViewModel.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            productoViewModel.Costo = Convert.ToDecimal(TxtCosto.Text);
            productoViewModel.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            productoViewModel.Estado = 1;
            Insertar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
