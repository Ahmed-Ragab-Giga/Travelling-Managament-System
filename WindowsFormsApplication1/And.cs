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
    public partial class And : Form
    {
        public And()
        {
            InitializeComponent();
        }

        private void button_display_Click(object sender, EventArgs e)
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

                if (dataGridView3.ColumnCount == 0)
                {
                    dataGridView3.Columns.Add("", v1);
                    dataGridView3.Columns.Add("", v2);
                    dataGridView3.Columns.Add("", v3);
                }


            }

            string choice1 = comboBox1.SelectedItem.ToString();
            string col1 = comboBox2.SelectedItem.ToString();
            string search_data1 = textBox1.Text;
            string choice2 = comboBox3.SelectedItem.ToString();
            string col2 = comboBox4.SelectedItem.ToString();
            string search_data2 = textBox2.Text;

            if (choice1 == "=" && col1 == "1" && choice2 == "=" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();
                int x = 0;
                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);
                    
                    if (int.Parse(search_data1) == int.Parse(unit_list[i].var1) && int.Parse(search_data2) == int.Parse(unit_list[i].var3))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                        x = 1;
                        break;
                    }
                }
                if(x==0)
                {
                    MessageBox.Show("This information does not exist");
                }
                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }


            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////   

            else if (choice1 == "=" && col1 == "1" && choice2 == ">" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();
                
                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(search_data1) == int.Parse(unit_list[i].var1) && int.Parse(unit_list[i].var3) >  int.Parse(search_data2) )
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }
               
                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == "=" && col1 == "1" && choice2 == "<" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(search_data1) == int.Parse(unit_list[i].var1) && int.Parse(unit_list[i].var3) < int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == ">" && col1 == "1" && choice2 == "=" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) > int.Parse(search_data1) && int.Parse(unit_list[i].var3) == int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == ">" && col1 == "1" && choice2 == "!=" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) > int.Parse(search_data1) && int.Parse(unit_list[i].var3) != int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == ">" && col1 == "1" && choice2 == ">" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) > int.Parse(search_data1) && int.Parse(unit_list[i].var3) > int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == ">" && col1 == "1" && choice2 == "<" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) > int.Parse(search_data1) && int.Parse(unit_list[i].var3) < int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == "<" && col1 == "1" && choice2 == "=" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) < int.Parse(search_data1) && int.Parse(unit_list[i].var3) == int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

           ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == "<" && col1 == "1" && choice2 == "!=" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) < int.Parse(search_data1) && int.Parse(unit_list[i].var3) != int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == "<" && col1 == "1" && choice2 == ">" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) < int.Parse(search_data1) && int.Parse(unit_list[i].var3) > int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (choice1 == "<" && col1 == "1" && choice2 == "<" && col2 == "3")
            {

                List<Unit> unit_list_new = new List<Unit>();

                for (int i = 0; i < unit_list.Count; i++)
                {
                    // MessageBox.Show("var1 " + unit_list[i].var1 + "  var2  " + unit_list[i].var2);

                    if (int.Parse(unit_list[i].var1) < int.Parse(search_data1) && int.Parse(unit_list[i].var3) < int.Parse(search_data2))
                    {
                        Unit Unew = new Unit(unit_list[i].var1, unit_list[i].var2, unit_list[i].var3);
                        unit_list_new.Add(Unew);
                    }
                }

                dataGridView3.Rows.Clear();

                for (int i = 0; i < unit_list_new.Count; i++)
                {
                    dataGridView3.Rows.Add(new string[] { unit_list_new[i].var1, unit_list_new[i].var2, unit_list_new[i].var3 });
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        }
    }
}
