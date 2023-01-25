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
    public partial class FrmTipoTransaccion : Form
    {

        private TipoTransaccionController tipoTransaccionController;
        private TipoTransaccionViewModel tipoTransaccionViewModel;
        public FrmTipoTransaccion()
        {
            InitializeComponent();
            tipoTransaccionController = new TipoTransaccionController();
        }

        private void Insertar()
        {
            if (tipoTransaccionController.InsertarTipoTransaccion(tipoTransaccionViewModel))
            {
                MessageBox.Show("Tipo de transacción insertada correctamente!");
                ListarTipoTransaccion();
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el tipo de transacción");
        }

        private void Actualizar()
        {
            if (tipoTransaccionController.ModificarTipoTransaccion(tipoTransaccionViewModel))
            {
                MessageBox.Show("Tipo de Transacció actualizada correctamente!");
                ListarTipoTransaccion();
            }
            else
                MessageBox.Show("ERROR! No se pudo actualizar el tipo de Transacció");
        }

        private void ListarTipoTransaccion()
        {
            DgvTipoTransaccion.DataSource = tipoTransaccionController.ListarTipoTransaccion();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            tipoTransaccionViewModel = new TipoTransaccionViewModel();
            tipoTransaccionViewModel.Descripcion = TxtDescripcion.Text;
            tipoTransaccionViewModel.Estado = 1;

            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                tipoTransaccionViewModel.TipoTransaccionId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmTipoTransaccion_Load(object sender, EventArgs e)
        {
            ListarTipoTransaccion();
        }

        private void DgvTipoTransaccion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvTipoTransaccion.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvTipoTransaccion.CurrentRow.Cells[0].Value.ToString();
                TxtDescripcion.Text = DgvTipoTransaccion.CurrentRow.Cells[1].Value.ToString();
                BtnGuardar.Text = "Actualizar";
            }
        }
    }
}
