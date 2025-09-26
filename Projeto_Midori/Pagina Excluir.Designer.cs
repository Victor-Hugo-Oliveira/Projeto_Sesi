namespace Projeto_Midori {
    partial class Pagina_Excluir {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Excluir));
            excluirItemDD = new ComboBox();
            excluirOrdemDD = new ComboBox();
            CancelExcluir = new Button();
            ConfirmarExcluir = new Button();
            homeButton = new Button();
            excluirCategoria = new RadioButton();
            excluirAmbiente = new RadioButton();
            excluirItem = new RadioButton();
            SuspendLayout();
            // 
            // excluirItemDD
            // 
            excluirItemDD.FormattingEnabled = true;
            excluirItemDD.Location = new Point(211, 51);
            excluirItemDD.Name = "excluirItemDD";
            excluirItemDD.Size = new Size(513, 23);
            excluirItemDD.TabIndex = 3;
            excluirItemDD.Text = "Selecione o item a ser excluido";
            // 
            // excluirOrdemDD
            // 
            excluirOrdemDD.FormattingEnabled = true;
            excluirOrdemDD.Location = new Point(211, 97);
            excluirOrdemDD.Name = "excluirOrdemDD";
            excluirOrdemDD.Size = new Size(513, 23);
            excluirOrdemDD.TabIndex = 4;
            excluirOrdemDD.Text = "Selecione a Ordem de servico do item";
            // 
            // CancelExcluir
            // 
            CancelExcluir.Location = new Point(141, 365);
            CancelExcluir.Name = "CancelExcluir";
            CancelExcluir.Size = new Size(75, 23);
            CancelExcluir.TabIndex = 5;
            CancelExcluir.Text = "Cancelar";
            CancelExcluir.UseVisualStyleBackColor = true;
            // 
            // ConfirmarExcluir
            // 
            ConfirmarExcluir.Location = new Point(582, 365);
            ConfirmarExcluir.Name = "ConfirmarExcluir";
            ConfirmarExcluir.Size = new Size(75, 23);
            ConfirmarExcluir.TabIndex = 6;
            ConfirmarExcluir.Text = "Confirmar";
            ConfirmarExcluir.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(12, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(33, 29);
            homeButton.TabIndex = 7;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // excluirCategoria
            // 
            excluirCategoria.AutoSize = true;
            excluirCategoria.Location = new Point(50, 55);
            excluirCategoria.Name = "excluirCategoria";
            excluirCategoria.Size = new Size(76, 19);
            excluirCategoria.TabIndex = 8;
            excluirCategoria.TabStop = true;
            excluirCategoria.Text = "Categoria";
            excluirCategoria.UseVisualStyleBackColor = true;
            // 
            // excluirAmbiente
            // 
            excluirAmbiente.AutoSize = true;
            excluirAmbiente.Location = new Point(50, 101);
            excluirAmbiente.Name = "excluirAmbiente";
            excluirAmbiente.Size = new Size(77, 19);
            excluirAmbiente.TabIndex = 9;
            excluirAmbiente.TabStop = true;
            excluirAmbiente.Text = "Ambiente";
            excluirAmbiente.UseVisualStyleBackColor = true;
            excluirAmbiente.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // excluirItem
            // 
            excluirItem.AutoSize = true;
            excluirItem.Location = new Point(50, 144);
            excluirItem.Name = "excluirItem";
            excluirItem.Size = new Size(49, 19);
            excluirItem.TabIndex = 10;
            excluirItem.TabStop = true;
            excluirItem.Text = "Item";
            excluirItem.UseVisualStyleBackColor = true;
            // 
            // Pagina_Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(excluirItem);
            Controls.Add(excluirAmbiente);
            Controls.Add(excluirCategoria);
            Controls.Add(homeButton);
            Controls.Add(ConfirmarExcluir);
            Controls.Add(CancelExcluir);
            Controls.Add(excluirOrdemDD);
            Controls.Add(excluirItemDD);
            Name = "Pagina_Excluir";
            Text = "Pagina_Excluir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox excluirItemDD;
        private ComboBox excluirOrdemDD;
        private Button CancelExcluir;
        private Button ConfirmarExcluir;
        private Button homeButton;
        private RadioButton excluirCategoria;
        private RadioButton excluirAmbiente;
        private RadioButton excluirItem;
    }
}