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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            Projeto P = new Projeto();
            P.Id = int.Parse(inputID.Text);

            ProjetosRepository.Excluir(P);

        }
    }
}
