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
        public static string a = "";
        public static string b = "";
        public static string c = "";
        public static string name = "";
        public static string gender = "";
        public static string yearlevel = "";
        public static string studentnumber = "";
        public static string eventName = "";
        public static string eventSpeaker= "";
        public static string eventDate = "";
        public static string eventPlace = "";



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




            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            name = textBox1.Text;
            studentnumber = textBox2.Text;
            gender = textBox3.Text;

            a = yearLevel.Text;
            b = studentType.Text;
            c = registrationType.Text;
            
            
            
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string,string> events = new Dictionary<string, string>();
            events.Add("Google Glass Project: Better but banned!",@"Rosa Parks
June 5, 2022
LCT Building");
            events.Add("Future of Communication", @"Jerry Hanna
July 16, 2022
LCT Building");
            events.Add("Distance Education", @"Martha Thompson
August 20, 2022
TYK Buildings");
            events.Add("Importance of Corporate Communications", @"Percy Jackson
September 31, 2022
Engineering Building"
);
            events.Add("Child Labor and related issues", @"Pedro San Vicente
October 19, 2022
TYK Building");
            events.Add("Smart antenna for mobile communication", @"Juan Dela Cruz
November 10, 2022
Engineering Building");
            events.Add("Low energy efficiency wireless", @"Harry Potter
December 9, 2022
Engineering Building");
            events.Add("Communication network design", @"Sheldon Copper
January 7, 2023
Engineering Building");
            events.Add("Plastic Solar Cell Technology", @"Walter White
February 14, 2023
Engineering Building");

            string currentText = comboBox1.SelectedItem.ToString();
            String[] eventsx = events[currentText].Split('\n');
            textSpeaker.Text = eventsx[0];
            eventSpeaker = eventsx[0];
            textDate.Text = eventsx[1];
           eventDate = eventsx[1];
            textPlace.Text = eventsx[2];
            eventPlace= eventsx[2];
            
            
        }
    }
}
