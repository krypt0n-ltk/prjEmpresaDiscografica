namespace EmpresaDiscografica.presentacion
{
    partial class formInicio
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlContenedorForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.btnProductor = new System.Windows.Forms.Button();
            this.btnEmpDisc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlContenedorForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlMenuLateral.Controls.Add(this.btnConsulta);
            this.pnlMenuLateral.Controls.Add(this.btnTrabajo);
            this.pnlMenuLateral.Controls.Add(this.btnPais);
            this.pnlMenuLateral.Controls.Add(this.btnProductor);
            this.pnlMenuLateral.Controls.Add(this.btnEmpDisc);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(0, 280);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsulta.Size = new System.Drawing.Size(250, 45);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta en vivo";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlContenedorForms
            // 
            this.pnlContenedorForms.AutoSize = true;
            this.pnlContenedorForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlContenedorForms.Controls.Add(this.pictureBox1);
            this.pnlContenedorForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorForms.Location = new System.Drawing.Point(250, 0);
            this.pnlContenedorForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedorForms.Name = "pnlContenedorForms";
            this.pnlContenedorForms.Size = new System.Drawing.Size(684, 561);
            this.pnlContenedorForms.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EmpresaDiscografica.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(243, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajo.FlatAppearance.BorderSize = 0;
            this.btnTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajo.Image = global::EmpresaDiscografica.Properties.Resources.handshake;
            this.btnTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajo.Location = new System.Drawing.Point(0, 235);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrabajo.Size = new System.Drawing.Size(250, 45);
            this.btnTrabajo.TabIndex = 7;
            this.btnTrabajo.Text = "  Relación de Trabajo";
            this.btnTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrabajo.UseVisualStyleBackColor = true;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // btnPais
            // 
            this.btnPais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPais.FlatAppearance.BorderSize = 0;
            this.btnPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPais.Image = global::EmpresaDiscografica.Properties.Resources.enterprise;
            this.btnPais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPais.Location = new System.Drawing.Point(0, 190);
            this.btnPais.Margin = new System.Windows.Forms.Padding(4);
            this.btnPais.Name = "btnPais";
            this.btnPais.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPais.Size = new System.Drawing.Size(250, 45);
            this.btnPais.TabIndex = 5;
            this.btnPais.Text = "  País";
            this.btnPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // btnProductor
            // 
            this.btnProductor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductor.FlatAppearance.BorderSize = 0;
            this.btnProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductor.Image = global::EmpresaDiscografica.Properties.Resources.employee;
            this.btnProductor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductor.Location = new System.Drawing.Point(0, 145);
            this.btnProductor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductor.Name = "btnProductor";
            this.btnProductor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductor.Size = new System.Drawing.Size(250, 45);
            this.btnProductor.TabIndex = 3;
            this.btnProductor.Text = "  Productor Musical";
            this.btnProductor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductor.UseVisualStyleBackColor = true;
            this.btnProductor.Click += new System.EventHandler(this.btnProductor_Click);
            // 
            // btnEmpDisc
            // 
            this.btnEmpDisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpDisc.FlatAppearance.BorderSize = 0;
            this.btnEmpDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDisc.ForeColor = System.Drawing.Color.LightGray;
            this.btnEmpDisc.Image = global::EmpresaDiscografica.Properties.Resources.compact_disc;
            this.btnEmpDisc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpDisc.Location = new System.Drawing.Point(0, 100);
            this.btnEmpDisc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpDisc.Name = "btnEmpDisc";
            this.btnEmpDisc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpDisc.Size = new System.Drawing.Size(250, 45);
            this.btnEmpDisc.TabIndex = 1;
            this.btnEmpDisc.Text = "  Empresa Discográfica";
            this.btnEmpDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpDisc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpDisc.UseVisualStyleBackColor = true;
            this.btnEmpDisc.Click += new System.EventHandler(this.btnEmpDisc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::EmpresaDiscografica.Properties.Resources.logoSinMsj;
            this.pictureBox2.Location = new System.Drawing.Point(60, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlContenedorForms);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "formInicio";
            this.Text = "formInicio";
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlContenedorForms.ResumeLayout(false);
            this.pnlContenedorForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnEmpDisc;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnProductor;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Panel pnlContenedorForms;
        private System.Windows.Forms.Button btnTrabajo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}