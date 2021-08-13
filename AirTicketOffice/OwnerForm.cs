using AirTicketOffice.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace AirTicketOffice
{
    public partial class OwnerForm : Form
    {
        private List<Flight> Flights;
        public static Admin admin;
        public OwnerForm()
        {
            InitializeComponent();
            this.Text = this.Text + admin.FirstName;
            OwnerNameLabel.Text = admin.FirstName;
            Reading();

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


            CountInfoLabel.Text = "Количество найденных результатов: " + flights.ToList().Count(); ;
        }

        public void Reading()
        {
            using (MyContext context = new MyContext())
            {

                try
                {
                    Flights = context.Flights.Include(e => e.airPlane)
                        .Select(f => f).ToList();

                    ResourceManager MyResourceClass =
                    new ResourceManager(typeof(Resources));

                    Dictionary<string, object> images = new Dictionary<string, object>();

                    ResourceSet resourceSet =
                        MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                    foreach (DictionaryEntry entry in resourceSet)
                        images.Add(entry.Key.ToString(), entry.Value);


                    int randImage = new Random().Next(1, 7);
                    this.BackgroundImage = (Image)images[randImage.ToString()];

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            InsertDataGrid(Flights);




        }



        private void Addbutton_Click(object sender, EventArgs e)
        {
            using (MyContext context = new MyContext())
            {
                Flight flight = new Flight();
                AddFlights addFlights = new AddFlights();
                DialogResult result = addFlights.ShowDialog(this);
               
                if (result == DialogResult.Cancel)
                    return;

                if(String.IsNullOrWhiteSpace(addFlights.FromCountr.Text)
                    || String.IsNullOrWhiteSpace(addFlights.FromCit.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ToCountry.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ToCity.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ModelAir.Text)
                    || addFlights.Cost.Value < 1
                    || (int)addFlights.totalSeats.Value < 1)
                {
                    MessageBox.Show("Корректно заполните поля");
                    return;
                }


                flight.Id = Guid.NewGuid();
                flight.From.Country = addFlights.FromCountr.Text;
                flight.From.City = addFlights.FromCit.Text;
                flight.To.Country = addFlights.ToCountry.Text;
                flight.To.City = addFlights.ToCity.Text;
                flight.dateDeparture = addFlights.DateToStart.Value;
                flight.dateArrival = addFlights.dateToArrivel.Value;
                flight.dateFlightMin = (flight.dateArrival.Date - flight.dateDeparture.Date).TotalMinutes;
                flight.Cost = (float)addFlights.Cost.Value;
                flight.airPlane.Model = addFlights.ModelAir.Text;
                flight.airPlane.TotalSeats = (int)addFlights.totalSeats.Value;
                flight.airPlane.FreeSeats = flight.airPlane.TotalSeats;
                flight.airPlane.Id = Guid.NewGuid();
                flight.Classes = addFlights.comboBox1.SelectedIndex == 0 ? Class.Business : Class.Economic;

                context.AirPlanes.Add(flight.airPlane);


                context.Flights.Add(flight);

                context.SaveChanges();
                Flights.Add(flight);

                InsertDataGrid(Flights);





            }



        }

        private void Changebutton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения");
                return;
            }

            using (MyContext context = new MyContext())
            {
                Flight flight = new Flight();

                AddFlights addFlights = new AddFlights();

                int indexRow = dataGridView1.SelectedRows[0].Index;

                addFlights.FromCountr.Text = dataGridView1[1, indexRow].Value.ToString();
                addFlights.FromCit.Text = dataGridView1[2, indexRow].Value.ToString();
                addFlights.ToCountry.Text = dataGridView1[3, indexRow].Value.ToString();
                addFlights.ToCity.Text = dataGridView1[4, indexRow].Value.ToString();
                addFlights.DateToStart.Value = DateTime.Parse(dataGridView1[5, indexRow].Value.ToString());
                addFlights.dateToArrivel.Value = DateTime.Parse(dataGridView1[6, indexRow].Value.ToString());
                addFlights.Cost.Value = decimal.Parse(dataGridView1[8, indexRow].Value.ToString());
                addFlights.ModelAir.Text = dataGridView1[9, indexRow].Value.ToString();
                addFlights.totalSeats.Value = decimal.Parse(dataGridView1[10, indexRow].Value.ToString());
                
                DialogResult result = addFlights.ShowDialog(this);




                if (result == DialogResult.Cancel)
                    return;


                if (String.IsNullOrWhiteSpace(addFlights.FromCountr.Text)
                    || String.IsNullOrWhiteSpace(addFlights.FromCit.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ToCountry.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ToCity.Text)
                    || String.IsNullOrWhiteSpace(addFlights.ModelAir.Text)
                    || addFlights.Cost.Value < 1
                    || (int)addFlights.totalSeats.Value < 1)
                {
                    MessageBox.Show("Корректно заполните поля");
                    Addbutton_Click(sender, e);
                }

                flight = context.Flights.Find(dataGridView1[0, indexRow].Value);
                Guid Id = context.Flights.Where(f => f.Id == flight.Id).Select(f => f.airPlane.Id).FirstOrDefault();
                flight.airPlane = context.AirPlanes.Where(f => f.Id == Id).Select(f => f).FirstOrDefault();
                

                flight.From.Country = addFlights.FromCountr.Text;
                flight.From.City = addFlights.FromCit.Text;
                flight.To.Country = addFlights.ToCountry.Text;
                flight.To.City = addFlights.ToCity.Text;
                flight.dateDeparture = addFlights.DateToStart.Value;
                flight.dateArrival = addFlights.dateToArrivel.Value;
                flight.dateFlightMin = (flight.dateArrival.Date - flight.dateDeparture.Date).TotalMinutes;
                flight.Cost = (float)addFlights.Cost.Value;
                flight.airPlane.Model = addFlights.ModelAir.Text;
                flight.airPlane.TotalSeats = (int)addFlights.totalSeats.Value;
                flight.airPlane.FreeSeats = flight.airPlane.TotalSeats;
                flight.airPlane.Id = Flights.Where(f => f.Id == flight.Id).Select(f => f.airPlane.Id).FirstOrDefault();

                Flights = Flights.Where(f => f.Id != flight.Id).Select(f => f).ToList();
                Flights.Add(flight);

                context.SaveChanges();

                InsertDataGrid(Flights);





            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения");
                return;
            }

            using (MyContext context = new MyContext())
            {

                    int index = dataGridView1.SelectedRows[0].Index;

                    Guid guid = (Guid)dataGridView1[0, index].Value;

                List<Ticket> tickets = context.Tickets.Include(t => t.Flight)
                    .Include(t => t.Flight.airPlane).Include(t => t.passenger).Where(t => t.Flight.Id == guid).ToList();
                List<Discount> discounts = context.Discounts.Include(t => t.FlightId).Where(t => t.FlightId.Id == guid).ToList();
                List<Flight> flights = context.Flights.Include(t => t.airPlane).Where(t => t.Id == guid).ToList();
                
                context.Discounts.RemoveRange(discounts);
 ;
                context.Tickets.RemoveRange(tickets);

                foreach (Flight flight in flights)
                {
                    context.AirPlanes.Remove(flight.airPlane);
                    context.Flights.Remove(flight);
                }

                context.SaveChanges();

                    Flights = Flights.Where(f => f.Id != guid).ToList();

                    InsertDataGrid(Flights);

            }


        }
  
        private void Discountbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для скидки");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            Discounts discounts = new Discounts();

            discounts.BeforeDiscount.Text += (Flights.Where(f => f.Id == (Guid)dataGridView1[0, index].Value)
                .Select(f => f.Cost).FirstOrDefault());
            discounts.AfterDiscount.Text += (Flights.Where(f => f.Id == (Guid)dataGridView1[0, index].Value)
                .Select(f => f.Cost).FirstOrDefault());

            discounts.numericUpDownDiscount.ValueChanged += (s, ea) => ValueChanges(s, ea, discounts);

            DialogResult result = discounts.ShowDialog(this);


            if (result == DialogResult.Cancel)
                return;

            Discount discount = new Discount();

            discount.percentDiscount = (int)discounts.numericUpDownDiscount.Value;
            discount.Title = discounts.textBoxDescription.Text;

            if (String.IsNullOrWhiteSpace(discount.Title))
                discount.Title = "Щедрость";

            using (MyContext context = new MyContext())
            {

                Guid guid = (Guid)dataGridView1[0, index].Value;

                discount.FlightId = context.Flights.Include(f => f.airPlane)
                    .FirstOrDefault(f => f.Id == guid);

                context.Discounts.Add(discount);

                discount.FlightId.Cost -= (discount.FlightId.Cost * discount.percentDiscount / 100);
                
                Flights = Flights.Where(f => f.Id != discount.FlightId.Id).ToList();
                
                Flights.Add(discount.FlightId);



                context.SaveChanges();

                InsertDataGrid(Flights);

            }

        }
        static void ValueChanges(object sender, EventArgs e, Discounts discounts)
        {

            string str = new String(
                discounts.BeforeDiscount.Text.Where(x => Char.IsDigit(x)).ToArray());

                discounts.AfterDiscount.Text = "После скидки: " + (float.Parse(str) - 
                (float.Parse(str) * (float)discounts.numericUpDownDiscount.Value / 100));
        }

        private void TicketcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.ToList();

            if (TicketcheckBox.Checked)
                list = list.OrderBy(f => f.airPlane, new AirPlane()).ToList();

            InsertDataGrid(list);
        }

        private void DirectioncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            List<Flight> list = Flights.ToList();

            if (DirectioncheckBox.Checked)
                list = list.OrderBy(f => f.To, new Location()).ToList();
               

            InsertDataGrid(list);
        }
        
        private void DiscountcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.ToList();
            if (DiscountcheckBox.Checked)
            {
                list.Clear();
                using (MyContext context = new MyContext())
                {
                    List<Discount> discounts = context.Discounts.Include(d => d.FlightId).ToList();

                    foreach (Flight flight in Flights)
                    {
                        foreach (Discount discount in discounts)
                        {
                            if (flight.Id == discount.FlightId.Id)
                            {
                                list.Add(flight);
                                break;
                            }
                               
                        }
                    }
                }

            }
            
            InsertDataGrid(list);

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

        private void FlightTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.ToList();
            if (!String.IsNullOrWhiteSpace(FlightTextBox.Text))
            {
                list = list.Where(l => l.Id.ToString().Contains(FlightTextBox.Text)).ToList();

            }

            InsertDataGrid(list);
        }

        private void AirPlaneTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.ToList();
            if (!String.IsNullOrWhiteSpace(AirPlaneTextBox.Text))
            {
                list = list.Where(l => l.airPlane.Model.ToString().Contains(AirPlaneTextBox.Text)).ToList();

            }

            InsertDataGrid(list);
        }

        private void FromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.dateDeparture >= FromdateTimePicker.Value).ToList();

            InsertDataGrid(list);
        }

        private void TilldateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            List<Flight> list = Flights.Where(l => l.dateDeparture <= TilldateTimePicker.Value).ToList();

            InsertDataGrid(list);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
