namespace Projeto_Midori
{
    public partial class CaminhoInic : Form {


        public static CaminhoInic Caminho;

       
        
        public CaminhoInic() {

            InitializeComponent();
            Caminho = this;
            
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e) {

        }

        private void SelecPasta_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                CaminhoPasta.Text = dialog.SelectedPath;
            }

            Caminho.Text = dialog.SelectedPath;


        }


        private void Continuar1_Click(object sender, EventArgs e) {
            if (CaminhoPasta.Text.Length != 0) {
                FrontPage form2 = new FrontPage();
                form2.FormClosed += (s, args) => this.Close(); // closes Form1 when Form2 closes
                form2.Show();
                this.Hide();
            } else {
                MessageBox.Show("Selecione a pasta para gravar os arquivos");
            }
        }
    }
}
