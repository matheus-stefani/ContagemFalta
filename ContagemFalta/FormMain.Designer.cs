namespace ContagemFalta
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrincipal = new DataGridView();
            btnCriar = new Button();
            btnExcluir = new Button();
            button1 = new Button();
            button2 = new Button();
            ExcluirColumn = new DataGridViewButtonColumn();
            IncrementarColumn = new DataGridViewButtonColumn();
            DecrementarColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPrincipal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { ExcluirColumn, IncrementarColumn, DecrementarColumn });
            dgvPrincipal.Location = new Point(205, 37);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowTemplate.Height = 25;
            dgvPrincipal.Size = new Size(886, 557);
            dgvPrincipal.TabIndex = 0;
            dgvPrincipal.CellClick += dgvPrincipal_CellClick;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(48, 74);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(131, 23);
            btnCriar.TabIndex = 1;
            btnCriar.Text = "Criar Banco";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(48, 500);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(131, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir tabela";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 127);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 3;
            button1.Text = "Inserir disciplina";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 189);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 4;
            button2.Text = "Exibir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ExcluirColumn
            // 
            ExcluirColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ExcluirColumn.HeaderText = "Excluir";
            ExcluirColumn.Name = "ExcluirColumn";
            ExcluirColumn.Text = "E";
            ExcluirColumn.UseColumnTextForButtonValue = true;
            ExcluirColumn.Width = 48;
            // 
            // IncrementarColumn
            // 
            IncrementarColumn.HeaderText = "Incrementar";
            IncrementarColumn.Name = "IncrementarColumn";
            IncrementarColumn.Text = "+";
            IncrementarColumn.UseColumnTextForButtonValue = true;
            IncrementarColumn.Width = 77;
            // 
            // DecrementarColumn
            // 
            DecrementarColumn.HeaderText = "Decrementar";
            DecrementarColumn.Name = "DecrementarColumn";
            DecrementarColumn.Text = "-";
            DecrementarColumn.UseColumnTextForButtonValue = true;
            DecrementarColumn.Width = 81;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 645);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnExcluir);
            Controls.Add(btnCriar);
            Controls.Add(dgvPrincipal);
            Name = "FormMain";
            Text = "Faltas";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnCriar;
        private Button btnExcluir;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn ExcluirColumn;
        private DataGridViewButtonColumn IncrementarColumn;
        private DataGridViewButtonColumn DecrementarColumn;
    }
}
