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
    public partial class FrmPrincipal : Form
    {
        float n1, n2, n3, n4;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Now.ToString();
            lblNome.Text = Program.usuario_logado;
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            FrmSituacao fs = new FrmSituacao();
            fs.ShowDialog();
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CalcularMedia();
        }

        public void CalcularMedia()
        {
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);
            n4 = float.Parse(txtNota4.Text);

            Program.media = (n1 + n2 + n3 + n4) / 4;

            lblMedia.Text = Program.media.ToString();
        }
    }
}
