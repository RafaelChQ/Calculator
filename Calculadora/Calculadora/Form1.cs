using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Go to "Commit Solution Changes" to update your last Changes
namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void b_sumar_Click(object sender, EventArgs e)
        {
            lbl_resp.Text = (Convert.ToInt32(txt_1.Text) + Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void b_restar_Click(object sender, EventArgs e)
        {
            lbl_resp.Text = (Convert.ToInt32(txt_1.Text) - Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void b_multiplicar_Click(object sender, EventArgs e)
        {
            lbl_resp.Text = (Convert.ToInt32(txt_1.Text) * Convert.ToInt32(txt_2.Text)).ToString();
        }
    }
}
