namespace ContagemFalta
{
    partial class InserirDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPegarInserirNome = new TextBox();
            btnInserirNome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 24);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome da disciplina";
            // 
            // txtPegarInserirNome
            // 
            txtPegarInserirNome.Location = new Point(62, 54);
            txtPegarInserirNome.Name = "txtPegarInserirNome";
            txtPegarInserirNome.Size = new Size(151, 23);
            txtPegarInserirNome.TabIndex = 1;
            // 
            // btnInserirNome
            // 
            btnInserirNome.Location = new Point(81, 100);
            btnInserirNome.Name = "btnInserirNome";
            btnInserirNome.Size = new Size(111, 23);
            btnInserirNome.TabIndex = 2;
            btnInserirNome.Text = "Salvar e Sair";
            btnInserirNome.UseVisualStyleBackColor = true;
            btnInserirNome.Click += button1_Click;
            // 
            // InserirDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 135);
            Controls.Add(btnInserirNome);
            Controls.Add(txtPegarInserirNome);
            Controls.Add(label1);
            Name = "InserirDados";
            Text = "InserirDados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPegarInserirNome;
        private Button btnInserirNome;
    }
}