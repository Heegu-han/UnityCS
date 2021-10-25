using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dd = label1.Text;
            lb1.Text = dd.Contains("Text").ToString();
            lb2.Text = dd.Equals("Text").ToString();
            lb3.Text = dd.Length.ToString();
            lb4.Text = dd.Replace("Text","Tixt").ToString();

            string[] strSplit = dd.Split(',');
            lb5.Text = strSplit[0].ToString();
            lb10.Text = strSplit[1].ToString();
            lb11.Text = strSplit[2].ToString();

            lb6.Text = dd.Substring(3, 6).ToString();
            lb7.Text = dd.ToLower().ToString();
            lb8.Text = dd.ToUpper().ToString();
            lb9.Text = dd.Trim().ToString();
        }
    }
}
