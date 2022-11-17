using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace shf_element
{
    public partial class Add_element : Form
    {
        
        string file;
        public Add_element()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose_pic = new OpenFileDialog();
            choose_pic.Filter = "Images files |*.jpg;*.jpeg;*.png;*.svg;*.ico; | All files | *.*";
            
            if (choose_pic.ShowDialog() == DialogResult.OK)
            {
                file = choose_pic.FileName;

                pictureBox1.Image = Image.FromFile(file);
            }

        }
        public void copy_file() 
        {
            System.IO.File.Copy(file, Application.StartupPath + @"\element_picture\" + Path.GetFileName(nameBox.Text) + ".png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] values = textBox2.Text.Split(',');
            int i = 0;
            foreach (string value in values)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = value;
                i++;
            }

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
        }

        private void Add_element_Load(object sender, EventArgs e)
        {
            P3.Dock = DockStyle.Fill;
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
