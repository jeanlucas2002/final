namespace Financiera.AppWin
{
    partial class frmConsultaPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCiente = new System.Windows.Forms.TextBox();
            this.cboPrestamo = new System.Windows.Forms.ComboBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeccha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPagoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plazo(Meses):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de Interés:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado de la Consulta";
            // 
            // txtCiente
            // 
            this.txtCiente.Location = new System.Drawing.Point(74, 118);
            this.txtCiente.Name = "txtCiente";
            this.txtCiente.Size = new System.Drawing.Size(439, 20);
            this.txtCiente.TabIndex = 6;
            // 
            // cboPrestamo
            // 
            this.cboPrestamo.FormattingEnabled = true;
            this.cboPrestamo.Location = new System.Drawing.Point(84, 42);
            this.cboPrestamo.Name = "cboPrestamo";
            this.cboPrestamo.Size = new System.Drawing.Size(287, 21);
            this.cboPrestamo.TabIndex = 7;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(102, 207);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(235, 20);
            this.txtplazo.TabIndex = 8;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(74, 160);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(161, 20);
            this.txtImporte.TabIndex = 9;
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(343, 160);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(171, 20);
            this.txtinteres.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detalle de las cuotas";
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colN,
            this.colfeccha,
            this.colCuota,
            this.ColInteres,
            this.ColPagoTotal,
            this.ColSaldo});
            this.dgvlistado.Location = new System.Drawing.Point(16, 307);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(646, 230);
            this.dgvlistado.TabIndex = 12;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(418, 35);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(139, 35);
            this.btnconsultar.TabIndex = 13;
            this.btnconsultar.Text = "Consulta";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // colN
            // 
            this.colN.HeaderText = "N°";
            this.colN.Name = "colN";
            // 
            // colfeccha
            // 
            this.colfeccha.HeaderText = "Fec.Venc.";
            this.colfeccha.Name = "colfeccha";
            // 
            // colCuota
            // 
            this.colCuota.HeaderText = "Cuota";
            this.colCuota.Name = "colCuota";
            // 
            // ColInteres
            // 
            this.ColInteres.HeaderText = "Interés";
            this.ColInteres.Name = "ColInteres";
            // 
            // ColPagoTotal
            // 
            this.ColPagoTotal.HeaderText = "Pago Total";
            this.ColPagoTotal.Name = "ColPagoTotal";
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            // 
            // frmConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 578);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtinteres);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtplazo);
            this.Controls.Add(this.cboPrestamo);
            this.Controls.Add(this.txtCiente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaPrestamo";
            this.Text = "frmConsultaPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCiente;
        private System.Windows.Forms.ComboBox cboPrestamo;
        private System.Windows.Forms.TextBox txtplazo;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeccha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPagoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    }
}