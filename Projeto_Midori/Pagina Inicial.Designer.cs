namespace Projeto_Midori {
    partial class FrontPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            CadastrarButton = new Button();
            InserirButton = new Button();
            VisualizarButton = new Button();
            ExcluirButton = new Button();
            SuspendLayout();
            // 
            // CadastrarButton
            // 
            CadastrarButton.Location = new Point(48, 65);
            CadastrarButton.Name = "CadastrarButton";
            CadastrarButton.Size = new Size(120, 39);
            CadastrarButton.TabIndex = 0;
            CadastrarButton.Text = "Cadastrar";
            CadastrarButton.UseVisualStyleBackColor = true;
            CadastrarButton.Click += button1_Click;
            // 
            // InserirButton
            // 
            InserirButton.Location = new Point(48, 134);
            InserirButton.Name = "InserirButton";
            InserirButton.Size = new Size(120, 39);
            InserirButton.TabIndex = 1;
            InserirButton.Text = "Inserir";
            InserirButton.UseVisualStyleBackColor = true;
            InserirButton.Click += InserirButton_Click;
            // 
            // VisualizarButton
            // 
            VisualizarButton.Location = new Point(48, 203);
            VisualizarButton.Name = "VisualizarButton";
            VisualizarButton.Size = new Size(120, 39);
            VisualizarButton.TabIndex = 2;
            VisualizarButton.Text = "Visualizar";
            VisualizarButton.UseVisualStyleBackColor = true;
            VisualizarButton.Click += VisualizarButton_Click;
            // 
            // ExcluirButton
            // 
            ExcluirButton.Location = new Point(48, 272);
            ExcluirButton.Name = "ExcluirButton";
            ExcluirButton.Size = new Size(120, 39);
            ExcluirButton.TabIndex = 3;
            ExcluirButton.Text = "Excluir";
            ExcluirButton.UseVisualStyleBackColor = true;
            ExcluirButton.Click += ExcluirButton_Click;
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExcluirButton);
            Controls.Add(VisualizarButton);
            Controls.Add(InserirButton);
            Controls.Add(CadastrarButton);
            Name = "FrontPage";
            Text = "Pagina Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button CadastrarButton;
        private Button InserirButton;
        private Button VisualizarButton;
        private Button ExcluirButton;
    }
}