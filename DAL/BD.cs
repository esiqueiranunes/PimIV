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
        //conectando com o bando sqlserver express à base de dados usando whindow authentication
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
                    Console.WriteLine("Erro ao Realizar a conexao!" + sqle);
                }
            }
        }
        public static DataTable listarGrid(string query) {
            

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
    }
}
