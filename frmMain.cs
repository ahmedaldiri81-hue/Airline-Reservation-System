using BusinessAirlineLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationWindowsForm
{
    public partial class frmMain : Form
    {
        public frmMain(string UserName)
        {
            InitializeComponent();

            _UserName = UserName;

        }

        string _UserName;

        private string _CurrentTable = "";
        

        private void _LoadData(Button btn)
        {
            if(btn == btnFlights)
            {
                dataGridView1.DataSource = clsFligthsBusiness.GetAllFligths();
                lblProocesing.Text = "Flights";
                _CurrentTable = "Flights";
                btnAddPassengers.Visible = false;
                btnAddBookings.Visible = false;
                btnAddTickets.Visible = false;
            }
            else if(btn == btnBookings)
            {
                dataGridView1.DataSource = clsBusinessBooking.GetAllBookings();
                lblProocesing.Text = "Bookings";
                _CurrentTable = "Bookings";
                btnAddPassengers.Visible = false;
                btnAddBookings.Visible = true;
                btnAddTickets.Visible = false;
            }
            else if(btn == btnPassengers)
            {
                dataGridView1.DataSource = clsBusinessPassenger.GetAllPassengers();
                lblProocesing.Text ="Passengers";
                _CurrentTable= "Passengers";
                btnAddPassengers.Visible = true;
                btnAddBookings.Visible = false;
                btnAddTickets.Visible = false;
            }
            else if(btn == btnTickets)
            {
                dataGridView1.DataSource = clsBusinessDetails.ShowAllBookingDetails();
                lblProocesing.Text = "Tickets";
                _CurrentTable = "Tickets";
                btnAddPassengers.Visible = false;
                btnAddBookings.Visible = false;
                btnAddTickets.Visible = true;

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblsetUserName.Text = _UserName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _LoadData((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _LoadData((Button)sender);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            _LoadData((Button)sender);
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            _LoadData((Button)sender);
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPassengers frm = new frmAddPassengers(-1);
            frm.ShowDialog();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddBookings_Click(object sender, EventArgs e)
        {
            frmAddBookings frm = new frmAddBookings(-1);

            frm.ShowDialog();

        }

       

        private void editBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditItem();
        }





        private void _DeletItem()
        {
            if (_CurrentTable == "Passengers")
            {
               deleteBookingToolStripMenuItem.Enabled = false;
                deletePassengerToolStripMenuItem.Enabled = true;
                if (clsBusinessPassenger.DeletePassenger((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Passenger Deleted successfully. ");
                }
                else
                {
                    MessageBox.Show("Passenger Deleted not successfully.");
                }

            }
            else if (_CurrentTable == "Bookings")
            {
                deletePassengerToolStripMenuItem.Enabled = false;
                deleteBookingToolStripMenuItem.Enabled= true;
                if (clsBusinessBooking.DeleteBooking((int)dataGridView1.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Booking Deleted successfully. ");
                }
                else
                {
                    MessageBox.Show("Booking Deleted not successfully.");
                }

            }

            if(_CurrentTable == "Passengers")
            {
                _LoadData(btnPassengers);
            }
            else if(_CurrentTable == "Bookings")
            {
                _LoadData(btnBookings);
            }
        }



        private void _EditItem()
        {

            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record.");
                return;
            }

            if (_CurrentTable == "Passengers")
            {

                frmAddPassengers frm = new frmAddPassengers((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _LoadData(btnPassengers);
            }
            else if (_CurrentTable == "Bookings") 
            {
                frmAddBookings frm = new frmAddBookings((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _LoadData(btnBookings);


            }

           



        }
        private void deletePassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _DeletItem();

        }

        private void deleteBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeletItem();
        }

        private void editPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditItem();

        }

        private void cmsPassengers_Opening(object sender, CancelEventArgs e)
        {

            bool IsPassenger = _CurrentTable == "Passengers";
            bool IsBooking = _CurrentTable == "Bookings";

            bool ShowMenu = IsPassenger || IsBooking;



            deletePassengerToolStripMenuItem.Visible = IsPassenger;
            deleteBookingToolStripMenuItem.Visible =IsBooking;
            editBookingToolStripMenuItem.Visible = IsBooking;
            editPassengerToolStripMenuItem.Visible = IsPassenger;
            cmsDelete.Visible = ShowMenu;
            cmsEdit.Visible = ShowMenu;
           
            
        }
    }
}
