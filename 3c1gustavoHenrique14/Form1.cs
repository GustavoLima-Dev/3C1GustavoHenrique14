using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3c1gustavoHenrique14.CODE.BLL;
using _3c1gustavoHenrique14.CODE.DTO;

namespace _3c1gustavoHenrique14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Oculos_bll _service = new Oculos_bll();

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_modelo.Text != "" && txt_preco.Text != "")
            {
                string nome = txt_modelo.Text;
                decimal preco = decimal.Parse(txt_preco.Text);

                _service.Inserir(new Oculos_dto() { Modelo = modelo, preco = preco });

                txt_modelo.Text = "";
                txt_preco.Text = "";
                txt_id.Text = "";
            }
            else
            {
                MessageBox.Show("Dados inseridos incorretamente!", "", MessageBoxButtons.OK);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                int id = int.Parse(txt_id.Text);
                string nome = txt_modelo.Text;
                decimal preco = decimal.Parse(txt_preco.Text);

                _service.Editar(new Oculos_dto() { Id = id, Modelo = modelo, Preco = preco });

                txt_modelo.Text = "";
                txt_preco.Text = "";
                txt_id.Text = "";
            }
            else
            {
                MessageBox.Show("Dados inseridos incorretamente!", "", MessageBoxButtons.OK);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                int id = int.Parse(txt_id.Text);

                _service.Excluir(new Oculos_dto() { Id = id });

                txt_modelo.Text = "";
                txt_preco.Text = "";
                txt_id.Text = "";
            }
            else
            {
                MessageBox.Show("Dados inseridos incorretamente!", "", MessageBoxButtons.OK);
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {

            dgv_view.DataSource = _service.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_view.DataSource = _service.Listar();
        }
    }
}
