using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
            hesab = new hesablama(function_mez);
            hesab += function_vergi;
            hesab += function_dmsf;
            hesab += function_xalis;


        }
        hesablama hesab;
        static  int salary = 400;
        static double d;
        static double v;
        static double xa;

        delegate double hesablama(float x);
        

        double function_mez(float x)
        {
            textBox5.Text = (x/box.Count).ToString();
            return 5;
        }

         double function_vergi(float x) {
            double v = salary * 0.14;
            textBox2.Text = v.ToString();
            return v;

        }

        double function_dmsf(float x)
        {
            double d = salary * 0.03;
            textBox3.Text = d.ToString();
            return d;
        }


         double function_xalis(float x)
        {
            double xa = salary - (int.Parse(textBox2.Text)+int.Parse(textBox3.Text));
            textBox4.Text = xa.ToString();
            return xa;

        }

        int t = 0;
        List<TextBox> box = new List<TextBox>(); 
        
        private void button1_Click(object sender, EventArgs e)
        {
            t++;
            TextBox textBox1 = new TextBox();
            textBox1.Left = 67;
            textBox1.Top = 32+t*30;
            this.Controls.Add(textBox1);

            box.Add(textBox1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach(var item in box)
            {
                s += int.Parse(item.Text);
            }
            hesab(s);
           
        }
    }
}



