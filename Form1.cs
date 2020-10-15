using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W202010151
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            {

                int randomNum = new Random().Next(100);
                try
                {
                    string aa = textBox1.Text;
                    int input_int = int.Parse(aa);

                    if (randomNum == input_int)
                    {
                        MessageBox.Show("ok", "骰子", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("88", "骰子", MessageBoxButtons.OK);
                    }




                }
                catch
                {
                    MessageBox.Show("別鬧", "骰子", MessageBoxButtons.OK);
                }


            }
        }
    }
}
