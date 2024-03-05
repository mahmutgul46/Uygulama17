using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama17
{
    public partial class Form1 : Form
    {
        ErrorProvider ep = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtNumara.Text, out int sonuc))
            {
                ep.SetError(txtNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "Numara girişi hatalı");
            }
        }

        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                e.Cancel = true;
                ep.SetError(txtAdSoyad, "Adı ve Soyadı girinizzss");
            }
            else 
            {
                ep.SetError(txtAdSoyad,"");
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if (int.TryParse(txtDersNotu.Text, out dersNotu))
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(txtDersNotu, "0 - 100 arasında değer giriniz.");
                }
                else
                {
                    ep.SetError(txtDersNotu, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, "Sayısal değer giriniz.");
            }

        }
    }
}
