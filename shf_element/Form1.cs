using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace shf_element
{
  

   

    public partial class Form1 : Form
    {
       








        object[] list1 = new object[] {"Нагрузка","Ёмкостная нагрузка ЛП","Индуктивная нагрузка ЛП","Разомкнутый конец МПЛ с учётом краевой ёмкости"};
        object[] list2 = new object[] { "Нагрузка", "Ёмкостная нагрузка ЛП", "Индуктивная нагрузка ЛП", "Разомкнутый конец МПЛ с учётом краевой ёмкости" };
        object[] list3 = new object[] { "Нагрузка", "Ёмкостная нагрузка ЛП", "Индуктивная нагрузка ЛП", "Разомкнутый конец МПЛ с учётом краевой ёмкости" };
        object[] list4 = new object[] { "Нагрузка", "Ёмкостная нагрузка ЛП", "Индуктивная нагрузка ЛП", "Разомкнутый конец МПЛ с учётом краевой ёмкости" };
        public Form1()
        {
            InitializeComponent();
           
            comboBox1.SelectedIndex = 0;
            
        }

      
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(list1);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(list1);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(list1);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(list1);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1) ;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1();
            cl.Trf();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_element form2 = new Add_element();
            form2.Show();
        }
    }
    public class Elements
    {
        public int element_group { get; set; }

        // public int element_type { get; set; }
        public string name { get; set; }
        public string k_reflaction { get; set; }
        // public string R { get; set; }
        //  public string C { get; set; }
        //  public string L { get; set; }


    }

}
