using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using Entities;
using System.Windows.Forms;

namespace DAL {
    public class DAOReserva {
        public static Boolean reservar(Hospedagem hospedagem) {


            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO HOSPEDAGEM VALUES((SELECT ID_PESSOA FROM PESSOA WHERE @CPF = CPF), (SELECT ID_LOCAL FROM LOCAL WHERE @LOCAL = NOME),@STATUS,@DATA_ENTRADA,@HORA_ENTRADA, @DATA_SAIDA, @HORA_SAIDA,@QUANT_PESSOAS)";
            try {
                
                SqlCommand comando = new SqlCommand(sql, conn);
                
                comando.Parameters.AddWithValue("@CPF", hospedagem.Titular);
                comando.Parameters.AddWithValue("@LOCAL", hospedagem.LocalHospedagem);
                comando.Parameters.AddWithValue("@STATUS", hospedagem.Status.ToString());
                comando.Parameters.AddWithValue("@DATA_ENTRADA", hospedagem.DataEntrada);
                comando.Parameters.AddWithValue("@HORA_ENTRADA", hospedagem.HorarioEntrada);
                comando.Parameters.AddWithValue("@DATA_SAIDA",hospedagem.DataSaida);
                comando.Parameters.AddWithValue("@HORA_SAIDA", hospedagem.HorarioSaida);
                comando.Parameters.AddWithValue("@QUANT_PESSOAS", hospedagem.QtePessoas);


                BD.abrirConexao();
                
                comando.ExecuteNonQuery();
               
                BD.fecharConexao();
                return true;
            }
            catch (SqlException erro) {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally {
                BD.fecharConexao();
            }
        }
    }
}
