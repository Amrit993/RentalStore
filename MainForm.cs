using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalStore
{
    public partial class MainForm : Form
    {
        private int CustomerRowIndex, MovieRowIndex, RentalRowIndex;
        private int MovieID, customerID, RentalRowID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            if(movieTitleText.Text != "" || rentingCostValue.Text != "" )
            {
                // Checks if user is trying to add new user or modify the existing one
                if(addMovieSelected.Checked)
                {
                    string columns = "(MovieTitle, MovieReleaseDate, MovieRatings, MovieCopies, MovieRentingCost, MovieGenre)";
                    string values  = "(@title, @date, @ratings, @copies, @rentingCost, @genre)";
                    object[] inputFields = { movieTitleText.Text, DateTime.Now, movieRatingsValue.Value, movieCopiesValue.Value, rentingCostValue.Text, comboBox1.SelectedItem.ToString() };
                    string[] fieldNames = { "@title", "@date", "@ratings", "@copies", "@rentingCost", "@genre" };
                    Database.Insert("Movies", columns, values, false, "", inputFields, fieldNames);
                }
                else
                {
                    string values = "MovieTitle=@title, MovieReleaseDate=@date, MovieRatings=@ratings, MovieCopies=@copies, MovieRentingCost=@cost, MovieGenre=@genre";
                    string[] inputs = { "@title", "@date", "@ratings", "@copies", "@cost", "@genre" };
                    object[] fieldValues = { movieTitleText.Text, movieReleaseDateValue.Value, movieRatingsValue.Value, movieCopiesValue.Value, rentingCostValue.Text, comboBox1.SelectedItem.ToString() };
                    Database.Update("Movies", values, true, "MovieID=" + MovieID, inputs, fieldValues);
                }

                ResetMovieFields();

                Database.AddToDataGridView("Movies", MoviesList);
            }
            else
            {
                MessageBox.Show("One or More fields are Empty!");
            }
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            // Checks if user has rented any movies before User can be deleted
            if(Database.HasRentedCopies(MovieID))
            {
                Functions.DisplayMessage("One of more copies of this movie are rented!");
            }
            else
            {
                Database.Delete("Movies", "MovieID", MovieID.ToString());
                Database.AddToDataGridView("Movies", MoviesList);
                ResetMovieFields();
            }
        }

        // When the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting default selection value
            addMovieSelected.Checked = true;
            modifyMovieSelected.Checked = false;

            // Add Movie Genre's to ComboBox
            Functions.AddMoviesGenre(comboBox1);

            // Add Movies to GridView
            Database.AddToDataGridView("Movies", MoviesList);

            // Add Customers to GridView
            Database.AddToDataGridView("Customers", CustomersList);

            // Add Rented Movies to GridView
            Database.AddToDataGridView("Rented", RentalsList);

            // Set Default Dates
            rentingDate.Value = DateTime.Now;
            returningDate.Value = DateTime.Now.AddDays(1);
        }

        private void Add_ModifyCustomerBtn_Click(object sender, EventArgs e)
        {
            if(firstNameField.Text != "" || lastNameField.Text != "" || addressField.Text != "" || phoneNumberField.Text != "")
            {
                if (addNewCustomerRadio.Checked)
                {
                    string columns = "(FirstName, LastName, Address, PhoneNumber)";
                    string values = "(@first, @last, @address, @phone)";
                    object[] inputFields = { firstNameField.Text, lastNameField.Text, addressField.Text, phoneNumberField.Text };
                    string[] fieldNames = { "@first", "@last", "@address", "@phone" };
                    Database.Insert("Customers", columns, values, false, "", inputFields, fieldNames);
                    Database.AddToDataGridView("Customers", CustomersList);
                }
                else
                {
                    string values = "FirstName=@first, LastName=@last, Address=@address, PhoneNumber=@phone";
                    object[] inputFields = { firstNameField.Text, lastNameField.Text, addressField.Text, phoneNumberField.Text };
                    string[] fieldNames = { "@first", "@last", "@address", "@phone" };
                    Database.Update("Customers", values, true, "CustomerID=" + customerID, fieldNames, inputFields);
                    Database.AddToDataGridView("Customers", CustomersList);
                }

                ResetCustomerFields();
            }
            else
            {
                MessageBox.Show("One or More fields are Empty!");
            }
        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if(Database.HasUserRentedMovie(customerID))
            {
                Functions.DisplayMessage("This Customer has Rented Movies!");
            }
            else
            {
                // Delete Customer from list
                Database.Delete("Customers", "CustomerID", customerID.ToString());
                Database.AddToDataGridView("Customers", CustomersList);

                // Makes sure to clear the fields once the user is deleted.
                ResetCustomerFields();
            }
        }

        private void AddNewCustomerRadio_CheckedChanged(object sender, EventArgs e)
        {
            add_ModifyCustomerBtn.Text = "Add Customer";
        }

        private void ModifyCustomerRadio_CheckedChanged(object sender, EventArgs e)
        {
            add_ModifyCustomerBtn.Text = "Modify Customer";
        }

        private void AddMovieSelected_CheckedChanged(object sender, EventArgs e)
        {
            addMovie.Text = "Add Movie";
        }

        private void ModifyMovieSelected_CheckedChanged(object sender, EventArgs e)
        {
            addMovie.Text = "Modify Movie";
        }

        private void CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CustomerRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if(this.CustomerRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
            }
            else
            {
                DataGridViewRow row = CustomersList.Rows[this.CustomerRowIndex];

                // Check's whether row is selected or not
                if(row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.CustomerRowIndex < CustomersList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        deleteCustomerBtn.Enabled = true;

                        customerID = Convert.ToInt32(row.Cells[0].Value);
                        firstNameField.Text = row.Cells[1].Value.ToString();
                        lastNameField.Text = row.Cells[2].Value.ToString();
                        addressField.Text = row.Cells[3].Value.ToString();
                        phoneNumberField.Text = row.Cells[4].Value.ToString();
                    }
                    else
                    {
                        deleteCustomerBtn.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");

                        // Clear all fields
                        ResetCustomerFields();
                    }
                }
                else
                {
                    // Clear all fields
                    ResetCustomerFields();
                }
            }
        }

        private void ResetMovieFields()
        {
            movieTitleText.Text = "";
            movieRatingsValue.Value = 0.5m;
            rentingCostValue.Text = "";
            comboBox1.SelectedIndex = 0;
            movieCopiesValue.Value = 0;
            MovieID = 0;

            deleteMovie.Enabled = false;
        }

        private void RentingDate_ValueChanged(object sender, EventArgs e)
        {
            if(rentingDate.Value.Date >= returningDate.Value.Date)
            {
                returningDate.Value = rentingDate.Value.AddDays(1);
            }
        }

        private void ReturningDate_ValueChanged(object sender, EventArgs e)
        {
            if (returningDate.Value.Date <= rentingDate.Value.Date)
            {
                returningDate.Value = rentingDate.Value.AddDays(1);
            }
            else
            {
                // Do nothing
            }
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            if(customerID > 0 && MovieID > 0)
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnection()))
                {
                    // Open Connection
                    conn.Open();

                    // Only issues movies if the copies of movie are available
                    if(movieCopiesValue.Value > 0)
                    {
                        using(SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                        {
                            _cmd.Parameters.AddWithValue("@copies", Convert.ToInt32(movieCopiesValue.Value - 1));
                            _cmd.Parameters.AddWithValue("@id", MovieID);
                            _cmd.ExecuteNonQuery();
                        }

                        // Add Movie to Rented Movies table
                        using(SqlCommand _cmd = new SqlCommand("INSERT INTO Rented (CustomerID, MovieID, RentFrom, RentTill) VALUES(@cid, @mid, @from, @till)", conn))
                        {
                            _cmd.Parameters.AddWithValue("@cid", customerID);
                            _cmd.Parameters.AddWithValue("@mid", MovieID);
                            _cmd.Parameters.AddWithValue("@from", rentingDate.Value);
                            _cmd.Parameters.AddWithValue("@till", returningDate.Value);
                            _cmd.ExecuteNonQuery();
                        }

                        // Calculate renting period in days
                        TimeSpan time = returningDate.Value.Subtract(rentingDate.Value);

                        // Display as pop-up message
                        Functions.DisplayMessage(firstNameField.Text + " has rented " + movieTitleText.Text + " for " + Convert.ToInt32(time.TotalDays) + " days!");

                        // Update all the tables
                        Database.AddToDataGridView("Movies", MoviesList);
                        Database.AddToDataGridView("Customers", CustomersList);
                        Database.AddToDataGridView("Rented", RentalsList);
                    }
                    else
                    {
                        Functions.DisplayMessage("All copies of " + movieTitleText.Text + " are rented!");
                    }
                }
            }
            else
            {
                if(customerID <= 0)
                {
                    Functions.DisplayMessage("Please Select the customer!");
                }
                else
                {
                    Functions.DisplayMessage("Please Select the Movie!");
                }
            }
        }

        private void RentalsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RentalRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if (this.RentalRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
            }
            else
            {
                DataGridViewRow row = RentalsList.Rows[this.RentalRowIndex];

                // Check's whether row is selected or not
                if (row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.RentalRowIndex < RentalsList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        deleteCustomerBtn.Enabled = true;

                        RentalRowID = Convert.ToInt32(row.Cells[0].Value);
                        rentingDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                        returningDate.Value = Convert.ToDateTime(row.Cells[4].Value);
                    }
                    else
                    {
                        deleteCustomerBtn.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");

                        // Clear all fields
                        ResetCustomerFields();
                    }
                }
                else
                {
                    // Clear all fields
                    ResetCustomerFields();
                }
            }
        }

        private void MoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            Database.TopUser();

        }

        private void topMovieBtn_Click(object sender, EventArgs e)
        {
            Database.TopRentedMovie();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Database.Delete("Rented", "RentalID", RentalRowID.ToString());

            Database.AddToDataGridView("Rented", RentalsList);

            using (SqlConnection conn = new SqlConnection(Connection.GetConnection()))
            {
                // Open Connection
                conn.Open();

                // Execute Query
                using(SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                {
                    int copies = 0;
                    SqlCommand _getcopies = new SqlCommand("SELECT MovieCopies FROM Movies WHERE MovieID=@mid", conn);
                    _getcopies.Parameters.AddWithValue("@mid", MovieID);
                    SqlDataReader reader = _getcopies.ExecuteReader();
                    while(reader.Read())
                    {
                        copies = Convert.ToInt32(reader["MovieCopies"]);
                    }
                    reader.Close();

                    _cmd.Parameters.AddWithValue("@copies", copies + 1);
                    _cmd.Parameters.AddWithValue("@id", MovieID);
                    _cmd.ExecuteNonQuery();
                }

                // Update Tables to keep the table data in sync
                Database.AddToDataGridView("Movies", MoviesList);
            }
        }

        private void ResetCustomerFields()
        {
            firstNameField.Text = "";
            lastNameField.Text = "";
            addressField.Text = "";
            phoneNumberField.Text = "";
            customerID = 0;
            deleteCustomerBtn.Enabled = false;
        }

        private void ResetRentalsFields()
        {
            rentingDate.Value = DateTime.Now;
            returningDate.Value = DateTime.Now.AddDays(1);
            RentalRowID = 0;
        }

        private void MoviesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MovieRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if (this.MovieRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
                ResetMovieFields();
            }
            else
            {
                DataGridViewRow row = MoviesList.Rows[this.MovieRowIndex];

                // Check's whether row is selected or not
                if (row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.MovieRowIndex < MoviesList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        deleteMovie.Enabled = true;

                        // Assign values to all the form fields
                        MovieID = Convert.ToInt32(row.Cells[0].Value);
                        movieTitleText.Text = row.Cells[1].Value.ToString();
                        movieReleaseDateValue.Value = Convert.ToDateTime(row.Cells[2].Value);
                        movieRatingsValue.Value = Convert.ToDecimal(row.Cells[3].Value);
                        movieCopiesValue.Value = Convert.ToInt32(row.Cells[4].Value);
                        rentingCostValue.Text = row.Cells[5].Value.ToString();
                        if (comboBox1.Items.Contains(row.Cells[6].Value.ToString()))
                        {
                            comboBox1.SelectedItem = row.Cells[6].Value.ToString();
                        }
                        else
                        {
                            comboBox1.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        deleteMovie.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");
                        ResetMovieFields();
                    }
                }
                else
                {
                    ResetMovieFields();
                }
            }
        }
    }
}
