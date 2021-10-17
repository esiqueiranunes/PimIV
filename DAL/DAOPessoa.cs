using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace DAL {
    public class DAOPessoa {

         public static Boolean cadastrarPessoa(string nome, string cpf, string nascimento, string email, int categoria, char sexo, string telefone) {
            

            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO PESSOA(NOME, CPF, EMAIL, DATA_NASC, FK_CATEGORIA, SEXO, TELEFONE) VALUES('@NOME','@CPF','@EMAIL','@NASCIMENTO',@FK_CATEGORIA,'@SEXO', '@TELEFONE')";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@NOME", nome);
                comando.Parameters.AddWithValue("@CPF", cpf);
                comando.Parameters.AddWithValue("@EMAIL", email);
                comando.Parameters.AddWithValue("@NASCIMENTO",nascimento);
                comando.Parameters.AddWithValue("@FK_CATEGORIA", categoria);
                comando.Parameters.AddWithValue("@SEXO", sexo);
                comando.Parameters.AddWithValue("@TELEFONE", telefone);

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
