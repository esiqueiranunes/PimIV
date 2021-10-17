using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace DAL {
    public class DAOCategoria {


        public static Boolean cadastrarCategoria(string classe, string nome) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
           string sql = "INSERT INTO CATEGORIA(CLASSE, NOME) VALUES(@CLASSE, @NOME)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@CLASSE", classe);
                comando.Parameters.AddWithValue("@NOME", nome);

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
                BD.fecharConexao();
                return true;
            }
            catch (SqlException erro) {
                Console.WriteLine("Erro ao inserir dados no banco" + erro);
                return false;
            }
            finally {
                BD.fecharConexao();
            }

        }

        
    }
}
