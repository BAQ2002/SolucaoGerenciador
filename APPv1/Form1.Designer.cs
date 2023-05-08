namespace APPv1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            BotaoAddProjeto = new Button();
            BotaoExcluirProjeto = new Button();
            button1 = new Button();
            BotaoUpdateLista = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(732, 268);
            dataGridView1.TabIndex = 0;
            // 
            // BotaoAddProjeto
            // 
            BotaoAddProjeto.Location = new Point(37, 31);
            BotaoAddProjeto.Name = "BotaoAddProjeto";
            BotaoAddProjeto.Size = new Size(131, 49);
            BotaoAddProjeto.TabIndex = 1;
            BotaoAddProjeto.Text = "Adicionar";
            BotaoAddProjeto.UseVisualStyleBackColor = true;
            BotaoAddProjeto.Click += BotaoAddProjeto_Click;
            // 
            // BotaoExcluirProjeto
            // 
            BotaoExcluirProjeto.Location = new Point(346, 31);
            BotaoExcluirProjeto.Name = "BotaoExcluirProjeto";
            BotaoExcluirProjeto.Size = new Size(131, 49);
            BotaoExcluirProjeto.TabIndex = 2;
            BotaoExcluirProjeto.Text = "Excluir";
            BotaoExcluirProjeto.UseVisualStyleBackColor = true;
            BotaoExcluirProjeto.Click += BotaoExcluirProjeto_Click;
            // 
            // button1
            // 
            button1.Location = new Point(640, 31);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 3;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BotaoUpdateLista
            // 
            BotaoUpdateLista.Location = new Point(359, 409);
            BotaoUpdateLista.Name = "BotaoUpdateLista";
            BotaoUpdateLista.Size = new Size(118, 29);
            BotaoUpdateLista.TabIndex = 4;
            BotaoUpdateLista.Text = "Atualizar Lista";
            BotaoUpdateLista.UseVisualStyleBackColor = true;
            BotaoUpdateLista.Click += BotaoUpdateLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(BotaoUpdateLista);
            Controls.Add(button1);
            Controls.Add(BotaoExcluirProjeto);
            Controls.Add(BotaoAddProjeto);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Gerenciador De Projetos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BotaoAddProjeto;
        private Button BotaoExcluirProjeto;
        private Button button1;
        private Button BotaoUpdateLista;
    }
}