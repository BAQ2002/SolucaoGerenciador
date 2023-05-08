namespace APPv1
{
    partial class Form2
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
            labelNome = new Label();
            labelGerente = new Label();
            labelDataDeInicio = new Label();
            labelDataFinal = new Label();
            labelResumo = new Label();
            labelStatus = new Label();
            inputNome = new TextBox();
            inputGerente = new TextBox();
            inputResumo = new TextBox();
            inputStatus = new TextBox();
            inputDataDeInicio = new DateTimePicker();
            inputDataFinal = new DateTimePicker();
            BotaoConfirmar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(30, 20);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelGerente
            // 
            labelGerente.AutoSize = true;
            labelGerente.Location = new Point(30, 73);
            labelGerente.Name = "labelGerente";
            labelGerente.Size = new Size(61, 20);
            labelGerente.TabIndex = 1;
            labelGerente.Text = "Gerente";
            // 
            // labelDataDeInicio
            // 
            labelDataDeInicio.AutoSize = true;
            labelDataDeInicio.Location = new Point(31, 219);
            labelDataDeInicio.Name = "labelDataDeInicio";
            labelDataDeInicio.Size = new Size(104, 20);
            labelDataDeInicio.TabIndex = 2;
            labelDataDeInicio.Text = "Data De Inicio";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(29, 272);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(76, 20);
            labelDataFinal.TabIndex = 3;
            labelDataFinal.Text = "Data Final";
            // 
            // labelResumo
            // 
            labelResumo.AutoSize = true;
            labelResumo.Location = new Point(29, 342);
            labelResumo.Name = "labelResumo";
            labelResumo.Size = new Size(62, 20);
            labelResumo.TabIndex = 4;
            labelResumo.Text = "Resumo";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(31, 148);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status";
            // 
            // inputNome
            // 
            inputNome.Location = new Point(30, 43);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(156, 27);
            inputNome.TabIndex = 6;
            // 
            // inputGerente
            // 
            inputGerente.Location = new Point(30, 96);
            inputGerente.Name = "inputGerente";
            inputGerente.Size = new Size(156, 27);
            inputGerente.TabIndex = 7;
            // 
            // inputResumo
            // 
            inputResumo.Location = new Point(29, 365);
            inputResumo.Multiline = true;
            inputResumo.Name = "inputResumo";
            inputResumo.Size = new Size(290, 34);
            inputResumo.TabIndex = 10;
            // 
            // inputStatus
            // 
            inputStatus.Location = new Point(31, 171);
            inputStatus.Name = "inputStatus";
            inputStatus.Size = new Size(155, 27);
            inputStatus.TabIndex = 11;
            // 
            // inputDataDeInicio
            // 
            inputDataDeInicio.Location = new Point(28, 242);
            inputDataDeInicio.Name = "inputDataDeInicio";
            inputDataDeInicio.Size = new Size(291, 27);
            inputDataDeInicio.TabIndex = 12;
            inputDataDeInicio.ValueChanged += inputDataDeInicio_ValueChanged;
            // 
            // inputDataFinal
            // 
            inputDataFinal.Location = new Point(29, 295);
            inputDataFinal.Name = "inputDataFinal";
            inputDataFinal.Size = new Size(291, 27);
            inputDataFinal.TabIndex = 13;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.Location = new Point(241, 433);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(94, 29);
            BotaoConfirmar.TabIndex = 14;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = true;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 484);
            Controls.Add(BotaoConfirmar);
            Controls.Add(inputDataFinal);
            Controls.Add(inputDataDeInicio);
            Controls.Add(inputStatus);
            Controls.Add(inputResumo);
            Controls.Add(inputGerente);
            Controls.Add(inputNome);
            Controls.Add(labelStatus);
            Controls.Add(labelResumo);
            Controls.Add(labelDataFinal);
            Controls.Add(labelDataDeInicio);
            Controls.Add(labelGerente);
            Controls.Add(labelNome);
            Name = "Form2";
            Text = "Adicionar Projeto";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelGerente;
        private Label labelDataDeInicio;
        private Label labelDataFinal;
        private Label labelResumo;
        private Label labelStatus;
        private TextBox inputNome;
        private TextBox inputGerente;
        private TextBox inputResumo;
        private TextBox inputStatus;
        private DateTimePicker inputDataDeInicio;
        private DateTimePicker inputDataFinal;
        private Button BotaoConfirmar;
    }
}