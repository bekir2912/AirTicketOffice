using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketOffice
{
    public partial class Registration : Form
    {
        private Passenger passenger = new Passenger();
        
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*PNG|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] photo;

                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    photo = new byte[stream.Length];
                    stream.Read(photo, 0, photo.Length);
                }

                passenger.Image = photo;
            }

            
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistrationPassenger();
        }

        private void RegistrationPassenger()
        {
            passenger.location = new Location();
            passenger.Id = Guid.NewGuid();
            passenger.Name = NametextBox.Text;
            passenger.Surname = SurnametextBox.Text;
            passenger.Age = (int)AgeBox.Value;
            passenger.location.Country = CountrytextBox.Text;
            passenger.location.City = CitytextBox.Text;
            passenger.Email = EmailtextBox.Text;
            passenger.Password = PasswordtextBox.Text;

            if (String.IsNullOrWhiteSpace(passenger.Name) ||
               String.IsNullOrWhiteSpace(passenger.Surname) ||
               String.IsNullOrWhiteSpace(passenger.location.Country) ||
               String.IsNullOrWhiteSpace(passenger.location.City) ||
               String.IsNullOrWhiteSpace(passenger.Email) ||
               String.IsNullOrWhiteSpace(passenger.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }



            if (passenger.Image == null)
            {
                byte[] photo;
                using (FileStream stream = new FileStream(@"..\..\img\User.png", FileMode.Open))
                {
                    photo = new byte[stream.Length];
                    stream.Read(photo, 0, photo.Length);
                }
                passenger.Image = photo;
            }

            using (MyContext myContext = new MyContext())
            {
                myContext.Passengers.Add(passenger);
                myContext.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрированны");
            }
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
