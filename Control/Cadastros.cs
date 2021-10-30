using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Users;
using M.Entities;
using Entities;

namespace Control {
    public class Cadastros {
        #region Cadastro de Categorias
        public static Boolean salvarCategoria(CategoriaGeral categoria) {
            if(DAOCategoria.cadastrarCategoria(categoria)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static Boolean salvarCategoriaService(CategoriaGeral categoria) {
            if (DAOCategoria.cadastrarCategoriaService(categoria)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static Boolean salvarCategoriaProduto(CategoriaGeral categoria) {
            if (DAOCategoria.cadastrarCategoriaProduto(categoria)) {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion
        #region Cadastro de Pessoa
        public static Boolean salvarPessoa(Pessoa pessoa) {
            if (DAOPessoa.cadastrarPessoa(pessoa)) {
                return true;
            }
            else {
                return false;
            }
        }
        

        public static Boolean salvarEndereco(string cpf, Endereco endereco) {
            if (DAOPessoa.cadastrarEndereco(cpf, endereco)) {
                return true;
            }
            else {
                return false;
            }
        }

        #endregion
        #region Cadastro de Usuário
        public static Boolean salvarUsuario(Usuario user) {
            if (DAOUser.cadastrarUsuario(user)) {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion
        #region Cadastro de Local
        public static Boolean salvarLocal(Local local) {
            if (DAOLocal.cadastrarLocal(local)) {
                return true;
            }
            else {
                return false;
            }
        }

        public static Boolean salvarCategoriaLocal(CategoriaLocal categoria) {
            if (DAOLocal.cadastrarCategoriaLocal(categoria)){
                return true;
            }
            else {
                return false;
            }
        }
        #endregion
        #region Cadastro de produtos e serviços
        public static Boolean salvarService(Service service) {
            if (DAOServico.cadastrarService(service)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static Boolean salvarProduto(Produto produto) {
            if (DAOProduto.cadastrarProduto(produto)) {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion
    }
}
