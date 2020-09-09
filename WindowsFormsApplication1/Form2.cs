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
   
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            List<Unit> unit_list = new List<Unit>();
            XmlDocument dc = new XmlDocument();
            dc.Load("XMLFile1.xml");
            XmlNodeList Rlist = dc.GetElementsByTagName("Row");
            for (int d = 0; d < Rlist.Count; d++)
            {
                XmlNodeList c = Rlist[d].ChildNodes;
                string v1 = c[0].Name;
                string vv1 = c[0].InnerText;
                string v2 = c[1].Name;
                string vv2 = c[1].InnerText;
                string v3 = c[2].Name;
                string vv3 = c[2].InnerText;

                Unit Uorignal = new Unit(vv1, vv2, vv3);
                unit_list.Add(Uorignal);

                if (dataGridView2.ColumnCount == 0)
                {
                    dataGridView2.Columns.Add("", v1);
                    dataGridView2.Columns.Add("", v2);
                    dataGridView2.Columns.Add("", v3);
                }
               
              
            }

           /////////////////////////////////////////////////////////////
            string choice = comboBox1.SelectedItem.ToString();
            string col = comboBox2.SelectedItem.ToString();
            
            
            if (choice == "=" && col == "1")
            {


                string search_data = textBox1.Text;
                    List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                    {
                       // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                        if (int.Parse(search_data) == int.Parse(unit_list[i].var1))
                        {                       
                            Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                            unit_list_new.Add(Unew);
                           
                        }
                     


                    }
                    dataGridView2.Rows.Clear();

                    for (int i = 0; i < unit_list_new.Count; i++)
                    {
                        dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                    }


            }
            
       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////    
            if (choice == "=" && col == "2")
            {
                string search_data = textBox1.Text;   
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if (search_data == unit_list[i].var2)
                     {
                         Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                         unit_list_new.Add(Unew);
                     }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (choice == "=" && col == "3")
            {
                string search_data = textBox1.Text;
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if (int.Parse(search_data) == int.Parse(unit_list[i].var3))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (choice == ">" && col == "1")
            {
                string search_data = textBox1.Text;
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if ( int.Parse(unit_list[i].var1) > int.Parse(search_data))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice == ">" && col == "3")
            {
                string search_data = textBox1.Text;
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if (int.Parse(unit_list[i].var3) > int.Parse(search_data))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (choice == ">" && col == "2")
            {
                MessageBox.Show("this constrain can not be used in strings");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice == "<" && col == "3")
            {
                string search_data = textBox1.Text;
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if (int.Parse(unit_list[i].var3) < int.Parse(search_data))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice == "<" && col == "1")
            {
                string search_data = textBox1.Text;
                List<Unit> unit_list_new = new List<Unit>();
                for (int i = 0; i < unit_list.Count; i++)
                {
                    //MessageBox.Show(" data  " + search_data + "  var2  " + unit_list[i].var2);
                    if (int.Parse(unit_list[i].var1) < int.Parse(search_data))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }

               
            else if (choice == "In" && col == "1")
            {
                
                List <int> numbers= new List<int>();
                int s;
                int search_data = int.Parse(textBox1.Text);
                while(search_data > 0)
                {
                    s = search_data % 10;
                    numbers.Add(s);
                    search_data =search_data / 10;
                }
                List<Unit> unit_list_new = new List<Unit>();
                
                for (int j = (numbers.Count)-1 ; j >= 0 ; j--)
                { 
                    for (int i = 0; i < unit_list.Count; i++)
                    {
                        
                        if (int.Parse(unit_list[i].var1) == numbers[j])
                        {
                            Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                            unit_list_new.Add(Unew);
                            break;
                        }
                        
                    }
                  
                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

               
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //  ????????????????????????????????
            else if (choice == "In" && col == "3")
            {
                List<int> numbers = new List<int>();
                int s;
                int search_data = int.Parse(textBox1.Text);
                while (search_data > 0)
                {
                    s = search_data % 10;
                    numbers.Add(s);
                    s = search_data % 10;
                    numbers.Add(s);

                    search_data = search_data / 100;
                }
                List<Unit> unit_list_new = new List<Unit>();

                for (int j = (numbers.Count) - 1; j >= 0; j--)
                {
                    for (int i = 0; i < unit_list.Count; i++)
                    {

                        if (int.Parse(unit_list[i].var3) == numbers[j])
                        {
                            Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                            unit_list_new.Add(Unew);
                            break;
                        }

                    }

                }
                dataGridView2.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView2.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }

            }


             textBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // dataGridView2.Rows.Clear();
            

              //  dataGridView2.Rows.Add(new string[] { vv1, vv2, vv3 });

            
        }
    }
}
