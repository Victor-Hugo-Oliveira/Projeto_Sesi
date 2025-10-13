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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // inserirItemDD
            // 
            inserirItemDD.DropDownStyle = ComboBoxStyle.DropDownList;
            inserirItemDD.FormattingEnabled = true;
            inserirItemDD.Location = new Point(53, 54);
            inserirItemDD.Name = "inserirItemDD";
            inserirItemDD.Size = new Size(678, 23);
            inserirItemDD.TabIndex = 0;
            inserirItemDD.SelectedIndexChanged += inserirItemDD_SelectedIndexChanged;
            
            // 
            // inserirAmbDD
            // 
            inserirAmbDD.DropDownStyle = ComboBoxStyle.DropDownList;
            inserirAmbDD.FormattingEnabled = true;
            inserirAmbDD.Location = new Point(610, 114);
            inserirAmbDD.Name = "inserirAmbDD";
            inserirAmbDD.Size = new Size(121, 23);
            inserirAmbDD.TabIndex = 1;
            // 
            // inserirOrdServDD
            // 
            inserirOrdServDD.DropDownStyle = ComboBoxStyle.DropDownList;
            inserirOrdServDD.FormattingEnabled = true;
            inserirOrdServDD.Location = new Point(447, 114);
            inserirOrdServDD.Name = "inserirOrdServDD";
            inserirOrdServDD.Size = new Size(121, 23);
            inserirOrdServDD.TabIndex = 2;
            // 
            // inserirCatDD
            // 
            inserirCatDD.DropDownStyle = ComboBoxStyle.DropDownList;
            inserirCatDD.FormattingEnabled = true;
            inserirCatDD.Location = new Point(283, 114);
            inserirCatDD.Name = "inserirCatDD";
            inserirCatDD.Size = new Size(121, 23);
            inserirCatDD.TabIndex = 3;
            // 
            // inserirQuantTXT
            // 
            inserirQuantTXT.Location = new Point(53, 114);
            inserirQuantTXT.Name = "inserirQuantTXT";
            inserirQuantTXT.Size = new Size(100, 23);
            inserirQuantTXT.TabIndex = 4;
            // 
            // inserirOBSTXT
            // 
            inserirOBSTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            inserirConfirmar.Click += inserirConfirmar_Click;
            // 
            // inserirUN
            // 
            inserirUN.BorderStyle = BorderStyle.None;
            inserirUN.Location = new Point(162, 117);
            inserirUN.Name = "inserirUN";
            inserirUN.ReadOnly = true;
            inserirUN.Size = new Size(48, 16);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 26);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 10;
            label1.Text = "Selecione o Servico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 96);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 96);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 12;
            label3.Text = "Ordem de Servico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 96);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 13;
            label4.Text = "Ambiente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 96);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 14;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 99);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 15;
            label6.Text = "Unidade de Medida";
            // 
            // Pagina_Inserir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}