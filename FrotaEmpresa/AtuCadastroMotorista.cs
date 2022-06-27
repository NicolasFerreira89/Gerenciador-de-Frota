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
    public partial class AtuCadastroMotorista : Form
    {
        DAOMotorista motorista;

        public AtuCadastroMotorista()
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

        private void AtuCadastroMotorista_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim Text box Código

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
            
            
        }//Fim do Botão Consultar

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            string newNome = motorista.AtualizarMotorista(Convert.ToInt32(textBox1.Text), "nome", textBox2.Text);
            string newCPF = motorista.AtualizarMotorista(Convert.ToInt32(textBox1.Text), "cpf", TratarCPF(maskedTextBox1.Text));
            string newEndereco = motorista.AtualizarMotorista(Convert.ToInt32(textBox1.Text), "endereco", textBox3.Text);
            string newTelefone = motorista.AtualizarMotorista(Convert.ToInt32(textBox1.Text), "telefone", maskedTextBox2.Text);           
            string newCNH = motorista.AtualizarMotorista(Convert.ToInt32(textBox1.Text), "cnh", comboBox1.Text);

            if((newNome == "Dados do Motorista Atualizados!") && (newCPF == "Dados do Motorista Atualizados!") && (newEndereco == "Dados do Motorista Atualizados!") && (newTelefone == "Dados do Motorista Atualizados!") && (newCNH == "Dados do Motorista Atualizados!"))
            {

                Campos();
                MessageBox.Show("Atualizado com Sucesso!");
                textBox2.Text = "";
                maskedTextBox1.Text = "";
                textBox3.Text = "";
                maskedTextBox2.Text = "";
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
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;

        }//Fim do Botão Limpar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do ComboBox CNH

    }//Fim da Classe Atualizar Cadastro Motorista
}//Fim do Projeto
