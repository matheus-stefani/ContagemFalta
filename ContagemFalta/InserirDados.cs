using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemFalta
{
    public partial class InserirDados : Form
    {
        public InserirDados()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPegarInserirNome.Text.Length < 3)
            {
                MessageBox.Show("Insira um nome maior que dois caracteres","Nome erro!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            FormMain.InserirDadosBancoDeDados(txtPegarInserirNome.Text);
            MessageBox.Show("Inserido com sucesso, Clique em Exibir para mostrar a nova disciplina!!!","Clique em Exibir",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            
            Close();
        }
    }
}
