using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Testaan tallennusta -niilo
                Random r = new Random();
                int luku = r.Next(1 ,100);
                textBox1.Text = luku.ToString();
           

            if (button1.BackColor == Color.Cyan)
            {
                button1.BackColor = Color.Green;

                if (true)
                {
                    //testiä
                }
                
            }
            else
            {
                button1.BackColor = Color.Cyan;
            }


        }
    }
        
}
