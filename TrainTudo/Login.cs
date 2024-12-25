using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTudo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if(UNameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Train Obj = new Train();  // Train.cs를 생성함
                Obj.Show();               //Train.cs을 보여줌
                this.Hide();              //자기자신(Login.cs)를 숨김
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}
