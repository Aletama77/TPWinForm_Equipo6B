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
            this.botonBuscarCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonBuscarCategoria
            // 
            this.botonBuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("botonBuscarCategoria.Image")));
            this.botonBuscarCategoria.Location = new System.Drawing.Point(151, 41);
            this.botonBuscarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonBuscarCategoria.Name = "botonBuscarCategoria";
            this.botonBuscarCategoria.Size = new System.Drawing.Size(44, 43);
            this.botonBuscarCategoria.TabIndex = 21;
            this.botonBuscarCategoria.UseVisualStyleBackColor = true;
            this.botonBuscarCategoria.Click += new System.EventHandler(this.botonBuscarCategoria_Click);
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
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(31, 60);
            this.textCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(113, 22);
            this.textCategoria.TabIndex = 19;
            this.textCategoria.TextChanged += new System.EventHandler(this.textCategoria_TextChanged);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Editar,
            this.Eliminar});
            this.dataGridViewCat.Location = new System.Drawing.Point(31, 201);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.RowTemplate.Height = 24;
            this.dataGridViewCat.Size = new System.Drawing.Size(712, 178);
            this.dataGridViewCat.TabIndex = 23;
            this.dataGridViewCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCat_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 125;
            // 
            // ABM_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonBuscarCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCategoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABM_Categorias";
            this.Text = "ABM_Categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonBuscarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}