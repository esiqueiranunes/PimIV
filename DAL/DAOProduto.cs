using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M.Entities;
using Entities;

namespace DAL {
    public class DAOProduto {

        public static Boolean cadastrarProduto(Produto produto) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO PRODUTOS VALUES(@NOME, @MARCA, @FORNECEDOR, @UNI_MEDIDA, @VALIDADE, @ESTOQUE, @VALOR, (SELECT ID_CATEGORIA FROM CATEGORIA WHERE @CATEGORIA = NOME AND CLASSE = 'PRODUTO'))";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@NOME", produto.Nome);
                comando.Parameters.AddWithValue("@MARCA", produto.Marca);
                comando.Parameters.AddWithValue("@FORNECEDOR", produto.Fornecedor);
                comando.Parameters.AddWithValue("@UNI_MEDIDA", produto.UnidMedida);
                comando.Parameters.AddWithValue("@VALIDADE", produto.Validade);
                comando.Parameters.AddWithValue("@ESTOQUE", produto.QteEstoque);
                comando.Parameters.AddWithValue("@VALOR", produto.Valor);
                comando.Parameters.AddWithValue("@CATEGORIA", produto.Categoria);
                



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
