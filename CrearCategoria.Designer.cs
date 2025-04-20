namespace TPWinForm_Equipo6B
{
    partial class CrearCategoria
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
            this.TxtDescripcioncategorias = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategorias = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDescripcioncategorias
            // 
            this.TxtDescripcioncategorias.Location = new System.Drawing.Point(132, 71);
            this.TxtDescripcioncategorias.Name = "TxtDescripcioncategorias";
            this.TxtDescripcioncategorias.Size = new System.Drawing.Size(128, 22);
            this.TxtDescripcioncategorias.TabIndex = 0;
            // 
            // lblDescripcionCategorias
            // 
            this.lblDescripcionCategorias.AutoSize = true;
            this.lblDescripcionCategorias.Location = new System.Drawing.Point(47, 71);
            this.lblDescripcionCategorias.Name = "lblDescripcionCategorias";
            this.lblDescripcionCategorias.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionCategorias.TabIndex = 1;
            this.lblDescripcionCategorias.Text = "Descripcion";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(266, 55);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(115, 38);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);  // Aquí se asocia el evento Click
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblDescripcionCategorias);
            this.Controls.Add(this.TxtDescripcioncategorias);
            this.Name = "CrearCategoria";
            this.Text = "CrearCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescripcioncategorias;
        private System.Windows.Forms.Label lblDescripcionCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
    }
}