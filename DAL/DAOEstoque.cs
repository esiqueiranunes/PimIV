using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL {
    public class DAOEstoque {

        public int AlterarProduto(Produto produto) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "UPDATE PRODUTOS SET VALIDADE = @VALIDADE, ESTOQUE = @ESTOQUE, VALOR = @VALOR WHERE ID_PRODUTO = @ID";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@VALIDADE", produto.Validade);
                comando.Parameters.AddWithValue("@ESTOQUE", produto.Estoque);
                comando.Parameters.AddWithValue("@VALOR", produto.Valor);
                comando.Parameters.AddWithValue("@ID", produto.Id_produto);

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
                BD.fecharConexao();
                return Convert.ToInt32(comando.ExecuteNonQuery());

            }
            catch (SqlException erro) {
                Console.WriteLine("Erro ao alterar dados no banco" + erro);
                return 0;
            }
            finally {
                BD.fecharConexao();
            }
        }


        




    }
   
}
