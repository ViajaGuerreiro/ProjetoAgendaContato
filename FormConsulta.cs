using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaContato
{
    public partial class FormConsulta : Form
    {

        cl_Contato cont = new cl_Contato();

        cl_ControleContato controle = new cl_ControleContato();


        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbOpcao.SelectedIndex == 0)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtBusca.Text);

                    dataGridView1.DataSource = controle.pesquisaCodigo(codigo);
                }
                catch
                {
                    MessageBox.Show("Digite um codigo valido");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }
            }  
            else if(cbOpcao.SelectedIndex == 1) {
                try
                {
                    string nome = txtBusca.Text;
                    dataGridView1.DataSource = controle.pesquisaNome(nome);
                }
                catch
                {
                    MessageBox.Show("Digite um valor valido");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }
            }
            else if (cbOpcao.SelectedIndex == 2)
            {
                try
                {
                    string telefone = txtBusca.Text;
                    dataGridView1.DataSource = controle.pesquisaTelefone(telefone);
                }
                catch
                {
                    MessageBox.Show("Digite um valor valido");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }
            }
            else if (cbOpcao.SelectedIndex == 3)
            {
                try
                {
                    string celular = txtBusca.Text;
                    dataGridView1.DataSource = controle.pesquisaCelular(celular);
                }
                catch
                {
                    MessageBox.Show("Digite um valor valido");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }
            }
            else if (cbOpcao.SelectedIndex == 4)
            {
                try
                {
                    string email = txtBusca.Text;
                    dataGridView1.DataSource = controle.pesquisaEmail(email);
                }
                catch
                {
                    MessageBox.Show("Digite um valor valido");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }
            }
        }

        private void btnLsTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOpcao.SelectedIndex < 0)
            {
                txtBusca.Enabled = false;
                btnBuscar.Enabled = false;
                lblOpcao.Text = "";
            }
            else
            {
                txtBusca.Enabled = true;
                btnBuscar.Enabled = true;
                lblOpcao.Text = "Digite o " + cbOpcao.Text;
                txtBusca.Clear();
                txtBusca.Focus();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if(txtBusca.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}
