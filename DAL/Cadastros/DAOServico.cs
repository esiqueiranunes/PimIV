using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M.Entities;
using Entities;
using System.Windows.Forms;

namespace DAL {
    public class DAOServico {

        public static Boolean cadastrarService(Service service) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO SERVICOS VALUES(@NOME, @DESCRICAO, @VALOR, (SELECT ID_CATEGORIA FROM CATEGORIA WHERE @NOMECATEGORIA = NOME_CATEGORIA AND CLASSE = @CLASSE))";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@NOME", service.Nome);
                comando.Parameters.AddWithValue("@DESCRICAO", service.Descricao);
                comando.Parameters.AddWithValue("@VALOR", service.Valor);
                comando.Parameters.AddWithValue("@NOMECATEGORIA", service.Categoria);
                comando.Parameters.AddWithValue("@CLASSE", service.Classe);

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



    }
}

