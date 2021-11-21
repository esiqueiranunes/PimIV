using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using Entities;
using System.Windows.Forms;
using Enums;
using System.Data;

namespace DAL {
    public class DAOReserva {

        private static string connString = @"Server = EDUARDO\SQLEXPRESS; Database = HOTEL; Trusted_Connection = true";

        private static SqlConnection objConect = null;
        private static SqlCommand objCommand = null;

        public static DataTable listaGrid() {
            string strSql = "SELECT * FROM HOSPEDAGEM";

            objConect = new SqlConnection(connString);
            objCommand = new SqlCommand(strSql, objConect);

            DataTable dtLista = new DataTable();

            try {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);


                objAdp.Fill(dtLista);

                return dtLista;
            }
            catch {

                MessageBox.Show("Disgraçaaaa");
            }
            return dtLista;
        }
        public DataTable directQuery(string query) {

            SqlConnection conn = BD.abrirConexao();
            string sql = query; // aqui vai o "SELECT * FROM CLIENTES""
            DataTable data = new DataTable("tabela"); // Cria table com os dados vindos do BD
            try {
                try {
                    SqlCommand cmd = new SqlCommand(sql, conn); // String de comando + string de coxeão 

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

                    adaptador.Fill(data); // Preenche a tabela
                }
                catch { }
            }
            finally {
                BD.fecharConexao();
            }
            return data; // Retorna um datatable com todos dados      
        }


        public static Boolean reservar(Hospedagem hospedagem) {


            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO HOSPEDAGEM VALUES((SELECT ID_PESSOA FROM PESSOA WHERE @CPF = CPF), (SELECT ID_LOCAL FROM LOCAL WHERE @LOCAL = NOME_LOCAL),@STATUS,@DATA_ENTRADA,@HORA_ENTRADA, @DATA_SAIDA, @HORA_SAIDA,@QUANT_PESSOAS)";
            try {

                SqlCommand comando = new SqlCommand(sql, conn);

                comando.Parameters.AddWithValue("@CPF", hospedagem.Titular);
                comando.Parameters.AddWithValue("@LOCAL", hospedagem.LocalHospedagem);
                comando.Parameters.AddWithValue("@STATUS", hospedagem.Status.ToString());
                comando.Parameters.AddWithValue("@DATA_ENTRADA", hospedagem.DataEntrada);
                comando.Parameters.AddWithValue("@HORA_ENTRADA", hospedagem.HorarioEntrada);
                comando.Parameters.AddWithValue("@DATA_SAIDA", hospedagem.DataSaida);
                comando.Parameters.AddWithValue("@HORA_SAIDA", hospedagem.HorarioSaida);
                comando.Parameters.AddWithValue("@QUANT_PESSOAS", hospedagem.QtePessoas);


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
        public List<Hospedagem> CarregarGridDao(string strWhere) {
            List<Hospedagem> listaHospedagem = new List<Hospedagem>();
            Hospedagem hospedagem = null;

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            //StringBuilder usada para concatenar strings
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT H.ID_HOSPEDAGEM, P.NOME, P.CPF, L.NOME_LOCAL , H.STATUS, H.DATA_ENTRADA ,H.HORA_ENTRADA, H.DATA_SAIDA, H.HORA_SAIDA, H.QUANT_PESSOAS ")
                .Append(" FROM HOSPEDAGEM H ")
                .Append("INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA ")
                .Append("INNER JOIN LOCAL L ON L.ID_LOCAL = H.FK_LOCAL")
                .Append(" " + strWhere + " ")
                .Append(" ORDER BY ID_HOSPEDAGEM");


            SqlConnection conn = BD.abrirConexao();
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            try {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    hospedagem = new Hospedagem();

                    /*if (dr["ID_HOSPEDAGEM"] != DBNull.Value)
                        hospedagem.IdHospedagem = Convert.ToInt32(dr["id_hospedagem"]);*/

                    /*if (dr["NOME"] != DBNull.Value)
                        hospedagem.Titular = (dr["titular"].ToString());

                    if (dr["NOME_LOCAL"] != DBNull.Value)
                        hospedagem.LocalHospedagem = (dr["nome_local"].ToString());*/

                    /*if (dr["STATUS"] != DBNull.Value)
                        hospedagem.Status = (StatusHospedagem)Enum.Parse(typeof(StatusHospedagem),(dr["status"].ToString())); */

                    if (dr["DATA_ENTRADA"] != DBNull.Value)
                        hospedagem.DataEntrada = Convert.ToDateTime(dr["data_entrada"].ToString());

                    /*if (dr["HORA_ENTRADA"] != DBNull.Value)
                        hospedagem.HorarioEntrada = TimeSpan.Parse((string)dr["hora_entrada"]);*/

                    if (dr["DATA_SAIDA"] != DBNull.Value)
                        hospedagem.DataSaida = Convert.ToDateTime(dr["data_saida"].ToString());

                    /* if (dr["HORA_SAIDA"] != DBNull.Value)
                         hospedagem.HorarioSaida = TimeSpan.Parse((string)dr["hora_saida"]); */

                    if (dr["QUANT_PESSOAS"] != DBNull.Value)
                        hospedagem.QtePessoas = Convert.ToInt32(dr["qtePessoas"].ToString()); ;

                    if (listaHospedagem == null)
                        listaHospedagem = new List<Hospedagem>();

                    listaHospedagem.Add(hospedagem);
                }

                return listaHospedagem;
            }
            catch (SqlException erro) {
                MessageBox.Show(erro.Message);
                return listaHospedagem;
            }

            finally {
                BD.fecharConexao();
            }
        }
        public int Check(int id, string query) {

            /* UPDATE HOSPEDAGEM SET DATA_ENTRADA = CONVERT (date, GETDATE()), HORA_ENTRADA = CONVERT (time, GETDATE()) WHERE ID_HOSPEDAGEM = @ID*/
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
