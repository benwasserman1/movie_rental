using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /*
        This function is called when the third form is loaded. This occurs when a movie
        is checked out or returned. The form first sets a variety of variables equal to their
        Form2 counterparts. It then calculates the time the movie has been checked out for. If the movie
        is being returned, it displays the days rented, the cost per day, the total cost, and the title of the movie. 
        If the movie is just being checked out, the form only displays the cost per day and the title of the movie. 
        */
        private void Form3_Load(object sender, EventArgs e)
        {
            string genre = Form2.genre;
            string title = Form2.title;
            string category = Form2.category;
            string price = "";
            int rented = Form2.isRented;
            DateTime checkout = Form2.checkout;
            DateTime checkin = Form2.checkin;
            TimeSpan diff = checkin.Subtract(checkout);
            double difference = diff.TotalDays;
            difference = Math.Truncate(difference + 1);

            
            if (category == "1")
            {
                price = "3.50";
            }
            else if (category == "2")
            {
                price = "2.50";
            }
            else if (category == "3")
            {
                price = "1.50";
            }
            else
            {
                MessageBox.Show("There is an error with the movie. Ask for help");
            }

            if (rented == 1)
            {
                lblDaysRented.Text = "Days rented: " + difference.ToString();
                lblTotalCost.Text = "Total cost: $" + (difference * double.Parse(price)).ToString();
                rented = 0;
            }
            lblMovieTitle.Text = "Checked out movie: " + title;
            lblMoviePrice.Text = "Price per day: $" + price;
        }

        //Exit the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Close the form
        private void buttonReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
