using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11900156carnaval.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _nome;
        private string _senha;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
