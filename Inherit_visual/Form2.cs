using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inherit_visual
{
    public partial class Form2 : Base_Form_Assignment4.Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFName.Text=="")
                {
                    MessageBox.Show("Please enter your first name !");
                }

                //reading the values from the combo box in the button handler
                KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)comboBox.SelectedItem;

                string key = selectedItem.Key.ToString();
                string value = selectedItem.Value.ToString();
                if (listBox.Items.Contains(key))
                {
                    MessageBox.Show("You have already selected your profession !", "Important Query", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    listBox.Items.Add("--------------------");
                    listBox.Items.Add(key);

                    string name = txtFName.Text;
                    string message = "Dear " + name + "!" + "\nWe have received your application for\nthe position of " + key
                         + "\n\nWe will review your application and contact  you soon !";
                    lblDisplay.Text = message;
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Please select Your Profession !");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //populating the combo box
            comboBox.Items.Add(new KeyValuePair<string, string>("Project Manager", "0"));
            comboBox.Items.Add(new KeyValuePair<string, string>("Business Analyst", "1"));
            comboBox.Items.Add(new KeyValuePair<string, string>("Software Developer", "2"));
            comboBox.Items.Add(new KeyValuePair<string, string>("Web Developer", "3"));
            comboBox.Items.Add(new KeyValuePair<string, string>("SQL Developer", "4"));
            comboBox.Items.Add(new KeyValuePair<string, string>("Software Tester", "5"));

           

            comboBox.DisplayMember = "key";
            comboBox.ValueMember = "value";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Have a nice day !" , "Exit Application", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
