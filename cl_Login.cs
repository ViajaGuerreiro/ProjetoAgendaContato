using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoAgendaContato
{
    public class cl_Login
    {
        cl_Conexao c = new cl_Conexao();

        /*O metodo Logar é do tipo bool e recebe os parametros de login e senha, foi criado uma
        variavel "sql" que recebe os codigos de seleção da tabela login do banco de dados
        logo após a conexão e os comando são executados e lidos, se não tiver o os dados no banco
        é retornado false caso contrario true.*/
        public bool Logar(string login, string senha)
        {
            try
            {
                string sql = "SELECT login, senha FROM tblogin WHERE login LIKE'" + login + "'AND senha LIKE'" + senha + "'";

                MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

                c.Conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();

                if(!objDados.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(MySqlException e)
            {
                throw (e);
            }

            finally
            {
                c.Desconectar();
            }

        }
    }
}
