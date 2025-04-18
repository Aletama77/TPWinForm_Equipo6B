namespace TPWinForm_Equipo6B
{
    partial class EliminacionMarca
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
            this.botonConfirmarEliminarMarca = new System.Windows.Forms.Button();
            this.botonCancelarEliminarMarca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonConfirmarEliminarMarca
            // 
            this.botonConfirmarEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonConfirmarEliminarMarca.Location = new System.Drawing.Point(271, 168);
            this.botonConfirmarEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmarEliminarMarca.Name = "botonConfirmarEliminarMarca";
            this.botonConfirmarEliminarMarca.Size = new System.Drawing.Size(86, 31);
            this.botonConfirmarEliminarMarca.TabIndex = 15;
            this.botonConfirmarEliminarMarca.Text = "Confirmar";
            this.botonConfirmarEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // botonCancelarEliminarMarca
            // 
            this.botonCancelarEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonCancelarEliminarMarca.Location = new System.Drawing.Point(419, 168);
            this.botonCancelarEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelarEliminarMarca.Name = "botonCancelarEliminarMarca";
            this.botonCancelarEliminarMarca.Size = new System.Drawing.Size(86, 31);
            this.botonCancelarEliminarMarca.TabIndex = 16;
            this.botonCancelarEliminarMarca.Text = "Cancelar";
            this.botonCancelarEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "¿Estas seguro que quieres eliminar Marca?";
            // 
            // EliminacionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonCancelarEliminarMarca);
            this.Controls.Add(this.botonConfirmarEliminarMarca);
            this.Name = "EliminacionMarca";
            this.Text = "EliminacionMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmarEliminarMarca;
        private System.Windows.Forms.Button botonCancelarEliminarMarca;
        private System.Windows.Forms.Label label3;
    }
}