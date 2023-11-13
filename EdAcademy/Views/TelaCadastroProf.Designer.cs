namespace EdAcademy.Views
{
    partial class TelaCadastroProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProf));
            label1 = new Label();
            label2 = new Label();
            txtNomeProf = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbGrauFormacao = new ComboBox();
            txtDataNascimento = new MaskedTextBox();
            txtEmailProf = new TextBox();
            label6 = new Label();
            btnSalvarProf = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 34);
            label1.Name = "label1";
            label1.Size = new Size(234, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Professor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 122);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome do Professor(a)\r\n";
            // 
            // txtNomeProf
            // 
            txtNomeProf.Location = new Point(64, 148);
            txtNomeProf.Margin = new Padding(3, 2, 3, 2);
            txtNomeProf.Name = "txtNomeProf";
            txtNomeProf.Size = new Size(235, 23);
            txtNomeProf.TabIndex = 2;
            txtNomeProf.TextChanged += txtNomeProf_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 193);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 3;
            label3.Text = "Data de nascimento";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 129);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(352, 194);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 6;
            label5.Text = "Grau de formação";
            // 
            // cmbGrauFormacao
            // 
            cmbGrauFormacao.FormattingEnabled = true;
            cmbGrauFormacao.Items.AddRange(new object[] { "Graduação", "Mestrado", "Doutorado" });
            cmbGrauFormacao.Location = new Point(352, 220);
            cmbGrauFormacao.Margin = new Padding(3, 2, 3, 2);
            cmbGrauFormacao.Name = "cmbGrauFormacao";
            cmbGrauFormacao.Size = new Size(235, 23);
            cmbGrauFormacao.TabIndex = 7;
            cmbGrauFormacao.SelectedIndexChanged += cmbGrauFormacao_SelectedIndexChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(64, 220);
            txtDataNascimento.Margin = new Padding(3, 2, 3, 2);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(235, 23);
            txtDataNascimento.TabIndex = 8;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            txtDataNascimento.MaskInputRejected += txtDataNascimento_MaskInputRejected;
            // 
            // txtEmailProf
            // 
            txtEmailProf.Location = new Point(352, 148);
            txtEmailProf.Margin = new Padding(3, 2, 3, 2);
            txtEmailProf.Name = "txtEmailProf";
            txtEmailProf.Size = new Size(235, 23);
            txtEmailProf.TabIndex = 10;
            txtEmailProf.TextChanged += txtEmailProf_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(352, 122);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email\r\n";
            // 
            // btnSalvarProf
            // 
            btnSalvarProf.Location = new Point(64, 284);
            btnSalvarProf.Name = "btnSalvarProf";
            btnSalvarProf.Size = new Size(75, 23);
            btnSalvarProf.TabIndex = 11;
            btnSalvarProf.Text = "Salvar";
            btnSalvarProf.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(732, 415);
            Controls.Add(btnSalvarProf);
            Controls.Add(txtEmailProf);
            Controls.Add(label6);
            Controls.Add(txtDataNascimento);
            Controls.Add(cmbGrauFormacao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNomeProf);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastroProf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Professor";
            Load += TelaCadastroProf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomeProf;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbGrauFormacao;
        private MaskedTextBox txtDataNascimento;
        private TextBox txtEmailProf;
        private Label label6;
        private Button btnSalvarProf;
    }
}