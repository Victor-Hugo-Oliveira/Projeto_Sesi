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
        public Pagina_Inserir() {
            InitializeComponent();
            Pagina_Inserir_Load();
            Pagina_inserir_LoadSub();

        }
        string caminho = CaminhoInic.Caminho.Text;
        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }

        private void Pagina_Inserir_Load() {
            string filePath = "C:\\Users\\Bone\\Documents\\Planilhas\\teste_Midori\\OSASCO_Teste.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range cell = ws.Range["B1:B5000"];
            Microsoft.Office.Interop.Excel.Range codRange = ws.Range["A2:A5000"];

            foreach (string Result in cell.Value) {
                if (Result != null ){
                    inserirItemDD.Items.Add(Result); 
                }
                
            }


            object[,] cods = codRange.Value2 as object[,];
            for (int i = 1; i < inserirItemDD.Items.Count; i++) {
                string resultadoCod = cods.GetValue(i,1).ToString();
                inserirItemDD.Items[i] = resultadoCod + " " + inserirItemDD.Items[i];
                    
            }
            wb.Close();           
        }

        private void Pagina_inserir_LoadSub() {
            string data;
            try {
                StreamReader streamReaderCad = new StreamReader(caminho + "\\Cadastro.txt");
            
                data = streamReaderCad.ReadLine();

                while (data != null) {
                    inserirCatDD.Items.Add(data);
                    data = streamReaderCad.ReadLine();
                }
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
            } catch (FileNotFoundException ex) {
                MessageBox.Show("Ambiente nao cadastrado");
            }

            try {
                StreamReader streamReaderOrdSer = new StreamReader(caminho + "\\Ordem de Servico.txt");

                data = streamReaderOrdSer.ReadLine();

                while (data != null) {
                    inserirOrdServDD.Items.Add(data);
                    data = streamReaderOrdSer.ReadLine();
                }
            }catch (FileNotFoundException ex) {

                MessageBox.Show("Ordem de Servico nao cadastrado");
                
            }
        }
    }
}
