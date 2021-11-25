using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importação da camada de negócio e da camada de acesso a dados
using _11900156carnaval.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using _11900156carnaval.Code.DAL;
using System.Data;

namespace _11900156carnaval.Code.BLL
{
    class CarnavalBLL
    {
        //Objeto para acesso ao banco de dados
        ConexaoBanco conexao = new ConexaoBanco();
        string tabela = "carnaval";

        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(CarnavalDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Quantidade}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(CarnavalDTO meddDto)
        {
            string alterar = $"update {tabela} set nomedobloco = '{meddDto.Nome}', quantpessoas = '{meddDto.Quantidade}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(CarnavalDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
