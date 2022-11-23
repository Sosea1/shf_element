using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;


namespace shf_element
{
    public partial class Add_element : Form
    {
        Dictionary<string, string> values = new Dictionary<string, string>();
        string group, name;
        string[] parameters;
        string file;
        string temp_values;

        public Add_element()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            P1.Location = new Point(1, 1);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
            
       
        public void copy_file() 
        {
            File.Copy(file, Application.StartupPath + @"\element_picture\" + Path.GetFileName(nameBox.Text) + ".png");
        }

        private void Label1_Next_Click(object sender, EventArgs e)
        {
            if(values_textbox.Text != temp_values)
            {
                dataGrid1_Fill();
            }
            temp_values = values_textbox.Text;
            group = comboBox1.SelectedItem.ToString();
            name = nameBox.Text;
            parameters = params_textbox.Text.Split(',');
            //string[] values = textBox2.Text.Split(',');
            //int i = 0;
           /* foreach (string value in values)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = value;
                i++;
            }*/
            P1.Hide();
            P2.Location = new Point(1, 1);
            P2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            dataGridView2.RowCount = a;
            dataGridView2.ColumnCount = a;
            dataGridView2.RowHeadersVisible = false;
            P2.Hide();
            P3.Location = new Point(1, 1);
            P3.Show();
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            P2.Hide();
            P1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P3.Hide();
            P2.Show();
            
        }

        private void Add_element_Load(object sender, EventArgs e)
        {
            P2.Hide();
            P3.Hide();
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            Insert_Elements insert_Elements = new Insert_Elements();
            List<string> matrix = new List<string>();
            int a =0;
          /*  for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    matrix.Add(dataGridView2[j, i].Value.ToString());
                }
            }*/
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                values.Add(dataGridView1.Rows[i].HeaderCell.Value.ToString(), dataGridView1[0, i].Value == null ? null : dataGridView1[0, i].Value.ToString());
                MessageBox.Show(Expr.Parse(dataGridView1[0, i].Value.ToString()).ToString());
                // Entity expr = dataGridView1[0, i].Value.ToString();
                // MessageBox.Show(expr.EvalNumerical().ToString());
            }
            string[] Matrix = matrix.ToArray();
           // insert_Elements.AddNewElement(group, name, parameters, values, Matrix);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog choose_pic = new OpenFileDialog();
            choose_pic.Filter = "Images files |*.jpg;*.jpeg;*.png;*.svg;*.ico; | All files | *.*";

            if (choose_pic.ShowDialog() == DialogResult.OK)
            {
                file = choose_pic.FileName;

                pictureBox1.Image = Image.FromFile(file);
            }
        }

        public void dataGrid1_Fill()
        {
            string[] values = values_textbox.Text.Split(',');
            int i = 0;
                foreach (string value in values)
                {

                if (dataGridView1.Rows.Count - i == 0) dataGridView1.Rows.Add();
                else
                {

                    if (dataGridView1.Rows[i].HeaderCell.Value.ToString() == value)
                    {
                        i++;
                        continue;
                    }
                }
                        dataGridView1.Rows[i].HeaderCell.Value = value;
                        i++;
                    
                    
                }
           
            for (int j = values.Length; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows.RemoveAt(j);
            }
        }



        //для изображений
        /*try
       {
           copy_file();
       }
       catch (DirectoryNotFoundException)
       {
           Directory.CreateDirectory(Application.StartupPath + @"\element_picture\");
           copy_file();
       }
       catch (Exception)
       {
           MessageBox.Show("Произошла ошибка");

       }
       MessageBox.Show("Успешно добавлено");*/

    }
}
