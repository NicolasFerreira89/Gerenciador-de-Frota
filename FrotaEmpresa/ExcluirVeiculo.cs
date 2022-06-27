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
    public partial class ExcluirVeiculo : Form
    {

        DAOVeiculo veiculo;

        public ExcluirVeiculo()
        {
            InitializeComponent();
            veiculo = new DAOVeiculo();
            Campos();
        }

        public void Campos()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            comboBox1.Enabled = false;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;
        }

        private void ExcluirVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Código

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box Placa

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text boa Modelo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Cor


        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            veiculo.ConsultarCodigoVeiculo();

            textBox1.ReadOnly = true;
            maskedTextBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            comboBox1.Enabled = true;

            textBox2.Text = "" + veiculo.ConsultarModelo(Convert.ToInt32(textBox1.Text));
            maskedTextBox1.Text = "" + veiculo.ConsultarPlaca(Convert.ToInt32(textBox1.Text));
            textBox3.Text = "" + veiculo.ConsultarCor(Convert.ToInt32(textBox1.Text));
            comboBox1.Text = "" + veiculo.ConsultarCombustivel(Convert.ToInt32(textBox1.Text));

            textBox1.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;

            if (textBox2.Text == "Modelo não Encontrado!")
            {

                MessageBox.Show("Cadastro não encontrado!\n\n" +
                                 "Digite o Código novamente");

                Campos();

                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

            }

        }//Fim do Botão Consultar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do Combo Box Combustivel

        private void Excluir_Click(object sender, EventArgs e)
        {

            veiculo.ExcluirVeiculo(Convert.ToInt32(textBox1.Text));

            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;

            Campos();

        }//Fim do Botão Excluir

        private void Limpar_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;

            Campos();

        }//Fim do Botão Limpar

    }//Fim da Classe
}//Fim do Projeto
