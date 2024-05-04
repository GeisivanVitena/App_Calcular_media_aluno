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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

     

        public void Login()
        {
            
            if (txtNomeLogin.Text != "Geisivan")
            {
                MessageBox.Show("Atenção: Nome de usuário incorreto!");
                txtNomeLogin.Text = "";
                return;
            }
            else if (txtSenha.Text != "123")
            {
                MessageBox.Show("Atenção: Senha incorreta!");
                txtSenha.Text = "";
                return;
            }
            else
            {
                
                Program.usuario_logado = txtNomeLogin.Text;
                MessageBox.Show("Seja bem vindo (a): " + Program.usuario_logado);
                FrmPrincipal fp = new FrmPrincipal();
                fp.ShowDialog();
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
