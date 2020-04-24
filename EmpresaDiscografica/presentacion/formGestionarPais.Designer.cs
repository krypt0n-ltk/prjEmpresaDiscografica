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
            this.pnlEliminarPa = new System.Windows.Forms.Panel();
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
            this.pnlEliminarPa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroPais
            // 
            this.pnlRegistroPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegistroPais.Controls.Add(this.btnLimpiarReg);
            this.pnlRegistroPais.Controls.Add(this.txtNombrePais);
            this.pnlRegistroPais.Controls.Add(this.txtCodigoPais);
            this.pnlRegistroPais.Controls.Add(this.btnGuardarPais);
            this.pnlRegistroPais.Controls.Add(this.lbCodigoPais);
            this.pnlRegistroPais.Controls.Add(this.lbNombrePais);
            this.pnlRegistroPais.Controls.Add(this.lbMensaje7);
            this.pnlRegistroPais.Location = new System.Drawing.Point(116, 53);
            this.pnlRegistroPais.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegistroPais.Name = "pnlRegistroPais";
            this.pnlRegistroPais.Size = new System.Drawing.Size(407, 246);
            this.pnlRegistroPais.TabIndex = 0;
            // 
            // btnLimpiarReg
            // 
            this.btnLimpiarReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarReg.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReg.Location = new System.Drawing.Point(55, 180);
            this.btnLimpiarReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarReg.Name = "btnLimpiarReg";
            this.btnLimpiarReg.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiarReg.TabIndex = 6;
            this.btnLimpiarReg.Text = "Limpiar";
            this.btnLimpiarReg.UseVisualStyleBackColor = false;
            this.btnLimpiarReg.Click += new System.EventHandler(this.btnLimpiarReg_Click);
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombrePais.Location = new System.Drawing.Point(122, 130);
            this.txtNombrePais.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(88, 20);
            this.txtNombrePais.TabIndex = 5;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoPais.Location = new System.Drawing.Point(122, 79);
            this.txtCodigoPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(88, 20);
            this.txtCodigoPais.TabIndex = 4;
            this.txtCodigoPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPais_KeyPress);
            // 
            // btnGuardarPais
            // 
            this.btnGuardarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPais.Location = new System.Drawing.Point(289, 180);
            this.btnGuardarPais.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPais.Name = "btnGuardarPais";
            this.btnGuardarPais.Size = new System.Drawing.Size(83, 25);
            this.btnGuardarPais.TabIndex = 7;
            this.btnGuardarPais.Text = "Guardar";
            this.btnGuardarPais.UseVisualStyleBackColor = false;
            this.btnGuardarPais.Click += new System.EventHandler(this.btnGuardarPais_Click);
            // 
            // lbCodigoPais
            // 
            this.lbCodigoPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodigoPais.AutoSize = true;
            this.lbCodigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoPais.Location = new System.Drawing.Point(52, 81);
            this.lbCodigoPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoPais.Name = "lbCodigoPais";
            this.lbCodigoPais.Size = new System.Drawing.Size(56, 15);
            this.lbCodigoPais.TabIndex = 2;
            this.lbCodigoPais.Text = "Codigo:";
            // 
            // lbNombrePais
            // 
            this.lbNombrePais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombrePais.AutoSize = true;
            this.lbNombrePais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePais.Location = new System.Drawing.Point(52, 130);
            this.lbNombrePais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombrePais.Name = "lbNombrePais";
            this.lbNombrePais.Size = new System.Drawing.Size(62, 15);
            this.lbNombrePais.TabIndex = 1;
            this.lbNombrePais.Text = "Nombre:";
            // 
            // lbMensaje7
            // 
            this.lbMensaje7.AutoSize = true;
            this.lbMensaje7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje7.Location = new System.Drawing.Point(51, 31);
            this.lbMensaje7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensaje7.Name = "lbMensaje7";
            this.lbMensaje7.Size = new System.Drawing.Size(202, 19);
            this.lbMensaje7.TabIndex = 0;
            this.lbMensaje7.Text = "Ingrese Datos del Pais ";
            // 
            // tbcGestionPais
            // 
            this.tbcGestionPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcGestionPais.Controls.Add(this.tbpRegristroPais);
            this.tbcGestionPais.Controls.Add(this.tbpActuPais);
            this.tbcGestionPais.Controls.Add(this.tbpEliminarPais);
            this.tbcGestionPais.Location = new System.Drawing.Point(11, 11);
            this.tbcGestionPais.Margin = new System.Windows.Forms.Padding(2);
            this.tbcGestionPais.Name = "tbcGestionPais";
            this.tbcGestionPais.SelectedIndex = 0;
            this.tbcGestionPais.Size = new System.Drawing.Size(665, 412);
            this.tbcGestionPais.TabIndex = 1;
            // 
            // tbpRegristroPais
            // 
            this.tbpRegristroPais.Controls.Add(this.pnlRegistroPais);
            this.tbpRegristroPais.Location = new System.Drawing.Point(4, 22);
            this.tbpRegristroPais.Margin = new System.Windows.Forms.Padding(2);
            this.tbpRegristroPais.Name = "tbpRegristroPais";
            this.tbpRegristroPais.Padding = new System.Windows.Forms.Padding(40, 30, 2, 2);
            this.tbpRegristroPais.Size = new System.Drawing.Size(657, 386);
            this.tbpRegristroPais.TabIndex = 0;
            this.tbpRegristroPais.Text = "Registro Pais";
            this.tbpRegristroPais.UseVisualStyleBackColor = true;
            // 
            // tbpActuPais
            // 
            this.tbpActuPais.Controls.Add(this.pnlActualizarPais);
            this.tbpActuPais.Location = new System.Drawing.Point(4, 22);
            this.tbpActuPais.Margin = new System.Windows.Forms.Padding(2);
            this.tbpActuPais.Name = "tbpActuPais";
            this.tbpActuPais.Padding = new System.Windows.Forms.Padding(2);
            this.tbpActuPais.Size = new System.Drawing.Size(657, 386);
            this.tbpActuPais.TabIndex = 1;
            this.tbpActuPais.Text = "Actualizar Pais";
            this.tbpActuPais.UseVisualStyleBackColor = true;
            // 
            // pnlActualizarPais
            // 
            this.pnlActualizarPais.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.pnlActualizarPais.Location = new System.Drawing.Point(94, 48);
            this.pnlActualizarPais.Margin = new System.Windows.Forms.Padding(2);
            this.pnlActualizarPais.Name = "pnlActualizarPais";
            this.pnlActualizarPais.Size = new System.Drawing.Size(472, 248);
            this.pnlActualizarPais.TabIndex = 2;
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiarAct.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAct.Location = new System.Drawing.Point(46, 202);
            this.btnLimpiarAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(97, 31);
            this.btnLimpiarAct.TabIndex = 10;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = false;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnActualizarPais
            // 
            this.btnActualizarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPais.Location = new System.Drawing.Point(325, 202);
            this.btnActualizarPais.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPais.Name = "btnActualizarPais";
            this.btnActualizarPais.Size = new System.Drawing.Size(119, 31);
            this.btnActualizarPais.TabIndex = 11;
            this.btnActualizarPais.Text = "Actualizar";
            this.btnActualizarPais.UseVisualStyleBackColor = false;
            this.btnActualizarPais.Click += new System.EventHandler(this.btnActualizarPais_Click);
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPais.Location = new System.Drawing.Point(336, 63);
            this.btnBuscarPais.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(97, 32);
            this.btnBuscarPais.TabIndex = 7;
            this.btnBuscarPais.Text = "Buscar";
            this.btnBuscarPais.UseVisualStyleBackColor = false;
            this.btnBuscarPais.Click += new System.EventHandler(this.btnBuscarPais_Click);
            // 
            // txtCodBuscarPais
            // 
            this.txtCodBuscarPais.Location = new System.Drawing.Point(227, 72);
            this.txtCodBuscarPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodBuscarPais.Name = "txtCodBuscarPais";
            this.txtCodBuscarPais.Size = new System.Drawing.Size(92, 20);
            this.txtCodBuscarPais.TabIndex = 6;
            this.txtCodBuscarPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBuscarPais_KeyPress);
            // 
            // txtActuNomPais
            // 
            this.txtActuNomPais.Location = new System.Drawing.Point(227, 151);
            this.txtActuNomPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtActuNomPais.Name = "txtActuNomPais";
            this.txtActuNomPais.Size = new System.Drawing.Size(92, 20);
            this.txtActuNomPais.TabIndex = 9;
            // 
            // txtActuCodPais
            // 
            this.txtActuCodPais.Location = new System.Drawing.Point(227, 108);
            this.txtActuCodPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtActuCodPais.Name = "txtActuCodPais";
            this.txtActuCodPais.Size = new System.Drawing.Size(92, 20);
            this.txtActuCodPais.TabIndex = 8;
            this.txtActuCodPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPaisEliminar_KeyPress);
            // 
            // lbActuCodPais
            // 
            this.lbActuCodPais.AutoSize = true;
            this.lbActuCodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuCodPais.Location = new System.Drawing.Point(45, 109);
            this.lbActuCodPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActuCodPais.Name = "lbActuCodPais";
            this.lbActuCodPais.Size = new System.Drawing.Size(56, 15);
            this.lbActuCodPais.TabIndex = 3;
            this.lbActuCodPais.Text = "Codigo:";
            // 
            // lbActuNomPais
            // 
            this.lbActuNomPais.AutoSize = true;
            this.lbActuNomPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActuNomPais.Location = new System.Drawing.Point(45, 151);
            this.lbActuNomPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActuNomPais.Name = "lbActuNomPais";
            this.lbActuNomPais.Size = new System.Drawing.Size(62, 15);
            this.lbActuNomPais.TabIndex = 2;
            this.lbActuNomPais.Text = "Nombre:";
            // 
            // lbCodBuscarPais
            // 
            this.lbCodBuscarPais.AutoSize = true;
            this.lbCodBuscarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodBuscarPais.Location = new System.Drawing.Point(43, 72);
            this.lbCodBuscarPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodBuscarPais.Name = "lbCodBuscarPais";
            this.lbCodBuscarPais.Size = new System.Drawing.Size(180, 15);
            this.lbCodBuscarPais.TabIndex = 1;
            this.lbCodBuscarPais.Text = "Ingrese el Codigo del Pais:";
            // 
            // lbMensaje8
            // 
            this.lbMensaje8.AutoSize = true;
            this.lbMensaje8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje8.Location = new System.Drawing.Point(42, 27);
            this.lbMensaje8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensaje8.Name = "lbMensaje8";
            this.lbMensaje8.Size = new System.Drawing.Size(142, 19);
            this.lbMensaje8.TabIndex = 0;
            this.lbMensaje8.Text = "Actualizar Pais";
            // 
            // tbpEliminarPais
            // 
            this.tbpEliminarPais.Controls.Add(this.pnlEliminarPa);
            this.tbpEliminarPais.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminarPais.Margin = new System.Windows.Forms.Padding(2);
            this.tbpEliminarPais.Name = "tbpEliminarPais";
            this.tbpEliminarPais.Padding = new System.Windows.Forms.Padding(2);
            this.tbpEliminarPais.Size = new System.Drawing.Size(657, 386);
            this.tbpEliminarPais.TabIndex = 2;
            this.tbpEliminarPais.Text = "Eliminar Pais";
            this.tbpEliminarPais.UseVisualStyleBackColor = true;
            // 
            // pnlEliminarPa
            // 
            this.pnlEliminarPa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEliminarPa.Controls.Add(this.btnEliminarPais);
            this.pnlEliminarPa.Controls.Add(this.txtCodPaisEliminar);
            this.pnlEliminarPa.Controls.Add(this.lbMensaje9);
            this.pnlEliminarPa.Controls.Add(this.lbCodPaisEliminar);
            this.pnlEliminarPa.Controls.Add(this.dgvDatosPaises);
            this.pnlEliminarPa.Controls.Add(this.btnConsultarPais);
            this.pnlEliminarPa.Location = new System.Drawing.Point(50, 16);
            this.pnlEliminarPa.Name = "pnlEliminarPa";
            this.pnlEliminarPa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlEliminarPa.Size = new System.Drawing.Size(541, 353);
            this.pnlEliminarPa.TabIndex = 6;
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPais.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPais.Location = new System.Drawing.Point(437, 305);
            this.btnEliminarPais.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(98, 38);
            this.btnEliminarPais.TabIndex = 11;
            this.btnEliminarPais.Text = "Eliminar";
            this.btnEliminarPais.UseVisualStyleBackColor = false;
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // txtCodPaisEliminar
            // 
            this.txtCodPaisEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodPaisEliminar.Location = new System.Drawing.Point(152, 322);
            this.txtCodPaisEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPaisEliminar.Name = "txtCodPaisEliminar";
            this.txtCodPaisEliminar.Size = new System.Drawing.Size(95, 20);
            this.txtCodPaisEliminar.TabIndex = 10;
            // 
            // lbMensaje9
            // 
            this.lbMensaje9.AutoSize = true;
            this.lbMensaje9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje9.Location = new System.Drawing.Point(26, 10);
            this.lbMensaje9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensaje9.Name = "lbMensaje9";
            this.lbMensaje9.Size = new System.Drawing.Size(123, 19);
            this.lbMensaje9.TabIndex = 9;
            this.lbMensaje9.Text = "Eliminar Pais";
            // 
            // lbCodPaisEliminar
            // 
            this.lbCodPaisEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodPaisEliminar.AutoSize = true;
            this.lbCodPaisEliminar.BackColor = System.Drawing.Color.Khaki;
            this.lbCodPaisEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodPaisEliminar.Location = new System.Drawing.Point(27, 323);
            this.lbCodPaisEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodPaisEliminar.Name = "lbCodPaisEliminar";
            this.lbCodPaisEliminar.Size = new System.Drawing.Size(108, 15);
            this.lbCodPaisEliminar.TabIndex = 8;
            this.lbCodPaisEliminar.Text = "Ingrese Codigo:";
            // 
            // dgvDatosPaises
            // 
            this.dgvDatosPaises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPaises.Location = new System.Drawing.Point(30, 107);
            this.dgvDatosPaises.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosPaises.Name = "dgvDatosPaises";
            this.dgvDatosPaises.RowTemplate.Height = 28;
            this.dgvDatosPaises.Size = new System.Drawing.Size(400, 177);
            this.dgvDatosPaises.TabIndex = 7;
            // 
            // btnConsultarPais
            // 
            this.btnConsultarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPais.Location = new System.Drawing.Point(26, 48);
            this.btnConsultarPais.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarPais.Name = "btnConsultarPais";
            this.btnConsultarPais.Size = new System.Drawing.Size(159, 36);
            this.btnConsultarPais.TabIndex = 6;
            this.btnConsultarPais.Text = "Consultar Pais";
            this.btnConsultarPais.UseVisualStyleBackColor = false;
            this.btnConsultarPais.Click += new System.EventHandler(this.btnConsultarPais_Click);
            // 
            // formGestionarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tbcGestionPais);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.pnlEliminarPa.ResumeLayout(false);
            this.pnlEliminarPa.PerformLayout();
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
        private System.Windows.Forms.Button btnLimpiarReg;
        private System.Windows.Forms.Button btnLimpiarAct;
        private System.Windows.Forms.Panel pnlEliminarPa;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.TextBox txtCodPaisEliminar;
        private System.Windows.Forms.Label lbMensaje9;
        private System.Windows.Forms.Label lbCodPaisEliminar;
        private System.Windows.Forms.DataGridView dgvDatosPaises;
        private System.Windows.Forms.Button btnConsultarPais;
    }
}