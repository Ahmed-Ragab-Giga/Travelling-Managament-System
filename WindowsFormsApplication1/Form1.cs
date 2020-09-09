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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            XmlDocument d = new XmlDocument();
            d.Load("XMLFile1.xml");
            XmlNodeList Rlist = d.GetElementsByTagName("Row");
             for (int i = 0; i < Rlist.Count; i++) 
            {
                XmlNodeList c = Rlist[i].ChildNodes;
                string id = c[0].Name; 
                string cid = c[0].InnerText;
                string name = c[1].Name;
                string cname = c[1].InnerText;
                string total = c[2].Name;
                string ctotal = c[2].InnerText;
                if (dataGridView1.ColumnCount == 0)
                {
                    dataGridView1.Columns.Add("", id);
                    dataGridView1.Columns.Add("", name);
                    dataGridView1.Columns.Add("", total);
                }
                dataGridView1.Rows.Add(new string[] { cid, cname, ctotal });
                
            }
            

           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // foreach(DataGridViewRow row in dataGridView1.Rows)
            //{
            //     row.Cells[dataGridView1.Columns["id"].Index].Value= (Convert.ToInt64(row.Cells[dataGridView1.Columns]))
            //}

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
         
            MessageBox.Show("The Sum is " + sum);
        }

        private void button3_avg_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double count = dataGridView1.Rows.Count-1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            double avg = sum / count;
            MessageBox.Show("The average is " + avg);
        }

        private void button_constrain_Click(object sender, EventArgs e)
        {
            Form2 f =new Form2();
            f.Show();
        }

        private void btn_OR_Click(object sender, EventArgs e)
        {

        }

        private void button_and_Click(object sender, EventArgs e)
        {
            And f = new And();
            f.Show();
        }
    }
}
