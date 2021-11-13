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


        public List<Produto> CarregarGridDao(string strWhere) {
            List<Produto> listaProdutos = new List<Produto>();
            Produto produtos = null;

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            //StringBuilder usada para concatenar strings
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT P.ID_PRODUTO, P.NOME , P.MARCA, P.FORNECEDOR, P.UNI_MEDIDA, P.VALIDADE, P.ESTOQUE, P.VALOR, C.NOME_CATEGORIA ")
                .Append(" FROM PRODUTOS P ")
                .Append("INNER JOIN CATEGORIA C ON P.FK_CATEGORIA = C.ID_CATEGORIA ")
                .Append(" " + strWhere + " ")
                .Append(" ORDER BY ID_PRODUTO");
            

            SqlConnection conn = BD.abrirConexao();
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            try {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    produtos = new Produto();

                   if (dr["ID_PRODUTO"] != DBNull.Value) 
                        produtos.Id_produto = Convert.ToInt32(dr["id_produto"]);

                    if (dr["NOME"] != DBNull.Value)
                    produtos.Nome = (dr["nome"].ToString());

                    if (dr["MARCA"] != DBNull.Value)
                    produtos.Marca = (dr["marca"].ToString());

                    if (dr["FORNECEDOR"] != DBNull.Value)
                    produtos.Fornecedor = dr["fornecedor"].ToString();

                    if (dr["UNI_MEDIDA"] != DBNull.Value)
                    produtos.Uni_medida = dr["uni_medida"].ToString();

                    if (dr["VALIDADE"] != DBNull.Value)
                    produtos.Validade= Convert.ToDateTime(dr["validade"].ToString());

                    if (dr["ESTOQUE"] != DBNull.Value)
                    produtos.Estoque = Convert.ToInt32(dr["estoque"]);

                    if (dr["VALOR"] != DBNull.Value)
                    produtos.Valor = Convert.ToDouble(dr["valor"]);

                    if (dr["NOME_CATEGORIA"] != DBNull.Value)
                    produtos.Nome_categoria = (dr["nome_categoria"].ToString()); ;

                    if (listaProdutos == null)
                    listaProdutos = new List<Produto>();

                    listaProdutos.Add(produtos);
                }

                return listaProdutos;
            }
            catch (SqlException erro) {
                MessageBox.Show(erro.Message);
                return listaProdutos;
            }
            /*catch (IndexOutOfRangeException erro) {
                MessageBox.Show(erro.Message);
                return listaProdutos;
            }*/
            finally {
                BD.fecharConexao();
            }
        }




    }
   
}
