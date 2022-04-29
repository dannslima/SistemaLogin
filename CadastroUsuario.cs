using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuario
    {
        public static Usuario[] usuarios = { new Usuario() { Nome = "Joao", Senha = "123" } };


        

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario item in usuarios)
            {
                if (item.Nome == nome && item.Senha == senha)
                {
                    UsuarioLogado = item;
                    return true;
                }
            }

            return false;
        }

    }
}
