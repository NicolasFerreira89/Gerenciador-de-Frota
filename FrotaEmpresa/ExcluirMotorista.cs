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
    public partial class ExcluirMotorista : Form
    {

        DAOMotorista motorista;

        public ExcluirMotorista()
        {
            InitializeComponent();
            motorista = new DAOMotorista();

            Campos();

        }

        public void Campos()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;
        }

        public long TratarCPF(string cpf)
        {
            string tratamento = cpf.Replace(",", "");
            tratamento = tratamento.Replace("-", "");
            return Convert.ToInt64(tratamento);
        }

        private void ExcluirMotorista_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box CPF

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box Telefone

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box Endereço

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text box CNH

        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            motorista.ConsultarCodigoMotorista();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
            maskedTextBox1.ReadOnly = false;
            maskedTextBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            comboBox1.Enabled = true;

            textBox2.Text = "" + motorista.ConsultarNome(Convert.ToInt32(textBox1.Text));
            maskedTextBox1.Text = "" + motorista.ConsultarCPF(Convert.ToInt32(textBox1.Text));
            maskedTextBox2.Text = "" + motorista.ConsultarTelefone(Convert.ToInt32(textBox1.Text));
            textBox3.Text = "" + motorista.ConsultarEndereco(Convert.ToInt32(textBox1.Text));
            comboBox1.Text = "" + motorista.ConsultarCNH(Convert.ToInt32(textBox1.Text));

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;

            if (textBox2.Text == "Nome não Encontrado!")
            {

                MessageBox.Show("Cadastro não encontrado!\n\n" +
                                 "Digite o Código novamente");

                Campos();

                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

            }

        }//Fim do Botão COnsultar

        private void botaoExcluir_Click(object sender, EventArgs e)
        {

            motorista.ExcluirMotorista(Convert.ToInt32(textBox1.Text));

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;


        }//Fim do Botão Excluir

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do ComboBox CNH

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;

        }//Fim do Botão Limpar

    }//Fim da Classe
}//Fim do Projeto
