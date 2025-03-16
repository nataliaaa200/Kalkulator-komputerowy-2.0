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
    public partial class Form1 : Form
    {
        private decimal komputerCena = 0;
        private decimal monitorCena = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKomputer_Click(object sender, EventArgs e)
        {
            Komputer komputer = new Komputer();
            if(komputer.ShowDialog()==DialogResult.OK)
            {
                komputerCena = komputer.WybranaCenaKomp;
                CenaOstateczna();
            }
        }
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            Monitor monitor = new Monitor();
            if (monitor.ShowDialog() == DialogResult.OK)
            {
               monitorCena = monitor.WybranaCena;
                CenaOstateczna();
            }
        }
        private void CenaOstateczna()
        {
            decimal ostatecznaCena = komputerCena + monitorCena;
            txtCena.Text = ostatecznaCena.ToString("0.00") + " zł";
        }

    }
}
