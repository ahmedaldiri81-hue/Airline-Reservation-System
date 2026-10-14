using BusinessAirlineLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationWindowsForm
{
    public partial class frmAddBookings : Form
    {
        public frmAddBookings( int BookingID)
        {
            InitializeComponent();

            _BookingID = BookingID;

            if(BookingID == -1)
            {
                _Mode = enMode.AddBooking;
            }
            else
            {
                _Mode = enMode.UpdateBooking;
            }
        }

        public enum enMode { AddBooking=0 , UpdateBooking=1 };

        enMode _Mode;

        clsBusinessBooking _Booking;

        int _BookingID;





        private void _LoadData()
        {
            if(_Mode == enMode.AddBooking)
            {
                lblAddBookings.Text = "Add New Booking";
                _Booking = new clsBusinessBooking();
                return;

            }




            _Booking = clsBusinessBooking.Find(_BookingID);

            txtBookingReference.Text = _Booking.BookingReference;
            txtBookingStatuse.Text = _Booking.BookingStatuse;
            txtPaymentStatuse.Text = _Booking.PaymentStatuse;
            txtTotalAmount.Text = _Booking.TotalAmount.ToString("F2");
            dtpBookingDate.Value = _Booking.BookingDate;


            

        }






        private void btnCancleBooking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBookings_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            _Booking.BookingReference = txtBookingReference.Text;
            _Booking.BookingDate = dtpBookingDate.Value;
            _Booking.BookingStatuse = txtBookingStatuse.Text;
            _Booking.PaymentStatuse = txtPaymentStatuse.Text;
            _Booking.TotalAmount = decimal.Parse( txtTotalAmount.Text);


            if(_Booking.Save())
            {
                MessageBox.Show($"Data Saved Successfully and BookingID : {_Booking.BookingID}");
            }
            else
            {
                MessageBox.Show("Error :  Data is not successfully.");
            }

        }
    }
}
