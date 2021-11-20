using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1gustavoHenrique14.CODE.DAL;
using _3c1gustavoHenrique14.CODE.DTO;
using System.Data;

namespace _3c1gustavoHenrique14.CODE.BLL
{
    class produto
    {
        public class Produto
        {
            Conexao conexao = new Conexao();
            string tabela = "oculos";

            public void Inserir(Oculos_dto medDto)
            {
                string inserir = $"insert into {tabela} values(null,'{oclDto.modelo}','{oclDto.preco}')";
                conexao.ExecutarComando(inserir);
            }

            public DataTable Listar()
            {
                string sql = $"select * from {tabela} order by id;";
                return conexao.ExecutarConsulta(sql);
            }

            public void Editar(Oculos_dto oclDto)
            {
                string alterar = $"update {tabela} set modelo = '{oclDto.modelo}', preco = '{oclDto.preco}' where id = '{oclDto.Id}';";
                conexao.ExecutarComando(alterar);
            }


            public void Excluir(OculosDTO oclDto)
            {
                string excluir = $"delete from {tabela} where id = '{oclDto.Id}';";
                conexao.ExecutarComando(excluir);
            }
        }
    }
}
