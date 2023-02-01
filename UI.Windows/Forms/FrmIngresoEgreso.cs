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
    public partial class FrmIngresoEgreso : Form
    {
        private IngresoEgresoController ingresoEgresoController;
        private IngresoEgresoViewModel ingresoEgresoViewModel;
        private TipoTransaccionController transaccionController;
        public FrmIngresoEgreso()
        {
            InitializeComponent();
            ingresoEgresoController = new IngresoEgresoController();
            transaccionController = new TipoTransaccionController();
        }

        private void Insertar()
        {
            if (ingresoEgresoController.InsertarIngresoEgreso(ingresoEgresoViewModel))
            {
                MessageBox.Show("Ingreso/Egreso insertado correctamente!");
                ListarIngresoEgresoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el ingreso/egreso");
        }

        private void Actualizar()
        {
            if (ingresoEgresoController.ModificarIngresoEgreso(ingresoEgresoViewModel))
            {
                MessageBox.Show("Ingreso/Egreso actualizado correctamente!");
                ListarIngresoEgresoActivo();
            }
            else
                MessageBox.Show("ERROR! No se pudo actualizar el ingreso/egreso");
        }

        private void Eliminar()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                id = Convert.ToInt32(TxtId.Text);
                if (ingresoEgresoController.Eliminar(id))
                {
                    MessageBox.Show("Ingreso/Egreso eliminado correctamente!");
                    ListarIngresoEgresoActivo();
                }
                else
                    MessageBox.Show("ERROR! No se pudo eliminar la cabecera");
            }
            else
                MessageBox.Show("ERROR! No se pudo eliminar, seleccione una fila");
        }

        private void ListarIngresoEgresoActivo()
        {
            DgvIngresoEgreso.DataSource = ingresoEgresoController.ListarIngresoEgresoActivo();
        }

        private void ListarCombo()
        {
            CbTipoTransaccion.DataSource = transaccionController.ListarTipoTransaccion();
            CbTipoTransaccion.ValueMember = "TipoTransaccionId";
            CbTipoTransaccion.DisplayMember = "Descripcion";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ingresoEgresoViewModel = new IngresoEgresoViewModel();
            ingresoEgresoViewModel.FechaHora = DtpFechaHora.Value;
            ingresoEgresoViewModel.Descripcion = TxtDescripcion.Text;
            ingresoEgresoViewModel.TipoTransaccionId = Convert.ToInt32(CbTipoTransaccion.SelectedValue);
            ingresoEgresoViewModel.Estado = 1;

            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                ingresoEgresoViewModel.IngresoEgresoId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIngresoEgreso_Load(object sender, EventArgs e)
        {
            ListarIngresoEgresoActivo();
            ListarCombo();
        }

        private void DgvIngresoEgreso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvIngresoEgreso.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvIngresoEgreso.CurrentRow.Cells[0].Value.ToString();
                DtpFechaHora.Value = Convert.ToDateTime(DgvIngresoEgreso.CurrentRow.Cells[1].Value.ToString());
                TxtDescripcion.Text = DgvIngresoEgreso.CurrentRow.Cells[2].Value.ToString();
                CbTipoTransaccion.SelectedValue = DgvIngresoEgreso.CurrentRow.Cells[3].Value;
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void DgvIngresoEgreso_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvIngresoEgreso.SelectedRows.Count > 0)
                TxtId.Text = DgvIngresoEgreso.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
