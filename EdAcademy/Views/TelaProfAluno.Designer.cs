namespace EdAcademy.Views
{
    partial class TelaProfAluno
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
            label1 = new Label();
            btnProf = new Button();
            btnAluno = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(325, 24);
            label1.TabIndex = 0;
            label1.Text = "Como você deseja se cadastrar ?";
            // 
            // btnProf
            // 
            btnProf.Location = new Point(25, 88);
            btnProf.Name = "btnProf";
            btnProf.Size = new Size(94, 29);
            btnProf.TabIndex = 1;
            btnProf.Text = "Professor";
            btnProf.UseVisualStyleBackColor = true;
            btnProf.Click += btnProf_Click;
            // 
            // btnAluno
            // 
            btnAluno.Location = new Point(227, 88);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(94, 29);
            btnAluno.TabIndex = 2;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += btnAluno_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 92);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 3;
            label2.Text = "ou";
            // 
            // TelaProfAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 151);
            Controls.Add(label2);
            Controls.Add(btnAluno);
            Controls.Add(btnProf);
            Controls.Add(label1);
            Name = "TelaProfAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaProfAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProf;
        private Button btnAluno;
        private Label label2;
    }
}