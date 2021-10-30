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
    public partial class FormPrincipal : Form
    {

        cl_ControleContato controle = new cl_ControleContato();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatos contatos = new FormContatos();
            contatos.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();
            consulta.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controle.Backup("C:\\Users/55119/Documents/ETEC THIAGO/DS/BackupProjetoAgenda"), "Backup do Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string CaminhoBackup = openFileDialog1.FileName;
                MessageBox.Show(controle.Restore(CaminhoBackup), "Restauração do BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio relatorio = new FormRelatorio();
            relatorio.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLogin login = new formLogin();

            login.ShowDialog();
        }
    }
}
