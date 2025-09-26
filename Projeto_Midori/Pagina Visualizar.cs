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
using System.Data.OleDb;


namespace Projeto_Midori {
    public partial class Pagina_Visualizar : Form {
        public Pagina_Visualizar() {
            InitializeComponent();
            Pagina_Visualizar_Load();
        }

        private void homeButton_Click(object sender, EventArgs e) {
            FrontPage frontPage = new FrontPage();
            frontPage.FormClosed += (s, args) => this.Close();
            frontPage.Show();
            this.Hide();
        }

        private void Pagina_Visualizar_Load() {
            string filepath = "";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;
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
            /*wb = excel.Workbooks.Open("C:\\Users\\Bone\\Documents\\Planilhas\\teste_Midori\\OSASCO - Planilha PSDA 455-24 - Lote 02.xlsx");
            ws = wb.Worksheets[1];

            visualizarDataGrid.DataSource = ws;*/

        }

        
        
    }
}
