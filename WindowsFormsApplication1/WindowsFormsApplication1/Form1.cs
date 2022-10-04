using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> types = new Dictionary<string, double>();
            types.Add("Regular Student", 0.0);
            types.Add("Student Assistant",0.3);
            types.Add("Scholar Student", 0.6);
            types.Add("Student with school benefits", 0.8); 
            types.Add("Student Athlete", 0.9);
            Dictionary<string, double> level = new Dictionary<string, double>();
            level.Add("1st Year", 180);
            level.Add("2nd Year", 220);
            level.Add("3rd Year", 280);
            level.Add("4th Year", 320);
            level.Add("5th Year", 400);
            Dictionary<string, double> register = new Dictionary<string, double>();
            register.Add("Regular", 150);
            register.Add("Reserve", 130);
            register.Add("Early", 100);
            register.Add("Special", 200);

            String yearofStudent = yearLevel.Text;
            String typeOfStudent = studentType.Text;
            String regular = registrationType.Text;
            double x = (level[yearofStudent] + register[regular]) * (1-types[typeOfStudent]);
            MessageBox.Show("dffd "+x.ToString());


        }
    }
}
