using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdAcademy.Views
{
    public partial class TelaProfAluno : Form
    {
        public TelaProfAluno()
        {
            InitializeComponent();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            var tela = new TelaCadastroProf();
            this.Hide();

            tela.FormClosed += (s, args) => this.Close();
            tela.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            var tela = new TelaCadastroAluno();
            this.Hide();

            tela.FormClosed += (s, args) => this.Close();
            tela.Show();
        }

        private void OuOu()
        {
            if(btnAluno_Click == null)
            {
                btnAluno.Enabled = true;
            }
            else
            {
                btnAluno.Enabled = false;
            }
        }
    }
}
