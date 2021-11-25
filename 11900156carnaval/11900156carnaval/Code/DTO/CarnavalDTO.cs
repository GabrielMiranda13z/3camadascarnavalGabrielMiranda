using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11900156carnaval.Code.DTO
{
    class CarnavalDTO
    {
        //Properiedades privadas
        private int _id;
        private string _nomedobloco;
        private string _quantpessoas;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nomedobloco; set => _nomedobloco = value; }
        public string Quantidade { get => _quantpessoas; set => _quantpessoas = value; }
    }
}
