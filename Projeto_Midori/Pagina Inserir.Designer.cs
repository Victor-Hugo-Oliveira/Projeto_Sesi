namespace Projeto_Midori {
    partial class Pagina_Inserir {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Inserir));
            inserirItemDD = new ComboBox();
            inserirAmbDD = new ComboBox();
            inserirOrdServDD = new ComboBox();
            inserirCatDD = new ComboBox();
            inserirQuantTXT = new TextBox();
            inserirOBSTXT = new RichTextBox();
            inserirCancelar = new Button();
            inserirConfirmar = new Button();
            inserirUN = new TextBox();
            homeButton = new Button();
            SuspendLayout();
            // 
            // inserirItemDD
            // 
            inserirItemDD.FormattingEnabled = true;
            inserirItemDD.Location = new Point(53, 54);
            inserirItemDD.Name = "inserirItemDD";
            inserirItemDD.Size = new Size(678, 23);
            inserirItemDD.TabIndex = 0;
            inserirItemDD.Text = "Selecionar item";
            // 
            // inserirAmbDD
            // 
            inserirAmbDD.FormattingEnabled = true;
            inserirAmbDD.Location = new Point(610, 114);
            inserirAmbDD.Name = "inserirAmbDD";
            inserirAmbDD.Size = new Size(121, 23);
            inserirAmbDD.TabIndex = 1;
            inserirAmbDD.Text = "Ambiente";
            // 
            // inserirOrdServDD
            // 
            inserirOrdServDD.FormattingEnabled = true;
            inserirOrdServDD.Location = new Point(447, 114);
            inserirOrdServDD.Name = "inserirOrdServDD";
            inserirOrdServDD.Size = new Size(121, 23);
            inserirOrdServDD.TabIndex = 2;
            inserirOrdServDD.Text = "Servico";
            // 
            // inserirCatDD
            // 
            inserirCatDD.FormattingEnabled = true;
            inserirCatDD.Location = new Point(283, 114);
            inserirCatDD.Name = "inserirCatDD";
            inserirCatDD.Size = new Size(121, 23);
            inserirCatDD.TabIndex = 3;
            inserirCatDD.Text = "Categoria";
            // 
            // inserirQuantTXT
            // 
            inserirQuantTXT.Location = new Point(53, 114);
            inserirQuantTXT.Name = "inserirQuantTXT";
            inserirQuantTXT.Size = new Size(100, 23);
            inserirQuantTXT.TabIndex = 4;
            inserirQuantTXT.Text = "Quantidade";
            // 
            // inserirOBSTXT
            // 
            inserirOBSTXT.Location = new Point(53, 158);
            inserirOBSTXT.Name = "inserirOBSTXT";
            inserirOBSTXT.Size = new Size(678, 236);
            inserirOBSTXT.TabIndex = 5;
            inserirOBSTXT.Text = "Observacoes";
            // 
            // inserirCancelar
            // 
            inserirCancelar.Location = new Point(53, 400);
            inserirCancelar.Name = "inserirCancelar";
            inserirCancelar.Size = new Size(90, 38);
            inserirCancelar.TabIndex = 6;
            inserirCancelar.Text = "Cancelar";
            inserirCancelar.UseVisualStyleBackColor = true;
            // 
            // inserirConfirmar
            // 
            inserirConfirmar.Location = new Point(641, 400);
            inserirConfirmar.Name = "inserirConfirmar";
            inserirConfirmar.Size = new Size(90, 38);
            inserirConfirmar.TabIndex = 7;
            inserirConfirmar.Text = "Confirmar";
            inserirConfirmar.UseVisualStyleBackColor = true;
            // 
            // inserirUN
            // 
            inserirUN.Location = new Point(159, 114);
            inserirUN.Name = "inserirUN";
            inserirUN.ReadOnly = true;
            inserirUN.Size = new Size(40, 23);
            inserirUN.TabIndex = 8;
            inserirUN.Text = "UN";
            // 
            // homeButton
            // 
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(12, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(33, 29);
            homeButton.TabIndex = 9;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // Pagina_Inserir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(homeButton);
            Controls.Add(inserirUN);
            Controls.Add(inserirConfirmar);
            Controls.Add(inserirCancelar);
            Controls.Add(inserirOBSTXT);
            Controls.Add(inserirQuantTXT);
            Controls.Add(inserirCatDD);
            Controls.Add(inserirOrdServDD);
            Controls.Add(inserirAmbDD);
            Controls.Add(inserirItemDD);
            Name = "Pagina_Inserir";
            Text = "Pagina_Inserir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inserirItemDD;
        private ComboBox inserirAmbDD;
        private ComboBox inserirOrdServDD;
        private ComboBox inserirCatDD;
        private TextBox inserirQuantTXT;
        private RichTextBox inserirOBSTXT;
        private Button inserirCancelar;
        private Button inserirConfirmar;
        private TextBox inserirUN;
        private Button homeButton;
    }
}