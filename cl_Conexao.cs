using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoAgendaContato
{
    class cl_Conexao
    {
        public MySqlConnection conexao = new MySqlConnection(@"Server=localhost;Port=3306;Database=agenda;SSL mode=none;User=root;Pwd=");

        public string Conectar()
        {
            try
            {
                conexao.Open();
                return ("Conexão realizada com Sucesso!");
            }
            catch(MySqlException e )
            {
                return (e.ToString());
                
            }
        }

        public string Desconectar()
        {
            try
            {
                conexao.Close();
                return ("Conexão encerrada!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
