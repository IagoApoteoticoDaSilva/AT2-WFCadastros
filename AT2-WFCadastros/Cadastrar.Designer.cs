namespace AT2_WFCadastros
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            lblCodigo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            dtpData = new DateTimePicker();
            lblData = new Label();
            btnCadastrar = new Button();
            mtbCodigo = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(11, 17);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(11, 77);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(12, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(318, 23);
            txtNome.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(11, 196);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.Location = new Point(11, 214);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(178, 23);
            txtDescricao.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(222, 137);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FlatStyle = FlatStyle.Popup;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxStatus.Location = new Point(222, 155);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(108, 23);
            cbxStatus.TabIndex = 8;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(11, 155);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(95, 23);
            dtpData.TabIndex = 9;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(11, 137);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 10;
            lblData.Text = "Data:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(128, 128, 255);
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(222, 199);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(108, 50);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // mtbCodigo
            // 
            mtbCodigo.BackColor = Color.White;
            mtbCodigo.Location = new Point(12, 35);
            mtbCodigo.Mask = "00000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(49, 23);
            mtbCodigo.TabIndex = 12;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(342, 298);
            Controls.Add(mtbCodigo);
            Controls.Add(btnCadastrar);
            Controls.Add(lblData);
            Controls.Add(dtpData);
            Controls.Add(cbxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastrar";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Cadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private DateTimePicker dtpData;
        private Label lblData;
        private Button btnCadastrar;
        private MaskedTextBox mtbCodigo;
    }
}