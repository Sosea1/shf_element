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

namespace shf_element
{
    public partial class Add_element : Form
    {
        string path_project= @"D:\projects VScode\shf_debuger\shf_debuger\bin\Debug\";
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
                File.Copy(file, path_project + Path.GetFileName(file));
                pictureBox1.Image = Image.FromFile(file);
            }

        }
    }
}
