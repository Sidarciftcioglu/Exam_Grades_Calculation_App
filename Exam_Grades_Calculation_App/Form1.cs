using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Grades_Calculation_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, lastname;
            int exam1, exam2, project;
            double average;

            name = textBox1.Text;
            lastname = textBox2.Text;
            exam1 = Convert.ToInt32(textBox3.Text);
            exam2 = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);
            average = (exam1 + exam2 + project) / 3;

            listBox1.Items.Add(name+" "+lastname+" "+"Average : "+average);
        }
    }
}
