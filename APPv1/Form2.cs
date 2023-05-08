using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using BLL;

namespace APPv1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            Projeto P = new Projeto();
            P.Id = ProjetosRepository.GetAll().Count + 1;
            P.Nome = inputNome.Text;
            P.Gerente = inputGerente.Text;
            P.DataDeInicio = inputDataDeInicio.Value;
            P.DataFinal = inputDataFinal.Value;
            P.Resumo = inputResumo.Text;
            P.Status = inputStatus.Text;

            ProjetosRepository.Add(P);

            //Form1 form1 = new Form1();

            //form1.Show();
            this.Close();



        }

        private void inputDataDeInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
