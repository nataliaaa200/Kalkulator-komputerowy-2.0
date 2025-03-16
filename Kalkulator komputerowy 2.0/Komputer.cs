using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_komputerowy_2._0
{
    public partial class Komputer : Form
    {
        private decimal dyskCena = 0;
        private decimal procesorCena = 0;
        private decimal CenaKomp = 0;

        public decimal WybranaCenaKomp { get; private set; }
        public Komputer()
        {
            InitializeComponent();

            comboBox1.Items.Add("Intel");
            comboBox1.Items.Add("MediaTek");
            comboBox1.SelectedIndex = 0;
            WybranaCenaKomp = CenaKomp;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dyskCena = 250;
            }
            if (radioButton2.Checked)
            {
                dyskCena = 420;
            }
            if (radioButton3.Checked)
            {
                dyskCena = 680;
            }

            txtDysk.Text = dyskCena.ToString("0.00") + " zł";
            
            CenaKomp = procesorCena + dyskCena;
            WybranaCenaKomp = CenaKomp;
            txtSumaKomp.Text = WybranaCenaKomp.ToString("0.00") + " zł";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {          
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranaOpcja = comboBox1.SelectedItem.ToString();
            
            if(wybranaOpcja=="Intel")
            {
                procesorCena = 1200;
            }
            else if(wybranaOpcja=="MediaTek")
            {
                procesorCena = 1700;
            }

            txtProcesor.Text = procesorCena.ToString("0.00") + " zł";
            
        }
    }
}
