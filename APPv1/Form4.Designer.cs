namespace APPv1
{
    partial class Form4
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
            inputGerente = new TextBox();
            labelGerente = new Label();
            labelDataFinal = new Label();
            labelStatus = new Label();
            inputStatus = new TextBox();
            BotaoAtualizar = new Button();
            inputDataFinal = new DateTimePicker();
            inputID = new TextBox();
            labelID = new Label();
            SuspendLayout();
            // 
            // inputGerente
            // 
            inputGerente.Location = new Point(28, 150);
            inputGerente.Name = "inputGerente";
            inputGerente.Size = new Size(156, 27);
            inputGerente.TabIndex = 0;
            // 
            // labelGerente
            // 
            labelGerente.AutoSize = true;
            labelGerente.Location = new Point(28, 127);
            labelGerente.Name = "labelGerente";
            labelGerente.Size = new Size(61, 20);
            labelGerente.TabIndex = 1;
            labelGerente.Text = "Gerente";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(28, 259);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(76, 20);
            labelDataFinal.TabIndex = 3;
            labelDataFinal.Text = "Data Final";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(28, 194);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status";
            // 
            // inputStatus
            // 
            inputStatus.Location = new Point(28, 217);
            inputStatus.Name = "inputStatus";
            inputStatus.Size = new Size(156, 27);
            inputStatus.TabIndex = 5;
            // 
            // BotaoAtualizar
            // 
            BotaoAtualizar.Location = new Point(121, 329);
            BotaoAtualizar.Name = "BotaoAtualizar";
            BotaoAtualizar.Size = new Size(94, 29);
            BotaoAtualizar.TabIndex = 6;
            BotaoAtualizar.Text = "Confirmar";
            BotaoAtualizar.UseVisualStyleBackColor = true;
            BotaoAtualizar.Click += BotaoAtualizar_Click;
            // 
            // inputDataFinal
            // 
            inputDataFinal.Location = new Point(28, 282);
            inputDataFinal.Name = "inputDataFinal";
            inputDataFinal.Size = new Size(289, 27);
            inputDataFinal.TabIndex = 7;
            // 
            // inputID
            // 
            inputID.Location = new Point(121, 58);
            inputID.Name = "inputID";
            inputID.Size = new Size(98, 27);
            inputID.TabIndex = 8;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(121, 35);
            labelID.Name = "labelID";
            labelID.Size = new Size(98, 20);
            labelID.TabIndex = 9;
            labelID.Text = "ID do Projeto";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 379);
            Controls.Add(labelID);
            Controls.Add(inputID);
            Controls.Add(inputDataFinal);
            Controls.Add(BotaoAtualizar);
            Controls.Add(inputStatus);
            Controls.Add(labelStatus);
            Controls.Add(labelDataFinal);
            Controls.Add(labelGerente);
            Controls.Add(inputGerente);
            Name = "Form4";
            Text = "Editar Projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputGerente;
        private Label labelGerente;
        private Label labelDataFinal;
        private Label labelStatus;
        private TextBox inputStatus;
        private Button BotaoAtualizar;
        private DateTimePicker inputDataFinal;
        private TextBox inputID;
        private Label labelID;
    }
}