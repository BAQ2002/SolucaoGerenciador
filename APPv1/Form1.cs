using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using MODEL;
using BLL;
using System.Windows.Forms;


namespace APPv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Enter += Form1_Enter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anton\source\repos\SolucaoGerenciador\DAL\database\Database.mdf;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Projetos";
            SqlCommand command = new SqlCommand(query, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        //private void Form1_Enter(object sender, EventArgs e)
        //{

        //  string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anton\source\repos\SolucaoGerenciador\DAL\database\Database.mdf;Integrated Security=True;";
        // SqlConnection connection = new SqlConnection(connectionString);
        //
        //  string query = "SELECT * FROM Projetos";
        //   SqlCommand command = new SqlCommand(query, connection);

        //
        //   SqlDataAdapter adapter = new SqlDataAdapter(command);
        //  DataTable dataTable = new DataTable();
        //   adapter.Fill(dataTable);
        //
        //   dataGridView1.DataSource = dataTable;
        //
        //    dataGridView1.Refresh();
        //}


        private void BotaoAddProjeto_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //this.Close();
        }

        private void BotaoExcluirProjeto_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void BotaoUpdateLista_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anton\source\repos\SolucaoGerenciador\DAL\database\Database.mdf;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Projetos";
            SqlCommand command = new SqlCommand(query, connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            dataGridView1.Refresh();

        }
    }
}