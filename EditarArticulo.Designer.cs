﻿namespace TPWinForm_Equipo6B
{
    partial class EditarArticulo
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
            this.editarArtIDCat = new System.Windows.Forms.ComboBox();
            this.editarArtIDMarca = new System.Windows.Forms.ComboBox();
            this.editarArtCodigo = new System.Windows.Forms.TextBox();
            this.editarArtNombre = new System.Windows.Forms.TextBox();
            this.editarArtPrecio = new System.Windows.Forms.TextBox();
            this.editarArtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirArticuloBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editarArtIDCat
            // 
            this.editarArtIDCat.FormattingEnabled = true;
            this.editarArtIDCat.Location = new System.Drawing.Point(31, 299);
            this.editarArtIDCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtIDCat.Name = "editarArtIDCat";
            this.editarArtIDCat.Size = new System.Drawing.Size(175, 24);
            this.editarArtIDCat.TabIndex = 51;
            // 
            // editarArtIDMarca
            // 
            this.editarArtIDMarca.FormattingEnabled = true;
            this.editarArtIDMarca.Location = new System.Drawing.Point(31, 239);
            this.editarArtIDMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtIDMarca.Name = "editarArtIDMarca";
            this.editarArtIDMarca.Size = new System.Drawing.Size(175, 24);
            this.editarArtIDMarca.TabIndex = 50;
            // 
            // editarArtCodigo
            // 
            this.editarArtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editarArtCodigo.Location = new System.Drawing.Point(31, 63);
            this.editarArtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtCodigo.Name = "editarArtCodigo";
            this.editarArtCodigo.Size = new System.Drawing.Size(175, 22);
            this.editarArtCodigo.TabIndex = 49;
            // 
            // editarArtNombre
            // 
            this.editarArtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editarArtNombre.Location = new System.Drawing.Point(31, 119);
            this.editarArtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtNombre.Name = "editarArtNombre";
            this.editarArtNombre.Size = new System.Drawing.Size(175, 22);
            this.editarArtNombre.TabIndex = 48;
            // 
            // editarArtPrecio
            // 
            this.editarArtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editarArtPrecio.Location = new System.Drawing.Point(31, 362);
            this.editarArtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtPrecio.Name = "editarArtPrecio";
            this.editarArtPrecio.Size = new System.Drawing.Size(175, 22);
            this.editarArtPrecio.TabIndex = 47;
            // 
            // editarArtDesc
            // 
            this.editarArtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editarArtDesc.Location = new System.Drawing.Point(31, 180);
            this.editarArtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editarArtDesc.Name = "editarArtDesc";
            this.editarArtDesc.Size = new System.Drawing.Size(175, 22);
            this.editarArtDesc.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "IdMarca";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "IdCategoría";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código";
            // 
            // ConfirArticuloBoton
            // 
            this.ConfirArticuloBoton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirArticuloBoton.Location = new System.Drawing.Point(281, 63);
            this.ConfirArticuloBoton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirArticuloBoton.Name = "ConfirArticuloBoton";
            this.ConfirArticuloBoton.Size = new System.Drawing.Size(115, 38);
            this.ConfirArticuloBoton.TabIndex = 39;
            this.ConfirArticuloBoton.Text = "Confirmar";
            this.ConfirArticuloBoton.UseVisualStyleBackColor = true;
            this.ConfirArticuloBoton.Click += new System.EventHandler(this.ConfirArticuloBoton_Click_1);
            // 
            // EditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.editarArtIDCat);
            this.Controls.Add(this.editarArtIDMarca);
            this.Controls.Add(this.editarArtCodigo);
            this.Controls.Add(this.editarArtNombre);
            this.Controls.Add(this.editarArtPrecio);
            this.Controls.Add(this.editarArtDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirArticuloBoton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarArticulo";
            this.Text = "EditarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox editarArtIDCat;
        private System.Windows.Forms.ComboBox editarArtIDMarca;
        private System.Windows.Forms.TextBox editarArtCodigo;
        private System.Windows.Forms.TextBox editarArtNombre;
        private System.Windows.Forms.TextBox editarArtPrecio;
        private System.Windows.Forms.TextBox editarArtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirArticuloBoton;
    }
}