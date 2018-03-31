using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCTI
{
    public partial class frmLeisFormacao : Form
    {
        public frmLeisFormacao(string nome)
        {
            InitializeComponent();
			lblIntroduction.Text ="Bem vindo," + nome + ". Essas são as fórmulas usadas nesse programa!";
        }

		private void btnVoltarLeisMenu_Click(object sender, EventArgs e)
		{
			frmMenu volta = new frmMenu();
			this.Hide();
			volta.Show();
		}

        private void lblIntroduction_Click(object sender, EventArgs e)
        {

        }
    }
}
