using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obliczanie_spadków_napięć_w_sieciach_dystrybucyjnych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NieskieNapięcie siec;
        
        private void StwKbl_Click(object sender, EventArgs e)
        {
            siec = new NieskieNapięcie((double)numI.Value, (double)numFi.Value, (double)numR0.Value, (double)numX0.Value, (double)numL.Value);
            lRL.Text = siec.Rl.ToString("#.##");
            lXL.Text = siec.Xl.ToString("#.##");
            lU.Text = siec.ustalU.ToString("#.##");
            siec.Rysuj(chart1);
        }
    }
}
