using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketOffice
{
    public partial class EnteringForm : Form
    {
        
        public EnteringForm()
        {
            InitializeComponent();
            InitialData();
        }

        private void InitialData()
        {
            User.isAdmin = false;
            User.isPassenger = false;
        }
        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
                LoginTextBox.Text = "Введите Email";
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text == "Введите Email")
            LoginTextBox.Text = "";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Введите пароль")
                PasswordTextBox.Text = "";
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
                PasswordTextBox.Text = "Введите пароль";
        }

        private void EnteringFormButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text.Equals("Введите Email") || PasswordTextBox.Text.Equals("Введите пароль"))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            CheckingEntering();
        }

        private void CheckingEntering()
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (String.IsNullOrWhiteSpace(login)
                || String.IsNullOrWhiteSpace(password))
                return;

            using (MyContext myContext = new MyContext())
            {
                var checkPassenger = myContext.Passengers.Where(l => l.Email.Equals(login) && l.Password.Equals(password)).FirstOrDefault();
                var checkAdmin = myContext.Leaders.Where(l => l.Email.Equals(login) && l.Password.Equals(password)).FirstOrDefault();

                if (checkPassenger != null)
                {
                    PassengerForm.passenger = checkPassenger;

                    User.isPassenger = true;

                    Close();
                }
                if (checkAdmin != null)
                {
                    OwnerForm.admin = checkAdmin;

                    User.isAdmin = true;

                    Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Введенные данные не верны, хотите ли вы зарегистрироваться?"
                                      , "Регистрация", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        Registration registration = new Registration();
                        registration.Show();
                    }
                }
            }
        }


    }
}
