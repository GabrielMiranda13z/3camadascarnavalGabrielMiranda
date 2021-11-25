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
    public partial class FrmLogin : Form
    {
        LoginBLL loginprodutoBBL = new LoginBLL();
        LoginDTO loginprodutoDTO = new LoginDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnentar_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginprodutoDTO.Nome = txtnome.Text;
            loginprodutoDTO.Senha = txtsenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginprodutoBBL.RealizarLogin(loginprodutoDTO) == true)
            {

                FrmCarnaval frm_rede = new FrmCarnaval();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
    }

