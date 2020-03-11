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
            button1.Text = "Лазить по ссылке";
            button2.Text = "Анализировать тексты";
            button3.Text = "Поиск";
            button5.Text = "очистить БД";
            button1.Click += Button1_Click;
            button2.Click += button2_Click;
            button3.Click += Button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;

            CheckArticleListButton();

            listBox2.MouseClick+= listBox2_SelectedItem;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void listBox2_SelectedItem(object sender, EventArgs e)
        {
            if(listBox2.Items.Count != 0) 
                textBox4.Text = listBox2.SelectedItem.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Выполнение";
            listBox2.Items.Clear();
            button3.Enabled = false;
            try
            {
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
                button3.Text = "Поиск";  
            }

            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label1.Text = textBox1.Text;
        }

        private void DisableWorkTextButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void EnableWorkTextButton()
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Выполнение";
            bool AllRight = true;
            DisableWorkTextButton();
            try
            {
                if(int.Parse(textBox2.Text) > 0)
                    OP.Crawl(textBox1.Text, int.Parse(textBox2.Text));
            }
            catch
            {
                AllRight = false;
            }
            finally
            {
                EnableWorkTextButton();
                button1.Text = "Лазить по ссылке";
            }

            if(AllRight)
                listBox1.Items.Add("выполнение \"лазанье\" по ссылке "+textBox1.Text);
            else
                listBox1.Items.Add("ошибка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Выполнение анализа";
            DisableWorkTextButton();
            try
            {
                OP.ExtractEntities();

            }
            finally
            {
                EnableWorkTextButton();
                button2.Text = "Анализировать тексты";
            }

            listBox1.Items.Add("выполнен анализ текстов");
        }


        private void CheckArticleListButton()
        {
            if(ArticlsList.Position == 0)
            {
                button4.Enabled = false;
            }
            else
            {
                if(!button4.Enabled) button4.Enabled = true;
            }

            if(ArticlsList.Position == ArticlsList.Articls.Count-1 || ArticlsList.Articls.Count == 0)
            {
                button7.Enabled = false;
            }
            else
            {
                if (!button7.Enabled) button7.Enabled = true;
            }
        }
        private void ShowCurrentArticle()
        {
            listBox3.Items.Clear();
            textBox5.Text = "";
            var pos = ArticlsList.Position;
            var len = ArticlsList.Articls.Count;
            
            textBox5.Text = ArticlsList.Articls[ArticlsList.Position];
            listBox3.Items.Add(ArticlsList.Articls[ArticlsList.Position]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //previos
            ArticlsList.Position--;
            CheckArticleListButton();
            ShowCurrentArticle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //update
            ArticlsList.Update();
            CheckArticleListButton();
            if (ArticlsList.Articls.Count != 0)
            {
                ShowCurrentArticle();
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //next
            ArticlsList.Position++;
            CheckArticleListButton();
            if(button7.Enabled)
                ShowCurrentArticle();
        }
    }
}
