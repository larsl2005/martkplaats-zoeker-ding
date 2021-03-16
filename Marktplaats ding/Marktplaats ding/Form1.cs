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
            if(MaxPrijs.Value < MinPrice.Value)
            {
                MaxPrijs.Value = MinPrice.Value;
            }
            string priceincents = (MaxPrijs.Value * 100).ToString();
            string maxdistance = (Afstand.Value * 1000).ToString();
            string minpriceincents = (MinPrice.Value * 100).ToString();
            System.Diagnostics.Process.Start("https://marktplaats.nl/q/" + SearchTerm + "#/PriceCentsFrom:" + minpriceincents + "/#PriceInCentsTo:" + priceincents + "|sortBy:PRICE|sortOrder:INCREASING|distanceMeters:" + maxdistance + "|searchInTitleAndDescription:true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Marktplaats Zoeker";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.MaximizeBox = false; --onnodig want FormBorderStyle.FixedToolWindow heeft geen MaximizeBox
        }

        private void Afstand_ValueChanged(object sender, EventArgs e)
        {
            switch (Afstand.Value)
            {
                case 75:
                case 50:
                    Afstand.Increment = 25;
                    return;
                case 35:
                    Afstand.Value = 50;
                    return;
                case 25:
                    Afstand.Increment = 10;
                    return;
                case 20:
                    Afstand.Value = 25;
                    return;
                case 15:
                    return; //om een bug te voorkomen
                case 10:
                    Afstand.Increment = 5;
                    return;
                case 7:
                    Afstand.Value = 10;
                    return;
                case 5:
                    Afstand.Increment = 2;
                    return;
                case 3:
                    Afstand.Increment = 2;
                    return;
                case 1:
                    Afstand.Value = 0;
                    return;
                case 0:
                    Afstand.Increment = 3;
                    return;
                default:
                    if (Afstand.Value != 1 | Afstand.Value != 7 | Afstand.Value != 15 | Afstand.Value != 20 | Afstand.Value != 35)
                    {
                        Afstand.Value = 0;
                        MessageBox.Show("Ongeldige afstand");
                        return;
                    }
                    return;
            }
        }
    }
}
