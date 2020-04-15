namespace EmpresaDiscografica
{
    partial class formGestionTrabajo
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
            this.pnlRegistroTra = new System.Windows.Forms.Panel();
            this.btnLimpiarReg = new System.Windows.Forms.Button();
            this.lbValidacion = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.btnGuardarTra = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.txtTarjetaProd = new System.Windows.Forms.TextBox();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbCodEmp = new System.Windows.Forms.Label();
            this.lbTarjetaProd = new System.Windows.Forms.Label();
            this.lbMensale11 = new System.Windows.Forms.Label();
            this.tbcOperacionesTrabajo = new System.Windows.Forms.TabControl();
            this.tbpRegistroTra = new System.Windows.Forms.TabPage();
            this.tbpConsulta1 = new System.Windows.Forms.TabPage();
            this.pnlConsulta1 = new System.Windows.Forms.Panel();
            this.lbSeleccioneFecha = new System.Windows.Forms.Label();
            this.lbMensaje14 = new System.Windows.Forms.Label();
            this.dtpFechCon2 = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.pnlRegistroTra.SuspendLayout();
            this.tbcOperacionesTrabajo.SuspendLayout();
            this.tbpRegistroTra.SuspendLayout();
            this.tbpConsulta1.SuspendLayout();
            this.pnlConsulta1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroTra
            // 
            this.pnlRegistroTra.Controls.Add(this.btnLimpiarReg);
            this.pnlRegistroTra.Controls.Add(this.lbValidacion);
            this.pnlRegistroTra.Controls.Add(this.rbNo);
            this.pnlRegistroTra.Controls.Add(this.rbSi);
            this.pnlRegistroTra.Controls.Add(this.btnGuardarTra);
            this.pnlRegistroTra.Controls.Add(this.dtpFechaFin);
            this.pnlRegistroTra.Controls.Add(this.dtpFechaInicio);
            this.pnlRegistroTra.Controls.Add(this.txtCodEmp);
            this.pnlRegistroTra.Controls.Add(this.txtTarjetaProd);
            this.pnlRegistroTra.Controls.Add(this.lbFechaFin);
            this.pnlRegistroTra.Controls.Add(this.lbFechaInicio);
            this.pnlRegistroTra.Controls.Add(this.lbCodEmp);
            this.pnlRegistroTra.Controls.Add(this.lbTarjetaProd);
            this.pnlRegistroTra.Controls.Add(this.lbMensale11);
            this.pnlRegistroTra.Location = new System.Drawing.Point(216, 48);
            this.pnlRegistroTra.Name = "pnlRegistroTra";
            this.pnlRegistroTra.Size = new System.Drawing.Size(688, 531);
            this.pnlRegistroTra.TabIndex = 0;
            // 
            // btnLimpiarReg
            // 
            this.btnLimpiarReg.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReg.Location = new System.Drawing.Point(491, 454);
            this.btnLimpiarReg.Name = "btnLimpiarReg";
            this.btnLimpiarReg.Size = new System.Drawing.Size(145, 49);
            this.btnLimpiarReg.TabIndex = 13;
            this.btnLimpiarReg.Text = "Limpiar";
            this.btnLimpiarReg.UseVisualStyleBackColor = false;
            this.btnLimpiarReg.Click += new System.EventHandler(this.btnLimpiarReg_Click);
            // 
            // lbValidacion
            // 
            this.lbValidacion.AutoSize = true;
            this.lbValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidacion.Location = new System.Drawing.Point(52, 300);
            this.lbValidacion.Name = "lbValidacion";
            this.lbValidacion.Size = new System.Drawing.Size(269, 22);
            this.lbValidacion.TabIndex = 12;
            this.lbValidacion.Text = "Desea ingresar la Fecha Fin:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(481, 300);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(54, 24);
            this.rbNo.TabIndex = 11;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Checked = true;
            this.rbSi.Location = new System.Drawing.Point(361, 300);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(48, 24);
            this.rbSi.TabIndex = 10;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // btnGuardarTra
            // 
            this.btnGuardarTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardarTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTra.Location = new System.Drawing.Point(257, 454);
            this.btnGuardarTra.Name = "btnGuardarTra";
            this.btnGuardarTra.Size = new System.Drawing.Size(152, 49);
            this.btnGuardarTra.TabIndex = 9;
            this.btnGuardarTra.Text = "Guardar";
            this.btnGuardarTra.UseVisualStyleBackColor = false;
            this.btnGuardarTra.Click += new System.EventHandler(this.btnGuardarTra_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(361, 372);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(190, 26);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(361, 239);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(190, 26);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(361, 165);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(190, 26);
            this.txtCodEmp.TabIndex = 6;
            this.txtCodEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEmp_KeyPress);
            // 
            // txtTarjetaProd
            // 
            this.txtTarjetaProd.Location = new System.Drawing.Point(361, 95);
            this.txtTarjetaProd.Name = "txtTarjetaProd";
            this.txtTarjetaProd.Size = new System.Drawing.Size(190, 26);
            this.txtTarjetaProd.TabIndex = 5;
            this.txtTarjetaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaProd_KeyPress);
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFin.Location = new System.Drawing.Point(58, 376);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(105, 22);
            this.lbFechaFin.TabIndex = 4;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(52, 243);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(124, 22);
            this.lbFechaInicio.TabIndex = 3;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // lbCodEmp
            // 
            this.lbCodEmp.AutoSize = true;
            this.lbCodEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodEmp.Location = new System.Drawing.Point(45, 169);
            this.lbCodEmp.Name = "lbCodEmp";
            this.lbCodEmp.Size = new System.Drawing.Size(163, 22);
            this.lbCodEmp.TabIndex = 2;
            this.lbCodEmp.Text = "Codigo Empresa:";
            // 
            // lbTarjetaProd
            // 
            this.lbTarjetaProd.AutoSize = true;
            this.lbTarjetaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjetaProd.Location = new System.Drawing.Point(48, 95);
            this.lbTarjetaProd.Name = "lbTarjetaProd";
            this.lbTarjetaProd.Size = new System.Drawing.Size(262, 22);
            this.lbTarjetaProd.TabIndex = 1;
            this.lbTarjetaProd.Text = "Numero Tarjeta Profesional:";
            // 
            // lbMensale11
            // 
            this.lbMensale11.AutoSize = true;
            this.lbMensale11.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensale11.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensale11.Location = new System.Drawing.Point(44, 17);
            this.lbMensale11.Name = "lbMensale11";
            this.lbMensale11.Size = new System.Drawing.Size(323, 29);
            this.lbMensale11.TabIndex = 0;
            this.lbMensale11.Text = "Registro de Vinculación";
            // 
            // tbcOperacionesTrabajo
            // 
            this.tbcOperacionesTrabajo.Controls.Add(this.tbpRegistroTra);
            this.tbcOperacionesTrabajo.Controls.Add(this.tbpConsulta1);
            this.tbcOperacionesTrabajo.Location = new System.Drawing.Point(44, 12);
            this.tbcOperacionesTrabajo.Name = "tbcOperacionesTrabajo";
            this.tbcOperacionesTrabajo.SelectedIndex = 0;
            this.tbcOperacionesTrabajo.Size = new System.Drawing.Size(1053, 635);
            this.tbcOperacionesTrabajo.TabIndex = 1;
            // 
            // tbpRegistroTra
            // 
            this.tbpRegistroTra.Controls.Add(this.pnlRegistroTra);
            this.tbpRegistroTra.Location = new System.Drawing.Point(4, 29);
            this.tbpRegistroTra.Name = "tbpRegistroTra";
            this.tbpRegistroTra.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistroTra.Size = new System.Drawing.Size(1045, 602);
            this.tbpRegistroTra.TabIndex = 0;
            this.tbpRegistroTra.Text = "Registro Trabajo";
            this.tbpRegistroTra.UseVisualStyleBackColor = true;
            // 
            // tbpConsulta1
            // 
            this.tbpConsulta1.Controls.Add(this.pnlConsulta1);
            this.tbpConsulta1.Location = new System.Drawing.Point(4, 29);
            this.tbpConsulta1.Name = "tbpConsulta1";
            this.tbpConsulta1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta1.Size = new System.Drawing.Size(1045, 602);
            this.tbpConsulta1.TabIndex = 1;
            this.tbpConsulta1.Text = "Consulta 1";
            this.tbpConsulta1.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta1
            // 
            this.pnlConsulta1.Controls.Add(this.lbSeleccioneFecha);
            this.pnlConsulta1.Controls.Add(this.lbMensaje14);
            this.pnlConsulta1.Controls.Add(this.dtpFechCon2);
            this.pnlConsulta1.Controls.Add(this.btnConsulta2);
            this.pnlConsulta1.Controls.Add(this.dgvConsulta1);
            this.pnlConsulta1.Controls.Add(this.btnConsulta1);
            this.pnlConsulta1.Location = new System.Drawing.Point(61, 35);
            this.pnlConsulta1.Name = "pnlConsulta1";
            this.pnlConsulta1.Size = new System.Drawing.Size(959, 536);
            this.pnlConsulta1.TabIndex = 0;
            // 
            // lbSeleccioneFecha
            // 
            this.lbSeleccioneFecha.AutoSize = true;
            this.lbSeleccioneFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccioneFecha.Location = new System.Drawing.Point(595, 108);
            this.lbSeleccioneFecha.Name = "lbSeleccioneFecha";
            this.lbSeleccioneFecha.Size = new System.Drawing.Size(175, 22);
            this.lbSeleccioneFecha.TabIndex = 6;
            this.lbSeleccioneFecha.Text = "Seleccione Fecha:";
            // 
            // lbMensaje14
            // 
            this.lbMensaje14.AutoSize = true;
            this.lbMensaje14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje14.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje14.Location = new System.Drawing.Point(26, 26);
            this.lbMensaje14.Name = "lbMensaje14";
            this.lbMensaje14.Size = new System.Drawing.Size(202, 29);
            this.lbMensaje14.TabIndex = 5;
            this.lbMensaje14.Text = "Consultas 5 y 6";
            // 
            // dtpFechCon2
            // 
            this.dtpFechCon2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechCon2.Location = new System.Drawing.Point(590, 133);
            this.dtpFechCon2.Name = "dtpFechCon2";
            this.dtpFechCon2.Size = new System.Drawing.Size(200, 26);
            this.dtpFechCon2.TabIndex = 4;
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.Location = new System.Drawing.Point(365, 108);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(181, 80);
            this.btnConsulta2.TabIndex = 3;
            this.btnConsulta2.Text = "Consulta 2";
            this.btnConsulta2.UseVisualStyleBackColor = false;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(26, 212);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.RowTemplate.Height = 28;
            this.dgvConsulta1.Size = new System.Drawing.Size(914, 235);
            this.dgvConsulta1.TabIndex = 1;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta1.Location = new System.Drawing.Point(43, 110);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(193, 76);
            this.btnConsulta1.TabIndex = 0;
            this.btnConsulta1.Text = "Consulta 1";
            this.btnConsulta1.UseVisualStyleBackColor = false;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // formGestionTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 673);
            this.Controls.Add(this.tbcOperacionesTrabajo);
            this.Name = "formGestionTrabajo";
            this.Text = "formGestionTrabajo";
            this.pnlRegistroTra.ResumeLayout(false);
            this.pnlRegistroTra.PerformLayout();
            this.tbcOperacionesTrabajo.ResumeLayout(false);
            this.tbpRegistroTra.ResumeLayout(false);
            this.tbpConsulta1.ResumeLayout(false);
            this.pnlConsulta1.ResumeLayout(false);
            this.pnlConsulta1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroTra;
        private System.Windows.Forms.Button btnGuardarTra;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.TextBox txtTarjetaProd;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbCodEmp;
        private System.Windows.Forms.Label lbTarjetaProd;
        private System.Windows.Forms.Label lbMensale11;
        private System.Windows.Forms.TabControl tbcOperacionesTrabajo;
        private System.Windows.Forms.TabPage tbpRegistroTra;
        private System.Windows.Forms.TabPage tbpConsulta1;
        private System.Windows.Forms.Label lbValidacion;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Panel pnlConsulta1;
        private System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Label lbSeleccioneFecha;
        private System.Windows.Forms.Label lbMensaje14;
        private System.Windows.Forms.DateTimePicker dtpFechCon2;
        private System.Windows.Forms.Button btnLimpiarReg;
    }
}