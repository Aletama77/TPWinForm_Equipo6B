namespace TPWinForm_Equipo6B
{
    partial class EditarMarca
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
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonEditarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMarca
            // 
            this.TxtMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtMarca.Location = new System.Drawing.Point(52, 74);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(175, 22);
            this.TxtMarca.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción";
            // 
            // botonEditarMarca
            // 
            this.botonEditarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonEditarMarca.Location = new System.Drawing.Point(235, 62);
            this.botonEditarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEditarMarca.Name = "botonEditarMarca";
            this.botonEditarMarca.Size = new System.Drawing.Size(115, 38);
            this.botonEditarMarca.TabIndex = 14;
            this.botonEditarMarca.Text = "Editar";
            this.botonEditarMarca.UseVisualStyleBackColor = true;
            // 
            // EditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonEditarMarca);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarMarca";
            this.Text = "EditarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonEditarMarca;
    }
}