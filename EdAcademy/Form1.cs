using EdAcademy.Views;

namespace EdAcademy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblIncorreto.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblIncorreto.Visible = false;
            if (txtUsuario.Text == "Rafa" && txtSenha.Text == "123")
            {
                var message = MessageBox.Show("Usuario conectado com sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message == DialogResult.OK)
                {
                    var telaInicial = new TelaInicial();
                    this.Hide();

                    telaInicial.FormClosed += (s, args) => this.Close();
                    telaInicial.Show();

                }
            }
            else
            {
                lblIncorreto.Visible = true;
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaProfAluno tela = new TelaProfAluno();
            tela.Show();
        }
    }
}