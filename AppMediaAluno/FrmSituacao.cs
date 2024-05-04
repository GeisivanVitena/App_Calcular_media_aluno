using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaAluno
{
    public partial class FrmSituacao : Form
    {
        public FrmSituacao()
        {
            InitializeComponent();
        }

        private void FrmSituacao_Load(object sender, EventArgs e)
        {
            lblNomeSituacao.Text = Program.usuario_logado;
            dtData.Text = DateTime.Now.ToString();
            MostrarSituacao();
        }

        public void MostrarSituacao()
        {
            lblMediaSituacao.Text = Program.media.ToString();

            if (Program.media < 7)
            {
                lblSituacao.Text = "ALUNO REPROVADO!";
            }
            else
            {
                lblSituacao.Text = "ALUNO APROVADO!";
            }
        }
    }
}
