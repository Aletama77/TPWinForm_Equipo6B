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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNombre.Location = new System.Drawing.Point(42, 60);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(132, 20);
            this.textNombre.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción";
            // 
            // botonAgregarMarca
            // 
            this.botonAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonAgregarMarca.Location = new System.Drawing.Point(179, 50);
            this.botonAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.botonAgregarMarca.Name = "botonAgregarMarca";
            this.botonAgregarMarca.Size = new System.Drawing.Size(86, 31);
            this.botonAgregarMarca.TabIndex = 11;
            this.botonAgregarMarca.Text = "Agregar";
            this.botonAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // CrearMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonAgregarMarca);
            this.Name = "CrearMarca";
            this.Text = "CrearMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregarMarca;
    }
}