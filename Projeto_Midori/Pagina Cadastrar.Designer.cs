namespace Projeto_Midori {
    partial class Pagina_Cadastrar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Cadastrar));
            cadastroTextBox = new TextBox();
            cadastroCancelar = new Button();
            cadastroConfirmar = new Button();
            homeButton = new Button();
            cadastrarCat = new RadioButton();
            cadastrarAmb = new RadioButton();
            cadastrarOrdSer = new RadioButton();
            SuspendLayout();
            // 
            // cadastroTextBox
            // 
            cadastroTextBox.Location = new Point(280, 51);
            cadastroTextBox.Name = "cadastroTextBox";
            cadastroTextBox.Size = new Size(407, 23);
            cadastroTextBox.TabIndex = 3;
            cadastroTextBox.Text = "Insira o nome que deseja cadastrar";
            cadastroTextBox.TextChanged += cadastroTextBox_TextChanged;
            // 
            // cadastroCancelar
            // 
            cadastroCancelar.Location = new Point(101, 374);
            cadastroCancelar.Name = "cadastroCancelar";
            cadastroCancelar.Size = new Size(75, 23);
            cadastroCancelar.TabIndex = 4;
            cadastroCancelar.Text = "Cancelar";
            cadastroCancelar.UseVisualStyleBackColor = true;
            // 
            // cadastroConfirmar
            // 
            cadastroConfirmar.Location = new Point(612, 374);
            cadastroConfirmar.Name = "cadastroConfirmar";
            cadastroConfirmar.Size = new Size(75, 23);
            cadastroConfirmar.TabIndex = 5;
            cadastroConfirmar.Text = "Confirmar";
            cadastroConfirmar.UseVisualStyleBackColor = true;
            cadastroConfirmar.Click += cadastroConfirmar_Click;
            // 
            // homeButton
            // 
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(12, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(33, 29);
            homeButton.TabIndex = 8;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // cadastrarCat
            // 
            cadastrarCat.AutoSize = true;
            cadastrarCat.Location = new Point(57, 55);
            cadastrarCat.Name = "cadastrarCat";
            cadastrarCat.Size = new Size(76, 19);
            cadastrarCat.TabIndex = 9;
            cadastrarCat.TabStop = true;
            cadastrarCat.Text = "Categoria";
            cadastrarCat.UseVisualStyleBackColor = true;
            cadastrarCat.CheckedChanged += cadastrarCat_CheckedChanged;
            // 
            // cadastrarAmb
            // 
            cadastrarAmb.AutoSize = true;
            cadastrarAmb.Location = new Point(57, 103);
            cadastrarAmb.Name = "cadastrarAmb";
            cadastrarAmb.Size = new Size(77, 19);
            cadastrarAmb.TabIndex = 10;
            cadastrarAmb.TabStop = true;
            cadastrarAmb.Text = "Ambiente";
            cadastrarAmb.UseVisualStyleBackColor = true;
            // 
            // cadastrarOrdSer
            // 
            cadastrarOrdSer.AutoSize = true;
            cadastrarOrdSer.Location = new Point(57, 147);
            cadastrarOrdSer.Name = "cadastrarOrdSer";
            cadastrarOrdSer.Size = new Size(119, 19);
            cadastrarOrdSer.TabIndex = 11;
            cadastrarOrdSer.TabStop = true;
            cadastrarOrdSer.Text = "Ordem de Servico";
            cadastrarOrdSer.UseVisualStyleBackColor = true;
            // 
            // Pagina_Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrarOrdSer);
            Controls.Add(cadastrarAmb);
            Controls.Add(cadastrarCat);
            Controls.Add(homeButton);
            Controls.Add(cadastroConfirmar);
            Controls.Add(cadastroCancelar);
            Controls.Add(cadastroTextBox);
            Name = "Pagina_Cadastrar";
            Text = "Pagina_Cadastrar";
            Load += Pagina_Cadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox cadastroTextBox;
        private Button cadastroCancelar;
        private Button cadastroConfirmar;
        private Button homeButton;
        
        private RadioButton cadastrarAmb;
        private RadioButton cadastrarOrdSer;
        private RadioButton cadastrarCat;
    }
}