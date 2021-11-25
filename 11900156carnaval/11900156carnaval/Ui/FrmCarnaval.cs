using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _11900156carnaval.Code.BLL;
using _11900156carnaval.Code.DTO;

namespace _11900156carnaval.Ui
{
    public partial class FrmCarnaval : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        CarnavalBLL medbll = new CarnavalBLL();
        CarnavalDTO meddto = new CarnavalDTO();

        public FrmCarnaval()
        {
            InitializeComponent();
        }

        private void FrmCarnaval_Load(object sender, EventArgs e)
        {
            dgvcarnaval.DataSource = medbll.Listar();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            meddto.Nome = txtnomedobloco.Text;
            meddto.Quantidade = txtquantpessoas.Text;


            if (txtnomedobloco.Text != "" || txtquantpessoas.Text != "")
            {
                medbll.Inserir(meddto);

                MessageBox.Show("Cadastrado com sucesso!", "Carnaval", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtid.Clear();
                txtnomedobloco.Clear();
                txtquantpessoas.Clear();

            }
            else
            {
                MessageBox.Show("Erro, preencha todos os campos!", "Carnaval", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvcarnaval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuario clicar em um registro da lista, os dados serão preenchidos
            txtid.Text = dgvcarnaval.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnomedobloco.Text = dgvcarnaval.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtquantpessoas.Text = dgvcarnaval.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);
            meddto.Nome = (txtnomedobloco.Text);
            meddto.Quantidade = (txtquantpessoas.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Carnaval", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtnomedobloco.Clear();
            txtquantpessoas.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);

            //Envio do dto preenchido para o método excluir
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Carnaval", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtnomedobloco.Clear();
            txtquantpessoas.Clear();
        }
    }
}
