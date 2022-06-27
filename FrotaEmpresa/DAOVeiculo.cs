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
    class DAOVeiculo
    {
        public MySqlConnection conexaoVeiculo;

        public string dadosVeiculo;
        public string comando;
        public string resultado;
        // VV VETORES  VV \\
        public int[] vetorCodigoVeiculo;
        public string[] vetorModelo;
        public string[] vetorPlaca;
        public string[] vetorCor;
        public string[] vetorCombustivel;
        public int i;
        public int contadorVeiculo;
        public int contarCodigoVeiculo;
        public string msg;
        
        public DAOVeiculo()
        {
            conexaoVeiculo = new MySqlConnection("server=localhost;DataBase=frotaEmpresa;Uid=root;password=");

            try
            {
                conexaoVeiculo.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
                conexaoVeiculo.Close();
            }

        }

        public void CadastrarVeiculo(string modelo, string placa, string cor, string combustivel)
        {
            try
            {
                dadosVeiculo = "('','" + modelo + "','" + placa + "','" + cor + "','" + combustivel + "')";
                comando = "Insert into veiculo (codigoVeiculo, modelo, placa, cor, combustivel) values" + dadosVeiculo;
                MySqlCommand sql = new MySqlCommand(comando, conexaoVeiculo);
                resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Veículo Cadastrado!");
                }
                else
                {
                    MessageBox.Show("Falha ao Cadastrar Veículo!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu Errado!" + erro);
            }
        }

        public void VetorVeiculo()
        {
            string query = "select * from veiculo ";

            vetorCodigoVeiculo = new int[100];
            vetorModelo = new string[100];
            vetorPlaca = new string[100];
            vetorCor = new string[100];
            vetorCombustivel = new string[100];

            for (i = 0; i < 100; i++)
            {
                vetorCodigoVeiculo[i] = 0;
                vetorModelo[i] = "";
                vetorPlaca[i] = "";
                vetorCor[i] = "";
                vetorCombustivel[i] = "";
            }

            MySqlCommand coletarVeiculo = new MySqlCommand(query, conexaoVeiculo);
            MySqlDataReader leituraVeiculo = coletarVeiculo.ExecuteReader();

            i = 0;
            contadorVeiculo = 0;
            while (leituraVeiculo.Read())
            {
                vetorCodigoVeiculo[i] = Convert.ToInt32(leituraVeiculo["codigoVeiculo"]);
                vetorModelo[i] = leituraVeiculo["modelo"] + "";
                vetorPlaca[i] = leituraVeiculo["placa"] + "";
                vetorCor[i] = leituraVeiculo["cor"] + "";
                vetorCombustivel[i] = leituraVeiculo["combustivel"] + "";

                contarCodigoVeiculo = contadorVeiculo;
                i++;
                contadorVeiculo++;
            }

            leituraVeiculo.Close();
        } // FIM DO VETOR VEICULO \\

        public string ConsultarTudoVeiculo()
        {
            VetorVeiculo();
            msg += "";
            for (i = 0; i < contadorVeiculo; i++)
            {
                msg = "Código do Veículo: " + vetorCodigoVeiculo[i] +
                      "Modelo: " + vetorModelo[i] +
                      "Placa: " + vetorPlaca[i] +
                      "Cor: " + vetorCor[i] +
                      "Tipo de Combustivel: " + vetorCombustivel +
                      "\n\n";
            }

            return msg;
        }

        public string ConsultarPlaca(int cod)
        {
            VetorVeiculo();

            for (i = 0; i < contadorVeiculo; i++)
            {
                if (vetorCodigoVeiculo[i] == cod)
                {
                    return vetorPlaca[i];
                }
            }

            return "Placa não Encontrada!";
        }

        public int ConsultarCodigoVeiculo()
        {
            VetorVeiculo();
            return vetorCodigoVeiculo[contarCodigoVeiculo];
        }   

        public string ConsultarModelo(int cod)
        {
            VetorVeiculo();

            for (i = 0; i < contadorVeiculo; i++)
            {
                if (vetorCodigoVeiculo[i] == cod)
                {
                    return vetorModelo[i];
                }
            }

            return "Modelo não Encontrado!";
        }

        public string ConsultarCor(int cod)
        {
            VetorVeiculo();

            for (i = 0; i < contadorVeiculo; i++)
            {
                if (vetorCodigoVeiculo[i] == cod)
                {
                    return vetorCor[i];
                }
            }

            return "Cor não Encontrada!";
        }

        public string ConsultarCombustivel(int cod)
        {
            VetorVeiculo();

            for (i = 0; i < contadorVeiculo; i++)
            {
                if (vetorCodigoVeiculo[i] == cod)
                {
                    return vetorCombustivel[i];
                }
            }

            return "Falha ao Procurar Combustivel";
        }

        public string AtualizarVeiculo(int cod, string campo, string novoDadoVeiculo)
        {
            try
            {
                string query = "update veiculo set " + campo + " = '" + novoDadoVeiculo + "' where codigoVeiculo = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoVeiculo);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Veículo Atualizado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar Veículo!";

        }

        public string AtualizarVeiculo(int cod, string campo, long novoDadoVeiculo)
        {
            try
            {
                string query = "update veiculo set " + campo + " = '" + novoDadoVeiculo + "' where codigoVeiculo = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoVeiculo);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Veículo Atualizado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar Veículo!";

        }

        public void ExcluirVeiculo(int cod)
        {
            try
            {
                string query = "delete from veiculo where codigoVeiculo = '" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexaoVeiculo);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Veículo Excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao Excluir Veiculo!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
    } // FIM DA CLASSE \\
} // FIM DO PROJETO \\
