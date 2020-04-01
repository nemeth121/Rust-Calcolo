using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Calcolo
{
    public partial class Form1 : Form
    {

        decimal val, wood, stone, metal, hqm;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {   
            
            val = giorniBar.Value;
            etichettaGiorni.Text = val.ToString();
            if (woodText.Value > 0)
            {;
                wood = val * woodText.Value;
                woodRes.Text = wood.ToString();
            }

            if (int.Parse(stoneText.Text) > 0)
            {
                stone = val * stoneText.Value;
                stoneRes.Text = stone.ToString();
            }

            if (int.Parse(metalText.Text) > 0)
            {
                metal = val * metalText.Value;
                metalRes.Text = metal.ToString();
            }

            if (int.Parse(hqmText.Text) > 0)
            {
                hqm = val * hqmText.Value;
                hqmRes.Text = hqm.ToString();
            }

        }

    }
}
