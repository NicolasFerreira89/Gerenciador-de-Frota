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
    public partial class CadastroVeiculo : Form
    {
        DAOVeiculo veiculo;
        public CadastroVeiculo()
        {
            InitializeComponent();
            veiculo = new DAOVeiculo();

            textBox1.Enabled = false;

        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Código

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked text box Placa

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text Box Modelo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text Box Cor

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do Combo Box Combustivel

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
               
                string placa = maskedTextBox1.Text;
                string modelo = textBox2.Text;
                string cor = textBox3.Text;
                string combustivel = comboBox1.Text;

                veiculo.CadastrarVeiculo(modelo, placa, cor, combustivel);
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;

        }//Fim do Botão Cadastrar
    }//Fim da Classe
}//Fim do Projeto
