using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace acIDS
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Placeholder until database is implemented
            if (textBox1.Text == Program.user.username && textBox2.Text == Program.user.password)
            {
                mainMenu ss = new mainMenu();
                Hide();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Error: Invalid Username and/or Password");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registrationForm ss = new registrationForm();
            Hide();
            ss.Show();
        }
    }
}
