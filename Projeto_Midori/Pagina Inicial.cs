using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Midori {
    public partial class FrontPage : Form {

        private string caminhoRecebido;
        public FrontPage() {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            Pagina_Cadastrar pagina_Cadastrar = new Pagina_Cadastrar();
            pagina_Cadastrar.FormClosed += (s, args) => this.Close();
            pagina_Cadastrar.Show();
            this.Hide();
        }

        private void InserirButton_Click(object sender, EventArgs e) {
            Pagina_Inserir pagina_Inserir = new Pagina_Inserir();
            pagina_Inserir.FormClosed += (s, args) => this.Close();
            pagina_Inserir.Show();
            this.Hide();
        }

        private void VisualizarButton_Click(object sender, EventArgs e) {
            Pagina_Visualizar pagina_Visualizar = new Pagina_Visualizar();
            pagina_Visualizar.FormClosed += (s, args) => this.Close();
            pagina_Visualizar.Show();
            this.Hide();
        }

        private void ExcluirButton_Click(object sender, EventArgs e) {
            Pagina_Excluir pagina_Excluir = new Pagina_Excluir();
            pagina_Excluir.FormClosed += (s, args) => this.Close();
            pagina_Excluir.Show();
            this.Hide();
        }
    }
}
