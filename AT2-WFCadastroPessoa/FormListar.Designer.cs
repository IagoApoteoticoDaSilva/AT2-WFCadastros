namespace AT2_WFCadastroPessoa
{
    partial class FormListar
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
            dgvCadastro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCadastro).BeginInit();
            SuspendLayout();
            // 
            // dgvCadastro
            // 
            dgvCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastro.Location = new Point(12, 12);
            dgvCadastro.Name = "dgvCadastro";
            dgvCadastro.Size = new Size(340, 253);
            dgvCadastro.TabIndex = 0;
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 277);
            Controls.Add(dgvCadastro);
            Name = "FormListar";
            Text = "FormListar";
            Load += FormListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCadastro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCadastro;
    }
}