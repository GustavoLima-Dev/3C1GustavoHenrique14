using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1gustavoHenrique14.Code.DTO;
using _3c1gustavoHenrique14.CODE.DAL;

namespace _3c1gustavoHenrique14.CODE.BLL
{
    class Oculos_bll
    {
        Conexao conexao = new Conexao();
        string tabela = "oculos";

        public void Inserir(Oculos_dto request)
        {
            string inserir = $"insert into {tabela} values(null,'{request.Modelo}',{request.Preco})";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(Oculos_dto request)
        {
            string alterar = $"update {tabela} set modelo = '{request.Modelo}', preco = {request.Preco} where id = {request.Id};";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(Oculos_dto request)
        {
            string excluir = $"delete from {tabela} where id = '{request.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
