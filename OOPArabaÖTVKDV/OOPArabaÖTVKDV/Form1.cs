using OOPArabaÖTVKDV.OTVV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPArabaÖTVKDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fiyat = 0;
        string radiolar = "";
        private void button1_Click(object sender, EventArgs e)
        {
        
            {
                if (radioButton1.Checked)
                {
                    radiolar = "Otomobil";
                    fiyat = int.Parse(fiyattxt.Text);

                }
                if (radioButton2.Checked)
                {
                    radiolar = "Motorsiklet";
                    fiyat = int.Parse(fiyattxt.Text);


                }
                if (radioButton3.Checked)
                {
                    radiolar = "Otobüs";
                    fiyat = int.Parse(fiyattxt.Text);

                }

                using (OTV araba = new OTV(radiolar, fiyat, comboBox1.Text,comboBox2.Text))
                {
                    label4.Text = araba.sonuc.ToString();
                }
            }       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox1.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = true;
        }
    }
}
