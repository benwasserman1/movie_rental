using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=MovieDB;Version=3;");
        DataTable dt = new DataTable();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        public Form2()
        {
            InitializeComponent();
        }

        /*
        These are static member variables that are used to be accessed by other forms when they are loaded.
        */
        public static string genre = "";
        public static string title = "";
        public static string category = "";
        public static DateTime checkout;
        public static DateTime checkin;
        public static int isRented;

        /*
       This function is called for SQLite queries that follow the format laid out
       in the function. The data adapter initializes a command, the table is cleaned, 
       and then it's opened, filled, and closed. Finally, the data grid is set equal to 
       the datatable. 
        */
        public void populateGrid(string query)
        {
            try
            {
                da.SelectCommand = new SQLiteCommand(query, conn);

                //Cleans data table
                dt.Clear();
                //Takes care of opening and closing
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
        When the second form is loaded there are a lot of checks to be made. First, I set
        a variety of variables equal to their Form1 counterparts so that they can 
        be manipulated in this form. Each if statement essentially checks to see if the user
        input a value to be searched for that field, and then calls populateGrid() if so. 
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            genre = Form1.genre;
            string price = Form1.price;
            string inventory = Form1.inventory;
            string title = Form1.title;
            string rented = Form1.rented;
            if (genre != "")
            {
                populateGrid("select * from Movies WHERE Genre ='" + genre.ToUpper() + "';");
                Form1.genre = "";
            }
            else if (price != "")
            {
                populateGrid("select * from Movies WHERE Category = '" + price + "';");
                Form1.price = "";
            }
            else if (title != "")
            {
                populateGrid("select * from Movies WHERE MovieTitle LIKE '%" + title + "%';");
                Form1.title = "";
            }
            else if (inventory == "1")
            {
                populateGrid("select * from Movies;");
                Form1.inventory = "";
            }
            else if (rented == "1")
            {
                populateGrid("select * from Movies WHERE isRented = 1;");
                Form1.rented = "";
            }

            
        }

        /*
        This function is used for checking out movies. There are a lot of steps in this function.
        It checks to see that the user is only checking out one movie, first. Then, if the user hasn't
        selected any movies, an error message is displayed. Lastly, the function runs all the commands
        to check out the movie, adds the check out time to the database, and marks it as rented. 
        */
        private void button1_Click(object sender, EventArgs e)
        {
            int movies = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (movies > 1)
            {
                MessageBox.Show("You can only check out one movie at a time", "Error", MessageBoxButtons.OK);
            }
            else if (movies == 0)
            {
                MessageBox.Show("You haven't selected any rows", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int movieID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(movieID.ToString());
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("Update Movies SET CheckOutDate = @time where MovieID = @movieID", conn);
                    SQLiteCommand cmd1 = new SQLiteCommand("Update Movies SET isRented = @rented where MovieID = @movieID", conn);


                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@movieID", movieID);

                    cmd1.Prepare();

                    cmd1.Parameters.AddWithValue("@rented", 1);
                    cmd1.Parameters.AddWithValue("@movieID", movieID);

                    conn.Open(); //Manual opening

                    cmd1.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    conn.Close(); //Manual closing
                    //Should open a new form that confirms the check out with certain pricing?
                    genre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    category = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    populateGrid("select * from Movies;");
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*
        This function is used to return movies. It doesn't return anything. The function checks to see
        that there is only one movie being returned, and that the user has selected a movie. Then it cehcks
        that the movie they selected has actually been checked out. Finally, it runs the command to change 
        the movie to no longer being rented, and inputs the date and time it was returned. 
        */
        private void button2_Click(object sender, EventArgs e)
        {
            int movies = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (movies > 1)
            {
                MessageBox.Show("Please return one movie at a time", "Error", MessageBoxButtons.OK);
            }
            else if (movies == 0)
            {
                MessageBox.Show("You haven't selected any rows", "Error", MessageBoxButtons.OK);
            }
            else
            {
                int movieID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(movieID.ToString());
                try
                {
                    if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "")
                    {
                        MessageBox.Show("You can't return this movie. It hasn't been checked out", "Return Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        checkout = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                        checkin = DateTime.Now;
                        //TimeSpan diff = checkin.Subtract(checkout);
                        //MessageBox.Show(diff.ToString());

                        SQLiteCommand cmd1 = new SQLiteCommand("Update Movies SET isRented = @rented where MovieID = @movieID", conn);
                        SQLiteCommand cmd = new SQLiteCommand("Update Movies SET ReturnDate = @time where MovieID = @movieID", conn);
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@time", DateTime.Now);
                        cmd.Parameters.AddWithValue("@movieID", movieID);

                        cmd1.Prepare();

                        cmd1.Parameters.AddWithValue("@rented", 0);
                        cmd1.Parameters.AddWithValue("@movieID", movieID);

                        conn.Open(); //Manual opening

                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        conn.Close(); //Manual closing

                        title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        category = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        isRented = 1;
                        Form3 frm3 = new Form3();
                        frm3.Show();
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
            }
        }

        //Refresh the whole movie inventory using populateGrid
        private void button4_Click(object sender, EventArgs e)
        {
            populateGrid("select * from Movies;");
        }

        //Exit application
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exit form
        private void buttonReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
