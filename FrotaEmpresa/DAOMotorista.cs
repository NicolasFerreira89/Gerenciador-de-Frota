using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace FrotaEmpresa
{
    class DAOMotorista
    {
        public MySqlConnection conexaoMotorista;

        public string dadosMotorista;
        public string comando;
        public string resultado;
        // VV VETORES  VV \\
        public int[] vetorCodigoMotorista;
        public string[] vetorNome;
        /*public int[] vetorIdade;*/
        public string[] vetorEndereco;
        public long[] vetorCPF;
        public string[] vetorTelefone;
        public string[] vetorCNH;
        public int i;
        public int contadorMotorista;
        public int contarCodigoMotorista;
        public string msg;


        public DAOMotorista()
        {
            conexaoMotorista = new MySqlConnection("server=localhost;DataBase=frotaEmpresa;Uid=root;password=");

            try
            {
                conexaoMotorista.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
                conexaoMotorista.Close();
            }

        }

        public void CadastrarMotorista(string nome, string endereco, long cpf, string telefone, string cnh)
        {
            try
            {
                dadosMotorista = "('','" + nome + "','" + cpf + "','" + endereco + "','" + telefone + "','" + cnh + "')";
                comando = "Insert into motorista (codigoMotorista, nome, cpf, endereco, telefone, cnh) values" + dadosMotorista;
                MySqlCommand sql = new MySqlCommand(comando, conexaoMotorista);
                resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Motorista Cadastrado!");
                }
                else
                {
                    MessageBox.Show("Falha ao Cadastrar Motorista!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu Errado!" + erro);
            }
        }

        public void VetorMotorista()
        {
            string query = "select * from motorista ";

            vetorCodigoMotorista = new int[100];
            vetorNome = new string[100];
            /*vetorIdade = new int[100];*/
            vetorEndereco = new string[100];
            vetorCPF = new long[100];
            vetorTelefone = new string[100];
            vetorCNH = new string[100];

            for (i = 0; i < 100; i++)
            {
                vetorCodigoMotorista[i] = 0;
                vetorNome[i] = "";
                /*vetorIdade[i] = 0;*/
                vetorEndereco[i] = "";
                vetorCPF[i] = 0;
                vetorTelefone[i] = "";
                vetorCNH[i] = "";
            }

            MySqlCommand coletarMotorista = new MySqlCommand(query, conexaoMotorista);
            MySqlDataReader leituraMotorista = coletarMotorista.ExecuteReader();

            i = 0;
            contadorMotorista = 0;
            while (leituraMotorista.Read())
            {
                vetorCodigoMotorista[i] = Convert.ToInt32(leituraMotorista["codigoMotorista"]);
                vetorNome[i] = leituraMotorista["nome"] + "";
                /*vetorIdade[i] = Convert.ToInt32(leituraMotorista["idade"]);*/
                vetorEndereco[i] = leituraMotorista["endereco"] + "";
                vetorCPF[i] = Convert.ToInt64(leituraMotorista["cpf"]);
                vetorTelefone[i] = leituraMotorista["telefone"] + "";
                vetorCNH[i] = leituraMotorista["cnh"] + "";

                contarCodigoMotorista = contadorMotorista;
                i++;
                contadorMotorista++;
            }

            leituraMotorista.Close();
        } // FIM DO VETOR VEICULO \\

        public string ConsultarTudoMotorista()
        {
            VetorMotorista();
            msg += "";
            for (i = 0; i < contadorMotorista; i++)
            {
                msg = "Código do Motorista: " + vetorCodigoMotorista[i] +
                      "Nome: " + vetorNome[i] +
                     /* "Idade: " + vetorIdade[i] +*/
                      "Endereço: " + vetorEndereco[i] +
                      "CPF: " + vetorCPF[i] +
                      "Telefone: " + vetorTelefone[i] +
                      "CNH: " + vetorCNH[i] +
                      "\n\n";
            }

            return msg;
        }

        public long ConsultarCPF(int cod)
        {
            VetorMotorista();

            for (i = 0; i < contadorMotorista; i++)
            {
                if (vetorCodigoMotorista[i] == cod)
                {
                    return vetorCPF[i];
                }
            }

            return -1;
        }

        public int ConsultarCodigoMotorista()
        {
            VetorMotorista();
            return vetorCodigoMotorista[contarCodigoMotorista];

        }

        public string ConsultarNome(int cod)
        {
            VetorMotorista();

            for (i = 0; i < contadorMotorista; i++)
            {
                if (vetorCodigoMotorista[i] == cod)
                {
                    return vetorNome[i];
                }
            }

            return "Nome não Encontrado!";
        }

        public string ConsultarTelefone(int cod)
        {
            VetorMotorista();

            for (i = 0; i < contadorMotorista; i++)
            {
                if (vetorCodigoMotorista[i] == cod)
                {
                    return vetorTelefone[i];
                }
            }

            return "Telefone não Encontrado!";
        }

        public string ConsultarEndereco(int cod)
        {
            VetorMotorista();

            for (i = 0; i < contadorMotorista; i++)
            {
                if (vetorCodigoMotorista[i] == cod)
                {
                    return vetorEndereco[i];
                }
            }

            return "Endereço não Encontrado!";
        }

        public string ConsultarCNH(int cod)
        {
            VetorMotorista();

            for (i = 0; i < contadorMotorista; i++)
            {
                if (vetorCodigoMotorista[i] == cod)
                {
                    return vetorCNH[i];
                }
            }

            return "Falha ao Procurar CNH!";
        }
        public string AtualizarMotorista(int cod, string campo, string novoDadoMotorista)
        {
            try
            {
                string query = "update motorista set " + campo + " = '" + novoDadoMotorista + "' where codigoMotorista = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoMotorista);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Dados do Motorista Atualizados!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar os dados do Motorista!";

        }

        public string AtualizarMotorista(int cod, string campo, long novoDadoVeiculo)
        {
            try
            {
                string query = "update motorista set " + campo + " = '" + novoDadoVeiculo + "' where codigoMotorista = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoMotorista);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Dados do Motorista Atualizados!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar os dados do Motorista!";

        }

        public void ExcluirMotorista(int cod)
        {
            try
            {
                string query = "delete from motorista where codigoMotorista = '" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexaoMotorista);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Motorista foi Excluído!");
                }
                else
                {
                    MessageBox.Show("Falha ao Excluir Motorista!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
    } // FIM DA CLASSE \\
} // FIM DO PROJETO \\




