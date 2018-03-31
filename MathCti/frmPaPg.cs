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
    public partial class frmPaPg : Form
    {
        double[] pg;
        decimal[] pa;
        decimal[] recebePa;
        double[] recebePg;

        public frmPaPg(string texto)
        {
            InitializeComponent();
            lblMostraNomePaPg.Text = texto;
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

        private void btnSairPaPg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal[] calcularPa()
        {
            int n = 1;
            int valor = 200;
            pa = new decimal[valor];
            do
            {
                pa[n] = nmdValorInicial.Value + (nmdValorRazao.Value * (n - 1));
                n++;
            } while (n != valor);
            return pa;
        }
        private double[] calcularPg()
        {
            int n = 1;
            double expoente = 1, razao = Convert.ToDouble(nmdValorRazao.Value);
            int valor = 200;
            pg = new double[valor];
            do
            {
                expoente = n - 1;
                pg[n] = Convert.ToDouble(nmdValorInicial.Value) * Math.Pow(razao, expoente);
                n++;
            } while (n != valor);
            return (pg);
        }
        private void calcular()
        {
            int n = 1;
            int valor = 200;
            decimal[] pa = new decimal[valor];
            string paValorGeral = null;
            string pgValorGeral = null;
            recebePa = new decimal[valor];
            recebePg = new double[valor];
            recebePa = calcularPa();
            recebePg = calcularPg();
            pa[0] = nmdValorRazao.Value;
            do
            {
                pa[n] = nmdValorRazao.Value + nmdValorRazao.Value * n;
                n++;
            } while (n != valor);
            n = 1;
            do
            {
                paValorGeral += Convert.ToString(recebePa[n]) + System.Environment.NewLine + System.Environment.NewLine;
                n++;
            } while (n != valor);
            txtPG.Text = Convert.ToString(nmdValorInicial.Value) + System.Environment.NewLine;
            n = 1;
            do
            {
                pgValorGeral += Convert.ToString(recebePg[n]) + System.Environment.NewLine + System.Environment.NewLine;
                n++;
            } while (n != valor);
            txtPG.Text = pgValorGeral;
            txtPA.Text = paValorGeral;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void btnVerTermo_Click(object sender, EventArgs e)
        {
            calcular();
            if (Convert.ToInt32(nmdPosicao.Value) > 0)
            {
                String textoNumeroTermo = nmdPosicao.Value.ToString();
                String pgEnviar = recebePg[Convert.ToInt32(nmdPosicao.Value)].ToString();
                String paEnviar = recebePa[Convert.ToInt32(nmdPosicao.Value)].ToString();

                String ao = nmdValorInicial.Value.ToString();
                String r = nmdValorRazao.Value.ToString();
                String texto = lblMostraNomePaPg.Text;
              frmVerTermo verTermo = new frmVerTermo(textoNumeroTermo, paEnviar, pgEnviar,ao,r,texto);
                verTermo.ShowDialog();            
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nmdPosicao.Value = 0;
            nmdValorInicial.Value = 0;
            nmdValorRazao.Value = 0;
            txtPA.Text = null;
            txtPG.Text = null;
        }
    }
}
