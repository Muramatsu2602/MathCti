using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCti
{
    public partial class frmVerTermo : Form
    {
        public frmVerTermo( String termo, String pa, String pg, String ao,String r, String texto)
        {
            InitializeComponent();
            lblNumeroDoTermo.Text = termo;
            lblPosicaoPA.Text = pa;
            lblPosicaoPG.Text = pg;
            lblMostraAoDoTermo.Text= ao;
            lblMostraRazaoDaProgressao.Text = r;
            lblMostraNome.Text = texto;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlAreaGeralMostraEspecifico_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
