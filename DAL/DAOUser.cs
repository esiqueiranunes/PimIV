using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Users;
using System.Windows.Forms;


namespace DAL {
    public class DAOUser {

        public static Boolean cadastrarUsuario(Usuario user) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO USUARIO VALUES(@LOGIN, @SENHA, (SELECT ID_PESSOA FROM PESSOA WHERE EMAIL = @LOGIN ), @NIVEL)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@LOGIN", user.Login);                
                comando.Parameters.AddWithValue("@SENHA", user.Senha);
                //comando.Parameters.AddWithValue("@EMAIL", user.Login);
                comando.Parameters.AddWithValue("@NIVEL", user.Nivel.ToString());
                

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
                BD.fecharConexao();
                return true;
            }
            catch (SqlException erro) {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally {
                BD.fecharConexao();
            }
        }
    }
}
