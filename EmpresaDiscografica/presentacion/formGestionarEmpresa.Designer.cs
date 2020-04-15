namespace EmpresaDiscografica
{
    partial class formGestionarEmpresa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRegistroEmp = new System.Windows.Forms.Panel();
            this.btnLimpiarRe = new System.Windows.Forms.Button();
            this.txtRegCodPa = new System.Windows.Forms.TextBox();
            this.lbRegCodPa = new System.Windows.Forms.Label();
            this.lbMensaje1 = new System.Windows.Forms.Label();
            this.btnGuardarEmp = new System.Windows.Forms.Button();
            this.rbCasaMatriz = new System.Windows.Forms.RadioButton();
            this.rbSubsidiaria = new System.Windows.Forms.RadioButton();
            this.dtpAnioFund = new System.Windows.Forms.DateTimePicker();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtCodigoEmp = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbAnioFundacion = new System.Windows.Forms.Label();
            this.lbNomEmpresa = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbcOperacionesEmp = new System.Windows.Forms.TabControl();
            this.tbpRegistroEmp = new System.Windows.Forms.TabPage();
            this.tbpActualizarEmp = new System.Windows.Forms.TabPage();
            this.pnlActualizarEmp = new System.Windows.Forms.Panel();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.txtActuCodPa = new System.Windows.Forms.TextBox();
            this.lbActuCodPa = new System.Windows.Forms.Label();
            this.txtActuAnioEmp = new System.Windows.Forms.TextBox();
            this.lbMensaje2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.rbActuCasa = new System.Windows.Forms.RadioButton();
            this.rbActuSubsi = new System.Windows.Forms.RadioButton();
            this.txtActuNomEmp = new System.Windows.Forms.TextBox();
            this.txtActuCodigoEmp = new System.Windows.Forms.TextBox();
            this.lbActuTipoEmp = new System.Windows.Forms.Label();
            this.lbActuAnioFuEmp = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.lbActuNombreEmp = new System.Windows.Forms.Label();
            this.lbActuCodigoEmp = new System.Windows.Forms.Label();
            this.lbCodigoBuscar = new System.Windows.Forms.Label();
            this.tbpEliminarEmp = new System.Windows.Forms.TabPage();
            this.pnlEliminarEmp = new System.Windows.Forms.Panel();
            this.lbMensaje3 = new System.Windows.Forms.Label();
            this.btnEliminarEmp = new System.Windows.Forms.Button();
            this.txtCodEmpEliminar = new System.Windows.Forms.TextBox();
            this.lbCodEmpEliminar = new System.Windows.Forms.Label();
            this.dgvDatosEmpresas = new System.Windows.Forms.DataGridView();
            this.btnConsultarEmp = new System.Windows.Forms.Button();
            this.pnlRegistroEmp.SuspendLayout();
            this.tbcOperacionesEmp.SuspendLayout();
            this.tbpRegistroEmp.SuspendLayout();
            this.tbpActualizarEmp.SuspendLayout();
            this.pnlActualizarEmp.SuspendLayout();
            this.tbpEliminarEmp.SuspendLayout();
            this.pnlEliminarEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroEmp
            // 
            this.pnlRegistroEmp.Controls.Add(this.btnLimpiarRe);
            this.pnlRegistroEmp.Controls.Add(this.txtRegCodPa);
            this.pnlRegistroEmp.Controls.Add(this.lbRegCodPa);
            this.pnlRegistroEmp.Controls.Add(this.lbMensaje1);
            this.pnlRegistroEmp.Controls.Add(this.btnGuardarEmp);
            this.pnlRegistroEmp.Controls.Add(this.rbCasaMatriz);
            this.pnlRegistroEmp.Controls.Add(this.rbSubsidiaria);
            this.pnlRegistroEmp.Controls.Add(this.dtpAnioFund);
            this.pnlRegistroEmp.Controls.Add(this.txtNombreEmp);
            this.pnlRegistroEmp.Controls.Add(this.txtCodigoEmp);
            this.pnlRegistroEmp.Controls.Add(this.lbTipo);
            this.pnlRegistroEmp.Controls.Add(this.lbAnioFundacion);
            this.pnlRegistroEmp.Controls.Add(this.lbNomEmpresa);
            this.pnlRegistroEmp.Controls.Add(this.lbCodigo);
            this.pnlRegistroEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistroEmp.Location = new System.Drawing.Point(122, 29);
            this.pnlRegistroEmp.Name = "pnlRegistroEmp";
            this.pnlRegistroEmp.Size = new System.Drawing.Size(802, 520);
            this.pnlRegistroEmp.TabIndex = 0;
            // 
            // btnLimpiarRe
            // 
            this.btnLimpiarRe.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarRe.Location = new System.Drawing.Point(619, 439);
            this.btnLimpiarRe.Name = "btnLimpiarRe";
            this.btnLimpiarRe.Size = new System.Drawing.Size(126, 47);
            this.btnLimpiarRe.TabIndex = 13;
            this.btnLimpiarRe.Text = "Limpiar";
            this.btnLimpiarRe.UseVisualStyleBackColor = false;
            this.btnLimpiarRe.Click += new System.EventHandler(this.btnLimpiarRe_Click);
            // 
            // txtRegCodPa
            // 
            this.txtRegCodPa.Location = new System.Drawing.Point(295, 148);
            this.txtRegCodPa.Name = "txtRegCodPa";
            this.txtRegCodPa.Size = new System.Drawing.Size(289, 28);
            this.txtRegCodPa.TabIndex = 12;
            this.txtRegCodPa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegCodPa_KeyPress);
            // 
            // lbRegCodPa
            // 
            this.lbRegCodPa.AutoSize = true;
            this.lbRegCodPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegCodPa.Location = new System.Drawing.Point(58, 151);
            this.lbRegCodPa.Name = "lbRegCodPa";
            this.lbRegCodPa.Size = new System.Drawing.Size(124, 22);
            this.lbRegCodPa.TabIndex = 11;
            this.lbRegCodPa.Text = "Codigo Pais:";
            // 
            // lbMensaje1
            // 
            this.lbMensaje1.AutoSize = true;
            this.lbMensaje1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje1.Location = new System.Drawing.Point(21, 19);
            this.lbMensaje1.Name = "lbMensaje1";
            this.lbMensaje1.Size = new System.Drawing.Size(340, 29);
            this.lbMensaje1.TabIndex = 10;
            this.lbMensaje1.Text = "Ingrese datos de Empresa";
            // 
            // btnGuardarEmp
            // 
            this.btnGuardarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmp.Location = new System.Drawing.Point(311, 438);
            this.btnGuardarEmp.Name = "btnGuardarEmp";
            this.btnGuardarEmp.Size = new System.Drawing.Size(167, 48);
            this.btnGuardarEmp.TabIndex = 9;
            this.btnGuardarEmp.Text = "Guardar";
            this.btnGuardarEmp.UseVisualStyleBackColor = false;
            this.btnGuardarEmp.Click += new System.EventHandler(this.btnGuardarEmp_Click);
            // 
            // rbCasaMatriz
            // 
            this.rbCasaMatriz.AutoSize = true;
            this.rbCasaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCasaMatriz.Location = new System.Drawing.Point(470, 374);
            this.rbCasaMatriz.Name = "rbCasaMatriz";
            this.rbCasaMatriz.Size = new System.Drawing.Size(140, 26);
            this.rbCasaMatriz.TabIndex = 8;
            this.rbCasaMatriz.Text = "Casa Matriz";
            this.rbCasaMatriz.UseVisualStyleBackColor = true;
            // 
            // rbSubsidiaria
            // 
            this.rbSubsidiaria.AutoSize = true;
            this.rbSubsidiaria.Checked = true;
            this.rbSubsidiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubsidiaria.Location = new System.Drawing.Point(314, 374);
            this.rbSubsidiaria.Name = "rbSubsidiaria";
            this.rbSubsidiaria.Size = new System.Drawing.Size(135, 26);
            this.rbSubsidiaria.TabIndex = 7;
            this.rbSubsidiaria.TabStop = true;
            this.rbSubsidiaria.Text = "Subsidiaria";
            this.rbSubsidiaria.UseVisualStyleBackColor = true;
            // 
            // dtpAnioFund
            // 
            this.dtpAnioFund.CustomFormat = "";
            this.dtpAnioFund.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnioFund.Location = new System.Drawing.Point(295, 297);
            this.dtpAnioFund.Name = "dtpAnioFund";
            this.dtpAnioFund.Size = new System.Drawing.Size(289, 28);
            this.dtpAnioFund.TabIndex = 6;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(295, 219);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(289, 28);
            this.txtNombreEmp.TabIndex = 5;
            // 
            // txtCodigoEmp
            // 
            this.txtCodigoEmp.Location = new System.Drawing.Point(295, 77);
            this.txtCodigoEmp.Name = "txtCodigoEmp";
            this.txtCodigoEmp.Size = new System.Drawing.Size(289, 28);
            this.txtCodigoEmp.TabIndex = 4;
            this.txtCodigoEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEmp_KeyPress);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(77, 374);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(56, 22);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbAnioFundacion
            // 
            this.lbAnioFundacion.AutoSize = true;
            this.lbAnioFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnioFundacion.Location = new System.Drawing.Point(58, 297);
            this.lbAnioFundacion.Name = "lbAnioFundacion";
            this.lbAnioFundacion.Size = new System.Drawing.Size(150, 22);
            this.lbAnioFundacion.TabIndex = 2;
            this.lbAnioFundacion.Text = "Año Fundacion:";
            // 
            // lbNomEmpresa
            // 
            this.lbNomEmpresa.AutoSize = true;
            this.lbNomEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomEmpresa.Location = new System.Drawing.Point(58, 222);
            this.lbNomEmpresa.Name = "lbNomEmpresa";
            this.lbNomEmpresa.Size = new System.Drawing.Size(169, 22);
            this.lbNomEmpresa.TabIndex = 1;
            this.lbNomEmpresa.Text = "Nombre Empresa:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(54, 84);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(79, 22);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo:";
            // 
            // tbcOperacionesEmp
            // 
            this.tbcOperacionesEmp.Controls.Add(this.tbpRegistroEmp);
            this.tbcOperacionesEmp.Controls.Add(this.tbpActualizarEmp);
            this.tbcOperacionesEmp.Controls.Add(this.tbpEliminarEmp);
            this.tbcOperacionesEmp.Location = new System.Drawing.Point(91, 24);
            this.tbcOperacionesEmp.Name = "tbcOperacionesEmp";
            this.tbcOperacionesEmp.SelectedIndex = 0;
            this.tbcOperacionesEmp.Size = new System.Drawing.Size(1002, 605);
            this.tbcOperacionesEmp.TabIndex = 1;
            // 
            // tbpRegistroEmp
            // 
            this.tbpRegistroEmp.BackColor = System.Drawing.Color.White;
            this.tbpRegistroEmp.Controls.Add(this.pnlRegistroEmp);
            this.tbpRegistroEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpRegistroEmp.Location = new System.Drawing.Point(4, 29);
            this.tbpRegistroEmp.Name = "tbpRegistroEmp";
            this.tbpRegistroEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistroEmp.Size = new System.Drawing.Size(994, 572);
            this.tbpRegistroEmp.TabIndex = 0;
            this.tbpRegistroEmp.Text = "Registro Empresa";
            // 
            // tbpActualizarEmp
            // 
            this.tbpActualizarEmp.Controls.Add(this.pnlActualizarEmp);
            this.tbpActualizarEmp.Location = new System.Drawing.Point(4, 29);
            this.tbpActualizarEmp.Name = "tbpActualizarEmp";
            this.tbpActualizarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActualizarEmp.Size = new System.Drawing.Size(994, 572);
            this.tbpActualizarEmp.TabIndex = 1;
            this.tbpActualizarEmp.Text = "Actualizar Empresa";
            this.tbpActualizarEmp.UseVisualStyleBackColor = true;
            // 
            // pnlActualizarEmp
            // 
            this.pnlActualizarEmp.Controls.Add(this.btnLimpiarAct);
            this.pnlActualizarEmp.Controls.Add(this.txtActuCodPa);
            this.pnlActualizarEmp.Controls.Add(this.lbActuCodPa);
            this.pnlActualizarEmp.Controls.Add(this.txtActuAnioEmp);
            this.pnlActualizarEmp.Controls.Add(this.lbMensaje2);
            this.pnlActualizarEmp.Controls.Add(this.btnActualizar);
            this.pnlActualizarEmp.Controls.Add(this.rbActuCasa);
            this.pnlActualizarEmp.Controls.Add(this.rbActuSubsi);
            this.pnlActualizarEmp.Controls.Add(this.txtActuNomEmp);
            this.pnlActualizarEmp.Controls.Add(this.txtActuCodigoEmp);
            this.pnlActualizarEmp.Controls.Add(this.lbActuTipoEmp);
            this.pnlActualizarEmp.Controls.Add(this.lbActuAnioFuEmp);
            this.pnlActualizarEmp.Controls.Add(this.txtBuscarCodigo);
            this.pnlActualizarEmp.Controls.Add(this.btnBuscarCodigo);
            this.pnlActualizarEmp.Controls.Add(this.lbActuNombreEmp);
            this.pnlActualizarEmp.Controls.Add(this.lbActuCodigoEmp);
            this.pnlActualizarEmp.Controls.Add(this.lbCodigoBuscar);
            this.pnlActualizarEmp.Location = new System.Drawing.Point(130, 6);
            this.pnlActualizarEmp.Name = "pnlActualizarEmp";
            this.pnlActualizarEmp.Size = new System.Drawing.Size(669, 544);
            this.pnlActualizarEmp.TabIndex = 2;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAct.Location = new System.Drawing.Point(493, 464);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(139, 47);
            this.btnLimpiarAct.TabIndex = 17;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = false;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // txtActuCodPa
            // 
            this.txtActuCodPa.Location = new System.Drawing.Point(272, 193);
            this.txtActuCodPa.Name = "txtActuCodPa";
            this.txtActuCodPa.Size = new System.Drawing.Size(144, 26);
            this.txtActuCodPa.TabIndex = 16;
            this.txtActuCodPa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActuCodPa_KeyPress);
            // 
            // lbActuCodPa
            // 
            this.lbActuCodPa.AutoSize = true;
            this.lbActuCodPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuCodPa.Location = new System.Drawing.Point(37, 197);
            this.lbActuCodPa.Name = "lbActuCodPa";
            this.lbActuCodPa.Size = new System.Drawing.Size(124, 22);
            this.lbActuCodPa.TabIndex = 15;
            this.lbActuCodPa.Text = "Codigo Pais:";
            // 
            // txtActuAnioEmp
            // 
            this.txtActuAnioEmp.Location = new System.Drawing.Point(272, 311);
            this.txtActuAnioEmp.Name = "txtActuAnioEmp";
            this.txtActuAnioEmp.Size = new System.Drawing.Size(144, 26);
            this.txtActuAnioEmp.TabIndex = 14;
            // 
            // lbMensaje2
            // 
            this.lbMensaje2.AutoSize = true;
            this.lbMensaje2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje2.Location = new System.Drawing.Point(20, 11);
            this.lbMensaje2.Name = "lbMensaje2";
            this.lbMensaje2.Size = new System.Drawing.Size(417, 29);
            this.lbMensaje2.TabIndex = 13;
            this.lbMensaje2.Text = "Actualizar datos de la Empresa";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(177, 459);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(183, 54);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // rbActuCasa
            // 
            this.rbActuCasa.AutoSize = true;
            this.rbActuCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActuCasa.Location = new System.Drawing.Point(312, 367);
            this.rbActuCasa.Name = "rbActuCasa";
            this.rbActuCasa.Size = new System.Drawing.Size(140, 26);
            this.rbActuCasa.TabIndex = 11;
            this.rbActuCasa.Text = "Casa Matriz";
            this.rbActuCasa.UseVisualStyleBackColor = true;
            // 
            // rbActuSubsi
            // 
            this.rbActuSubsi.AutoSize = true;
            this.rbActuSubsi.Checked = true;
            this.rbActuSubsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActuSubsi.Location = new System.Drawing.Point(127, 367);
            this.rbActuSubsi.Name = "rbActuSubsi";
            this.rbActuSubsi.Size = new System.Drawing.Size(135, 26);
            this.rbActuSubsi.TabIndex = 10;
            this.rbActuSubsi.TabStop = true;
            this.rbActuSubsi.Text = "Subsidiaria";
            this.rbActuSubsi.UseVisualStyleBackColor = true;
            // 
            // txtActuNomEmp
            // 
            this.txtActuNomEmp.Location = new System.Drawing.Point(272, 245);
            this.txtActuNomEmp.Name = "txtActuNomEmp";
            this.txtActuNomEmp.Size = new System.Drawing.Size(144, 26);
            this.txtActuNomEmp.TabIndex = 8;
            // 
            // txtActuCodigoEmp
            // 
            this.txtActuCodigoEmp.Location = new System.Drawing.Point(272, 139);
            this.txtActuCodigoEmp.Name = "txtActuCodigoEmp";
            this.txtActuCodigoEmp.Size = new System.Drawing.Size(144, 26);
            this.txtActuCodigoEmp.TabIndex = 7;
            this.txtActuCodigoEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActuCodigoEmp_KeyPress);
            // 
            // lbActuTipoEmp
            // 
            this.lbActuTipoEmp.AutoSize = true;
            this.lbActuTipoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuTipoEmp.Location = new System.Drawing.Point(33, 371);
            this.lbActuTipoEmp.Name = "lbActuTipoEmp";
            this.lbActuTipoEmp.Size = new System.Drawing.Size(56, 22);
            this.lbActuTipoEmp.TabIndex = 6;
            this.lbActuTipoEmp.Text = "Tipo:";
            // 
            // lbActuAnioFuEmp
            // 
            this.lbActuAnioFuEmp.AutoSize = true;
            this.lbActuAnioFuEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuAnioFuEmp.Location = new System.Drawing.Point(33, 311);
            this.lbActuAnioFuEmp.Name = "lbActuAnioFuEmp";
            this.lbActuAnioFuEmp.Size = new System.Drawing.Size(150, 22);
            this.lbActuAnioFuEmp.TabIndex = 5;
            this.lbActuAnioFuEmp.Text = "Año Fundacion:";
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(272, 91);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(144, 26);
            this.txtBuscarCodigo.TabIndex = 4;
            this.txtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCodigo_KeyPress);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigo.Location = new System.Drawing.Point(447, 82);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(185, 41);
            this.btnBuscarCodigo.TabIndex = 3;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // lbActuNombreEmp
            // 
            this.lbActuNombreEmp.AutoSize = true;
            this.lbActuNombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuNombreEmp.Location = new System.Drawing.Point(33, 249);
            this.lbActuNombreEmp.Name = "lbActuNombreEmp";
            this.lbActuNombreEmp.Size = new System.Drawing.Size(169, 22);
            this.lbActuNombreEmp.TabIndex = 2;
            this.lbActuNombreEmp.Text = "Nombre Empresa:";
            // 
            // lbActuCodigoEmp
            // 
            this.lbActuCodigoEmp.AutoSize = true;
            this.lbActuCodigoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuCodigoEmp.Location = new System.Drawing.Point(33, 139);
            this.lbActuCodigoEmp.Name = "lbActuCodigoEmp";
            this.lbActuCodigoEmp.Size = new System.Drawing.Size(79, 22);
            this.lbActuCodigoEmp.TabIndex = 1;
            this.lbActuCodigoEmp.Text = "Codigo:";
            // 
            // lbCodigoBuscar
            // 
            this.lbCodigoBuscar.AutoSize = true;
            this.lbCodigoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBuscar.Location = new System.Drawing.Point(29, 91);
            this.lbCodigoBuscar.Name = "lbCodigoBuscar";
            this.lbCodigoBuscar.Size = new System.Drawing.Size(216, 22);
            this.lbCodigoBuscar.TabIndex = 0;
            this.lbCodigoBuscar.Text = "Digite codigo a buscar:";
            // 
            // tbpEliminarEmp
            // 
            this.tbpEliminarEmp.Controls.Add(this.pnlEliminarEmp);
            this.tbpEliminarEmp.Location = new System.Drawing.Point(4, 29);
            this.tbpEliminarEmp.Name = "tbpEliminarEmp";
            this.tbpEliminarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarEmp.Size = new System.Drawing.Size(994, 572);
            this.tbpEliminarEmp.TabIndex = 2;
            this.tbpEliminarEmp.Text = "Eliminar Empresa";
            this.tbpEliminarEmp.UseVisualStyleBackColor = true;
            // 
            // pnlEliminarEmp
            // 
            this.pnlEliminarEmp.Controls.Add(this.lbMensaje3);
            this.pnlEliminarEmp.Controls.Add(this.btnEliminarEmp);
            this.pnlEliminarEmp.Controls.Add(this.txtCodEmpEliminar);
            this.pnlEliminarEmp.Controls.Add(this.lbCodEmpEliminar);
            this.pnlEliminarEmp.Controls.Add(this.dgvDatosEmpresas);
            this.pnlEliminarEmp.Controls.Add(this.btnConsultarEmp);
            this.pnlEliminarEmp.Location = new System.Drawing.Point(17, 38);
            this.pnlEliminarEmp.Name = "pnlEliminarEmp";
            this.pnlEliminarEmp.Size = new System.Drawing.Size(944, 479);
            this.pnlEliminarEmp.TabIndex = 2;
            // 
            // lbMensaje3
            // 
            this.lbMensaje3.AutoSize = true;
            this.lbMensaje3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje3.Location = new System.Drawing.Point(38, 20);
            this.lbMensaje3.Name = "lbMensaje3";
            this.lbMensaje3.Size = new System.Drawing.Size(240, 29);
            this.lbMensaje3.TabIndex = 5;
            this.lbMensaje3.Text = "Eliminar Empresa";
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmp.Location = new System.Drawing.Point(476, 369);
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Size = new System.Drawing.Size(167, 48);
            this.btnEliminarEmp.TabIndex = 4;
            this.btnEliminarEmp.Text = "Eliminar";
            this.btnEliminarEmp.UseVisualStyleBackColor = false;
            this.btnEliminarEmp.Click += new System.EventHandler(this.btnEliminarEmp_Click);
            // 
            // txtCodEmpEliminar
            // 
            this.txtCodEmpEliminar.Location = new System.Drawing.Point(300, 381);
            this.txtCodEmpEliminar.Name = "txtCodEmpEliminar";
            this.txtCodEmpEliminar.Size = new System.Drawing.Size(170, 26);
            this.txtCodEmpEliminar.TabIndex = 3;
            this.txtCodEmpEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEmpEliminar_KeyPress);
            // 
            // lbCodEmpEliminar
            // 
            this.lbCodEmpEliminar.AutoSize = true;
            this.lbCodEmpEliminar.BackColor = System.Drawing.Color.Khaki;
            this.lbCodEmpEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodEmpEliminar.Location = new System.Drawing.Point(62, 381);
            this.lbCodEmpEliminar.Name = "lbCodEmpEliminar";
            this.lbCodEmpEliminar.Size = new System.Drawing.Size(220, 22);
            this.lbCodEmpEliminar.TabIndex = 2;
            this.lbCodEmpEliminar.Text = "Digite codigo a eliminar";
            // 
            // dgvDatosEmpresas
            // 
            this.dgvDatosEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmpresas.Location = new System.Drawing.Point(66, 146);
            this.dgvDatosEmpresas.Name = "dgvDatosEmpresas";
            this.dgvDatosEmpresas.RowTemplate.Height = 28;
            this.dgvDatosEmpresas.Size = new System.Drawing.Size(802, 196);
            this.dgvDatosEmpresas.TabIndex = 1;
            // 
            // btnConsultarEmp
            // 
            this.btnConsultarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEmp.Location = new System.Drawing.Point(349, 60);
            this.btnConsultarEmp.Name = "btnConsultarEmp";
            this.btnConsultarEmp.Size = new System.Drawing.Size(267, 63);
            this.btnConsultarEmp.TabIndex = 0;
            this.btnConsultarEmp.Text = "Consultar Empresas";
            this.btnConsultarEmp.UseVisualStyleBackColor = false;
            this.btnConsultarEmp.Click += new System.EventHandler(this.btnConsultarEmp_Click);
            // 
            // formGestionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 641);
            this.Controls.Add(this.tbcOperacionesEmp);
            this.Name = "formGestionarEmpresa";
            this.Text = "Gestionar Empresa Discografica";
            this.pnlRegistroEmp.ResumeLayout(false);
            this.pnlRegistroEmp.PerformLayout();
            this.tbcOperacionesEmp.ResumeLayout(false);
            this.tbpRegistroEmp.ResumeLayout(false);
            this.tbpActualizarEmp.ResumeLayout(false);
            this.pnlActualizarEmp.ResumeLayout(false);
            this.pnlActualizarEmp.PerformLayout();
            this.tbpEliminarEmp.ResumeLayout(false);
            this.pnlEliminarEmp.ResumeLayout(false);
            this.pnlEliminarEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtCodigoEmp;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbAnioFundacion;
        private System.Windows.Forms.Label lbNomEmpresa;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnGuardarEmp;
        private System.Windows.Forms.RadioButton rbCasaMatriz;
        private System.Windows.Forms.RadioButton rbSubsidiaria;
        private System.Windows.Forms.DateTimePicker dtpAnioFund;
        private System.Windows.Forms.Label lbMensaje1;
        private System.Windows.Forms.TabControl tbcOperacionesEmp;
        private System.Windows.Forms.TabPage tbpRegistroEmp;
        private System.Windows.Forms.TabPage tbpActualizarEmp;
        private System.Windows.Forms.Panel pnlActualizarEmp;
        private System.Windows.Forms.Label lbActuNombreEmp;
        private System.Windows.Forms.Label lbActuCodigoEmp;
        private System.Windows.Forms.Label lbCodigoBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.RadioButton rbActuCasa;
        private System.Windows.Forms.RadioButton rbActuSubsi;
        private System.Windows.Forms.TextBox txtActuNomEmp;
        private System.Windows.Forms.TextBox txtActuCodigoEmp;
        private System.Windows.Forms.Label lbActuTipoEmp;
        private System.Windows.Forms.Label lbActuAnioFuEmp;
        private System.Windows.Forms.Panel pnlEliminarEmp;
        private System.Windows.Forms.TabPage tbpEliminarEmp;
        private System.Windows.Forms.Button btnEliminarEmp;
        private System.Windows.Forms.TextBox txtCodEmpEliminar;
        private System.Windows.Forms.Label lbCodEmpEliminar;
        private System.Windows.Forms.DataGridView dgvDatosEmpresas;
        private System.Windows.Forms.Button btnConsultarEmp;
        private System.Windows.Forms.Label lbMensaje3;
        private System.Windows.Forms.Label lbMensaje2;
        private System.Windows.Forms.TextBox txtActuAnioEmp;
        private System.Windows.Forms.TextBox txtActuCodPa;
        private System.Windows.Forms.Label lbActuCodPa;
        private System.Windows.Forms.TextBox txtRegCodPa;
        private System.Windows.Forms.Label lbRegCodPa;
        private System.Windows.Forms.Button btnLimpiarRe;
        private System.Windows.Forms.Button btnLimpiarAct;
    }
}

