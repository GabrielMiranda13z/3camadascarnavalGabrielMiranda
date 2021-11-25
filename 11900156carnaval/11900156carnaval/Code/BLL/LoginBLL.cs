using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11900156carnaval.Code.DTO; 
using _11900156carnaval.Code.DAL;
using System.Data;

namespace _11900156carnaval.Code.BLL
{
    class LoginBLL
    {
        //Objeto para acesso ao banco de dados
        ConexaoBanco conexao = new ConexaoBanco();
        string tabela = "login";

        public bool RealizarLogin(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where nome='{login.Nome}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
