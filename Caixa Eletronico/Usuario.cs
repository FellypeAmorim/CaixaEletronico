using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    internal class Usuario
    {
        private string _nome;
        private int _senha;

        public Usuario()
        {
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public void SetSenha(int senha)
        {
            _senha = senha;
        }

        public override string ToString()
        {
            return "Olá "
                + _nome;
        }
    }
}
