using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoAgendaContato
{
    class cl_ControleContato
    {
        cl_Conexao c = new cl_Conexao();


        /*O metodo coleta os dados que os usuarios digitaram na text box e "tenta" enviar para 
          o banco de dados atraves dos comandos do SQL, mas para isso ele usa o objeto "c" da classe "cl_conexao"
          para usar o metodo conectar para inserir os dados e logo após se desconecta e retorna a mensagem "Cadastrado com sucesso"
          caso de algum erro ele executa a outra função para mostrar o erro.*/
        public string Cadastrar(cl_Contato cont)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbcontato (nome, telefone, celular, email) " +
                                                    "VALUES ('" + cont.Nome + "', '" + cont.Telefone + "', '"
                                                    + cont.Celular + "', '" + cont.Email + "')", c.conexao);

                c.Conectar();

                cmd.ExecuteNonQuery();
                c.Desconectar();
                return ("Cadastrado com sucesso.");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string alterar(cl_Contato cont)
        {
            try
            {
                string sql = "update tbcontato set nome = '" + cont.Nome + "' ," + "telefone = '" + cont.Telefone +
                            "', celular = '" + cont.Celular + "', email = '" + cont.Email +
                            "' where codcontato = " + cont.Codcontato + " ; ";

                MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

                //update tbcontato set nome ='João Santos', telefone= '11 5522-4477', celular = '11 96655-6655',
                //  email ='joaosantos2010@gmail.com' where codcontato = 4;

                c.Conectar();
                cmd.ExecuteNonQuery();
                c.Desconectar();

                return ("Alterado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }

        }

        public string excluir(cl_Contato cont)
        {
            try
            {
                string sql = "delete from tbcontato where codcontato = " + cont.Codcontato + " ; ";
                //delete from tbcontato where codcontato = 4;

                MySqlCommand cmd = new MySqlCommand(sql, c.conexao);
                c.Conectar();

                cmd.ExecuteNonQuery();

                c.Desconectar();

                return ("Registro excluido com sucesso!");

            } catch (MySqlException e)

            {
                return (e.ToString());
            }


        }

        public cl_Contato buscar(int codigo)
        {
            cl_Contato cont = new cl_Contato();

            try
            {
                string sql = "select * from tbcontato where codcontato = " + codigo + " ; ";

                MySqlCommand cmd = new MySqlCommand(sql, c.conexao);
                c.Conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    return null;
                }

                else
                {
                    objDados.Read();
                    cont.Codcontato = Convert.ToInt32(objDados["codcontato"]);
                    cont.Nome = objDados["nome"].ToString();
                    cont.Telefone = objDados["telefone"].ToString();
                    cont.Celular = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();

                    objDados.Close();
                    return cont;
                }
            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally
            {
                c.Desconectar();
            }
        }

        public DataTable PreencherTodos()
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }

        public DataTable pesquisaCodigo(int codigo)
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato where codcontato = " + codigo + " ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }

        public DataTable pesquisaNome(string nome)
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato where nome like '%" + nome + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }

        public DataTable pesquisaTelefone(string telefone)
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato where telefone like '%" + telefone + "%' ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }

        public DataTable pesquisaCelular(string celular)
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato where celular like '%" + celular + "%' ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }
        public DataTable pesquisaEmail(string email)
        {
            string sql = "select codcontato as 'Codigo', nome as Nome, telefone as Telefone, " +
                        "celular as Celular, email as Email from tbcontato where email like '%" + email + "%' ; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.conexao);

            c.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.Desconectar();
            return contato;
        }

        public string Backup(string Caminho)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string CaminhoBackup = Caminho + "\\backupContatos_" + dataAtual + ".sql";

            try
            {
                MySqlCommand cmd = new MySqlCommand(CaminhoBackup, c.conexao);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.Conectar();
                mb.ExportToFile(CaminhoBackup);
                c.Desconectar();
                return ("Backup  do banco de dados realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string Restore(string Caminho) //Backup a MySQL database
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Caminho, c.conexao);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.Conectar();
                mb.ImportFromFile(Caminho);
                c.Desconectar();
                return ("Banco de dados restaurado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

    }
}
