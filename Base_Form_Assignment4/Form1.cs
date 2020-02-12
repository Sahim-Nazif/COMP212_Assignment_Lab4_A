using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Form_Assignment4
{
    public partial class Form1 : Form
    {

        public string firstName;
        public string lastName;
        public string emailAddress;
        public string phoneNumber;
        public string address;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            firstName = txtFName.Text;
            lastName = txtLName.Text;
            emailAddress = txtEmail.Text;
            phoneNumber = txtPhone.Text;
            address = txtAddress.Text;
            
            if (firstName == "" || lastName == "" || emailAddress == "" || address == "")
            {
                MessageBox.Show("Please fill all required fields", "Important Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox.Items.Contains(firstName))
            {
                MessageBox.Show("Your details have already been received ! Thanks." , "Important Query", MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }

            else
            {
                {
                    listBox.Items.Add(firstName);
                    listBox.Items.Add(lastName);
                    listBox.Items.Add(emailAddress);
                    listBox.Items.Add(phoneNumber);
                    listBox.Items.Add(address);

                    foreach (var item in list)
                    {
                        listBox.Items.Add(string.Format(" ", item));
                    }
                }

            }
            ClearField();

        }


        public void ClearField()
        {


        }

    }
}
