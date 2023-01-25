namespace UI.Windows.Forms
{
    partial class FrmIngresoEgreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtTipoTransaccionId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.DgvIngresoEgreso = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresoEgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(508, 120);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 25;
            this.BtnRegresar.Text = "Cerrar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(508, 89);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTipoTransaccionId
            // 
            this.TxtTipoTransaccionId.Location = new System.Drawing.Point(246, 156);
            this.TxtTipoTransaccionId.Name = "TxtTipoTransaccionId";
            this.TxtTipoTransaccionId.Size = new System.Drawing.Size(222, 22);
            this.TxtTipoTransaccionId.TabIndex = 21;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(246, 120);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(222, 22);
            this.TxtDescripcion.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "TipoTransaccionId: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha/Hora: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingreso/Egreso";
            // 
            // DtpFechaHora
            // 
            this.DtpFechaHora.Location = new System.Drawing.Point(246, 87);
            this.DtpFechaHora.Name = "DtpFechaHora";
            this.DtpFechaHora.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaHora.TabIndex = 26;
            // 
            // DgvIngresoEgreso
            // 
            this.DgvIngresoEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIngresoEgreso.Location = new System.Drawing.Point(51, 210);
            this.DgvIngresoEgreso.Name = "DgvIngresoEgreso";
            this.DgvIngresoEgreso.RowHeadersWidth = 51;
            this.DgvIngresoEgreso.RowTemplate.Height = 24;
            this.DgvIngresoEgreso.Size = new System.Drawing.Size(532, 150);
            this.DgvIngresoEgreso.TabIndex = 27;
            this.DgvIngresoEgreso.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvIngresoEgreso_CellMouseDoubleClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(162, 51);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(0, 22);
            this.TxtId.TabIndex = 28;
            this.TxtId.Visible = false;
            // 
            // FrmIngresoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 406);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DgvIngresoEgreso);
            this.Controls.Add(this.DtpFechaHora);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTipoTransaccionId);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresoEgreso";
            this.Text = ".: Ingreso/Egreso :.";
            this.Load += new System.EventHandler(this.FrmIngresoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresoEgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtTipoTransaccionId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaHora;
        private System.Windows.Forms.DataGridView DgvIngresoEgreso;
        private System.Windows.Forms.TextBox TxtId;
    }
}