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
    public partial class AtuCadastroVeiculo : Form
    {
        DAOVeiculo veiculo;
        public AtuCadastroVeiculo()
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
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;
        }

        private void AtuCadastroVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim Text Box Código

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked text box Placa

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Modelo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Cor


        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            veiculo.ConsultarCodigoVeiculo();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
            maskedTextBox1.ReadOnly = false;
            textBox3.ReadOnly = false;
            comboBox1.Enabled = true;

            textBox2.Text = "" + veiculo.ConsultarModelo(Convert.ToInt32(textBox1.Text));
            maskedTextBox1.Text = "" + veiculo.ConsultarPlaca(Convert.ToInt32(textBox1.Text));
            textBox3.Text = "" + veiculo.ConsultarCor(Convert.ToInt32(textBox1.Text));
            comboBox1.Text = "" + veiculo.ConsultarCombustivel(Convert.ToInt32(textBox1.Text));

            if (textBox2.Text == "Modelo não Encontrado!")
            {

                MessageBox.Show("Veículo não encontrado!\n\n" +
                                 "Digite o Código novamente");

                Campos();

                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

            }

        }//Fim do botão Consultar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do Combo Box Combustivel

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            string newModelo = veiculo.AtualizarVeiculo(Convert.ToInt32(textBox1.Text), "modelo", textBox2.Text);
            string newPlaca = veiculo.AtualizarVeiculo(Convert.ToInt32(textBox1.Text), "placa", maskedTextBox1.Text);
            string newCor = veiculo.AtualizarVeiculo(Convert.ToInt32(textBox1.Text), "cor", textBox3.Text);
            string newCombustivel = veiculo.AtualizarVeiculo(Convert.ToInt32(textBox1.Text), "combustivel", comboBox1.Text);

            if ((newModelo == "Veículo Atualizado!") && (newPlaca == "Veículo Atualizado!") && (newCor == "Veículo Atualizado!") && (newCombustivel == "Veículo Atualizado!"))
            {

                Campos();
                MessageBox.Show("Atualizado com Sucesso!");
                textBox2.Text = "";
                maskedTextBox1.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";


            }
            else
            {
                MessageBox.Show("Não foi possivel Atualizar!");
            }


        }//Fim do Botão Atualizar

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;

        }//Fim do Botão Limpar

    }//Fim da Classe
}//Fim do projeto