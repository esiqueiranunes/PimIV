using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M.Entities;

namespace DAL {
    public class DAOLocal {

        public static Boolean cadastrarCategoriaLocal(CategoriaLocal catLocal) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO C_LOCAL VALUES(@NOME, @QUANT_PESSOAS, @VALOR, @DESCONTO_MAX)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@NOME", catLocal.nome);
                comando.Parameters.AddWithValue("@QUANT_PESSOAS", catLocal.qteMaxPessoas);
                comando.Parameters.AddWithValue("@VALOR", catLocal.valor);
                comando.Parameters.AddWithValue("@DESCONTO_MAX", catLocal.descontoMax);

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
