using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descriptionAttribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int alfabe = Convert.ToInt32(comboBox1.SelectedIndex);
            switch (alfabe)
            {
                case 0:
                    label1.Text = "A harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 1:
                    label1.Text = "B harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 2:
                    label1.Text = "C harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 3:
                    label1.Text = "Ç harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 4:
                    label1.Text = "D harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 5:
                    label1.Text = "E harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 6:
                    label1.Text = "F harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 7:
                    label1.Text = "G harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 8:
                    label1.Text = "Ğ harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 9:
                    label1.Text = "H harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 10:
                    label1.Text = "I harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 11:
                    label1.Text = "İ harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 12:
                    label1.Text = "J harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 13:
                    label1.Text = "K harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 14:
                    label1.Text = "L harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 15:
                    label1.Text = "M harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 16:
                    label1.Text = "N harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 17:
                    label1.Text = "O harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 18:
                    label1.Text = "Ö harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 19:
                    label1.Text = "P harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 20:
                    label1.Text = "R harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 21:
                    label1.Text = "S harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 22:
                    label1.Text = "Ş harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 23:
                    label1.Text = "T harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 24:
                    label1.Text = "U harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 25:
                    label1.Text = "Ü harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 26:
                    label1.Text = "V harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 27:
                    label1.Text = "Y harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                case 28:
                    label1.Text = "Z harfi alfabenin " + Convert.ToInt32(alfabe + 1) + ". harfidir";
                    break;
                default:    
                    MessageBox.Show("Boyle bir harf yok");
                    break;

            }
        }
    }
}
