using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Regex;

namespace SoftwareConsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Regex r = new Regex(@"if\s*\(((?:[^\(\)]|\((?1)\))*+)\)\s*{((?:[^{}]|{(?2)})*+)}");

            Match m = Regex.Match(richTextBox1.Text, @"if\s*\(([^\(\)]|\s)*\)\s*{(.|\s)*?}");
            if (m.Success)
            {
                richTextBox2.Text = "Valid";
            }
            else
            {
                richTextBox2.Text = "Invalid";
            }

            String[] tokens = { "if", "(", ")", "{", "}" , ";" };
            String arr = richTextBox1.Text;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == "i")
                {
                    if (arr[i + 1].ToString() == "f")
                        
                        listBox1.Items.Add("if");
                }
                if(arr[i].ToString()=="=")
                {
                    if (arr[i + 1].ToString() == "=")
                        listBox1.Items.Add("==");
                    
                }
                for (int j=0;j< tokens.Length; j++)
                {
                    if(arr[i].ToString() == tokens[j])
                    {
                        
                        listBox1.Items.Add(arr[i].ToString());
                    }
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
