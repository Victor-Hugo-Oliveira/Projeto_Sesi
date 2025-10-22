namespace Projeto_Midori
{
    partial class CaminhoInic
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
        private void InitializeComponent() {
            folderBrowserDialog1 = new FolderBrowserDialog();
            CaminhoPasta = new TextBox();
            SelecPasta = new Button();
            Continuar1 = new Button();
            SuspendLayout();
            // 
            // CaminhoPasta
            // 
            CaminhoPasta.Location = new Point(111, 61);
            CaminhoPasta.Name = "CaminhoPasta";
            CaminhoPasta.ReadOnly = true;
            CaminhoPasta.Size = new Size(609, 23);
            CaminhoPasta.TabIndex = 0;
            // 
            // SelecPasta
            // 
            SelecPasta.Location = new Point(111, 107);
            SelecPasta.Name = "SelecPasta";
            SelecPasta.Size = new Size(138, 23);
            SelecPasta.TabIndex = 1;
            SelecPasta.Text = "Selecione a pasta";
            SelecPasta.UseVisualStyleBackColor = true;
            SelecPasta.Click += SelecPasta_Click;
            // 
            // Continuar1
            // 
            Continuar1.Location = new Point(645, 107);
            Continuar1.Name = "Continuar1";
            Continuar1.Size = new Size(75, 23);
            Continuar1.TabIndex = 2;
            Continuar1.Text = "Continuar";
            Continuar1.UseVisualStyleBackColor = true;
            Continuar1.Click += Continuar1_Click;
            // 
            // CaminhoInic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Continuar1);
            Controls.Add(SelecPasta);
            Controls.Add(CaminhoPasta);
            Name = "CaminhoInic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione o caminho da pasta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox CaminhoPasta;
        private Button SelecPasta;
        private Button Continuar1;
    }
}
