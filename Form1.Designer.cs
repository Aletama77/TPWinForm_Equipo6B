namespace TPWinForm_Equipo6B
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMBMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verImágenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMImágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.imágenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verArtículoToolStripMenuItem,
            this.aBMArtículosToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // verArtículoToolStripMenuItem
            // 
            this.verArtículoToolStripMenuItem.Name = "verArtículoToolStripMenuItem";
            this.verArtículoToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.verArtículoToolStripMenuItem.Text = "Ver Artículo";
            // 
            // aBMArtículosToolStripMenuItem
            // 
            this.aBMArtículosToolStripMenuItem.Name = "aBMArtículosToolStripMenuItem";
            this.aBMArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aBMArtículosToolStripMenuItem.Text = "ABM Artículos";
            this.aBMArtículosToolStripMenuItem.Click += new System.EventHandler(this.aBMArtículosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMarcasToolStripMenuItem,
            this.aMBMarcaToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // verMarcasToolStripMenuItem
            // 
            this.verMarcasToolStripMenuItem.Name = "verMarcasToolStripMenuItem";
            this.verMarcasToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.verMarcasToolStripMenuItem.Text = "Ver Marcas";
            // 
            // aMBMarcaToolStripMenuItem
            // 
            this.aMBMarcaToolStripMenuItem.Name = "aMBMarcaToolStripMenuItem";
            this.aMBMarcaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.aMBMarcaToolStripMenuItem.Text = "AMB Marca";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCategoríasToolStripMenuItem,
            this.aBMCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // verCategoríasToolStripMenuItem
            // 
            this.verCategoríasToolStripMenuItem.Name = "verCategoríasToolStripMenuItem";
            this.verCategoríasToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.verCategoríasToolStripMenuItem.Text = "Ver Categorías";
            // 
            // aBMCategoríasToolStripMenuItem
            // 
            this.aBMCategoríasToolStripMenuItem.Name = "aBMCategoríasToolStripMenuItem";
            this.aBMCategoríasToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.aBMCategoríasToolStripMenuItem.Text = "ABM Categorías";
            // 
            // imágenesToolStripMenuItem
            // 
            this.imágenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verImágenToolStripMenuItem,
            this.aBMImágenesToolStripMenuItem});
            this.imágenesToolStripMenuItem.Name = "imágenesToolStripMenuItem";
            this.imágenesToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.imágenesToolStripMenuItem.Text = "Imágenes";
            // 
            // verImágenToolStripMenuItem
            // 
            this.verImágenToolStripMenuItem.Name = "verImágenToolStripMenuItem";
            this.verImágenToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.verImágenToolStripMenuItem.Text = "Ver Imágen";
            // 
            // aBMImágenesToolStripMenuItem
            // 
            this.aBMImágenesToolStripMenuItem.Name = "aBMImágenesToolStripMenuItem";
            this.aBMImágenesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.aBMImágenesToolStripMenuItem.Text = "ABM Imágenes";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMBMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imágenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verImágenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMImágenesToolStripMenuItem;
    }
}

