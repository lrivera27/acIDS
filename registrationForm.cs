using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace acIDS
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            this.Text = "Registration Page";
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //registrationFormExtension tools = new registrationFormExtension();
            string[] arr = { firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text };
            bool check = true;
            for(int i = 0; i < arr.Length; i++)
            {
                if(tools.validateString(arr[i]) == false)
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Program.user.firstName = arr[0];
                Program.user.lastName = arr[1];
                Program.user.username = arr[2];
                Program.user.password = arr[3];
                loginForm ss = new loginForm();
                this.Close();
                ss.Show();
            }
            else
                MessageBox.Show("Error: Please don't use any spaces, special character. Limit of value cannot exceed from 10 characters");
        }
    }
}
