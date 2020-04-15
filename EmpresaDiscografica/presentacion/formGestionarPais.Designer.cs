namespace EmpresaDiscografica
{
    partial class formGestionarPais
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
            this.pnlRegistroPais = new System.Windows.Forms.Panel();
            this.btnLimpiarReg = new System.Windows.Forms.Button();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.btnGuardarPais = new System.Windows.Forms.Button();
            this.lbCodigoPais = new System.Windows.Forms.Label();
            this.lbNombrePais = new System.Windows.Forms.Label();
            this.lbMensaje7 = new System.Windows.Forms.Label();
            this.tbcGestionPais = new System.Windows.Forms.TabControl();
            this.tbpRegristroPais = new System.Windows.Forms.TabPage();
            this.tbpActuPais = new System.Windows.Forms.TabPage();
            this.pnlActualizarPais = new System.Windows.Forms.Panel();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.btnActualizarPais = new System.Windows.Forms.Button();
            this.btnBuscarPais = new System.Windows.Forms.Button();
            this.txtCodBuscarPais = new System.Windows.Forms.TextBox();
            this.txtActuNomPais = new System.Windows.Forms.TextBox();
            this.txtActuCodPais = new System.Windows.Forms.TextBox();
            this.lbActuCodPais = new System.Windows.Forms.Label();
            this.lbActuNomPais = new System.Windows.Forms.Label();
            this.lbCodBuscarPais = new System.Windows.Forms.Label();
            this.lbMensaje8 = new System.Windows.Forms.Label();
            this.tbpEliminarPais = new System.Windows.Forms.TabPage();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            this.txtCodPaisEliminar = new System.Windows.Forms.TextBox();
            this.lbMensaje9 = new System.Windows.Forms.Label();
            this.lbCodPaisEliminar = new System.Windows.Forms.Label();
            this.dgvDatosPaises = new System.Windows.Forms.DataGridView();
            this.btnConsultarPais = new System.Windows.Forms.Button();
            this.pnlRegistroPais.SuspendLayout();
            this.tbcGestionPais.SuspendLayout();
            this.tbpRegristroPais.SuspendLayout();
            this.tbpActuPais.SuspendLayout();
            this.pnlActualizarPais.SuspendLayout();
            this.tbpEliminarPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroPais
            // 
            this.pnlRegistroPais.Controls.Add(this.btnLimpiarReg);
            this.pnlRegistroPais.Controls.Add(this.txtNombrePais);
            this.pnlRegistroPais.Controls.Add(this.txtCodigoPais);
            this.pnlRegistroPais.Controls.Add(this.btnGuardarPais);
            this.pnlRegistroPais.Controls.Add(this.lbCodigoPais);
            this.pnlRegistroPais.Controls.Add(this.lbNombrePais);
            this.pnlRegistroPais.Controls.Add(this.lbMensaje7);
            this.pnlRegistroPais.Location = new System.Drawing.Point(203, 65);
            this.pnlRegistroPais.Name = "pnlRegistroPais";
            this.pnlRegistroPais.Size = new System.Drawing.Size(611, 351);
            this.pnlRegistroPais.TabIndex = 0;
            // 
            // btnLimpiarReg
            // 
            this.btnLimpiarReg.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReg.Location = new System.Drawing.Point(427, 264);
            this.btnLimpiarReg.Name = "btnLimpiarReg";
            this.btnLimpiarReg.Size = new System.Drawing.Size(118, 38);
            this.btnLimpiarReg.TabIndex = 6;
            this.btnLimpiarReg.Text = "Limpiar";
            this.btnLimpiarReg.UseVisualStyleBackColor = false;
            this.btnLimpiarReg.Click += new System.EventHandler(this.btnLimpiarReg_Click);
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(183, 183);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(130, 26);
            this.txtNombrePais.TabIndex = 5;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(183, 100);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(130, 26);
            this.txtCodigoPais.TabIndex = 4;
            this.txtCodigoPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPais_KeyPress);
            // 
            // btnGuardarPais
            // 
            this.btnGuardarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPais.Location = new System.Drawing.Point(183, 263);
            this.btnGuardarPais.Name = "btnGuardarPais";
            this.btnGuardarPais.Size = new System.Drawing.Size(125, 39);
            this.btnGuardarPais.TabIndex = 3;
            this.btnGuardarPais.Text = "Guardar";
            this.btnGuardarPais.UseVisualStyleBackColor = false;
            this.btnGuardarPais.Click += new System.EventHandler(this.btnGuardarPais_Click);
            // 
            // lbCodigoPais
            // 
            this.lbCodigoPais.AutoSize = true;
            this.lbCodigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoPais.Location = new System.Drawing.Point(78, 103);
            this.lbCodigoPais.Name = "lbCodigoPais";
            this.lbCodigoPais.Size = new System.Drawing.Size(79, 22);
            this.lbCodigoPais.TabIndex = 2;
            this.lbCodigoPais.Text = "Codigo:";
            // 
            // lbNombrePais
            // 
            this.lbNombrePais.AutoSize = true;
            this.lbNombrePais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePais.Location = new System.Drawing.Point(78, 183);
            this.lbNombrePais.Name = "lbNombrePais";
            this.lbNombrePais.Size = new System.Drawing.Size(85, 22);
            this.lbNombrePais.TabIndex = 1;
            this.lbNombrePais.Text = "Nombre:";
            // 
            // lbMensaje7
            // 
            this.lbMensaje7.AutoSize = true;
            this.lbMensaje7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje7.Location = new System.Drawing.Point(24, 19);
            this.lbMensaje7.Name = "lbMensaje7";
            this.lbMensaje7.Size = new System.Drawing.Size(305, 29);
            this.lbMensaje7.TabIndex = 0;
            this.lbMensaje7.Text = "Ingrese Datos del Pais ";
            // 
            // tbcGestionPais
            // 
            this.tbcGestionPais.Controls.Add(this.tbpRegristroPais);
            this.tbcGestionPais.Controls.Add(this.tbpActuPais);
            this.tbcGestionPais.Controls.Add(this.tbpEliminarPais);
            this.tbcGestionPais.Location = new System.Drawing.Point(56, 31);
            this.tbcGestionPais.Name = "tbcGestionPais";
            this.tbcGestionPais.SelectedIndex = 0;
            this.tbcGestionPais.Size = new System.Drawing.Size(998, 514);
            this.tbcGestionPais.TabIndex = 1;
            // 
            // tbpRegristroPais
            // 
            this.tbpRegristroPais.Controls.Add(this.pnlRegistroPais);
            this.tbpRegristroPais.Location = new System.Drawing.Point(4, 29);
            this.tbpRegristroPais.Name = "tbpRegristroPais";
            this.tbpRegristroPais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegristroPais.Size = new System.Drawing.Size(990, 481);
            this.tbpRegristroPais.TabIndex = 0;
            this.tbpRegristroPais.Text = "Registro Pais";
            this.tbpRegristroPais.UseVisualStyleBackColor = true;
            // 
            // tbpActuPais
            // 
            this.tbpActuPais.Controls.Add(this.pnlActualizarPais);
            this.tbpActuPais.Location = new System.Drawing.Point(4, 29);
            this.tbpActuPais.Name = "tbpActuPais";
            this.tbpActuPais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActuPais.Size = new System.Drawing.Size(990, 481);
            this.tbpActuPais.TabIndex = 1;
            this.tbpActuPais.Text = "Actualizar Pais";
            this.tbpActuPais.UseVisualStyleBackColor = true;
            // 
            // pnlActualizarPais
            // 
            this.pnlActualizarPais.Controls.Add(this.btnLimpiarAct);
            this.pnlActualizarPais.Controls.Add(this.btnActualizarPais);
            this.pnlActualizarPais.Controls.Add(this.btnBuscarPais);
            this.pnlActualizarPais.Controls.Add(this.txtCodBuscarPais);
            this.pnlActualizarPais.Controls.Add(this.txtActuNomPais);
            this.pnlActualizarPais.Controls.Add(this.txtActuCodPais);
            this.pnlActualizarPais.Controls.Add(this.lbActuCodPais);
            this.pnlActualizarPais.Controls.Add(this.lbActuNomPais);
            this.pnlActualizarPais.Controls.Add(this.lbCodBuscarPais);
            this.pnlActualizarPais.Controls.Add(this.lbMensaje8);
            this.pnlActualizarPais.Location = new System.Drawing.Point(151, 59);
            this.pnlActualizarPais.Name = "pnlActualizarPais";
            this.pnlActualizarPais.Size = new System.Drawing.Size(708, 347);
            this.pnlActualizarPais.TabIndex = 2;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAct.Location = new System.Drawing.Point(521, 277);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(145, 47);
            this.btnLimpiarAct.TabIndex = 9;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = false;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnActualizarPais
            // 
            this.btnActualizarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPais.Location = new System.Drawing.Point(311, 277);
            this.btnActualizarPais.Name = "btnActualizarPais";
            this.btnActualizarPais.Size = new System.Drawing.Size(178, 47);
            this.btnActualizarPais.TabIndex = 8;
            this.btnActualizarPais.Text = "Actualizar";
            this.btnActualizarPais.UseVisualStyleBackColor = false;
            this.btnActualizarPais.Click += new System.EventHandler(this.btnActualizarPais_Click);
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPais.Location = new System.Drawing.Point(520, 71);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(146, 49);
            this.btnBuscarPais.TabIndex = 7;
            this.btnBuscarPais.Text = "Buscar";
            this.btnBuscarPais.UseVisualStyleBackColor = false;
            this.btnBuscarPais.Click += new System.EventHandler(this.btnBuscarPais_Click);
            // 
            // txtCodBuscarPais
            // 
            this.txtCodBuscarPais.Location = new System.Drawing.Point(340, 94);
            this.txtCodBuscarPais.Name = "txtCodBuscarPais";
            this.txtCodBuscarPais.Size = new System.Drawing.Size(136, 26);
            this.txtCodBuscarPais.TabIndex = 6;
            this.txtCodBuscarPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBuscarPais_KeyPress);
            // 
            // txtActuNomPais
            // 
            this.txtActuNomPais.Location = new System.Drawing.Point(340, 215);
            this.txtActuNomPais.Name = "txtActuNomPais";
            this.txtActuNomPais.Size = new System.Drawing.Size(136, 26);
            this.txtActuNomPais.TabIndex = 5;
            // 
            // txtActuCodPais
            // 
            this.txtActuCodPais.Location = new System.Drawing.Point(340, 149);
            this.txtActuCodPais.Name = "txtActuCodPais";
            this.txtActuCodPais.Size = new System.Drawing.Size(136, 26);
            this.txtActuCodPais.TabIndex = 4;
            this.txtActuCodPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActuCodPais_KeyPress);
            // 
            // lbActuCodPais
            // 
            this.lbActuCodPais.AutoSize = true;
            this.lbActuCodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuCodPais.Location = new System.Drawing.Point(78, 153);
            this.lbActuCodPais.Name = "lbActuCodPais";
            this.lbActuCodPais.Size = new System.Drawing.Size(79, 22);
            this.lbActuCodPais.TabIndex = 3;
            this.lbActuCodPais.Text = "Codigo:";
            // 
            // lbActuNomPais
            // 
            this.lbActuNomPais.AutoSize = true;
            this.lbActuNomPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuNomPais.Location = new System.Drawing.Point(78, 219);
            this.lbActuNomPais.Name = "lbActuNomPais";
            this.lbActuNomPais.Size = new System.Drawing.Size(85, 22);
            this.lbActuNomPais.TabIndex = 2;
            this.lbActuNomPais.Text = "Nombre:";
            // 
            // lbCodBuscarPais
            // 
            this.lbCodBuscarPais.AutoSize = true;
            this.lbCodBuscarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodBuscarPais.Location = new System.Drawing.Point(70, 94);
            this.lbCodBuscarPais.Name = "lbCodBuscarPais";
            this.lbCodBuscarPais.Size = new System.Drawing.Size(251, 22);
            this.lbCodBuscarPais.TabIndex = 1;
            this.lbCodBuscarPais.Text = "Ingrese el Codigo del Pais:";
            // 
            // lbMensaje8
            // 
            this.lbMensaje8.AutoSize = true;
            this.lbMensaje8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje8.Location = new System.Drawing.Point(66, 30);
            this.lbMensaje8.Name = "lbMensaje8";
            this.lbMensaje8.Size = new System.Drawing.Size(214, 29);
            this.lbMensaje8.TabIndex = 0;
            this.lbMensaje8.Text = "Actualizar Pais";
            // 
            // tbpEliminarPais
            // 
            this.tbpEliminarPais.Controls.Add(this.btnEliminarPais);
            this.tbpEliminarPais.Controls.Add(this.txtCodPaisEliminar);
            this.tbpEliminarPais.Controls.Add(this.lbMensaje9);
            this.tbpEliminarPais.Controls.Add(this.lbCodPaisEliminar);
            this.tbpEliminarPais.Controls.Add(this.dgvDatosPaises);
            this.tbpEliminarPais.Controls.Add(this.btnConsultarPais);
            this.tbpEliminarPais.Location = new System.Drawing.Point(4, 29);
            this.tbpEliminarPais.Name = "tbpEliminarPais";
            this.tbpEliminarPais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarPais.Size = new System.Drawing.Size(990, 481);
            this.tbpEliminarPais.TabIndex = 2;
            this.tbpEliminarPais.Text = "Eliminar Pais";
            this.tbpEliminarPais.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPais.Location = new System.Drawing.Point(502, 356);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(147, 58);
            this.btnEliminarPais.TabIndex = 5;
            this.btnEliminarPais.Text = "Eliminar";
            this.btnEliminarPais.UseVisualStyleBackColor = false;
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // txtCodPaisEliminar
            // 
            this.txtCodPaisEliminar.Location = new System.Drawing.Point(335, 368);
            this.txtCodPaisEliminar.Name = "txtCodPaisEliminar";
            this.txtCodPaisEliminar.Size = new System.Drawing.Size(141, 26);
            this.txtCodPaisEliminar.TabIndex = 4;
            this.txtCodPaisEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPaisEliminar_KeyPress);
            // 
            // lbMensaje9
            // 
            this.lbMensaje9.AutoSize = true;
            this.lbMensaje9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje9.Location = new System.Drawing.Point(142, 38);
            this.lbMensaje9.Name = "lbMensaje9";
            this.lbMensaje9.Size = new System.Drawing.Size(186, 29);
            this.lbMensaje9.TabIndex = 3;
            this.lbMensaje9.Text = "Eliminar Pais";
            // 
            // lbCodPaisEliminar
            // 
            this.lbCodPaisEliminar.AutoSize = true;
            this.lbCodPaisEliminar.BackColor = System.Drawing.Color.Khaki;
            this.lbCodPaisEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodPaisEliminar.Location = new System.Drawing.Point(147, 369);
            this.lbCodPaisEliminar.Name = "lbCodPaisEliminar";
            this.lbCodPaisEliminar.Size = new System.Drawing.Size(151, 22);
            this.lbCodPaisEliminar.TabIndex = 2;
            this.lbCodPaisEliminar.Text = "Ingrese Codigo:";
            // 
            // dgvDatosPaises
            // 
            this.dgvDatosPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPaises.Location = new System.Drawing.Point(289, 149);
            this.dgvDatosPaises.Name = "dgvDatosPaises";
            this.dgvDatosPaises.RowTemplate.Height = 28;
            this.dgvDatosPaises.Size = new System.Drawing.Size(415, 162);
            this.dgvDatosPaises.TabIndex = 1;
            // 
            // btnConsultarPais
            // 
            this.btnConsultarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPais.Location = new System.Drawing.Point(377, 74);
            this.btnConsultarPais.Name = "btnConsultarPais";
            this.btnConsultarPais.Size = new System.Drawing.Size(238, 56);
            this.btnConsultarPais.TabIndex = 0;
            this.btnConsultarPais.Text = "Consultar Pais";
            this.btnConsultarPais.UseVisualStyleBackColor = false;
            this.btnConsultarPais.Click += new System.EventHandler(this.btnConsultarPais_Click);
            // 
            // formGestionarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 571);
            this.Controls.Add(this.tbcGestionPais);
            this.Name = "formGestionarPais";
            this.Text = "FormGestionarPais";
            this.pnlRegistroPais.ResumeLayout(false);
            this.pnlRegistroPais.PerformLayout();
            this.tbcGestionPais.ResumeLayout(false);
            this.tbpRegristroPais.ResumeLayout(false);
            this.tbpActuPais.ResumeLayout(false);
            this.pnlActualizarPais.ResumeLayout(false);
            this.pnlActualizarPais.PerformLayout();
            this.tbpEliminarPais.ResumeLayout(false);
            this.tbpEliminarPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroPais;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Button btnGuardarPais;
        private System.Windows.Forms.Label lbCodigoPais;
        private System.Windows.Forms.Label lbNombrePais;
        private System.Windows.Forms.Label lbMensaje7;
        private System.Windows.Forms.TabControl tbcGestionPais;
        private System.Windows.Forms.TabPage tbpRegristroPais;
        private System.Windows.Forms.TabPage tbpActuPais;
        private System.Windows.Forms.Panel pnlActualizarPais;
        private System.Windows.Forms.TabPage tbpEliminarPais;
        private System.Windows.Forms.Button btnActualizarPais;
        private System.Windows.Forms.Button btnBuscarPais;
        private System.Windows.Forms.TextBox txtCodBuscarPais;
        private System.Windows.Forms.TextBox txtActuNomPais;
        private System.Windows.Forms.TextBox txtActuCodPais;
        private System.Windows.Forms.Label lbActuCodPais;
        private System.Windows.Forms.Label lbActuNomPais;
        private System.Windows.Forms.Label lbCodBuscarPais;
        private System.Windows.Forms.Label lbMensaje8;
        private System.Windows.Forms.Label lbCodPaisEliminar;
        private System.Windows.Forms.DataGridView dgvDatosPaises;
        private System.Windows.Forms.Button btnConsultarPais;
        private System.Windows.Forms.Label lbMensaje9;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.TextBox txtCodPaisEliminar;
        private System.Windows.Forms.Button btnLimpiarReg;
        private System.Windows.Forms.Button btnLimpiarAct;
    }
}