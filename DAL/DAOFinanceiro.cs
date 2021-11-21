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
    public class DAOFinanceiro {

        public static Boolean CadastrarContas(Conta conta) {


            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO CONTAS VALUES(@NOME, @VALOR, @STATUS, @DESCRICAO,(SELECT ID_CATEGORIA FROM CATEGORIA WHERE @CATEGORIA = NOME_CATEGORIA), (SELECT ID_HOSPEDAGEM FROM HOSPEDAGEM WHERE @ID_HOSPEDAGEM = ID_HOSPEDAGEM))";
            try {

                SqlCommand comando = new SqlCommand(sql, conn);

                comando.Parameters.AddWithValue("@NOME", conta.TituloConta);
                comando.Parameters.AddWithValue("@VALOR", conta.Valor);
                comando.Parameters.AddWithValue("@STATUS", conta.Status.ToString());
                comando.Parameters.AddWithValue("@DESCRICAO", conta.Descricao);
                comando.Parameters.AddWithValue("@CATEGORIA", conta.Categoria);
                comando.Parameters.AddWithValue("@ID_HOSPEDAGEM", conta.Hospedagem);
                      


                BD.abrirConexao();

                comando.ExecuteNonQuery();

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
