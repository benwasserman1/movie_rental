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
    public partial class Form1 : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=MovieDB;Version=3;");
        DataTable dt = new DataTable();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        /*
        These are static member variables that are used to be accessed by other forms when they are loaded.
        */
        public static string genre = "";
        public static string price = "";
        public static string title = "";
        public static string inventory = "";
        public static string rented = "";

        /*
        The method checkCategories doesn't take any input and it returns an integer. It checks to see
        that the user is inputting either a 1, 2, or 3 into the category text box within the group box
        where the user is adding movies. It returns 0 if this is not the case, and 1 if it is.
        */
        public int checkCategories()
        {
            if ((textBoxAddMovieCategoryInput.Text != "1") && (textBoxAddMovieCategoryInput.Text != "2") && (textBoxAddMovieCategoryInput.Text != "3"))
            {
                return 0;
            }
            return 1;
        }

        /*
        The method checkGenres takes in no input as parameters and it returns an integer. It checks to see
        that the genre that the user is inputting matches the possible genres that the DB can have. It returns 1
        if they do and 0 otherwise.
        */
        public int checkGenres()
        {
            string genre = textBoxAddMovieGenreInput.Text.ToLower();
            if (genre != "action" && genre != "comedy" && genre != "drama" && genre != "family" && genre!= "thriller" && genre!= "mystery" && genre != "documentary" && genre!= "romance" && genre != "fantasy")
            {
                return 0;
            }
            return 1;
        }

        /*
        The method checkAllCategories takes in no input as parameters and returns an integer. It checks
        to see if each text box has nothing in it. If any of the text boxes are empty, it returns 0. Otherwise, the method
        returns 1.
        */
        public int checkAllCategories()
        {
            string genre = textBoxAddMovieGenreInput.Text;
            string title = textBoxAddMovieTitleInput.Text;
            string category = textBoxAddMovieCategoryInput.Text;
            if (genre == "" || title == "" || category == "")
            {
                return 0;
            }
            return 1;
        }

        /*
        The method initializeAddMovie doesn't return anything and it doesn't take in any input as parameters.
        It merely puts all the text boxes in the group box where the user is adding movies, back to empty.
        */
        public void initializeAddMovie()
        {
            textBoxAddMovieCategoryInput.Text = "";
            textBoxAddMovieTitleInput.Text = "";
            textBoxAddMovieGenreInput.Text = "";
        }

        /*
        This function is called when the button to display the movie inventory is clicked. 
        It doesn't return anything. The function sets the inventory to 1 and then loads
        the second form. The second form takes care of displaying the data grid based on the 
        value of inventory.
        */
        private void buttonDisplayInventory_Click(object sender, EventArgs e)
        {
            inventory = "1";
            Form2 frm2 = new Form2();
            frm2.Show();
            //populateGrid("select * from Movies;");
        }

        /*
        This function is called when the button to display the rented movie inventory is clicked. 
        It doesn't return anything. The function sets the variable rented to 1 and then loads
        the second form. The second form takes care of displaying the data grid based on the 
        value of rented.
        */
        private void buttonDisplayRented_Click(object sender, EventArgs e)
        {
            rented = "1";
            Form2 frm2 = new Form2();
            frm2.Show();
            //populateGrid("select * from Movies WHERE isRented = 1;");
        }

        /*
        This function is called when the button to search a genre is clicked. 
        It doesn't return anything. The function sets the variable genre to the user input,
        checks to see that the input is valid, and then loads the second form. The second
        form takes care of displaying the data grid.
        */
        private void buttonSearchGenre_Click(object sender, EventArgs e)
        {
            
            //string genre1 = comboBoxSearcGenre.SelectedValue.ToString();
            //Use cmd.selectCommand.paramters.addwithvalue
            genre = textBoxGenreInput.Text.ToLower();
            if (genre != "action" && genre != "comedy" && genre != "drama" && genre != "family")
            {
                MessageBox.Show("This is not a valid genre", "Error", MessageBoxButtons.OK);
            }
            else
            {
                textBoxGenreInput.Text = "";
                Form2 frm2 = new Form2();
                frm2.Show();
            }                  
        }

        /*
       This function is called when the button to search a price is clicked. 
       It doesn't return anything. The function sets the price equal to the corresponding
       category so that the information can be properly searched from the database. It then 
       loads the second form which takes care of displaying the grid based on the value of price.
       */
        private void buttonSearchPrice_Click(object sender, EventArgs e)
        {   
            if (textBoxPriceInput.Text == "2.50")
            {
                
                price = "2";
                textBoxPriceInput.Text = "";
                Form2 frm2 = new Form2();
                frm2.Show();
                //populateGrid("select * from Movies WHERE Category = '" + price + "';");
            }
            else if (textBoxPriceInput.Text == "3.50")
            {
                price = "1";
                textBoxPriceInput.Text = "";
                Form2 frm2 = new Form2();
                frm2.Show();
                //populateGrid("select * from Movies WHERE Category = '" + price + "';");
            }
            else if (textBoxPriceInput.Text == "1.50")
            {
                price = "3";
                textBoxPriceInput.Text = "";
                Form2 frm2 = new Form2();
                frm2.Show();          
                //populateGrid("select * from Movies WHERE Category = '" + price + "';");
            }
            else
            {
                textBoxPriceInput.Text = "";
                MessageBox.Show("Price options are 1.50, 2.50, and 3.50", "Error", MessageBoxButtons.OK);
            }
        }

        /*
       This function is called when the button to search a title is clicked. 
       It doesn't return anything. The function sets the variable title to the user input,
       checks to see that the input is valid, and then loads the second form. The second
       form takes care of displaying the data grid.
       */
        private void buttonSearchTitle_Click(object sender, EventArgs e)
        {
            title = textBoxTitleInput.Text;
            if (title == "")
            {
                MessageBox.Show("Must enter a title", "Error", MessageBoxButtons.OK);
            }
            else
            {
                textBoxTitleInput.Text = "";
                Form2 frm2 = new Form2();
                frm2.Show();
            }      
            //populateGrid("select * from Movies WHERE MovieTitle = '" + title + "';");
        }

        /*
       This function is called when the button to add a movie is clicked. It doesn't
       return anything. The function prepares an SQLite command to insert a new movie into 
       the database. It then checks to make sure that each field has been entered properly, and
       executes the command to add the movie if so. 
       */
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Movies(MovieTitle, Category, Genre, CheckOutDate, ReturnDate, isRented) VALUES(@title, @category, @genre, @checkout, @checkin, @isRented)", conn);
                cmd.Prepare();

                if (checkAllCategories() == 1)
                {
                    if (checkCategories() == 1)
                    {
                        if (checkGenres() == 1)
                        {
                            cmd.Parameters.AddWithValue("@title", textBoxAddMovieTitleInput.Text);
                            cmd.Parameters.AddWithValue("@category", textBoxAddMovieCategoryInput.Text);
                            cmd.Parameters.AddWithValue("@genre", textBoxAddMovieGenreInput.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@checkout", null);
                            cmd.Parameters.AddWithValue("@checkin", null);
                            cmd.Parameters.AddWithValue("@isRented", 0);
                            conn.Open(); //Manual opening

                            cmd.ExecuteNonQuery();
                            conn.Close(); //Manual closing
                            initializeAddMovie();
                            MessageBox.Show("Movie was added", "Movie Added", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("The only valid inputs are Family, Action, Drama, and Comedy", "Genre Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valid categories are 1, 2, and 3. \nThey correspond to 3.50, 2.50, and 1.50 respectively.", "Category Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter a value for each text box", "Error Adding Movie", MessageBoxButtons.OK);
                }
                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            
         
        }

        private void buttonReturnMovie_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
