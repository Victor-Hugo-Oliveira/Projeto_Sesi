using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_Midori {
    public partial class Pagina_Excluir : Form {

        string caminho = CaminhoInic.Caminho.Text;
        string data;
        public Pagina_Excluir() {
            InitializeComponent();
        }

        private void checkAmbiente_CheckedChanged(object sender, EventArgs e) {

        }

        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }



        private void excluirCategoria_CheckedChanged(object sender, EventArgs e) {
            excluirItemDD.Items.Clear();
            try {

                StreamReader streamReaderCat = new StreamReader(caminho + "\\Categoria.txt");

                data = streamReaderCat.ReadLine();

                while (data != null) {
                    excluirItemDD.Items.Add(data);
                    data = streamReaderCat.ReadLine();
                }

                streamReaderCat.Close();
            }
            catch (FileNotFoundException) {
                MessageBox.Show("Categoria nao cadastrada");
            }
        }

        private void excluirAmbiente_CheckedChanged(object sender, EventArgs e) {

            excluirItemDD.Items.Clear();
            try {
                StreamReader streamReaderAmb = new StreamReader(caminho + "\\Ambiente.txt");

                data = streamReaderAmb.ReadLine();

                while (data != null) {
                    excluirItemDD.Items.Add(data);
                    data = streamReaderAmb.ReadLine();
                }

                streamReaderAmb.Close();

            }
            catch (FileNotFoundException) {
                MessageBox.Show("Ambiente nao cadastrado");
            }
        }

        private void excluirItem_CheckedChanged(object sender, EventArgs e) {
            MessageBox.Show("Item a ser excluido");
        }

        private void excluirOrdServ_CheckedChanged(object sender, EventArgs e) {
            excluirItemDD.Items.Clear();
            try {
                StreamReader streamReaderOrdServ = new StreamReader(caminho + "\\Ordem de Servico.txt");

                data = streamReaderOrdServ.ReadLine();

                while (data != null) {
                    excluirItemDD.Items.Add(data);
                    data = streamReaderOrdServ.ReadLine();
                }

                streamReaderOrdServ.Close();

            }
            catch (FileNotFoundException) {
                MessageBox.Show("Ordem de Servico nao cadastrado");
            }
        }

        private void ConfirmarExcluir_Click(object sender, EventArgs e) {
            string itemSelec = "";
            string excludItem = "";

            if (excluirCategoria.Checked)
                itemSelec = "Categoria";
            else if (excluirOrdServ.Checked)
                itemSelec = "Ordem De Servico";
            else if (excluirAmbiente.Checked)
                itemSelec = "Ambiente";

            excludItem = excluirItemDD.Text;
            string arquivo = Path.Combine(caminho, itemSelec + ".txt");

            // Lê todas as linhas
            string[] linhas = File.ReadAllLines(arquivo);

            // Filtra removendo a linha que contém o item
            var novasLinhas = linhas
                .Where(l => !l.Trim().Equals(excludItem, StringComparison.OrdinalIgnoreCase)) // remove linha exata
                .Where(l => !string.IsNullOrWhiteSpace(l)) // remove vazias
                .ToArray();

            // Escreve novamente o arquivo (sem o item)
            File.WriteAllLines(arquivo, novasLinhas);

            MessageBox.Show($"Item \"{excludItem}\" removido de {itemSelec}.txt com sucesso!");

            excluirItemDD.Text = "";
        }
    }
}
