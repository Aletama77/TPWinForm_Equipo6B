namespace TPWinForm_Equipo6B
{
    partial class CrearMarca
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
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDescripcion
            // 
            this.textDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textDescripcion.Location = new System.Drawing.Point(56, 74);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(175, 22);
            this.textDescripcion.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción";
            // 
            // botonAgregarMarca
            // 
            this.botonAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonAgregarMarca.Location = new System.Drawing.Point(239, 62);
            this.botonAgregarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregarMarca.Name = "botonAgregarMarca";
            this.botonAgregarMarca.Size = new System.Drawing.Size(115, 38);
            this.botonAgregarMarca.TabIndex = 11;
            this.botonAgregarMarca.Text = "Agregar";
            this.botonAgregarMarca.UseVisualStyleBackColor = true;
            this.botonAgregarMarca.Click += new System.EventHandler(this.botonAgregarMarca_Click);
            // 
            // CrearMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonAgregarMarca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearMarca";
            this.Text = "CrearMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregarMarca;
    }
}