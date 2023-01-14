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
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el ingreso/egreso");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ingresoEgresoViewModel = new IngresoEgresoViewModel();
            ingresoEgresoViewModel.FechaHora = DtpFechaHora.Value;
            ingresoEgresoViewModel.Descripcion = TxtDescripcion.Text;
            ingresoEgresoViewModel.TipoTransaccionId = Convert.ToInt32(TxtTipoTransaccionId);
            ingresoEgresoViewModel.Estado = 1;
            Insertar();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
