using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;


namespace WindowsFormsApp1
{
     
    public partial class Form1 : Form
    {
         float point=0;
    
        XDocument xDoc = null;
        struct Body
        {
            public int High;
            public float Weight;
            public int age;
        }
        Point pop;
        Body user1 = new Body();
        string[] item = new string[5];
        int m = 0;
        string town;
        string[] qw = new string[3];  // вопрос
     
        // варианты ответа
        string[] answ1 = new string[3];

        string[] answ2 = new string[3];
        string[] answ3 = new string[3];
        string[] right = new string[3];



        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }
        private void showBody()
        {
            // ищем узел <head>
            /*  XmlDocument doc = new XmlDocument();
              doc.Load ("C:/Users/workplace/Documents/Visual Studio 2015/Projects/WindowsFormsApplication5/WindowsFormsApplication5/bin/Debug/XMLFile1.xml");
              foreach (XmlNode node in doc.DocumentElement.SelectNodes("first"))
              {*/
            pictureBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            town = textBox1.Text;

            label1.Visible = true;
            textBox3.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            textBox4.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true; 
            label5.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Count()
        {
            point = 0;
            if (checkBox2.Checked)
            {
                switch (user1.age)
                {
                    case 2:

                        if ((user1.High > 85 && user1.High < 92) && (user1.Weight > 11.80 && user1.Weight < 14.30))
                        {
                        }
                        else
                        {
                            point++;
                        }

                        break;


                    case 3:
                        if ((user1.High > 92 && user1.High < 99) && (user1.Weight > 13.20 && user1.Weight < 16.30))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 4:
                        if ((user1.High > 98 && user1.High < 108) && (user1.Weight > 14.90 && user1.Weight < 19.30))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;

                    case 5:
                        if ((user1.High > 105 && user1.High < 116) && (user1.Weight > 16.60 && user1.Weight < 22.70))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 6:
                        if ((user1.High > 111 && user1.High < 121) && (user1.Weight > 18.70 && user1.Weight < 25.10))
                        {
                        }
                        else
                        {
                          point++;
                        }
                        break;
                    case 7:
                        if ((user1.High > 118 && user1.High < 129) && (user1.Weight > 20.60 && user1.Weight < 29.40))
                        {
                        }
                        else
                        {
                           point++;
                        }
                        break;
                    case 8:
                        if ((user1.High > 124 && user1.High < 135) && (user1.Weight > 23.20 && user1.Weight < 32.60))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 9:
                        if ((user1.High > 129 && user1.High < 141) && (user1.Weight > 24.70 && user1.Weight < 36.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 10:
                        if ((user1.High > 135 && user1.High < 147) && (user1.Weight > 28.50 && user1.Weight < 39.00))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 11:
                        if ((user1.High > 138 && user1.High < 149) && (user1.Weight > 29.8 && user1.Weight < 42.10))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 12:
                        if ((user1.High > 143 && user1.High < 158) && (user1.Weight > 33.8 && user1.Weight < 48.6))
                        {
                        }
                        else
                        {
                           point++;
                        }
                        break;
                    case 13:
                        if ((user1.High > 149 && user1.High < 165) && (user1.Weight > 40.6 && user1.Weight < 57.1))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 14:
                        if ((user1.High > 155 && user1.High < 170) && (user1.Weight > 43.8 && user1.Weight < 58.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 15:
                        if ((user1.High > 159 && user1.High < 175) && (user1.Weight > 47.9 && user1.Weight < 64.8))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 16:
                        if ((user1.High > 168 && user1.High < 179) && (user1.Weight > 54.5 && user1.Weight < 69.9))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 17:
                        if ((user1.High > 170 && user1.High < 180) && (user1.Weight > 58.00 && user1.Weight < 75.5))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;

                }
            }
            if (checkBox1.Checked)
            {
                switch (user1.age)
                {
                    case 2:

                        if ((user1.High > 82 && user1.High < 90) && (user1.Weight > 10.90 && user1.Weight < 14.15))
                        {
                        }
                        else
                        {
                            point++;
                        }

                        break;


                    case 3:
                        if ((user1.High > 91 && user1.High < 99) && (user1.Weight > 13.30 && user1.Weight < 16.10))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 4:
                        if ((user1.High > 95 && user1.High < 106) && (user1.Weight > 13.80 && user1.Weight < 18.00))
                        {
                        }
                        else
                        {
                          point++;
                        }
                        break;

                    case 5:
                        if ((user1.High > 104 && user1.High < 114) && (user1.Weight > 16.00 && user1.Weight < 22.70))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 6:
                        if ((user1.High > 111 && user1.High < 120) && (user1.Weight > 18.20 && user1.Weight < 24.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 7:
                        if ((user1.High > 113 && user1.High < 127) && (user1.Weight > 20.50 && user1.Weight < 28.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 8:
                        if ((user1.High > 124 && user1.High < 134) && (user1.Weight > 22.50 && user1.Weight < 32.30))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 9:
                        if ((user1.High > 128 && user1.High < 140) && (user1.Weight > 25.10 && user1.Weight < 36.90))
                        {
                        }
                        else
                        {
                           point++;
                        }
                        break;
                    case 10:
                        if ((user1.High > 134 && user1.High < 147) && (user1.Weight > 27.90 && user1.Weight < 40.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 11:
                        if ((user1.High > 138 && user1.High < 152) && (user1.Weight > 30.4 && user1.Weight < 44.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 12:
                        if ((user1.High > 146 && user1.High < 160) && (user1.Weight > 36.5 && user1.Weight < 51.5))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 13:
                        if ((user1.High > 151 && user1.High < 163) && (user1.Weight > 40.4 && user1.Weight < 56.6))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 14:
                        if ((user1.High > 154 && user1.High < 167) && (user1.Weight > 44.6 && user1.Weight < 58.50))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 15:
                        if ((user1.High > 156 && user1.High < 167) && (user1.Weight > 47.0 && user1.Weight < 62.3))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                    case 16:
                        if ((user1.High > 157 && user1.High < 167) && (user1.Weight > 48.8 && user1.Weight < 62.6))
                        {
                        }
                        else
                        {
                           point++;
                        }
                        break;
                    case 17:
                        if ((user1.High > 158 && user1.High < 168) && (user1.Weight > 49.20 && user1.Weight < 63.5))
                        {
                        }
                        else
                        {
                            point++;
                        }
                        break;
                }
            }
            xDoc = new XDocument(
                new XElement("User",
                    new XElement("user" , point)));
            xDoc.Save("XMLFile2.xml");
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            
            user1.High = int.Parse(textBox2.Text);
            user1.Weight = float.Parse(textBox3.Text);
            user1.age = int.Parse(textBox4.Text);
            Count();
            Form ifrm = new Form2();
            ifrm.Show(); // отображаем Form2
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
