namespace Lite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSalvar = new Button();
            dtgCategorias = new DataGridView();
            categoriaBindingSource = new BindingSource(components);
            dgvProdutos = new DataGridView();
            produtoBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            idCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(569, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dtgCategorias
            // 
            dtgCategorias.AutoGenerateColumns = false;
            dtgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCategorias.Columns.AddRange(new DataGridViewColumn[] { idCategoriaDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            dtgCategorias.DataSource = categoriaBindingSource;
            dtgCategorias.Location = new Point(80, 102);
            dtgCategorias.Name = "dtgCategorias";
            dtgCategorias.Size = new Size(259, 150);
            dtgCategorias.TabIndex = 1;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Categoria);
            // 
            // dgvProdutos
            // 
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn1 });
            dgvProdutos.DataSource = produtoBindingSource;
            dgvProdutos.Location = new Point(452, 102);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(336, 150);
            dgvProdutos.TabIndex = 2;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataMember = "Produto";
            produtoBindingSource.DataSource = categoriaBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            idCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria";
            idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(dtgCategorias);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private DataGridView dtgCategorias;
        private BindingSource categoriaBindingSource;
        private DataGridView dgvProdutos;
        private BindingSource produtoBindingSource;
        private DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
    }
}
