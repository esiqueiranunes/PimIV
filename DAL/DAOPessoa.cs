using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using Entities;

namespace DAL {
    public class DAOPessoa {

        public static Boolean cadastrarPessoa(Pessoa pessoa) {


            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO PESSOA VALUES(@NOME,@CPF,@EMAIL,@NASCIMENTO,(SELECT ID_CATEGORIA FROM CATEGORIA WHERE @CATEGORIA = NOME ),@SEXO, @TELEFONE)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@NOME", pessoa.Nome);
                comando.Parameters.AddWithValue("@CPF", pessoa.Cpf);
                comando.Parameters.AddWithValue("@EMAIL", pessoa.Email);
                comando.Parameters.AddWithValue("@NASCIMENTO", pessoa.Nascimento);
                comando.Parameters.AddWithValue("@CATEGORIA", pessoa.Categoria);
                comando.Parameters.AddWithValue("@SEXO", pessoa.Sexo.ToString());
                comando.Parameters.AddWithValue("@TELEFONE", pessoa.Telefone);

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
        public static Boolean cadastrarEndereco(string cpf, Endereco endereco) {


            SqlConnection conn = BD.abrirConexao();

            string sql = "INSERT INTO ENDERECO VALUES(@NOME_END,@BAIRRO,@CIDADE,@ESTADO,(SELECT ID_PESSOA FROM PESSOA WHERE CPF= @CPF))";
            //string sql = "INSERT INTO ENDERECO VALUES('TESTE','TESTE','TESTE','GO',(SELECT ID_PESSOA FROM PESSOA WHERE CPF= 'TESTE'))";
            try {
                SqlCommand comando = new SqlCommand(sql, conn);
             

                comando.Parameters.AddWithValue("@NOME_END", endereco.Logradouro);
                comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
                comando.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
                comando.Parameters.AddWithValue("@ESTADO", endereco.Uf.ToString());
                comando.Parameters.AddWithValue("@CPF", cpf);



                BD.abrirConexao();

                comando.ExecuteNonQuery();

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
