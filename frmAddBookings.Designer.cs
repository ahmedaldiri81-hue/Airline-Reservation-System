namespace AirlineReservationWindowsForm
{
    partial class frmAddBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBookings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddBookings = new System.Windows.Forms.Label();
            this.txtBookingReference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookingStatuse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentStatuse = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.btnCancleBooking = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 914);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.lblAddBookings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 84);
            this.panel2.TabIndex = 0;
            // 
            // lblAddBookings
            // 
            this.lblAddBookings.AutoSize = true;
            this.lblAddBookings.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBookings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddBookings.Location = new System.Drawing.Point(67, 28);
            this.lblAddBookings.Name = "lblAddBookings";
            this.lblAddBookings.Size = new System.Drawing.Size(271, 34);
            this.lblAddBookings.TabIndex = 0;
            this.lblAddBookings.Text = "Add New Bookings";
            // 
            // txtBookingReference
            // 
            this.txtBookingReference.BackColor = System.Drawing.Color.DarkGray;
            this.txtBookingReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookingReference.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingReference.ForeColor = System.Drawing.Color.White;
            this.txtBookingReference.Location = new System.Drawing.Point(441, 156);
            this.txtBookingReference.Name = "txtBookingReference";
            this.txtBookingReference.Size = new System.Drawing.Size(362, 22);
            this.txtBookingReference.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Booking Reference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Booking Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.DarkGray;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(441, 391);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(362, 22);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Booking Statuse:";
            // 
            // txtBookingStatuse
            // 
            this.txtBookingStatuse.BackColor = System.Drawing.Color.DarkGray;
            this.txtBookingStatuse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookingStatuse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingStatuse.ForeColor = System.Drawing.Color.White;
            this.txtBookingStatuse.Location = new System.Drawing.Point(441, 513);
            this.txtBookingStatuse.Name = "txtBookingStatuse";
            this.txtBookingStatuse.Size = new System.Drawing.Size(362, 22);
            this.txtBookingStatuse.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment Statuse :";
            // 
            // txtPaymentStatuse
            // 
            this.txtPaymentStatuse.BackColor = System.Drawing.Color.DarkGray;
            this.txtPaymentStatuse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentStatuse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentStatuse.ForeColor = System.Drawing.Color.White;
            this.txtPaymentStatuse.Location = new System.Drawing.Point(441, 638);
            this.txtPaymentStatuse.Name = "txtPaymentStatuse";
            this.txtPaymentStatuse.Size = new System.Drawing.Size(362, 22);
            this.txtPaymentStatuse.TabIndex = 9;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpBookingDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBookingDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(441, 292);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(362, 29);
            this.dtpBookingDate.TabIndex = 11;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveBooking.FlatAppearance.BorderSize = 0;
            this.btnSaveBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooking.Location = new System.Drawing.Point(657, 757);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(145, 80);
            this.btnSaveBooking.TabIndex = 12;
            this.btnSaveBooking.Text = "Save Change";
            this.btnSaveBooking.UseVisualStyleBackColor = false;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // btnCancleBooking
            // 
            this.btnCancleBooking.BackColor = System.Drawing.Color.Maroon;
            this.btnCancleBooking.FlatAppearance.BorderSize = 0;
            this.btnCancleBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancleBooking.Location = new System.Drawing.Point(441, 757);
            this.btnCancleBooking.Name = "btnCancleBooking";
            this.btnCancleBooking.Size = new System.Drawing.Size(145, 80);
            this.btnCancleBooking.TabIndex = 13;
            this.btnCancleBooking.Text = "Close";
            this.btnCancleBooking.UseVisualStyleBackColor = false;
            this.btnCancleBooking.Click += new System.EventHandler(this.btnCancleBooking_Click);
            // 
            // frmAddBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(856, 914);
            this.Controls.Add(this.btnCancleBooking);
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaymentStatuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookingStatuse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingReference);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddBookings";
            this.Text = "frmAddBookings";
            this.Load += new System.EventHandler(this.frmAddBookings_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddBookings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBookingReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookingStatuse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentStatuse;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnCancleBooking;
    }
}