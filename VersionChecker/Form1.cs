using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ReturnValue = AutoSetup.CheckPC.AppVersion();

            textBox3.Text = "입력하신 프로그램이 없습니다.";
            for (int i = 0; i < ReturnValue.Count; i++)
            {


                if (ReturnValue[i].Contains(textBox1.Text))
                {

                    if (ReturnValue[i].Contains(textBox2.Text))
                    {
                        textBox3.Text = ReturnValue[i];
                        //label4.Text = ReturnValue[i];
                    }
                    else
                    {
                        textBox3.Text = "입력하신 버전과 다릅니다.";
                    }

                }
                else
                {

                }


            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PV = AutoSetup.CheckPC.ProVersion(textBox4.Text);
            if (PV != null)
            {
                textBox5.Text = PV;
            }
            else
            {
                textBox5.Text = "입력하신 프로그램이 없습니다.";
            }
        }
    }
}
