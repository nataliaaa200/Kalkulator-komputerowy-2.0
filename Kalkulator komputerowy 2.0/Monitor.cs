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
    public partial class Monitor : Form
    {
        public decimal WybranaCena { get; private set; }
        public decimal cenaMonitora = 0;
        public Monitor()
        {
            InitializeComponent();
            listViewMonitor.View = View.List;

            listViewMonitor.Items.Add(new ListViewItem("Monitor 21 cali"));
            listViewMonitor.Items.Add(new ListViewItem("Monitor 24 cale"));
            listViewMonitor.Items.Add(new ListViewItem("Monitor 27 cali"));
            WybranaCena = cenaMonitora;
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

        private void listViewMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewMonitor.SelectedItems.Count>0)
            {
                string wybranyMonitor = listViewMonitor.SelectedItems[0].Text;

                switch (wybranyMonitor)
                {
                    case "Monitor 21 cali":
                        cenaMonitora = 500;
                        break;
                    case "Monitor 24 cale":
                        cenaMonitora = 800;
                        break;
                    case "Monitor 27 cali":
                        cenaMonitora = 1000;
                        break;
                }
                txtCena.Text = cenaMonitora.ToString("0.00") + " zł";
                WybranaCena = cenaMonitora;
            }
        }
    }
}
