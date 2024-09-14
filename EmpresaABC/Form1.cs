using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaABC
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                if (!txtDescricao.Text.Equals(""))
                {
                    lbdPesquisar.Items.Clear();
                    lbdPesquisar.Items.Add(txtDescricao.Text);
                }
                else {
                    MessageBox.Show("Favor inserir valores válidos.");
                    txtDescricao.Focus();
                }
            }
        }


        private void Pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            rdbNome.Checked = false;
            rdbCodigo.Checked = false;
            lbdPesquisar.Items.Clear();
            txtDescricao.Enabled = false;

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }
    }
}
