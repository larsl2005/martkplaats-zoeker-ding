using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marktplaats_ding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SearchTerm = ZoekTerm.Text;
            string priceincents = (MaxPrijs.Value * 100).ToString();
            string maxdistance = (Afstand.Value * 1000).ToString();
            System.Diagnostics.Process.Start("https://marktplaats.nl/q/" + SearchTerm + "/#PriceInCentsTo:" + priceincents + "|sortBy:PRICE|sortOrder:INCREASING|distanceMeters:" + maxdistance + "|searchInTitleAndDescription:true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Marktplaats Zoeker";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.MaximizeBox = false; --onnodig want FormBorderStyle.FixedToolWindow heeft geen MaximizeBox
        }
    }
}
