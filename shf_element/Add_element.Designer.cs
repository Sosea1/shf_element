namespace shf_element
{
    partial class Add_element
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Params = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Двухполюсники",
            "Четырехполюсники",
            "Шестиполюсники",
            "Восьмиполюсники"});
            this.comboBox1.Location = new System.Drawing.Point(111, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбирете группу";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(305, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(111, 392);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(177, 20);
            this.textBox11.TabIndex = 46;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(111, 360);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(177, 20);
            this.textBox12.TabIndex = 45;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 20);
            this.textBox5.TabIndex = 44;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(111, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 20);
            this.textBox6.TabIndex = 43;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(111, 275);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(177, 20);
            this.textBox7.TabIndex = 42;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(111, 243);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(177, 20);
            this.textBox8.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 20);
            this.textBox4.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "label12";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(111, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(177, 20);
            this.nameBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Название";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Ввод параметров";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Name,
            this.Params,
            this.Values,
            this.Matrix});
            this.dataGridView1.Location = new System.Drawing.Point(481, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 437);
            this.dataGridView1.TabIndex = 49;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа элемента";
            this.Group.Items.AddRange(new object[] {
            "Двухполюсник",
            "Четырехполюсник",
            "Шестиполюсник",
            "Восьмиполюстник"});
            this.Group.Name = "Group";
            // 
            // Name
            // 
            this.Name.HeaderText = "Название элемента";
            this.Name.Name = "Name";
            // 
            // Params
            // 
            this.Params.HeaderText = "Параметры элемента";
            this.Params.Name = "Params";
            // 
            // Values
            // 
            this.Values.HeaderText = "Промежуточные значения";
            this.Values.Name = "Values";
            // 
            // Matrix
            // 
            this.Matrix.HeaderText = "Матрица";
            this.Matrix.Name = "Matrix";
            // 
            // Add_element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Text = "Add_element";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Params;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrix;
    }
}