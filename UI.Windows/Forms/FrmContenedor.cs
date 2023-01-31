using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Forms
{
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuDesplegable_Click(object sender, EventArgs e)
        {
            if (PnMenuVertical.Width == 188)
                PnMenuVertical.Width = 85;
            else
                PnMenuVertical.Width = 188;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnReducir.Visible = true;
            BtnMaximizar.Visible = false;
        }

        private void BtnReducir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnReducir.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.PnContenedor.Controls.Count > 0)
                this.PnContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnContenedor.Controls.Add(fh);
            this.PnContenedor.Tag = fh;
            fh.Show();
        }
        private void MnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCategoria());
        }

        private void MnTipoTransaccion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmTipoTransaccion());
        }

        private void MnIngresoEgreso_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmIngresoEgreso());
        }

        private void MnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmProducto());
        }

        private void BtnDetalleIngresoEgreso_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDetalleIngreso());
        }
    }
}
