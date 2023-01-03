namespace UI.Windows.Forms
{
    partial class FrmPedido
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
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtUsuarioId = new System.Windows.Forms.TextBox();
            this.TxtClienteId = new System.Windows.Forms.TextBox();
            this.TxtNumPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.TxtImpuestos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(246, 358);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 25;
            this.BtnRegresar.Text = "Cerrar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(137, 358);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(246, 233);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(222, 22);
            this.TxtSubtotal.TabIndex = 23;
            // 
            // TxtUsuarioId
            // 
            this.TxtUsuarioId.Location = new System.Drawing.Point(246, 195);
            this.TxtUsuarioId.Name = "TxtUsuarioId";
            this.TxtUsuarioId.Size = new System.Drawing.Size(222, 22);
            this.TxtUsuarioId.TabIndex = 22;
            // 
            // TxtClienteId
            // 
            this.TxtClienteId.Location = new System.Drawing.Point(246, 156);
            this.TxtClienteId.Name = "TxtClienteId";
            this.TxtClienteId.Size = new System.Drawing.Size(222, 22);
            this.TxtClienteId.TabIndex = 21;
            // 
            // TxtNumPedido
            // 
            this.TxtNumPedido.Location = new System.Drawing.Point(246, 120);
            this.TxtNumPedido.Name = "TxtNumPedido";
            this.TxtNumPedido.Size = new System.Drawing.Size(222, 22);
            this.TxtNumPedido.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subtotal: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Usuario Id: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cliente Id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pedido #: ";
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
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pedido";
            // 
            // DtpFechaHora
            // 
            this.DtpFechaHora.Location = new System.Drawing.Point(246, 87);
            this.DtpFechaHora.Name = "DtpFechaHora";
            this.DtpFechaHora.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaHora.TabIndex = 26;
            // 
            // TxtImpuestos
            // 
            this.TxtImpuestos.Location = new System.Drawing.Point(246, 273);
            this.TxtImpuestos.Name = "TxtImpuestos";
            this.TxtImpuestos.Size = new System.Drawing.Size(222, 22);
            this.TxtImpuestos.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Impuestos: ";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(246, 309);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(222, 22);
            this.TxtTotal.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total: ";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 435);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtImpuestos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtpFechaHora);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtUsuarioId);
            this.Controls.Add(this.TxtClienteId);
            this.Controls.Add(this.TxtNumPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.Text = ".: Pedido :.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtUsuarioId;
        private System.Windows.Forms.TextBox TxtClienteId;
        private System.Windows.Forms.TextBox TxtNumPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaHora;
        private System.Windows.Forms.TextBox TxtImpuestos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label8;
    }
}