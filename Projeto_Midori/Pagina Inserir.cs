using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Projeto_Midori {

    
    public partial class Pagina_Inserir : Form {

        public static Workbook wb;
        public static Worksheet ws;
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        string filePath = "C:\\Users\\Bone\\Documents\\Planilhas\\teste_Midori\\OSASCO_Teste.xlsx";
        string caminho = CaminhoInic.Caminho.Text;

        public Pagina_Inserir() {
            InitializeComponent();
            Pagina_Inserir_Load();
            Pagina_inserir_LoadSub();
            RemoverDuplicatas(inserirItemDD);

        }

        // Volta pro menu principal
        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }

        // Carrega os items da planilha pro menu drop down principal
        public void Pagina_Inserir_Load() { 
            
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cell = ws.Range["B1:B5000"];
            Microsoft.Office.Interop.Excel.Range codRange = ws.Range["A2:A5000"];
            

            foreach (string Result in cell.Value) {
                if (Result != null) {
                    inserirItemDD.Items.Add(Result);
                }

            }



            object[,] cods = codRange.Value2 as object[,];
            for (int i = 1; i < inserirItemDD.Items.Count; i++) {
                string resultadoCod = cods.GetValue(i, 1).ToString();
                inserirItemDD.Items[i] = resultadoCod + " " + inserirItemDD.Items[i];

            }



            wb.Close();
        }

        // Carrega os items de Categoria/Ambiente/Ordem de Servico
        private void Pagina_inserir_LoadSub() { 
            string data;
            try {
                StreamReader streamReaderCad = new StreamReader(caminho + "\\Categoria.txt");

                data = streamReaderCad.ReadLine();

                while (data != null) {
                    inserirCatDD.Items.Add(data);
                    data = streamReaderCad.ReadLine();
                }

                streamReaderCad.Close();
            }
            catch (FileNotFoundException ex) {
                MessageBox.Show("Categoria nao cadastrado");
            }

            try {
                StreamReader streamReaderAmb = new StreamReader(caminho + "\\Ambiente.txt");

                data = streamReaderAmb.ReadLine();

                while (data != null) {
                    inserirAmbDD.Items.Add(data);
                    data = streamReaderAmb.ReadLine();
                }

                streamReaderAmb.Close();
            }
            catch (FileNotFoundException ex) {
                MessageBox.Show("Ambiente nao cadastrado");
            }

            try {
                StreamReader streamReaderOrdSer = new StreamReader(caminho + "\\Ordem de Servico.txt");

                data = streamReaderOrdSer.ReadLine();

                while (data != null) {
                    inserirOrdServDD.Items.Add(data);
                    data = streamReaderOrdSer.ReadLine();
                }

                streamReaderOrdSer.Close();
            }
            catch (FileNotFoundException ex) {

                MessageBox.Show("Ordem de Servico nao cadastrado");

            }
        }

        // Remove duplicatas
        private void RemoverDuplicatas(ComboBox comboBox) { 
            var unique = new HashSet<string>();
            for (int i = comboBox.Items.Count - 1; i >= 0; i--) {
                string value = comboBox.Items[i].ToString();
                if (!unique.Add(value)) {
                    comboBox.Items.RemoveAt(i);
                }
            }
        }


        //Pega a unidade de medida e exibe ao lado de Quantidade
        private void inserirItemDD_SelectedIndexChanged(object sender, EventArgs e) { 

            
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range UnRange = ws.Range["D1:D5000"];

            object[,] values = UnRange.Value2 as object[,];
            int curIndex = inserirItemDD.SelectedIndex;
            int rowIndex = curIndex + 1;
            inserirUN.Text = values.GetValue(rowIndex, 1).ToString();
            wb.Close();

        }

        // Insere as informacoes na planilha, verificando se existe informacao no item selecionado
        private void inserirConfirmar_Click(object sender, EventArgs e) {
            wb = excel.Workbooks.Open(filePath);
            ws = excel.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range ItemRange = ws.Range["B1:B5000"];
            Microsoft.Office.Interop.Excel.Range QuantRange = ws.Range["C1:C5000"];
            Microsoft.Office.Interop.Excel.Range AmbRange = ws.Range["E1:E5000"];
            Microsoft.Office.Interop.Excel.Range CatRange = ws.Range["F1:F5000"];
            Microsoft.Office.Interop.Excel.Range OrdServRange = ws.Range["G1:G5000"];
            Microsoft.Office.Interop.Excel.Range ObsRange = ws.Range["H1:H5000"];


            int curIndex = inserirItemDD.SelectedIndex;

            String[] inserir = {inserirItemDD.SelectedItem.ToString(), inserirQuantTXT.Text, inserirAmbDD.SelectedItem.ToString(), inserirCatDD.SelectedItem.ToString(), inserirOrdServDD.SelectedItem.ToString(), inserirOBSTXT.Text };


            if (QuantRange.Cells[curIndex + 1, 1] != null) {
                int countIndx = 0;
                foreach (string check in ItemRange.Value) {
                    countIndx++;
                    if (check == null) {
                        curIndex = countIndx;
                        break;
                    }
                    
                }

            } 

                AmbRange.Cells[curIndex + 1, 1].Value2 = inserir[2];
                QuantRange.Cells[curIndex + 1, 1].Value2 = inserir[1];
                CatRange.Cells[curIndex + 1, 1].Value2 = inserir[3];
                OrdServRange.Cells[curIndex + 1, 1].Value2 = inserir[4];
                ObsRange.Cells[curIndex + 1, 1].Value2 = inserir[5];

            

            wb.Save();
            wb.Close();
        }
    }
}
