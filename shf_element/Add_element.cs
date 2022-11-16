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
            Insert_Elements el = new Insert_Elements();
            el.Trf();
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
}
