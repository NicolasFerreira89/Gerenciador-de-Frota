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
    class DAOGasto
    {
        public MySqlConnection conexaoGasto;

        public string dadosGasto;
        public string comando;
        public string resultado;
        // V V VETORES  V V \\
        public int[] vetorCodigoGasto;
        public double[] vetorAbastecimento;
        public double[] vetorManutencao;
        public int[] vetorcodVeiculo;
        public DateTime[] vetorDia;
        public double[] vetorMulta;
        public int i;
        public int contadorGasto;
        public int contarCodigoGasto;
        public string msg;
        public DAOGasto()
        {
            conexaoGasto = new MySqlConnection("server=localhost;DataBase=frotaEmpresa;Uid=root;password=");

            try
            {
                conexaoGasto.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
                conexaoGasto.Close();
            }

        }

        public void CadastrarGasto(int codVeiculo, string abastecimento, string manutencao, string dtDia, string multa)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                /*parameter.Value = dtDia.Year + "-" + dtDia.Month + "-" + dtDia.Day; */
                dadosGasto = "('','" + codVeiculo + "','" + abastecimento + "','" + manutencao + "','" + dtDia + "','" + multa + "')";
                comando = "Insert into gasto (codigoGasto, codVeiculo, abastecimento, manutencao, dia, multa) values" + dadosGasto;
                MySqlCommand sql = new MySqlCommand(comando, conexaoGasto);
                resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Valor Inserido!");
                }
                else
                {
                    MessageBox.Show("Falha ao Inserir Valor!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu Errado!" + erro);
            }
        }

        public void VetorGasto()
        {
            string query = "select * from gasto ";

            vetorCodigoGasto = new int[100];
            vetorcodVeiculo = new int[100];
            vetorAbastecimento = new double[100];
            vetorManutencao = new double[100];
            vetorDia = new DateTime[100];
            vetorMulta = new double[100];


            for (i = 0; i < 100; i++)
            {
                vetorCodigoGasto[i] = 0;
                vetorcodVeiculo[i] = 0;
                vetorAbastecimento[i] = 0;
                vetorManutencao[i] = 0;
                vetorDia[i] = new DateTime();
                vetorMulta[i] = 0;
            }

            MySqlCommand coletarGasto = new MySqlCommand(query, conexaoGasto);
            MySqlDataReader leituraGasto = coletarGasto.ExecuteReader();

            i = 0;
            contadorGasto = 0;
            while (leituraGasto.Read())
            {
                vetorCodigoGasto[i] = Convert.ToInt32(leituraGasto["codigoGasto"]);
                vetorcodVeiculo[i] = Convert.ToInt32(leituraGasto["codVeiculo"]);
                vetorAbastecimento[i] = Convert.ToDouble(leituraGasto["abastecimento"]);
                vetorManutencao[i] = Convert.ToDouble(leituraGasto["manutencao"]);
                vetorDia[i] = Convert.ToDateTime(leituraGasto["dia"]);
                vetorMulta[i] = Convert.ToDouble(leituraGasto["multa"]);


                contarCodigoGasto = contadorGasto;
                i++;
                contadorGasto++;
            }

            leituraGasto.Close();
        } // FIM DO VETOR VEICULO \\

        public string ConsultarTudoGasto()
        {
            VetorGasto();
            msg += "";
            for (i = 0; i < contadorGasto; i++)
            {
                msg = "Código de Gasto: " + vetorCodigoGasto[i] +
                      "Código do Veículo" + vetorcodVeiculo[i] +
                      "Valor de Abastecimento: " + vetorAbastecimento[i] +
                      "Valor de Manutenção: " + vetorManutencao[i] +
                      "Data de Requerimento" + vetorDia[i] +
                      "Valor de Multas: " + vetorMulta[i] +
                      "\n\n";
            }

            return msg;
        }

        public double ConsultarGastoAbastecimento(int cod)
        {
            VetorGasto();

            for (i = 0; i < contadorGasto; i++)
            {
                if (vetorCodigoGasto[i] == cod)
                {
                    return vetorAbastecimento[i];
                }
            }

            return -1;
        }

        public double ConsultarGastoManutencao(int cod)
        {
            VetorGasto();

            for (i = 0; i < contadorGasto; i++)
            {
                if (vetorCodigoGasto[i] == cod)
                {
                    return vetorManutencao[i];
                }
            }

            return -1;
        }

        public double ConsultarGastoMulta(int cod)
        {
            VetorGasto();

            for (i = 0; i < contadorGasto; i++)
            {
                if (vetorCodigoGasto[i] == cod)
                {
                    return vetorMulta[i];
                }
            }

            return -1;
        }

        public string ConsultarTotal(int cod)
        {

            try
            {
                string query = "select * from gasto where codVeiculo like " + cod;

                MySqlCommand sql = new MySqlCommand(query, conexaoGasto);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Dados Encontrados!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Erro ao Atualizar Valores!";

        }

        public string AtualizarGasto(int cod, string campo, string novoDadoGasto)
        {
            try
            {
                string query = "update gasto set " + campo + " = '" + novoDadoGasto + "' where codigoGasto = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoGasto);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Valores Atualizados!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar Valores!";

        }

        public string AtualizarGasto(int cod, string campo, long novoDadoGasto)
        {
            try
            {
                string query = "update gasto set " + campo + " = '" + novoDadoGasto + "' where codigoGasto = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexaoGasto);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    return "Valores Atualizados!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }

            return "Erro ao Atualizar Valores!";

        }

        public void ExcluirGasto(int cod)
        {
            try
            {
                string query = "delete from gasto where codigoGasto = '" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexaoGasto);
                string resultado = "" + sql.ExecuteNonQuery();

                if (resultado == "1")
                {
                    MessageBox.Show("Valor Excluído!");
                }
                else
                {
                    MessageBox.Show("Falha ao Excluir Valores!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
    } // FIM DA CLASSE \\
} // FIM DO PROJETO \\
