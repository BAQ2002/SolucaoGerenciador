namespace APPv1
{
    partial class Form3
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
            inputID = new TextBox();
            labelID = new Label();
            BotaoExcluir = new Button();
            SuspendLayout();
            // 
            // inputID
            // 
            inputID.Location = new Point(60, 66);
            inputID.Name = "inputID";
            inputID.Size = new Size(102, 27);
            inputID.TabIndex = 0;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(60, 28);
            labelID.Name = "labelID";
            labelID.Size = new Size(102, 20);
            labelID.TabIndex = 1;
            labelID.Text = "ID do Projeto ";
            // 
            // BotaoExcluir
            // 
            BotaoExcluir.Location = new Point(60, 122);
            BotaoExcluir.Name = "BotaoExcluir";
            BotaoExcluir.Size = new Size(102, 29);
            BotaoExcluir.TabIndex = 2;
            BotaoExcluir.Text = "Excluir";
            BotaoExcluir.UseVisualStyleBackColor = true;
            BotaoExcluir.Click += BotaoExcluir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 202);
            Controls.Add(BotaoExcluir);
            Controls.Add(labelID);
            Controls.Add(inputID);
            Name = "Form3";
            Text = "Excluir Projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputID;
        private Label labelID;
        private Button BotaoExcluir;
    }
}