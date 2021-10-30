using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using M.Entities;
using System.Windows.Forms;

namespace DAL {
    public class DAOCategoria {

        public static Boolean cadastrarCategoria(CategoriaGeral categoria) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO CATEGORIA(CLASSE, NOME) VALUES(@CLASSE, @NOME)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@CLASSE", categoria.Classe);
                comando.Parameters.AddWithValue("@NOME", categoria.Nome);

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
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
        public static Boolean cadastrarCategoriaProduto(CategoriaGeral categoria) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO CATEGORIA(CLASSE, NOME) VALUES(@CLASSE, @NOME)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@CLASSE", categoria.Classe);
                comando.Parameters.AddWithValue("@NOME", categoria.Nome);

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
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
        public static Boolean cadastrarCategoriaService(CategoriaGeral categoria) {
            //abrir a conexao
            SqlConnection conn = BD.abrirConexao();
            //string para inserção
            string sql = "INSERT INTO CATEGORIA(CLASSE, NOME) VALUES(@CLASSE, @NOME)";
            try {
                //criar um objeto passando a conexao e a sql inserção
                SqlCommand comando = new SqlCommand(sql, conn);
                //adicionando os valores a sql
                comando.Parameters.AddWithValue("@CLASSE", categoria.Classe);
                comando.Parameters.AddWithValue("@NOME", categoria.Nome);

                //abrir a conexao
                BD.abrirConexao();
                //executar os comandos
                comando.ExecuteNonQuery();
                //fechar a conexao
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
