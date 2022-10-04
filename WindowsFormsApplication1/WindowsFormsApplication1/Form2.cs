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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> types = new Dictionary<string, double>();
            types.Add("Regular Student", 0.0);
            types.Add("Student Assistant", 0.3);
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
            String yearofStudent = Form1.a;
            String typeOfStudent = Form1.b;
            String regular = Form1.c;
            double x = (level[yearofStudent] + register[regular]) * (1 - types[typeOfStudent]);
            double pay = Convert.ToDouble(textPayment.Text);
            if (pay >= x)
            {

                MessageBox.Show("Total Payment:" + x.ToString() + "\n Paid by Student: "+pay.ToString()+"\n Change: " + (pay-x).ToString());

            }
            else
            {
                MessageBox.Show("Your money is not enough");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // ------------------------------------------
            Dictionary<string, double> types = new Dictionary<string, double>();
            types.Add("Regular Student", 0.0);
            types.Add("Student Assistant", 0.3);
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
            String yearofStudent = Form1.a;
            String typeOfStudent = Form1.b;
            String regular = Form1.c;

            label1.Text = Form1.name;
            label2.Text = Form1.studentnumber;
            label3.Text = Form1.gender;
            label4.Text = Form1.a + " - "+ level[yearofStudent];
            label5.Text = Form1.b +  " - " + register[regular];
            label6.Text = Form1.c + " - " + types[typeOfStudent];

            label22.Text = Form1.eventName;
            label21.Text = Form1.eventSpeaker;
            label20.Text = Form1.eventDate;
            label19.Text = Form1.eventPlace;
         

            double x = (level[yearofStudent] + register[regular]) * (1 - types[typeOfStudent]);
            textTotalCost.Text = x.ToString();



        }
    }
}
