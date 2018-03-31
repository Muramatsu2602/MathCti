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
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
          

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

        private void btnLeisDeFormacao_Click(object sender, EventArgs e)
        {
            frmLeisDeFormacao objLeisDeFormacao = new frmLeisDeFormacao(txtNome.Text);
            objLeisDeFormacao.ShowDialog();
        }

        private void btnPaPg_Click(object sender, EventArgs e)
        {
            frmPaPg objPaPg = new frmPaPg(txtNome.Text);
            objPaPg.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
