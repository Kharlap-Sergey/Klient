using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Выполнить";
            button3.Text = "Выполнить";
            button5.Text = "очистить БД";
            button1.Click += Button1_Click;
            button3.Click += Button3_Click;
            button5.Click += button5_Click;
            listBox2.MouseClick+= listBox2_SelectedItem;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void listBox2_SelectedItem(object sender, EventArgs e)
        {
            
            textBox4.Text = listBox2.SelectedItem.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Выполнение";
            //listBox1.Items.Add(textBox1.Text)
            listBox2.Items.Clear();
            //var button1 = sender as Button;
            button3.Enabled = false;
            try
            {
                //var boof = OP.FindByWord(textBox3.Text)
                textBox4.Text = textBox3.Text;
                if(checkBox3.Checked)
                    foreach (var uri in OP.FindByEntity(textBox3.Text))
                        listBox2.Items.Add(uri);
                if (checkBox4.Checked)
                    foreach (var uri in OP.FindByWord(textBox3.Text))
                        if(!listBox2.Items.Contains(uri))
                            listBox2.Items.Add(uri);

            }
            finally
            {
                button3.Enabled = true;
                button3.Text = "Выполнено";  
            }

            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label1.Text = textBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Выполнение";
            //listBox1.Items.Add(textBox1.Text);
            //var button1 = sender as Button;
            button1.Enabled = false;
            try
            {
                if(checkBox1.Checked)
                    OP.Crawl(textBox1.Text, int.Parse(textBox2.Text));
                if (checkBox2.Checked)
                    OP.ExtractEntities();
                //MessageBox.Show("egwergwerg");

            }
            finally
            {
                button1.Enabled = true;
                button1.Text = "Выполнено";
            }

            listBox1.Items.Add("выполненение \"лазанье\" по ссылке "+textBox1.Text);
            //label1.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OP.DeleteTabels();
        }
    }
}
