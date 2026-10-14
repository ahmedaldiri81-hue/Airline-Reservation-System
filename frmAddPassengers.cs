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
    public partial class frmAddPassengers : Form
    {
        public frmAddPassengers(int ID)
        {
            InitializeComponent();

            _PassengerID = ID;

            if(ID == -1)
            {
                _Mode = enMode.AddPassenger;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }



       public  enum enMode { AddPassenger=0 , Update=1};
        enMode _Mode;


        clsBusinessPassenger _Passenger;

        int _PassengerID;



        private void _LoadData()
        {
            if(_Mode == enMode.AddPassenger)
            {

                lblTitleAdd.Text = "Add New Passenger";
                _Passenger = new clsBusinessPassenger();
                return;
            }


            _Passenger = clsBusinessPassenger.Find(_PassengerID);

            if(_Passenger == null)
            {
                MessageBox.Show("This form will be closed no Passenger with ID.");
                this.Close();
                return;
            }

            lblTitleAdd.Text = "Update Passenger";
            txtFirstName.Text = _Passenger.FirstName;
            txtLastName.Text = _Passenger.LastName;
            txtNationality.Text = _Passenger.Nationality;
            txtPasswordNumber.Text = _Passenger.PassportNumber;
            txtEmail.Text = _Passenger.Email;
            txtPhone.Text = _Passenger.Phone;
        }



        



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddPassengers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Passenger.FirstName = txtFirstName.Text;
            _Passenger.LastName = txtLastName.Text;
            _Passenger.Nationality = txtNationality.Text;
            _Passenger.Email = txtEmail.Text;
            _Passenger.PassportNumber = txtPasswordNumber.Text;
            _Passenger.Phone = txtEmail.Text;

            if(_Passenger.Save())
            {
                MessageBox.Show("Data Saved Successfully:)");
            }
            else
            {
                MessageBox.Show("Error: Data is not Saved successfuly:(");
            }
        }
    }
}
