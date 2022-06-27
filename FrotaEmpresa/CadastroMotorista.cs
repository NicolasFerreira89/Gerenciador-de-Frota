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
    public partial class CadastroMotorista : Form
    {
        DAOMotorista motorista;

        public CadastroMotorista()
        {
            InitializeComponent();
            motorista = new DAOMotorista();
            textBox1.Enabled = false;

        }

        private void CadastroMotorista_Load(object sender, EventArgs e)
        {

        }

        public long TratarCPF(String cpf)
        {
            string tratamento = cpf.Replace(",", "");
            tratamento = tratamento.Replace("-", "");
            return Convert.ToInt64(tratamento);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text Box Código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text Box Nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text Box CPF

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Masked Text Box Telefone

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text Box Endereço


        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = TratarCPF(maskedTextBox1.Text);
                string nome = textBox2.Text;
                string telefone = maskedTextBox2.Text;
                string endereco = textBox3.Text;
                string cnh = comboBox1.Text;

                motorista.CadastrarMotorista(nome, endereco, cpf, telefone, cnh);

                maskedTextBox1.Clear();
                textBox2.Clear();
                maskedTextBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

            }
            catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//Fim do Botão Cadastrar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do Combo Box CNH

    }//Fim da Classe
}//Fim do Projeto
