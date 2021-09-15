using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_lista_de_convidados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "lista de convidados";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparcampos();

        }
        private void limparcampos()
        {
            tbID.Clear();
            tbnome.Clear();
            tbcpf.Clear();
            tbemail.Clear();
            tbtelefone.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void atualizarDataGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM convidados WHERE ativo = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dglistadeconvidados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dglistadeconvidados.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    dglistadeconvidados.Rows.Add(row);
                }

                realizaconexaoBD.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não consigo abrir a conexão!");
                Console.WriteLine(ex.Message);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO convidados (nome, cpf, email, telefone)" +
                    " Values" +
                    " ('" + tbnome.Text + "', '" + tbcpf.Text + "', '" + tbemail.Text + "', '" + tbtelefone.Text + "') ";



                comandoMySql.ExecuteNonQuery();

                realizaconexaoBD.Close();
                MessageBox.Show("Convidado cadastrado");
                atualizarDataGrid();
                limparcampos();

            }
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE convidados SET nome = '" + tbnome.Text + "'," +
                    "cpf = '" + tbcpf.Text + "'," +
                    " email = '" + tbemail.Text + "'," +
                    "telefone = '" + tbtelefone.Text + "'" +
                    "WHERE id = " + tbID.Text + "";
               comandoMySql.ExecuteNonQuery();

                realizaconexaoBD.Close();
                MessageBox.Show("Convidado atualizado");
                atualizarDataGrid();
                limparcampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();

                //comandoMySql.CommandText = "DELETE FROM convidados WHERE id = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE convidados SET ativo = 0 WHERE id = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaconexaoBD.Close();
                MessageBox.Show("Convidado deletado");
                atualizarDataGrid();
                limparcampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void dglistadeconvidados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dglistadeconvidados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dglistadeconvidados.CurrentRow.Selected = true;

                tbnome.Text = dglistadeconvidados.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbcpf.Text = dglistadeconvidados.Rows[e.RowIndex].Cells["colCPF"].FormattedValue.ToString();
                tbemail.Text = dglistadeconvidados.Rows[e.RowIndex].Cells["colEmail"].FormattedValue.ToString();
                tbtelefone.Text = dglistadeconvidados.Rows[e.RowIndex].Cells["colTelefone"].FormattedValue.ToString();
                tbID.Text = dglistadeconvidados.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
            }
        }
    }
}
