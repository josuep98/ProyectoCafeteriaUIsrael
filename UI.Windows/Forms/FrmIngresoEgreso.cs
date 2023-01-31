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
        public int Id;
        public FrmIngresoEgreso()
        {
            InitializeComponent();
            ingresoEgresoController = new IngresoEgresoController();
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

        private void ListarIngresoEgresoActivo()
        {
            DgvIngresoEgreso.DataSource = ingresoEgresoController.ListarIngresoEgresoActivo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ingresoEgresoViewModel = new IngresoEgresoViewModel();
            ingresoEgresoViewModel.FechaHora = DtpFechaHora.Value;
            ingresoEgresoViewModel.Descripcion = TxtDescripcion.Text;
            ingresoEgresoViewModel.TipoTransaccionId = Convert.ToInt32(TxtTipoTransaccionId.Text);
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
        }

        private void DgvIngresoEgreso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvIngresoEgreso.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvIngresoEgreso.CurrentRow.Cells[0].Value.ToString();
                DtpFechaHora.Value = Convert.ToDateTime(DgvIngresoEgreso.CurrentRow.Cells[1].Value.ToString());
                TxtDescripcion.Text = DgvIngresoEgreso.CurrentRow.Cells[2].Value.ToString();
                TxtTipoTransaccionId.Text = DgvIngresoEgreso.CurrentRow.Cells[3].Value.ToString();
                BtnGuardar.Text = "Actualizar";
            }
        }

    }
}
