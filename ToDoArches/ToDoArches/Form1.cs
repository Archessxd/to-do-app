using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoArches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                string eklenecekItem = textBox1.Text;
                listBox1.Items.Add(eklenecekItem);
                textBox1.Text = null;
            } 
            catch  (Exception sa )
            {
                MessageBox.Show(sa.Message);
            }
        }

        private void moveToDoing_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("please select a work");
                }
                else { 
                    listBox2.Items.Add(listBox1.SelectedItem);

                    listBox1.Items.Remove(listBox1.SelectedItem);
                }

            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
        }

        private void moveToDone_BTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("please select a work");
                }
                else
                {
                    listBox3.Items.Add(listBox1.SelectedItem);

                    listBox1.Items.Remove(listBox1.SelectedItem);
                }

            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
        }

        private void moveToDone2_BTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox2.SelectedItem == null)
                {
                    MessageBox.Show("please select a work");
                }
                else
                {
                    listBox3.Items.Add(listBox2.SelectedItem);

                    listBox2.Items.Remove(listBox2.SelectedItem);
                }

            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
        }
    }
}
