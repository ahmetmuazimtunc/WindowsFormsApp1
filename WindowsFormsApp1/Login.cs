using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
        try
            {

                try
                {
                    
                if (username.Text != null && password.Text == null)
                {

                MessageBox.Show("Please enter an password");
                }
                else if (username.Text == null && password.Text != null)
                {
                        MessageBox.Show("Please enter an password");
                }


                }
                catch (Exception)
                {

                    MessageBox.Show("System Error");
                }

                if (username.Text == "admin" && password.Text == "1")
                {
                   home form2 = new home();
                    form2.Show();
                    this.Hide();

                }
                

                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    password.Text = null;
                    username.Text = null;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("System Error");
            }


        }

       


    }
}
