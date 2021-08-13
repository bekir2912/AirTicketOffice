using AirTicketOffice.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketOffice
{
    public partial class PassengerForm : Form
    {
        private List<Flight> Flights;
        public static Passenger passenger { get; set; }
        private EFGenericRepository<Ticket> ticketGeneric = new EFGenericRepository<Ticket>();
        public PassengerForm()
        {
            InitializeComponent();
            InitialData();

        }

        public void UpdateFlights()
        {
            dataGridView1.DataSource =
                    Flights.Where(f => f.airPlane.FreeSeats != 0).Select(f => new
                    {
                        f.Id,
                        f.From.Country,
                        f.From.City,
                        ToCountry = f.To.Country,
                        ToCity = f.To.City,
                        f.dateDeparture,
                        f.dateArrival,
                        f.dateFlightMin,
                        f.Cost,
                        f.airPlane.Model,
                        f.airPlane.TotalSeats,
                        f.airPlane.FreeSeats
                    }
                        ).ToList();

        }

        public void UpdateTickets()
        {
            dataGridView2.DataSource =
                    passenger.tickets.GroupBy(f => new
                    {
                        FlightId = f.Flight.Id,
                        CountryFrom = f.Flight.From.Country,
                        CityFrom = f.Flight.From.City,
                        CountryTo = f.Flight.To.Country,
                        CityTo = f.Flight.To.City,
                        DateDeparture = f.Flight.dateDeparture,
                        DateArrival = f.Flight.dateArrival,
                        FlightMin = f.Flight.dateFlightMin,
                        FlightCost = f.Flight.Cost,
                        AirPlaneModel = f.Flight.airPlane.Model,
                        Buy = f.Buyied,
                        Name = f.passenger.Name
                    }).Select(g => new
                    {
                        g.Key.CountryFrom,
                        g.Key.CityFrom,
                        g.Key.CountryTo,
                        g.Key.CityTo,
                        g.Key.DateDeparture,
                        g.Key.DateArrival,
                        g.Key.FlightMin,
                        g.Key.FlightCost,
                        g.Key.AirPlaneModel,
                        g.Key.FlightId,
                        g.Key.Name,
                        g.Key.Buy,
                        Count = g.Count()
                    }
                        ).OrderBy(g => g.Buy).ToList();

        }

        public void InitialData()
        {
            try
            {
                this.Text = "Здравствуйте, " + passenger.Name;
                labelBalance.Text = "Баланс: " + passenger.Balance;
                PassengerNameLabel.Text = passenger.Name;
                pictureBox1.Image = Image.FromStream(new MemoryStream(passenger.Image));
                pictureBox1.Refresh();

                ResourceManager MyResourceClass =
                 new ResourceManager(typeof(Resources));

                Dictionary<string, object> images = new Dictionary<string, object>();

                ResourceSet resourceSet =
                    MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                foreach (DictionaryEntry entry in resourceSet)
                    images.Add(entry.Key.ToString(), entry.Value);

              
                int randImage = new Random().Next(1, 7);
                this.BackgroundImage = (Image)images[randImage.ToString()];
              
        

                using (MyContext context = new MyContext())
                {

                    try
                    {
                        Flights = context.Flights.Include(e => e.airPlane)
                            .Select(f => f).ToList();
                        passenger.tickets = context.Tickets.Include(f => f.Flight).Include(f => f.Flight.airPlane).Include(f => f.passenger)
                            .Where(f => f.passenger.Id == passenger.Id).Select(f => f).ToList();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                UpdateFlights();
                UpdateTickets();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DebitForm debitForm = new DebitForm();
            DialogResult result = debitForm.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                using (MyContext context = new MyContext())
                {
                    passenger.Balance += (int)debitForm.AddingBalance.Value;
                    Passenger passen = context.Passengers.Where(p => p.Id == passenger.Id).FirstOrDefault();
                    passen.Balance = passenger.Balance;
                    labelBalance.Text = "Баланс: " + passenger.Balance;
                    context.SaveChanges();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для бронирование");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            using (MyContext context = new MyContext())
            {
                Ticket ticket = new Ticket();
                ticket.Id = Guid.NewGuid();
                ticket.Buyied = false;

                Guid guid = (Guid)dataGridView1[0, index].Value;
                ticket.Flight = context.Flights.Include(f => f.airPlane).FirstOrDefault(f => f.Id == guid);

                ticket.passenger = context.Passengers.Find(passenger.Id);

                passenger.tickets.Add(ticket);

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }

            UpdateFlights();
            UpdateTickets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для покупки");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            using (MyContext context = new MyContext())
            {
                Ticket ticket = new Ticket();

                ticket.Id = Guid.NewGuid();
                ticket.Buyied = true;


                Guid guid = (Guid)dataGridView1[0, index].Value;

                ticket.Flight = context.Flights.Include(f => f.airPlane).FirstOrDefault(f => f.Id == guid);

                ticket.passenger = context.Passengers.Find(passenger.Id);
               
                if(ticket.Flight.Cost > passenger.Balance)
                {
                    MessageBox.Show($"Вам не хватает {ticket.Flight.Cost - passenger.Balance}, пополните ваш баланс");
                    return;
                }

                if (!checkBox1.Checked)
                    passenger.Balance -= ticket.Flight.Cost;
                else
                    passenger.Balance -= ticket.Flight.Cost/2;

                ticket.passenger.Balance = passenger.Balance;
                labelBalance.Text = "Баланс: " + passenger.Balance;

                if (ticket.Flight.airPlane.FreeSeats-- == 0)
                {
                    MessageBox.Show("Выбранном рейте мест не осталось");
                    return;
                }
                passenger.tickets.Add(ticket);

                Flights = Flights.Where(f => f.Id != ticket.Flight.Id).ToList();
                Flights.Add(ticket.Flight);

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }

            UpdateFlights();
            UpdateTickets();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите билет для продажи");
                return;
            }


            using (MyContext context = new MyContext())
            {
            int index = dataGridView2.SelectedRows[0].Index;
                
                Guid guid = (Guid)dataGridView2[9, index].Value;
                Ticket ticket = context.Tickets.Include(f => f.Flight).Include(f => f.Flight.airPlane).Include(f => f.passenger).FirstOrDefault(f => f.Flight.Id == guid);

                passenger.tickets = passenger.tickets.Where(p => p.Id != ticket.Id).ToList();

                if((bool)dataGridView2[11, index].Value == true) { 
                passenger.Balance += ticket.Flight.Cost / 2;
                ticket.passenger.Balance = passenger.Balance;
                labelBalance.Text = "Баланс: " + passenger.Balance;
                }
                 
                Flights = Flights.Where(f => f.Id != ticket.Flight.Id).ToList();

                if (ticket.Buyied != false)
                ticket.Flight.airPlane.FreeSeats++;

                Flights.Add(ticket.Flight);

                context.Tickets.Remove(ticket);
                context.SaveChanges();

            }

            UpdateFlights();
            UpdateTickets();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите забронированный билет");
                return;
            }

            using (MyContext context = new MyContext())
            {
                int index = dataGridView2.SelectedRows[0].Index;

                if ((bool)dataGridView2[11, index].Value == true)
                {
                    MessageBox.Show("Вы хотите забронировать уже купленный билет");
                    return;
                }

                Guid guid = (Guid)dataGridView2[9, index].Value;

                Ticket ticket = context.Tickets.Include(f => f.Flight).Include(f => f.Flight.airPlane).Include(f => f.passenger).Where(f => f.Flight.Id == guid && f.Buyied == false).FirstOrDefault();
                
               

                if (ticket.Flight.airPlane.FreeSeats-- == 0)
                {
                    MessageBox.Show("Выбранном рейте мест не осталось");
                    return;
                }


                if (ticket.Flight.Cost > passenger.Balance)
                {
                    MessageBox.Show($"Вам не хватает {ticket.Flight.Cost - passenger.Balance}, пополните ваш баланс");
                    return;
                }

                if (!checkBox1.Checked)
                    passenger.Balance -= ticket.Flight.Cost;
                else
                    passenger.Balance -= ticket.Flight.Cost / 2;

                ticket.passenger.Balance = passenger.Balance;
                labelBalance.Text = "Баланс: " + passenger.Balance;

                ticket.Buyied = true;

                passenger.tickets = passenger.tickets.Where(p => p.Id != ticket.Id).ToList();
                passenger.tickets.Add(ticket);
                Flights = Flights.Where(f => f.Id != ticket.Flight.Id).ToList();
                Flights.Add(ticket.Flight);

                context.SaveChanges();
            }
            UpdateFlights();
            UpdateTickets();
        }
        public void InsertDataGrid(List<Flight> flights)
        {
            dataGridView1.DataSource =
               flights.Select(f => new
               {
                   f.Id,
                   f.From.Country,
                   f.From.City,
                   ToCountry = f.To.Country,
                   ToCity = f.To.City,
                   f.dateDeparture,
                   f.dateArrival,
                   f.dateFlightMin,
                   f.Cost,
                   f.airPlane.Model,
                   f.airPlane.TotalSeats,
                   f.airPlane.FreeSeats
               }
                   ).ToList();



        }
        private void FromTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.ToList();
            if (!String.IsNullOrWhiteSpace(FromTextBox.Text))
            {
                list = list.Where(l => l.From.Country.Contains(FromTextBox.Text)
                || l.From.City.Contains(FromTextBox.Text)).ToList();

            }

            InsertDataGrid(list);
        }

        private void ToTextBox_TextChanged(object sender, EventArgs e)
        {
           
            List<Flight> list = Flights.ToList();
            if (!String.IsNullOrWhiteSpace(ToTextBox.Text))
            {
                list = list.Where(l => l.To.Country.Contains(ToTextBox.Text)
                || l.To.City.Contains(ToTextBox.Text)).ToList();

            }

            InsertDataGrid(list);
            

        }

        private void FromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.dateDeparture >= FromdateTimePicker.Value).ToList();

            InsertDataGrid(list);
        }

        private void TodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.dateDeparture <= TodateTimePicker.Value).ToList();

            InsertDataGrid(list);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.Classes == Class.Economic).ToList();

            InsertDataGrid(list);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.Classes == Class.Business).ToList();

            InsertDataGrid(list);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            InsertDataGrid(Flights);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
