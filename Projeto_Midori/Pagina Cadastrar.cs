using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Midori {
    public partial class Pagina_Cadastrar : Form {

        
        public Pagina_Cadastrar() {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void Pagina_Cadastrar_Load(object sender, EventArgs e) {

        }

        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }

        private void cadastrarCat_CheckedChanged(object sender, EventArgs e) {

        }

        private void cadastroTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void cadastroConfirmar_Click(object sender, EventArgs e) {
            string nomeCadastro = cadastroTextBox.Text;
            /*if (cadastrarCat.Checked) {
                nomeCadastro = nomeCadastro +" " + cadastrarCat.Text;
            } else if (cadastrarAmb.Checked) {
                nomeCadastro = nomeCadastro + " " + cadastrarAmb.Text;
            } else if (cadastrarOrdSer.Checked) {
                nomeCadastro = nomeCadastro + " " + cadastrarOrdSer.Text;
            }*/
            

            string caminho = CaminhoInic.Caminho.Text;

            if (cadastrarCat.Checked) {
                StreamWriter streamWriter = new StreamWriter(caminho + "\\Categoria.txt", true);
                streamWriter.WriteLine(nomeCadastro);
                streamWriter.Close();
                MessageBox.Show($"Categoria: \"{nomeCadastro}\" cadastrado");
            }

            if (cadastrarAmb.Checked) {
                StreamWriter streamWriter = new StreamWriter(caminho + "\\Ambiente.txt", true);
                streamWriter.WriteLine(nomeCadastro);
                streamWriter.Close();
                MessageBox.Show($"Ambiente: \"{nomeCadastro}\" cadastrado");
            }

            if (cadastrarOrdSer.Checked) {
                StreamWriter streamWriter = new StreamWriter(caminho + "\\Ordem de Servico.txt", true);
                streamWriter.WriteLine(nomeCadastro);
                streamWriter.Close();
                MessageBox.Show($"Ordem de Serivco: \"{nomeCadastro}\" cadastrado");
            }


        }
    }
}
