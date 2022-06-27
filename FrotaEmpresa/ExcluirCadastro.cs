using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrotaEmpresa
{
    public partial class ExcluirCadastro : Form
    {

        ExcluirVeiculo DelVeiculo;
        ExcluirMotorista DelMotorista;
        
        public ExcluirCadastro()
        {
            InitializeComponent();
            DelVeiculo = new ExcluirVeiculo();
            DelMotorista = new ExcluirMotorista();
        }

        private void ExcluirCadastro_Load(object sender, EventArgs e)
        {

        }

        private void ExcluirMotorista_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            DelMotorista.ShowDialog();
            this.Visible = true;

        }//Fim Botão Excluir Cadastro Motorista

        private void ExcluirVeiculo_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            DelVeiculo.ShowDialog();
            this.Visible = true;

        }//Fim Botão Excluir Cadastro Veículo
    }
}
