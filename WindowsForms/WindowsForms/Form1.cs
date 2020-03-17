using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Desabilita os campos
            desabilitacampos(false);
            //Ao iniciar a aplicação o programa deve verificar se o arquivo acme.sqlite existe. 
            //Caso exista, deve abrir conexão de banco de dados.
            try
            {
                if (System.IO.File.Exists(@"C:\sqlite\acme.sqlite"))
                {
                    ChamaBanco();
                }
                else
                {
                    // Caso não exista, deve criar o arquivo e a tabela TB_VOO conforme definida acima.
                    SQLiteConnection.CreateFile(@"C:\sqlite\acme.sqlite");
                    SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\sqlite\acme.sqlite;Version=3;");
                    m_dbConnection.Open();

                    StringBuilder varname1 = new StringBuilder();
                    varname1.Append("CREATE TABLE [TB_VOO] ( \n");
                    varname1.Append("[ID_VOO] INTEGER  PRIMARY KEY NOT NULL, \n");
                    varname1.Append("[DATA_VOO] DATE DEFAULT CURRENT_DATE NULL, \n");
                    varname1.Append("[CUSTO] NUMERIC  NULL, \n");
                    varname1.Append("[DISTANCIA] INTEGER  NULL, \n");
                    varname1.Append("[CAPTURA] VARCHAR(1)  NULL, \n");
                    varname1.Append("[NIVEL_DOR] INTEGER  NULL \n");
                    varname1.Append(")");


                    SQLiteCommand command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                    command.ExecuteNonQuery();

                    varname1 = new StringBuilder();
                    varname1.Append("insert into TB_VOO (ID_VOO, DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) values (1, '2020-03-15 23:59:02', '100', 50, 'S',1)");

                    command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                    command.ExecuteNonQuery();

                    if (m_dbConnection.State != ConnectionState.Closed)
                    {
                        m_dbConnection.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// habilita e desabilita os botoes cancela e inclir
        /// </summary>
        /// <param name="hab"></param>
        protected void desabilitacampos(bool hab)
        {
            btnCancelar.Enabled = hab;
            btnSalvar.Enabled = hab;
        }
        public class VOO
        {
            public int ID_VOO;
            public DateTime DATA_VOO;
            public string CUSTO;
            public int DISTANCIA;
            public string CAPTURA;
            public int NIVEL_DOR;
        }

        public void ChamaBanco()
        {
            try
            {

                DataTable dt = new DataTable();

                String insSQL = "select * from TB_VOO";
                String strConn = @"Data Source=C:\sqlite\acme.sqlite";

                SQLiteConnection conn = new SQLiteConnection(strConn);

                SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, strConn);
                da.Fill(dt);
                grid_TB_VOO.DataSource = dt;
                grid_TB_VOO.Columns["ID_VOO"].Visible = false;
                grid_TB_VOO.Columns["CUSTO"].Visible = false;
                grid_TB_VOO.Columns["DISTANCIA"].Visible = false;




                //List<VOO> vOOs = new List<VOO>();

                //foreach (DataRow item in dt.AsEnumerable())
                //{
                //    VOO vOO = new VOO();
                //    vOO.ID_VOO = Convert.ToInt32(item["ID_VOO"]);
                //    vOO.DATA_VOO = Convert.ToDateTime(item["DATA_VOO"]);
                //    vOO.CUSTO = item["CUSTO"].ToString();
                //    vOO.DISTANCIA = Convert.ToInt32(item["DISTANCIA"]);
                //    vOO.NIVEL_DOR = Convert.ToInt32(item["NIVEL_DOR"]);
                //    vOO.CAPTURA = item["CAPTURA"].ToString();
                //    vOOs.Add(vOO);
                //}

                //grid_TB_VOO.DataSource = vOOs.ToArray();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtCusto.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        string valor;
        private void txtCusto_Leave(object sender, EventArgs e)
        {
            if (txtCusto.Text.Length > 0)
            {
                valor = txtCusto.Text.Replace("R$", "");
                txtCusto.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            }
        }

        private void txtCusto_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtCusto.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtCusto.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtCusto.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtCusto.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtCusto.Text.StartsWith("0,"))
                {
                    txtCusto.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtCusto.Text.Contains("00,"))
                {
                    txtCusto.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtCusto.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtCusto.Text;
            txtCusto.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtCusto.Select(txtCusto.Text.Length, 0);
        }

        private void grid_TB_VOO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dataGridViewRow = grid_TB_VOO.Rows[index];
                if (dataGridViewRow.Cells[0].Value != DBNull.Value)
                {
                    dataGridViewRow.Cells[0].Value.ToString(); //ID
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridViewRow.Cells[1].Value);
                    txtCusto.Text = dataGridViewRow.Cells[2].Value.ToString();
                    ddlDistancia.Value = Convert.ToDecimal(dataGridViewRow.Cells[3].Value);
                    if (dataGridViewRow.Cells[4].Value.ToString() == "S")
                    {
                        radBCapturaS.Checked = true;
                    }
                    else
                    {
                        radBCapturaN.Checked = true;
                    }
                    ddlNivelDor.Value = Convert.ToDecimal(dataGridViewRow.Cells[5].Value);
                }
                desabilitacampos(false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\sqlite\acme.sqlite;Version=3;");
                m_dbConnection.Open();

                StringBuilder varname1 = new StringBuilder();
                varname1.Append("INSERT INTO TB_VOO (DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) \n");
                varname1.Append("VALUES ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + txtCusto.Text.Trim().Replace("R$", "").Replace(",", "") + "', " + ddlDistancia.Value + ", '" + (radBCapturaS.Checked == true ? "S" : "N") + "'," + ddlNivelDor.Value + ")");

                SQLiteCommand command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                command.ExecuteNonQuery();


                varname1 = new StringBuilder();
                varname1.Append("SELECT * FROM TB_VOO");
                command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                command.ExecuteNonQuery();

                SQLiteDataAdapter da = new SQLiteDataAdapter(varname1.ToString(), m_dbConnection);
                da.Fill(dt);
                grid_TB_VOO.DataSource = dt;
                grid_TB_VOO.Columns["ID_VOO"].Visible = false;
                grid_TB_VOO.Columns["CUSTO"].Visible = false;
                grid_TB_VOO.Columns["DISTANCIA"].Visible = false;

                if (m_dbConnection.State != ConnectionState.Closed)
                {
                    m_dbConnection.Close();
                }

                //Se o usuário clicar em “INCLUIR”, limpar os campos Data, Custo, Distância, os radio buttons de captura (Não/Sim) e Nível dor, e manter habilitados para edição. 
                dateTimePicker1.Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
                txtCusto.Text = "";
                ddlDistancia.Value = 0;
                radBCapturaS.Checked = false;
                radBCapturaN.Checked = false;
                ddlNivelDor.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                //Se o usuário selecionar um item e clicar em “Excluir”, executar comando DELETE para excluir apenas o item selecionado utilizando ID_VOO como chave.
                if (grid_TB_VOO.SelectedRows.Count > 0)
                {

                    DataGridViewSelectedRowCollection dataGridViewRow = grid_TB_VOO.SelectedRows;
                    int id_voo = Convert.ToInt32(dataGridViewRow[0].Cells["ID_VOO"].Value);

                    SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\sqlite\acme.sqlite;Version=3;");
                    m_dbConnection.Open();

                    StringBuilder varname1 = new StringBuilder();
                    varname1.Append("DELETE FROM TB_VOO WHERE ID_VOO = " + id_voo + "");


                    SQLiteCommand command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                    command.ExecuteNonQuery();

                    grid_TB_VOO.Rows.RemoveAt(dataGridViewRow[0].Index);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\sqlite\acme.sqlite;Version=3;");
            m_dbConnection.Open();

            StringBuilder varname1 = new StringBuilder();
            varname1.Append("INSERT INTO TB_VOO (DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) \n");
            varname1.Append("VALUES ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + Convert.ToInt32(txtCusto.Text.Trim().Replace("R$", "").Replace(",", "")) + "', " + ddlDistancia.Value + ", '" + (radBCapturaS.Checked == true ? "S" : "N") + "'," + ddlNivelDor.Value + ")");

            SQLiteCommand command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
            command.ExecuteNonQuery();


            varname1 = new StringBuilder();
            varname1.Append("SELECT * FROM TB_VOO");
            command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
            command.ExecuteNonQuery();

            SQLiteDataAdapter da = new SQLiteDataAdapter(varname1.ToString(), m_dbConnection);
            da.Fill(dt);
            grid_TB_VOO.DataSource = dt;
            grid_TB_VOO.Columns["ID_VOO"].Visible = false;
            grid_TB_VOO.Columns["CUSTO"].Visible = false;
            grid_TB_VOO.Columns["DISTANCIA"].Visible = false;

            if (m_dbConnection.State != ConnectionState.Closed)
            {
                m_dbConnection.Close();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Se o usuário selecionar um dos campos de um voo existente e alterar o valor, deve-se habilitar os botões SALVAR e CANCELAR. 
            desabilitacampos(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void ddlDistancia_ValueChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void radBCapturaS_CheckedChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void radBCapturaN_CheckedChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void ddlNivelDor_ValueChanged(object sender, EventArgs e)
        {
            desabilitacampos(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (grid_TB_VOO.SelectedRows.Count > 0)
                {


                    DataGridViewSelectedRowCollection dataGridViewRow = grid_TB_VOO.SelectedRows;
                    int id_voo = Convert.ToInt32(dataGridViewRow[0].Cells["ID_VOO"].Value);
                    int index = dataGridViewRow[0].Index;
                    SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\sqlite\acme.sqlite;Version=3;");
                    m_dbConnection.Open();


                    StringBuilder varname1 = new StringBuilder();
                    varname1.Append("UPDATE TB_VOO SET \n");
                    varname1.Append("DATA_VOO =  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', \n");
                    varname1.Append("CUSTO = " + Convert.ToInt32(txtCusto.Text.Trim().Replace("R$", "").Replace(", ", "")) + ", \n");
                    varname1.Append("DISTANCIA = " + ddlDistancia.Value + ", \n");
                    varname1.Append("CAPTURA = '" + (radBCapturaS.Checked == true ? "S" : "N") + "', \n");
                    varname1.Append("NIVEL_DOR  = " + ddlNivelDor.Value + " \n");
                    varname1.Append("WHERE ID_VOO = " + id_voo + "");

                    SQLiteCommand command = new SQLiteCommand(varname1.ToString(), m_dbConnection);
                    command.ExecuteNonQuery();

                    grid_TB_VOO.Rows[index].Cells["DATA_VOO"].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    grid_TB_VOO.Rows[index].Cells["CUSTO"].Value = Convert.ToInt32(txtCusto.Text.Trim().Replace("R$", "").Replace(", ", ""));
                    grid_TB_VOO.Rows[index].Cells["DISTANCIA"].Value = ddlDistancia.Value;
                    grid_TB_VOO.Rows[index].Cells["CAPTURA"].Value = (radBCapturaS.Checked == true ? "S" : "N");
                    grid_TB_VOO.Rows[index].Cells["NIVEL_DOR"].Value = ddlNivelDor.Value;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
