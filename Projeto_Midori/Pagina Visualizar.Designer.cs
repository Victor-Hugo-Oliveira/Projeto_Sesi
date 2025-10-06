namespace Projeto_Midori {
    partial class Pagina_Visualizar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Visualizar));
            visualizarOrdServDD = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            visualizarVoltar = new Button();
            homeButton = new Button();
            visualizarDataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)visualizarDataGrid).BeginInit();
            SuspendLayout();
            // 
            // visualizarOrdServDD
            // 
            visualizarOrdServDD.DropDownStyle = ComboBoxStyle.DropDownList;
            visualizarOrdServDD.FormattingEnabled = true;
            visualizarOrdServDD.Location = new Point(51, 41);
            visualizarOrdServDD.Name = "visualizarOrdServDD";
            visualizarOrdServDD.Size = new Size(414, 23);
            visualizarOrdServDD.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(471, 44);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(62, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "Filtrar por:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(539, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 23);
            comboBox2.TabIndex = 2;
            // 
            // visualizarVoltar
            // 
            visualizarVoltar.Location = new Point(645, 406);
            visualizarVoltar.Name = "visualizarVoltar";
            visualizarVoltar.Size = new Size(120, 32);
            visualizarVoltar.TabIndex = 4;
            visualizarVoltar.Text = "Voltar";
            visualizarVoltar.UseVisualStyleBackColor = true;
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
            // visualizarDataGrid
            // 
            visualizarDataGrid.AllowUserToAddRows = false;
            visualizarDataGrid.AllowUserToDeleteRows = false;
            visualizarDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizarDataGrid.Location = new Point(36, 79);
            visualizarDataGrid.Name = "visualizarDataGrid";
            visualizarDataGrid.ReadOnly = true;
            visualizarDataGrid.Size = new Size(729, 321);
            visualizarDataGrid.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 10;
            label1.Text = "Selecione a Ordem de Servico";
            // 
            // Pagina_Visualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(visualizarDataGrid);
            Controls.Add(homeButton);
            Controls.Add(visualizarVoltar);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(visualizarOrdServDD);
            Name = "Pagina_Visualizar";
            Text = "Pagina_Visualizar";
            ((System.ComponentModel.ISupportInitialize)visualizarDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox visualizarOrdServDD;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button visualizarVoltar;
        private Button homeButton;
        private DataGridView visualizarDataGrid;
        private Label label1;
    }
}