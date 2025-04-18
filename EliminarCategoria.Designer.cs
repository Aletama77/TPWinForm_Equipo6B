namespace TPWinForm_Equipo6B
{
    partial class EliminarCategoria
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
            this.lblEliminacionCategoria = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEliminacionCategoria
            // 
            this.lblEliminacionCategoria.AutoSize = true;
            this.lblEliminacionCategoria.Location = new System.Drawing.Point(202, 153);
            this.lblEliminacionCategoria.Name = "lblEliminacionCategoria";
            this.lblEliminacionCategoria.Size = new System.Drawing.Size(363, 16);
            this.lblEliminacionCategoria.TabIndex = 0;
            this.lblEliminacionCategoria.Text = "Esta seguro que desea eliminar la categoria seleccionada?";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(151, 216);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 38);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(509, 216);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(115, 38);
            this.bttnCancelar.TabIndex = 2;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // EliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblEliminacionCategoria);
            this.Name = "EliminarCategoria";
            this.Text = "EliminarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminacionCategoria;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button bttnCancelar;
    }
}