using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Projeto_Midori {
    public partial class Pagina_Visualizar : Form {
        public Pagina_Visualizar() {
            InitializeComponent();
            Pagina_Visualizar_Load();
        }
        string caminho = CaminhoInic.Caminho.Text;

        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }

        private void Pagina_Visualizar_Load() {
            
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source='C:\\Users\\Bone\\Documents\\Planilhas\\teste_Midori\\OSASCO_Teste.xlsx';Extended Properties='Excel 12.0;HDR=YES'";

            using (OleDbConnection conn = new OleDbConnection(connStr)) {
                conn.Open();
                System.Data.DataTable schema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheet = schema.Rows[0]["TABLE_NAME"].ToString();

                // Load data
                OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM [{sheet}]", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                visualizarDataGrid.DataSource = dt;
            }
            string data;
            try {
                StreamReader streamReaderOrdSer = new StreamReader(caminho + "\\Ordem de Servico.txt");

                data = streamReaderOrdSer.ReadLine();

                while (data != null) {
                    visualizarOrdServDD.Items.Add(data);
                    data = streamReaderOrdSer.ReadLine();
                }
            }
            catch (FileNotFoundException ex) {

                MessageBox.Show("Ordem de Servico nao cadastrado");

            }

        }

        
        
    }
}
