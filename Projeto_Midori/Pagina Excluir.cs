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
    public partial class Pagina_Excluir : Form {

        
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
