using Microsoft.Data.Sqlite;
using System.Text;

namespace ContagemFalta
{
    public partial class FormMain : Form
    {
        List<DisciplinaInformacao> listaDisc = new List<DisciplinaInformacao>();

        static string caminhoDB = Path.Combine(Application.LocalUserAppDataPath, "faltasDB");

        public FormMain()
        {
            InitializeComponent();
            PegarDadosTabela();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CriarBancoDeDados()
        {
            using (SqliteConnection conn = new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();

                StringBuilder query = new StringBuilder();

                query.Append("CREATE TABLE IF NOT EXISTS Tb_Disciplinas(");
                query.Append("ID INTEGER PRIMARY KEY,");
                query.Append("NOME VARCHAR(255) NOT NULL,");
                query.Append("QUANTIDADE_FALTA_TOTAL VARCHAR(255) NOT NULL,");
                query.Append("QUANTIDADE_FALTA_ATUAL VARCHAR(255) NOT NULL);");

                SqliteCommand cmd = new SqliteCommand(query.ToString(), conn);

                cmd.ExecuteNonQuery();
            }
        }
        public static void InserirDadosBancoDeDados(string nome)
        {
            using (SqliteConnection conn = new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO Tb_Disciplinas(NOME,QUANTIDADE_FALTA_TOTAL,QUANTIDADE_FALTA_ATUAL)");
                query.Append("VALUES (@nome,5,0);");
                SqliteCommand cmd = new SqliteCommand(query.ToString(), conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
            }
        }



        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            CriarBancoDeDados();
        }

        private void DropTable()
        {
            using (SqliteConnection conn = new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();
                StringBuilder query = new StringBuilder();
                query.Append("DROP TABLE IF EXISTS Tb_Disciplinas;");
                SqliteCommand cmd = new SqliteCommand(query.ToString(), conn);
                cmd.ExecuteNonQuery();
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Tem certeza que deseja excluir a tabela?", "Excluir tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes) DropTable();


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            new InserirDados().Show();
            


        }

        public void PegarDadosTabela()
        {
            using (SqliteConnection conn = new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT * FROM Tb_Disciplinas");
                SqliteCommand cmd = new SqliteCommand(query.ToString(), conn);
                try
                {
                    SqliteDataReader dados = cmd.ExecuteReader();
                    List<DisciplinaInformacao> listaDisc2 = new List<DisciplinaInformacao>();
                    while (dados.Read())
                    {
                        int id = Convert.ToInt32(dados["ID"]);
                        string nome = (string)dados["NOME"];
                        int Ftotal = Convert.ToInt32(dados["QUANTIDADE_FALTA_TOTAL"]);
                        int Fatual = Convert.ToInt32(dados["QUANTIDADE_FALTA_ATUAL"]);
                        listaDisc2.Add(new DisciplinaInformacao(id, nome, Ftotal,
                                  Fatual));
                    }
                    listaDisc = listaDisc2;
                    dgvPrincipal.DataSource = listaDisc;
                }
                catch
                {
                    MessageBox.Show("Tabela não existe crie antes");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PegarDadosTabela();
        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                if (MessageBox.Show($"Tem certeza deseja deletar o {GetById(e.RowIndex + 1)}?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                DeleteById(e.RowIndex + 1);
                PegarDadosTabela();

            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show($"Tem certeza deseja colocar uma falta na materia {GetById(e.RowIndex + 1)}?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    AlterarFalta(1, e.RowIndex + 1);
                PegarDadosTabela();

            }
            if (e.ColumnIndex == 2)
            {

                if (MessageBox.Show($"Tem certeza deseja tirar uma falta na materia {GetById(e.RowIndex + 1)}?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    AlterarFalta(-1, e.RowIndex + 1);
                     PegarDadosTabela();
            }

        }

        private void AlterarFalta(int falta, int id)
        {
            using(SqliteConnection conn =  new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();
                
                StringBuilder query = new StringBuilder();
                query.Append("UPDATE Tb_Disciplinas SET QUANTIDADE_FALTA_ATUAL = @faltaContagem WHERE ID=@id;");
                SqliteCommand cmd = new SqliteCommand(query.ToString(), conn);
                cmd.Parameters.AddWithValue("@id", id);
                
                if(PegarNumeroDeFaltasAtual(id) + falta < 0)
                {
                    MessageBox.Show("Não pode tirar falta, ja esta com zero!!!");
                    return;
                }
                 
                cmd.Parameters.AddWithValue("@faltaContagem", PegarNumeroDeFaltasAtual(id) + falta);
                cmd.ExecuteNonQuery();
            }
        }


        private int PegarNumeroDeFaltasAtual(int id)
        {
            using (SqliteConnection conn = new SqliteConnection($"Filename={caminhoDB}"))
            {
                conn.Open();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT QUANTIDADE_FALTA_ATUAL FROM Tb_Disciplinas WHERE ID=@ID");
                SqliteCommand cmd = new SqliteCommand(query.ToString(),conn);
                cmd.Parameters.AddWithValue("@ID", id);
                var a = cmd.ExecuteReader();
                List<int> result = new List<int>();
                while (a.Read())
                {
                    result.Add(Convert.ToInt32(a["QUANTIDADE_FALTA_ATUAL"]));
                }
                return result[0];
            }
        }
        private string GetById(int id)
        {
            using (SqliteConnection coon = new SqliteConnection($"Filename={caminhoDB}"))
            {
                coon.Open();
                StringBuilder query = new StringBuilder();

                query.Append("SELECT NOME FROM Tb_Disciplinas WHERE ID=@id");

                SqliteCommand cmd = new SqliteCommand(query.ToString(), coon);
                cmd.Parameters.AddWithValue("@id", id);
                var a = cmd.ExecuteReader();
                List<string> b = new List<string>();
               while (a.Read())
                {
                    string nome = (string)a["NOME"];
                    b.Add(nome);
                }
                return b[0];
            }
        }

        private void DeleteById(int id)
        {
            using(SqliteConnection coon = new SqliteConnection($"Filename={caminhoDB}"))
            {
                coon.Open();
                StringBuilder query = new StringBuilder();

                query.Append("DELETE FROM Tb_Disciplinas WHERE ID=@id");
                SqliteCommand cmd = new SqliteCommand(query.ToString(), coon);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Linha deletada com sucesso","Sucesso!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
