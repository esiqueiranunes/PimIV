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
                MessageBox.Show("Corriga os dados, conforme erro: " + erro.Message);
                return false;
            }
            finally {
                BD.fecharConexao();
            }
        }
        public static Boolean verificarUsuarioBanco(string usuario, string senha) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            SqlDataReader dr; //objeto para receber o retorno do banco
            //string para pesquisa de usuario no banco
            string sql = "SELECT LOGIN FROM USUARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@LOGIN", usuario);
                comando.Parameters.AddWithValue("@SENHA", senha);
                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                dr = comando.ExecuteReader();//Usado para quando a conexão retorna valores nesse caso usamos um select
                //fechar a conexao
                if (dr.HasRows) { //se foi encontrada linha com os dados enviados
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (SqlException erro) {
                MessageBox.Show("Corriga os dados, conforme erro: " + erro.Message);
                return false;
            }
            finally {
                BD.fecharConexao();
            }
        }
    }
}
