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
    public partial class Gasto : Form
    {
        DAOGasto gasto;
        DAOVeiculo veiculo;
        public Gasto()
        {
            InitializeComponent();

            gasto = new DAOGasto();
            veiculo = new DAOVeiculo();

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;

        }

        public decimal TratarValor(string valor)
        {

            string tratamento = valor.Replace(".", "");
            tratamento = tratamento.Replace(",", "");
         
            return Convert.ToDecimal(tratamento);

        }

        private void Gasto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Código

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box Abastecimento

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Tex box Manutenção

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box Multa

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box Data

        private void button1_Click(object sender, EventArgs e)
        {

            veiculo.ConsultarCodigoVeiculo();

            textBox2.Text = "" + veiculo.ConsultarModelo(Convert.ToInt32(textBox1.Text));

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = false;
            maskedTextBox2.ReadOnly = false;
            maskedTextBox3.ReadOnly = false;
            maskedTextBox4.ReadOnly = false;

            if (textBox2.Text == "Modelo não Encontrado!")
            {

                MessageBox.Show("Veículo não encontrado!\n\n" +
                                 "Digite o Código novamente");

                textBox1.Clear();
                textBox2.Clear();

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                maskedTextBox1.ReadOnly = true;
                maskedTextBox2.ReadOnly = true;
                maskedTextBox3.ReadOnly = true;
                maskedTextBox4.ReadOnly = true;

            }

        }//Fim do Botão Consultar

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                int codVeiculo = Convert.ToInt32(textBox1.Text);
                string abastecimento =maskedTextBox2.Text;
                string manutencao = maskedTextBox3.Text;
                string multa = maskedTextBox4.Text;
                string dtDia = maskedTextBox1.Text;



                gasto.CadastrarGasto(codVeiculo, abastecimento, manutencao, dtDia, multa);

                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
              
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//Fim do Botão Cadastrar

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do textBox Modelo Veiculo

    }//Fim da Classe
}//Fim do Projeto
