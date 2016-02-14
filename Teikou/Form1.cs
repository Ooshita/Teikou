using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teikou
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                char[] c = textBox1.Text.ToCharArray();
                int color = Convert.ToInt32(c[0]);
                //label3.Text = c[0].ToString();
                try
                {
                    //一列目のカラーコード
                    if (textBox1.Text[0] == '0')
                    {
                        pictureBox2.BackColor = Color.Black;
                    }
                    else if (textBox1.Text[0] == '1')
                    {
                        pictureBox2.BackColor = Color.Brown;
                    }
                    else if (textBox1.Text[0] == '2')
                    {
                        pictureBox2.BackColor = Color.Red;
                    }
                    else if (textBox1.Text[0] == '3')
                    {
                        pictureBox2.BackColor = Color.Orange;
                    }
                    else if (textBox1.Text[0] == '4')
                    {
                        pictureBox2.BackColor = Color.Yellow;
                    }
                    else if (textBox1.Text[0] == '5')
                    {
                        pictureBox2.BackColor = Color.Green;
                    }
                    else if (textBox1.Text[0] == '6')
                    {
                        pictureBox2.BackColor = Color.Blue;
                    }
                    else if (textBox1.Text[0] == '7')
                    {
                        pictureBox2.BackColor = Color.Purple;
                    }
                    else if (textBox1.Text[0] == '8')
                    {
                        pictureBox2.BackColor = Color.Gray;
                    }
                    else if (textBox1.Text[0] == '9')
                    {
                        pictureBox2.BackColor = Color.White;
                    }
                    //二列目のカラーコード
                    if (textBox1.Text[1] == '0')
                    {
                        pictureBox3.BackColor = Color.Black;
                    }
                    else if (textBox1.Text[1] == '1')
                    {
                        pictureBox3.BackColor = Color.Brown;
                    }
                    else if (textBox1.Text[1] == '2')
                    {
                        pictureBox3.BackColor = Color.Red;
                    }
                    else if (textBox1.Text[1] == '3')
                    {
                        pictureBox3.BackColor = Color.Orange;
                    }
                    else if (textBox1.Text[1] == '4')
                    {
                        pictureBox3.BackColor = Color.Yellow;
                    }
                    else if (textBox1.Text[1] == '5')
                    {
                        pictureBox3.BackColor = Color.Green;
                    }
                    else if (textBox1.Text[1] == '6')
                    {
                        pictureBox3.BackColor = Color.Blue;
                    }
                    else if (textBox1.Text[1] == '7')
                    {
                        pictureBox3.BackColor = Color.Purple;
                    }
                    else if (textBox1.Text[1] == '8')
                    {
                        pictureBox3.BackColor = Color.Gray;
                    }
                    else if (textBox1.Text[1] == '9')
                    {
                        pictureBox3.BackColor = Color.White;
                    }

                    //三列目のカラーコード
                    if (textBox1.Text[2] == '0')
                    {
                        pictureBox4.BackColor = Color.Black;
                    }
                    else if (textBox1.Text[2] == '1')
                    {
                        pictureBox4.BackColor = Color.Brown;
                    }
                    else if (textBox1.Text[2] == '2')
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (textBox1.Text[2] == '3')
                    {
                        pictureBox4.BackColor = Color.Orange;
                    }
                    else if (textBox1.Text[2] == '4')
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (textBox1.Text[2] == '5')
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else if (textBox1.Text[2] == '6')
                    {
                        pictureBox4.BackColor = Color.Blue;
                    }
                    else if (textBox1.Text[2] == '7')
                    {
                        pictureBox4.BackColor = Color.Purple;
                    }
                    else if (textBox1.Text[2] == '8')
                    {
                        pictureBox4.BackColor = Color.Gray;
                    }
                    else if (textBox1.Text[2] == '9')
                    {
                        pictureBox4.BackColor = Color.White;
                    }
                }
            catch (IndexOutOfRangeException)
            {
                
            }
           // pictureBox2.BackColor = Color.Red;
        }

        public class ColorCode
        {
            public char ColorSelect(char c)
            {
                try
                {
                    if (c == 0)
                    {

                    }
                    else if (c == 1)
                    {

                    }
                    else if (c == 2)
                    {

                    }
                }
                catch (IndexOutOfRangeException)
                {

                }
                return c;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
