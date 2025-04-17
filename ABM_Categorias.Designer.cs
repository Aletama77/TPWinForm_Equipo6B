namespace TPWinForm_Equipo6B
{
    partial class ABM_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Categorias));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(151, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 43);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Categoría";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(31, 60);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(113, 22);
            this.textPrecio.TabIndex = 19;
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(57, 188);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.RowTemplate.Height = 24;
            this.dataGridViewCat.Size = new System.Drawing.Size(675, 178);
            this.dataGridViewCat.TabIndex = 23;
            // 
            // ABM_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPrecio);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABM_Categorias";
            this.Text = "ABM_Categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.DataGridView dataGridViewCat;
    }
}