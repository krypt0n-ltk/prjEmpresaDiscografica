namespace EmpresaDiscografica
{
    partial class formConsultaEnVivo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMensaje13 = new System.Windows.Forms.Label();
            this.dgvConsultaVivo = new System.Windows.Forms.DataGridView();
            this.btnConsultaVivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbMensaje13);
            this.panel1.Controls.Add(this.dgvConsultaVivo);
            this.panel1.Controls.Add(this.btnConsultaVivo);
            this.panel1.Location = new System.Drawing.Point(20, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(641, 493);
            this.panel1.TabIndex = 0;
            // 
            // lbMensaje13
            // 
            this.lbMensaje13.AutoSize = true;
            this.lbMensaje13.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbMensaje13.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje13.Location = new System.Drawing.Point(53, 27);
            this.lbMensaje13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensaje13.Name = "lbMensaje13";
            this.lbMensaje13.Size = new System.Drawing.Size(152, 19);
            this.lbMensaje13.TabIndex = 2;
            this.lbMensaje13.Text = "Consulta en Vivo";
            // 
            // dgvConsultaVivo
            // 
            this.dgvConsultaVivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaVivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVivo.Location = new System.Drawing.Point(45, 162);
            this.dgvConsultaVivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsultaVivo.Name = "dgvConsultaVivo";
            this.dgvConsultaVivo.RowTemplate.Height = 28;
            this.dgvConsultaVivo.Size = new System.Drawing.Size(557, 286);
            this.dgvConsultaVivo.TabIndex = 1;
            // 
            // btnConsultaVivo
            // 
            this.btnConsultaVivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultaVivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultaVivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaVivo.Location = new System.Drawing.Point(240, 68);
            this.btnConsultaVivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultaVivo.Name = "btnConsultaVivo";
            this.btnConsultaVivo.Size = new System.Drawing.Size(152, 57);
            this.btnConsultaVivo.TabIndex = 0;
            this.btnConsultaVivo.Text = "Consultar";
            this.btnConsultaVivo.UseVisualStyleBackColor = false;
            this.btnConsultaVivo.Click += new System.EventHandler(this.btnConsultaVivo_Click);
            // 
            // formConsultaEnVivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formConsultaEnVivo";
            this.Text = "formConsultaEnVivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMensaje13;
        private System.Windows.Forms.DataGridView dgvConsultaVivo;
        private System.Windows.Forms.Button btnConsultaVivo;
    }
}