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
    
    public partial class Form2 : Form
    {
        XDocument xDoc = null;
       XmlTextWriter xmlWriter = new XmlTextWriter("results.xml", Encoding.Unicode);
        XmlDocument document = new XmlDocument();
        DataTable dt = new DataTable("answer");
        DataRow relation;
        float points = 0;
        float bal = 0;
        string[] qw1 = new string[8];
        object[] useranswer = new object[8];
        string[] answ1 = new string[16];
        int count = 0;
        string path=" ";
        string[] right = new string[8];
        int p = 0;
        int blocks =1;
        int c = 0;
        public Form2()
        {
            InitializeComponent();
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("head");
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
           
            showQw();
        }
        private void showQw()
        {
            p = 0; c = 0; count = 0;
            Array.Clear(qw1, 0, qw1.Length);
            Array.Clear(useranswer, 0, useranswer.Length);
            Array.Clear(answ1, 0, answ1.Length);
            Array.Clear(right, 0, right.Length);
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");
            if (path == " ")
            {
                path = "first";

            }

            foreach (XmlNode node in doc.DocumentElement.SelectNodes(path))
            {

                foreach (XmlNode childnode in node.SelectNodes("task"))
                {
                    foreach (XmlNode child in childnode.ChildNodes)
                    {
                        // если узел - company
                        if (child.Name == "qw")
                        {
                            qw1[count] = child.InnerText;
                            count++;

                        }
                        
                        // если узел age
                        if (child.Name == "an")
                        {
                            right[p] = child.InnerText;
                            p++;
                        }
                        // если узел age
                        if (child.Name == "varan")
                        {
                            answ1[c] = child.InnerText;
                            c++;
                        }
                    }

                }

            }
            count = 0;
            shownext();

        }
        private void sumpoints()
        {
           

            if (blocks == 3)
            {
                for (int i = 0; i < useranswer.Length; i++)

                {
                    dt.Columns.Add("user" + blocks + "." + i);

                }
                for (int i = 0; i < p ; i++)
                {
                    // dt.Columns.Add("user" + blocks + "." + i);

                    

                    if (string.Equals(right[i], useranswer[i]))
                    {
                        points++;
                    }
                }

                dt.Rows.Add(dt.NewRow().ItemArray = useranswer.Cast<object>().ToArray());
            }
            else
            {
                for (int i = 0; i < useranswer.Length; i++)

                {
                    dt.Columns.Add("user" + blocks + "." + i);
                    
                }
                    for (int i = 0; i < qw1.Length; i++)

                {
                    /* dt.Columns.Add("user" + blocks + "." + i);
                     */

                    //  dt.Columns.Add("user" + blocks + "." + i);
              /*      DataColumn idColumn = new DataColumn("id" + blocks + "." + i,
                    Type.GetType("System.Int32"));
                    idColumn.AutoIncrement = true;
                    idColumn.AutoIncrementSeed = 10;
                    dt.Columns.Add(idColumn);
 relation = dt.NewRow();
                  
                    relation.ItemArray= useranswer;
                    dt.Rows.Add(relation);
                    DataColumn firstNameColumn = new DataColumn("Item",
                        Type.GetType("System.String"));
                    dt.Columns.Add(firstNameColumn);*/
                   

                    if (string.Equals(right[i], useranswer[i]))
                    {
                        points++;
                    }
                }
                dt.Rows.Add(dt.NewRow().ItemArray = useranswer.Cast<object>().ToArray());

            }

            
        }

        ///
        private void persent()
        {
                 points = points / 20;
                    points *= 100;
                   
            
            
        }
        private void shownext()
        {
             if (count < qw1.Length && qw1[count] != null)
            {
               
                
                    label1.Text = qw1[count];
                    button1.Text = answ1[count*2];
                    button2.Text = answ1[count*2 + 1];

                
            }
            else
            {
                sumpoints();
                blocks++;
                showblock();
                if (blocks > 3)
                {
                    if (points<= 12)
                    {
                        dt.WriteXml("results.xml", XmlWriteMode.WriteSchema);
                        Positiveresults();
                        System.Environment.Exit(0);
                    }

                    if (points > 12)
                    {
                        dt.WriteXml("results.xml", XmlWriteMode.WriteSchema);

                        MustBeill();
                        System.Environment.Exit(0);
                    }
                }
            }

        }
       

        private void showblock()
        {
            switch (blocks)
            {
                case 2:
                    path = "second";
                    break;
                case 3:
                    path = "third";
                    break;
            }
            showQw();
        }

        private void Positiveresults()
        {
           
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile2.xml");
            foreach (XmlNode node in doc.DocumentElement.SelectNodes("user"))
            {
                bal =float.Parse(node.InnerText);
            }
            points += bal;
             persent();

            MessageBox.Show("Низкий риск инфецирования эхинококком \n"+points.ToString() + " %", "Результат тестирования", MessageBoxButtons.OK);
       
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            if (count < qw1.Length && qw1[count]!=null)
            {  
                useranswer[count] = button2.Text;
                count++;
                shownext();
            }
            else
            {
                sumpoints();
                blocks++;
                showblock();
                if (blocks > 3)
                {
                    if (points <= 12)
                    {
                       
                        Positiveresults();
                        System.Environment.Exit(0);

                    }
                    if(points >12)
                    {
                       
                        MustBeill();
                        System.Environment.Exit(0);
                    }
                }
            }
        }
        private void MustBeill()
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile2.xml");
            foreach (XmlNode node in doc.DocumentElement.SelectNodes("user"))
            {
                bal= float.Parse(node.InnerText);
            }
            points += bal;
            persent();
            MessageBox.Show("Высокий риск инфецирования эхинококком, срочно обратитесь к врачу!\n" + points.ToString()+" %", "Результат тестирования", MessageBoxButtons.OK);
           
   
    }
         private void back()
        {
            count--;
            shownext();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (count < qw1.Length && qw1[count] != null)
            {
                
                useranswer[count] = button1.Text;
                count++;
                shownext();

            }
            else
            {
                sumpoints();
                blocks++;
                showblock();
                if (blocks > 3)
                {

                    if (points <= 12)
                    {
                        
                        Positiveresults();
                        System.Environment.Exit(0);
                    }
                    if(points >12)
                    {
                        
                        MustBeill();
                        System.Environment.Exit(0);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            back();
        }
    }
}
