using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;


namespace ProjetoAgendaContato
{
    public partial class FormRelatorio : Form
    {

        cl_Conexao c = new cl_Conexao();
        cl_Contato cont = new cl_Contato();
        cl_ControleContato controle = new cl_ControleContato();

        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            string sql = "select * from tbcontato";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, c.conexao);

            dsContatos ds = new dsContatos();
            da.Fill(ds.Tables["tbcontato"]);
            ReportDocument cr = new ReportDocument();
            cr = new cr_Contato();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            ReportDocument cryRpt = new ReportDocument();
        }

        private void FormRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            cl_Conexao c = new cl_Conexao();
            c.Desconectar();
        }

    }
}
