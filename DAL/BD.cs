using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL {
    public class BD {
        //conectando com o bando sqlserver express à base de dados usando window authentication
        // para conectar com o banco de dados criado, segundo o arquivo de criação do "SCRIPT PIM.sql" na pasta SQL deste projeto
        // mude o nome "EDUARDO\SQLEXPRESS" para o nome da
        private static string connString = @"Server = EDUARDO\SQLEXPRESS; Database = HOTEL; Trusted_Connection = true";
        //criar um atributo para a conexao
        private static SqlConnection conn = null;
        private static SqlConnection objConect = null;
        private static SqlCommand objCommand = null;
        //metodo para realizar a conexao
        public static SqlConnection abrirConexao() {
            //criar a conexao
            conn = new SqlConnection(connString);
            //conexao ok
            try {
                //abrir a conexão
                conn.Open();
            }
            catch (SqlException sqle) {
                conn = null;
                Console.WriteLine("Erro ao Realizar a conexao!" + sqle);
            }
            return conn;
        }
        public static void fecharConexao() {
            if (conn != null) {
                try {
                    conn.Close();
                }
                catch (SqlException sqle) {
                    Console.WriteLine("Erro ao fechar conexão com o banco de dados" + sqle);
                }
            }
        }
        public  DataTable ListarGrid(string query) {
            

            objConect = new SqlConnection(connString);
            objCommand = new SqlCommand(query, objConect);

            DataTable dtLista = new DataTable();

            try {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);


                objAdp.Fill(dtLista);
                return dtLista;

            }
            catch (SqlException erro) {

                MessageBox.Show(erro.Message);
            }
            return null;

        }
        public  int ExcluirRegistro(int id, string query) {
            /*StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM HOSPEDAGEM ")
              .Append("WHERE [ID_HOSPEDAGEM] = 8");*/

            SqlConnection conn = BD.abrirConexao();

            try {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                return Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException erro) {
                MessageBox.Show(erro.Message);
            }
            catch (Exception erro) {
                MessageBox.Show(erro.Message);
            }
            return 0;
        }

    }
}
