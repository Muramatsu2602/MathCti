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
    public partial class frmLeisDeFormacao : Form
    {
        public frmLeisDeFormacao(string texto)
        {
            InitializeComponent();
            lblNomeLeisDeForm.Text = texto;
      
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
        private void btnVoltar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

    }
}
