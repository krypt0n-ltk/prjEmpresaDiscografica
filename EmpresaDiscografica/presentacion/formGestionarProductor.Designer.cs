namespace EmpresaDiscografica
{
    partial class formGestionarProductor
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
            this.tbpEliminarProd = new System.Windows.Forms.TabPage();
            this.txtTarjetaEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.lbTarjetaEliminar = new System.Windows.Forms.Label();
            this.lbMensaje7 = new System.Windows.Forms.Label();
            this.dgvDatosProductores = new System.Windows.Forms.DataGridView();
            this.btnconsultarProd = new System.Windows.Forms.Button();
            this.tpbActuProd = new System.Windows.Forms.TabPage();
            this.pnlActualizarProd = new System.Windows.Forms.Panel();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtTarjetaBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.cbxActuGenero = new System.Windows.Forms.ComboBox();
            this.cbxActuAnioExp = new System.Windows.Forms.ComboBox();
            this.txtActuApellido = new System.Windows.Forms.TextBox();
            this.txtActuNombreProd = new System.Windows.Forms.TextBox();
            this.txtActuTarjeta = new System.Windows.Forms.TextBox();
            this.lbActuGenero = new System.Windows.Forms.Label();
            this.lbActuAnioExp = new System.Windows.Forms.Label();
            this.lbActuApellido = new System.Windows.Forms.Label();
            this.lbActuNombreProd = new System.Windows.Forms.Label();
            this.lbActuTarjeta = new System.Windows.Forms.Label();
            this.lbTarjetaBuscar = new System.Windows.Forms.Label();
            this.lbMensaje6 = new System.Windows.Forms.Label();
            this.tbpRegistroProd = new System.Windows.Forms.TabPage();
            this.pnlRegistroProd = new System.Windows.Forms.Panel();
            this.btnLimpiarRe = new System.Windows.Forms.Button();
            this.btnGuardarProd = new System.Windows.Forms.Button();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxAnioExp = new System.Windows.Forms.ComboBox();
            this.txtApellidoProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtTarjetaPro = new System.Windows.Forms.TextBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbAnioExp = new System.Windows.Forms.Label();
            this.lbApellidoProd = new System.Windows.Forms.Label();
            this.lbNombreProd = new System.Windows.Forms.Label();
            this.lbNumTarjeta = new System.Windows.Forms.Label();
            this.lbMensaje5 = new System.Windows.Forms.Label();
            this.tbcOperacionesProd = new System.Windows.Forms.TabControl();
            this.tbpEliminarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductores)).BeginInit();
            this.tpbActuProd.SuspendLayout();
            this.pnlActualizarProd.SuspendLayout();
            this.tbpRegistroProd.SuspendLayout();
            this.pnlRegistroProd.SuspendLayout();
            this.tbcOperacionesProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpEliminarProd
            // 
            this.tbpEliminarProd.Controls.Add(this.txtTarjetaEliminar);
            this.tbpEliminarProd.Controls.Add(this.btnEliminarProd);
            this.tbpEliminarProd.Controls.Add(this.lbTarjetaEliminar);
            this.tbpEliminarProd.Controls.Add(this.lbMensaje7);
            this.tbpEliminarProd.Controls.Add(this.dgvDatosProductores);
            this.tbpEliminarProd.Controls.Add(this.btnconsultarProd);
            this.tbpEliminarProd.Location = new System.Drawing.Point(4, 29);
            this.tbpEliminarProd.Name = "tbpEliminarProd";
            this.tbpEliminarProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarProd.Size = new System.Drawing.Size(1014, 568);
            this.tbpEliminarProd.TabIndex = 2;
            this.tbpEliminarProd.Text = "Eliminar Productor";
            this.tbpEliminarProd.UseVisualStyleBackColor = true;
            // 
            // txtTarjetaEliminar
            // 
            this.txtTarjetaEliminar.Location = new System.Drawing.Point(382, 447);
            this.txtTarjetaEliminar.Name = "txtTarjetaEliminar";
            this.txtTarjetaEliminar.Size = new System.Drawing.Size(180, 26);
            this.txtTarjetaEliminar.TabIndex = 5;
            this.txtTarjetaEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaEliminar_KeyPress);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(592, 433);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(146, 53);
            this.btnEliminarProd.TabIndex = 4;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // lbTarjetaEliminar
            // 
            this.lbTarjetaEliminar.AutoSize = true;
            this.lbTarjetaEliminar.BackColor = System.Drawing.Color.Khaki;
            this.lbTarjetaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjetaEliminar.Location = new System.Drawing.Point(63, 447);
            this.lbTarjetaEliminar.Name = "lbTarjetaEliminar";
            this.lbTarjetaEliminar.Size = new System.Drawing.Size(275, 22);
            this.lbTarjetaEliminar.TabIndex = 3;
            this.lbTarjetaEliminar.Text = "Ingrese la Tarjeta Profesional";
            // 
            // lbMensaje7
            // 
            this.lbMensaje7.AutoSize = true;
            this.lbMensaje7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje7.Location = new System.Drawing.Point(52, 32);
            this.lbMensaje7.Name = "lbMensaje7";
            this.lbMensaje7.Size = new System.Drawing.Size(272, 29);
            this.lbMensaje7.TabIndex = 2;
            this.lbMensaje7.Text = "Eliminar Productor";
            // 
            // dgvDatosProductores
            // 
            this.dgvDatosProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProductores.Location = new System.Drawing.Point(56, 169);
            this.dgvDatosProductores.Name = "dgvDatosProductores";
            this.dgvDatosProductores.RowTemplate.Height = 28;
            this.dgvDatosProductores.Size = new System.Drawing.Size(911, 188);
            this.dgvDatosProductores.TabIndex = 1;
            // 
            // btnconsultarProd
            // 
            this.btnconsultarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnconsultarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarProd.Location = new System.Drawing.Point(345, 83);
            this.btnconsultarProd.Name = "btnconsultarProd";
            this.btnconsultarProd.Size = new System.Drawing.Size(312, 54);
            this.btnconsultarProd.TabIndex = 0;
            this.btnconsultarProd.Text = "Consultar Productores";
            this.btnconsultarProd.UseVisualStyleBackColor = false;
            this.btnconsultarProd.Click += new System.EventHandler(this.btnconsultarProd_Click);
            // 
            // tpbActuProd
            // 
            this.tpbActuProd.Controls.Add(this.pnlActualizarProd);
            this.tpbActuProd.Location = new System.Drawing.Point(4, 29);
            this.tpbActuProd.Name = "tpbActuProd";
            this.tpbActuProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpbActuProd.Size = new System.Drawing.Size(1014, 568);
            this.tpbActuProd.TabIndex = 1;
            this.tpbActuProd.Text = "Actualizar Productor";
            this.tpbActuProd.UseVisualStyleBackColor = true;
            // 
            // pnlActualizarProd
            // 
            this.pnlActualizarProd.Controls.Add(this.btnLimpiarAct);
            this.pnlActualizarProd.Controls.Add(this.btnBuscarProd);
            this.pnlActualizarProd.Controls.Add(this.txtTarjetaBuscar);
            this.pnlActualizarProd.Controls.Add(this.btnActualizarProd);
            this.pnlActualizarProd.Controls.Add(this.cbxActuGenero);
            this.pnlActualizarProd.Controls.Add(this.cbxActuAnioExp);
            this.pnlActualizarProd.Controls.Add(this.txtActuApellido);
            this.pnlActualizarProd.Controls.Add(this.txtActuNombreProd);
            this.pnlActualizarProd.Controls.Add(this.txtActuTarjeta);
            this.pnlActualizarProd.Controls.Add(this.lbActuGenero);
            this.pnlActualizarProd.Controls.Add(this.lbActuAnioExp);
            this.pnlActualizarProd.Controls.Add(this.lbActuApellido);
            this.pnlActualizarProd.Controls.Add(this.lbActuNombreProd);
            this.pnlActualizarProd.Controls.Add(this.lbActuTarjeta);
            this.pnlActualizarProd.Controls.Add(this.lbTarjetaBuscar);
            this.pnlActualizarProd.Controls.Add(this.lbMensaje6);
            this.pnlActualizarProd.Location = new System.Drawing.Point(90, 36);
            this.pnlActualizarProd.Name = "pnlActualizarProd";
            this.pnlActualizarProd.Size = new System.Drawing.Size(821, 508);
            this.pnlActualizarProd.TabIndex = 2;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAct.Location = new System.Drawing.Point(631, 425);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(155, 47);
            this.btnLimpiarAct.TabIndex = 35;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = false;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(631, 72);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(155, 44);
            this.btnBuscarProd.TabIndex = 34;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtTarjetaBuscar
            // 
            this.txtTarjetaBuscar.Location = new System.Drawing.Point(466, 82);
            this.txtTarjetaBuscar.Name = "txtTarjetaBuscar";
            this.txtTarjetaBuscar.Size = new System.Drawing.Size(137, 26);
            this.txtTarjetaBuscar.TabIndex = 33;
            this.txtTarjetaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaBuscar_KeyPress);
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Location = new System.Drawing.Point(307, 425);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(149, 55);
            this.btnActualizarProd.TabIndex = 32;
            this.btnActualizarProd.Text = "Actualizar";
            this.btnActualizarProd.UseVisualStyleBackColor = false;
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // cbxActuGenero
            // 
            this.cbxActuGenero.FormattingEnabled = true;
            this.cbxActuGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxActuGenero.Location = new System.Drawing.Point(466, 356);
            this.cbxActuGenero.Name = "cbxActuGenero";
            this.cbxActuGenero.Size = new System.Drawing.Size(140, 28);
            this.cbxActuGenero.TabIndex = 31;
            // 
            // cbxActuAnioExp
            // 
            this.cbxActuAnioExp.FormattingEnabled = true;
            this.cbxActuAnioExp.Items.AddRange(new object[] {
            "Menor de 5 años.",
            "Entre 5 y 10 años.",
            "De 11 a 20 años.",
            "Mas de 20 años."});
            this.cbxActuAnioExp.Location = new System.Drawing.Point(466, 303);
            this.cbxActuAnioExp.Name = "cbxActuAnioExp";
            this.cbxActuAnioExp.Size = new System.Drawing.Size(137, 28);
            this.cbxActuAnioExp.TabIndex = 30;
            // 
            // txtActuApellido
            // 
            this.txtActuApellido.Location = new System.Drawing.Point(466, 249);
            this.txtActuApellido.Name = "txtActuApellido";
            this.txtActuApellido.Size = new System.Drawing.Size(137, 26);
            this.txtActuApellido.TabIndex = 29;
            // 
            // txtActuNombreProd
            // 
            this.txtActuNombreProd.Location = new System.Drawing.Point(466, 190);
            this.txtActuNombreProd.Name = "txtActuNombreProd";
            this.txtActuNombreProd.Size = new System.Drawing.Size(137, 26);
            this.txtActuNombreProd.TabIndex = 28;
            // 
            // txtActuTarjeta
            // 
            this.txtActuTarjeta.Location = new System.Drawing.Point(466, 136);
            this.txtActuTarjeta.Name = "txtActuTarjeta";
            this.txtActuTarjeta.Size = new System.Drawing.Size(137, 26);
            this.txtActuTarjeta.TabIndex = 27;
            this.txtActuTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActuTarjeta_KeyPress);
            // 
            // lbActuGenero
            // 
            this.lbActuGenero.AutoSize = true;
            this.lbActuGenero.BackColor = System.Drawing.Color.White;
            this.lbActuGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuGenero.Location = new System.Drawing.Point(111, 356);
            this.lbActuGenero.Name = "lbActuGenero";
            this.lbActuGenero.Size = new System.Drawing.Size(82, 22);
            this.lbActuGenero.TabIndex = 26;
            this.lbActuGenero.Text = "Genero:";
            // 
            // lbActuAnioExp
            // 
            this.lbActuAnioExp.AutoSize = true;
            this.lbActuAnioExp.BackColor = System.Drawing.Color.White;
            this.lbActuAnioExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuAnioExp.Location = new System.Drawing.Point(107, 303);
            this.lbActuAnioExp.Name = "lbActuAnioExp";
            this.lbActuAnioExp.Size = new System.Drawing.Size(200, 22);
            this.lbActuAnioExp.TabIndex = 25;
            this.lbActuAnioExp.Text = "Años de Experiencia:";
            // 
            // lbActuApellido
            // 
            this.lbActuApellido.AutoSize = true;
            this.lbActuApellido.BackColor = System.Drawing.Color.White;
            this.lbActuApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuApellido.Location = new System.Drawing.Point(107, 249);
            this.lbActuApellido.Name = "lbActuApellido";
            this.lbActuApellido.Size = new System.Drawing.Size(88, 22);
            this.lbActuApellido.TabIndex = 24;
            this.lbActuApellido.Text = "Apellido:";
            // 
            // lbActuNombreProd
            // 
            this.lbActuNombreProd.AutoSize = true;
            this.lbActuNombreProd.BackColor = System.Drawing.Color.White;
            this.lbActuNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuNombreProd.Location = new System.Drawing.Point(107, 190);
            this.lbActuNombreProd.Name = "lbActuNombreProd";
            this.lbActuNombreProd.Size = new System.Drawing.Size(85, 22);
            this.lbActuNombreProd.TabIndex = 23;
            this.lbActuNombreProd.Text = "Nombre:";
            // 
            // lbActuTarjeta
            // 
            this.lbActuTarjeta.AutoSize = true;
            this.lbActuTarjeta.BackColor = System.Drawing.Color.White;
            this.lbActuTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuTarjeta.Location = new System.Drawing.Point(107, 136);
            this.lbActuTarjeta.Name = "lbActuTarjeta";
            this.lbActuTarjeta.Size = new System.Drawing.Size(187, 22);
            this.lbActuTarjeta.TabIndex = 22;
            this.lbActuTarjeta.Text = "Tarjeta Profesional:";
            // 
            // lbTarjetaBuscar
            // 
            this.lbTarjetaBuscar.AutoSize = true;
            this.lbTarjetaBuscar.BackColor = System.Drawing.Color.White;
            this.lbTarjetaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjetaBuscar.Location = new System.Drawing.Point(111, 83);
            this.lbTarjetaBuscar.Name = "lbTarjetaBuscar";
            this.lbTarjetaBuscar.Size = new System.Drawing.Size(334, 22);
            this.lbTarjetaBuscar.TabIndex = 21;
            this.lbTarjetaBuscar.Text = "Ingrese Numero Tarjeta Profesional:";
            // 
            // lbMensaje6
            // 
            this.lbMensaje6.AutoSize = true;
            this.lbMensaje6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje6.Location = new System.Drawing.Point(110, 14);
            this.lbMensaje6.Name = "lbMensaje6";
            this.lbMensaje6.Size = new System.Drawing.Size(428, 29);
            this.lbMensaje6.TabIndex = 20;
            this.lbMensaje6.Text = "Actualizar datos del Productor";
            // 
            // tbpRegistroProd
            // 
            this.tbpRegistroProd.Controls.Add(this.pnlRegistroProd);
            this.tbpRegistroProd.Location = new System.Drawing.Point(4, 29);
            this.tbpRegistroProd.Name = "tbpRegistroProd";
            this.tbpRegistroProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistroProd.Size = new System.Drawing.Size(1014, 568);
            this.tbpRegistroProd.TabIndex = 0;
            this.tbpRegistroProd.Text = "Registro Productor ";
            this.tbpRegistroProd.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroProd
            // 
            this.pnlRegistroProd.Controls.Add(this.btnLimpiarRe);
            this.pnlRegistroProd.Controls.Add(this.btnGuardarProd);
            this.pnlRegistroProd.Controls.Add(this.cbxGenero);
            this.pnlRegistroProd.Controls.Add(this.cbxAnioExp);
            this.pnlRegistroProd.Controls.Add(this.txtApellidoProd);
            this.pnlRegistroProd.Controls.Add(this.txtNombreProd);
            this.pnlRegistroProd.Controls.Add(this.txtTarjetaPro);
            this.pnlRegistroProd.Controls.Add(this.lbGenero);
            this.pnlRegistroProd.Controls.Add(this.lbAnioExp);
            this.pnlRegistroProd.Controls.Add(this.lbApellidoProd);
            this.pnlRegistroProd.Controls.Add(this.lbNombreProd);
            this.pnlRegistroProd.Controls.Add(this.lbNumTarjeta);
            this.pnlRegistroProd.Controls.Add(this.lbMensaje5);
            this.pnlRegistroProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistroProd.Location = new System.Drawing.Point(244, 23);
            this.pnlRegistroProd.Name = "pnlRegistroProd";
            this.pnlRegistroProd.Size = new System.Drawing.Size(546, 459);
            this.pnlRegistroProd.TabIndex = 0;
            // 
            // btnLimpiarRe
            // 
            this.btnLimpiarRe.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarRe.Location = new System.Drawing.Point(402, 398);
            this.btnLimpiarRe.Name = "btnLimpiarRe";
            this.btnLimpiarRe.Size = new System.Drawing.Size(106, 38);
            this.btnLimpiarRe.TabIndex = 2;
            this.btnLimpiarRe.Text = "Limpiar";
            this.btnLimpiarRe.UseVisualStyleBackColor = false;
            this.btnLimpiarRe.Click += new System.EventHandler(this.btnLimpiarRe_Click);
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProd.Location = new System.Drawing.Point(224, 398);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(123, 38);
            this.btnGuardarProd.TabIndex = 11;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.UseVisualStyleBackColor = false;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxGenero.Location = new System.Drawing.Point(301, 325);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(152, 30);
            this.cbxGenero.TabIndex = 10;
            // 
            // cbxAnioExp
            // 
            this.cbxAnioExp.FormattingEnabled = true;
            this.cbxAnioExp.Items.AddRange(new object[] {
            "Menor de 5 años.",
            "Entre 5 y 10 años.",
            "De 11 a 20 años.",
            "Mas de 20 años."});
            this.cbxAnioExp.Location = new System.Drawing.Point(301, 272);
            this.cbxAnioExp.Name = "cbxAnioExp";
            this.cbxAnioExp.Size = new System.Drawing.Size(152, 30);
            this.cbxAnioExp.TabIndex = 9;
            // 
            // txtApellidoProd
            // 
            this.txtApellidoProd.Location = new System.Drawing.Point(301, 218);
            this.txtApellidoProd.Name = "txtApellidoProd";
            this.txtApellidoProd.Size = new System.Drawing.Size(152, 28);
            this.txtApellidoProd.TabIndex = 8;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(301, 159);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(152, 28);
            this.txtNombreProd.TabIndex = 7;
            // 
            // txtTarjetaPro
            // 
            this.txtTarjetaPro.Location = new System.Drawing.Point(301, 105);
            this.txtTarjetaPro.Name = "txtTarjetaPro";
            this.txtTarjetaPro.Size = new System.Drawing.Size(152, 28);
            this.txtTarjetaPro.TabIndex = 6;
            this.txtTarjetaPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaPro_KeyPress);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(35, 325);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(82, 22);
            this.lbGenero.TabIndex = 5;
            this.lbGenero.Text = "Genero:";
            // 
            // lbAnioExp
            // 
            this.lbAnioExp.AutoSize = true;
            this.lbAnioExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnioExp.Location = new System.Drawing.Point(31, 272);
            this.lbAnioExp.Name = "lbAnioExp";
            this.lbAnioExp.Size = new System.Drawing.Size(200, 22);
            this.lbAnioExp.TabIndex = 4;
            this.lbAnioExp.Text = "Años de Experiencia:";
            // 
            // lbApellidoProd
            // 
            this.lbApellidoProd.AutoSize = true;
            this.lbApellidoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoProd.Location = new System.Drawing.Point(31, 218);
            this.lbApellidoProd.Name = "lbApellidoProd";
            this.lbApellidoProd.Size = new System.Drawing.Size(88, 22);
            this.lbApellidoProd.TabIndex = 3;
            this.lbApellidoProd.Text = "Apellido:";
            // 
            // lbNombreProd
            // 
            this.lbNombreProd.AutoSize = true;
            this.lbNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProd.Location = new System.Drawing.Point(31, 159);
            this.lbNombreProd.Name = "lbNombreProd";
            this.lbNombreProd.Size = new System.Drawing.Size(85, 22);
            this.lbNombreProd.TabIndex = 2;
            this.lbNombreProd.Text = "Nombre:";
            // 
            // lbNumTarjeta
            // 
            this.lbNumTarjeta.AutoSize = true;
            this.lbNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTarjeta.Location = new System.Drawing.Point(31, 105);
            this.lbNumTarjeta.Name = "lbNumTarjeta";
            this.lbNumTarjeta.Size = new System.Drawing.Size(187, 22);
            this.lbNumTarjeta.TabIndex = 1;
            this.lbNumTarjeta.Text = "Tarjeta Profesional:";
            // 
            // lbMensaje5
            // 
            this.lbMensaje5.AutoSize = true;
            this.lbMensaje5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje5.Location = new System.Drawing.Point(17, 12);
            this.lbMensaje5.Name = "lbMensaje5";
            this.lbMensaje5.Size = new System.Drawing.Size(491, 29);
            this.lbMensaje5.TabIndex = 0;
            this.lbMensaje5.Text = "Ingrese datos del Productor Musical";
            // 
            // tbcOperacionesProd
            // 
            this.tbcOperacionesProd.Controls.Add(this.tbpRegistroProd);
            this.tbcOperacionesProd.Controls.Add(this.tpbActuProd);
            this.tbcOperacionesProd.Controls.Add(this.tbpEliminarProd);
            this.tbcOperacionesProd.Location = new System.Drawing.Point(38, 26);
            this.tbcOperacionesProd.Name = "tbcOperacionesProd";
            this.tbcOperacionesProd.SelectedIndex = 0;
            this.tbcOperacionesProd.Size = new System.Drawing.Size(1022, 601);
            this.tbcOperacionesProd.TabIndex = 1;
            // 
            // formGestionarProductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 639);
            this.Controls.Add(this.tbcOperacionesProd);
            this.Name = "formGestionarProductor";
            this.Text = "FormGestionarProductor";
            this.tbpEliminarProd.ResumeLayout(false);
            this.tbpEliminarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductores)).EndInit();
            this.tpbActuProd.ResumeLayout(false);
            this.pnlActualizarProd.ResumeLayout(false);
            this.pnlActualizarProd.PerformLayout();
            this.tbpRegistroProd.ResumeLayout(false);
            this.pnlRegistroProd.ResumeLayout(false);
            this.pnlRegistroProd.PerformLayout();
            this.tbcOperacionesProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpEliminarProd;
        private System.Windows.Forms.TextBox txtTarjetaEliminar;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Label lbTarjetaEliminar;
        private System.Windows.Forms.Label lbMensaje7;
        private System.Windows.Forms.DataGridView dgvDatosProductores;
        private System.Windows.Forms.Button btnconsultarProd;
        private System.Windows.Forms.TabPage tpbActuProd;
        private System.Windows.Forms.Panel pnlActualizarProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtTarjetaBuscar;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.ComboBox cbxActuGenero;
        private System.Windows.Forms.ComboBox cbxActuAnioExp;
        private System.Windows.Forms.TextBox txtActuApellido;
        private System.Windows.Forms.TextBox txtActuNombreProd;
        private System.Windows.Forms.TextBox txtActuTarjeta;
        private System.Windows.Forms.Label lbActuGenero;
        private System.Windows.Forms.Label lbActuAnioExp;
        private System.Windows.Forms.Label lbActuApellido;
        private System.Windows.Forms.Label lbActuNombreProd;
        private System.Windows.Forms.Label lbActuTarjeta;
        private System.Windows.Forms.Label lbTarjetaBuscar;
        private System.Windows.Forms.Label lbMensaje6;
        private System.Windows.Forms.TabPage tbpRegistroProd;
        private System.Windows.Forms.Panel pnlRegistroProd;
        private System.Windows.Forms.Button btnGuardarProd;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxAnioExp;
        private System.Windows.Forms.TextBox txtApellidoProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtTarjetaPro;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbAnioExp;
        private System.Windows.Forms.Label lbApellidoProd;
        private System.Windows.Forms.Label lbNombreProd;
        private System.Windows.Forms.Label lbNumTarjeta;
        private System.Windows.Forms.Label lbMensaje5;
        private System.Windows.Forms.TabControl tbcOperacionesProd;
        private System.Windows.Forms.Button btnLimpiarRe;
        private System.Windows.Forms.Button btnLimpiarAct;
    }
}