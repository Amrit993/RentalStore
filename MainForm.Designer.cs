namespace MovieRentalStore
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Movies = new System.Windows.Forms.TabPage();
            this.topMovieBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.MoviesList = new System.Windows.Forms.DataGridView();
            this.RowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRentingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteMovie = new System.Windows.Forms.Button();
            this.modifyMovieSelected = new System.Windows.Forms.RadioButton();
            this.addMovieSelected = new System.Windows.Forms.RadioButton();
            this.addMovie = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rentingCostValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movieCopiesValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.movieReleaseDateValue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.movieRatingsValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieTitleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_Customers = new System.Windows.Forms.TabPage();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.add_ModifyCustomerBtn = new System.Windows.Forms.Button();
            this.modifyCustomerRadio = new System.Windows.Forms.RadioButton();
            this.addNewCustomerRadio = new System.Windows.Forms.RadioButton();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomersList = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_Rentals = new System.Windows.Forms.TabPage();
            this.Return = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.returningDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.rentingDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RentalsList = new System.Windows.Forms.DataGridView();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent_Till = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Tab_Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsValue)).BeginInit();
            this.Tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).BeginInit();
            this.Tab_Rentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Movies);
            this.tabControl1.Controls.Add(this.Tab_Customers);
            this.tabControl1.Controls.Add(this.Tab_Rentals);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1597, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Movies
            // 
            this.Tab_Movies.Controls.Add(this.topMovieBtn);
            this.Tab_Movies.Controls.Add(this.viewBtn);
            this.Tab_Movies.Controls.Add(this.MoviesList);
            this.Tab_Movies.Controls.Add(this.deleteMovie);
            this.Tab_Movies.Controls.Add(this.modifyMovieSelected);
            this.Tab_Movies.Controls.Add(this.addMovieSelected);
            this.Tab_Movies.Controls.Add(this.addMovie);
            this.Tab_Movies.Controls.Add(this.comboBox1);
            this.Tab_Movies.Controls.Add(this.label7);
            this.Tab_Movies.Controls.Add(this.rentingCostValue);
            this.Tab_Movies.Controls.Add(this.label6);
            this.Tab_Movies.Controls.Add(this.movieCopiesValue);
            this.Tab_Movies.Controls.Add(this.label5);
            this.Tab_Movies.Controls.Add(this.movieReleaseDateValue);
            this.Tab_Movies.Controls.Add(this.label4);
            this.Tab_Movies.Controls.Add(this.movieRatingsValue);
            this.Tab_Movies.Controls.Add(this.label3);
            this.Tab_Movies.Controls.Add(this.label2);
            this.Tab_Movies.Controls.Add(this.movieTitleText);
            this.Tab_Movies.Controls.Add(this.label1);
            this.Tab_Movies.Location = new System.Drawing.Point(4, 25);
            this.Tab_Movies.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Movies.Name = "Tab_Movies";
            this.Tab_Movies.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Movies.Size = new System.Drawing.Size(1589, 761);
            this.Tab_Movies.TabIndex = 0;
            this.Tab_Movies.Text = "Movies";
            this.Tab_Movies.UseVisualStyleBackColor = true;
            // 
            // topMovieBtn
            // 
            this.topMovieBtn.Location = new System.Drawing.Point(471, 711);
            this.topMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.topMovieBtn.Name = "topMovieBtn";
            this.topMovieBtn.Size = new System.Drawing.Size(202, 46);
            this.topMovieBtn.TabIndex = 20;
            this.topMovieBtn.Text = "Top Movie";
            this.topMovieBtn.UseVisualStyleBackColor = true;
            this.topMovieBtn.Click += new System.EventHandler(this.topMovieBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(261, 711);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(202, 46);
            this.viewBtn.TabIndex = 19;
            this.viewBtn.Text = "Top Customer";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // MoviesList
            // 
            this.MoviesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowID,
            this.MovieTitle,
            this.MovieReleaseDate,
            this.MovieRatings,
            this.MovieCopies,
            this.MovieRentingCost,
            this.MovieGenre});
            this.MoviesList.Location = new System.Drawing.Point(0, 0);
            this.MoviesList.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.RowHeadersWidth = 51;
            this.MoviesList.Size = new System.Drawing.Size(1044, 398);
            this.MoviesList.TabIndex = 18;
            this.MoviesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesList_CellClick);
            this.MoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesList_CellContentClick);
            // 
            // RowID
            // 
            this.RowID.DataPropertyName = "MovieID";
            this.RowID.HeaderText = "ID";
            this.RowID.MinimumWidth = 6;
            this.RowID.Name = "RowID";
            this.RowID.ReadOnly = true;
            this.RowID.Width = 25;
            // 
            // MovieTitle
            // 
            this.MovieTitle.DataPropertyName = "MovieTitle";
            this.MovieTitle.HeaderText = "Title";
            this.MovieTitle.MinimumWidth = 6;
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Width = 185;
            // 
            // MovieReleaseDate
            // 
            this.MovieReleaseDate.DataPropertyName = "MovieReleaseDate";
            this.MovieReleaseDate.HeaderText = "ReleaseDate";
            this.MovieReleaseDate.MinimumWidth = 6;
            this.MovieReleaseDate.Name = "MovieReleaseDate";
            this.MovieReleaseDate.ReadOnly = true;
            this.MovieReleaseDate.Width = 175;
            // 
            // MovieRatings
            // 
            this.MovieRatings.DataPropertyName = "MovieRatings";
            this.MovieRatings.HeaderText = "Ratings";
            this.MovieRatings.MinimumWidth = 6;
            this.MovieRatings.Name = "MovieRatings";
            this.MovieRatings.ReadOnly = true;
            this.MovieRatings.Width = 125;
            // 
            // MovieCopies
            // 
            this.MovieCopies.DataPropertyName = "MovieCopies";
            this.MovieCopies.HeaderText = "Available Copies";
            this.MovieCopies.MinimumWidth = 6;
            this.MovieCopies.Name = "MovieCopies";
            this.MovieCopies.ReadOnly = true;
            this.MovieCopies.Width = 130;
            // 
            // MovieRentingCost
            // 
            this.MovieRentingCost.DataPropertyName = "MovieRentingCost";
            this.MovieRentingCost.HeaderText = "Cost";
            this.MovieRentingCost.MinimumWidth = 6;
            this.MovieRentingCost.Name = "MovieRentingCost";
            this.MovieRentingCost.ReadOnly = true;
            this.MovieRentingCost.Width = 125;
            // 
            // MovieGenre
            // 
            this.MovieGenre.DataPropertyName = "MovieGenre";
            this.MovieGenre.HeaderText = "Genre";
            this.MovieGenre.MinimumWidth = 6;
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.ReadOnly = true;
            this.MovieGenre.Width = 125;
            // 
            // deleteMovie
            // 
            this.deleteMovie.Enabled = false;
            this.deleteMovie.Location = new System.Drawing.Point(527, 661);
            this.deleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMovie.Name = "deleteMovie";
            this.deleteMovie.Size = new System.Drawing.Size(411, 46);
            this.deleteMovie.TabIndex = 17;
            this.deleteMovie.Text = "Delete Movie";
            this.deleteMovie.UseVisualStyleBackColor = true;
            this.deleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // modifyMovieSelected
            // 
            this.modifyMovieSelected.AutoSize = true;
            this.modifyMovieSelected.Location = new System.Drawing.Point(257, 632);
            this.modifyMovieSelected.Margin = new System.Windows.Forms.Padding(4);
            this.modifyMovieSelected.Name = "modifyMovieSelected";
            this.modifyMovieSelected.Size = new System.Drawing.Size(170, 21);
            this.modifyMovieSelected.TabIndex = 16;
            this.modifyMovieSelected.Text = "Modify Selected Movie";
            this.modifyMovieSelected.UseVisualStyleBackColor = true;
            this.modifyMovieSelected.CheckedChanged += new System.EventHandler(this.ModifyMovieSelected_CheckedChanged);
            // 
            // addMovieSelected
            // 
            this.addMovieSelected.AutoSize = true;
            this.addMovieSelected.Checked = true;
            this.addMovieSelected.Location = new System.Drawing.Point(23, 632);
            this.addMovieSelected.Margin = new System.Windows.Forms.Padding(4);
            this.addMovieSelected.Name = "addMovieSelected";
            this.addMovieSelected.Size = new System.Drawing.Size(126, 21);
            this.addMovieSelected.TabIndex = 15;
            this.addMovieSelected.TabStop = true;
            this.addMovieSelected.Text = "Add New Movie";
            this.addMovieSelected.UseVisualStyleBackColor = true;
            this.addMovieSelected.CheckedChanged += new System.EventHandler(this.AddMovieSelected_CheckedChanged);
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(23, 661);
            this.addMovie.Margin = new System.Windows.Forms.Padding(4);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(411, 46);
            this.addMovie.TabIndex = 14;
            this.addMovie.Text = "Add Movie";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(527, 599);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(409, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 572);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Movie Genre";
            // 
            // rentingCostValue
            // 
            this.rentingCostValue.Location = new System.Drawing.Point(527, 544);
            this.rentingCostValue.Margin = new System.Windows.Forms.Padding(4);
            this.rentingCostValue.Name = "rentingCostValue";
            this.rentingCostValue.Size = new System.Drawing.Size(409, 22);
            this.rentingCostValue.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 518);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Renting Cost";
            // 
            // movieCopiesValue
            // 
            this.movieCopiesValue.Location = new System.Drawing.Point(527, 489);
            this.movieCopiesValue.Margin = new System.Windows.Forms.Padding(4);
            this.movieCopiesValue.Name = "movieCopiesValue";
            this.movieCopiesValue.Size = new System.Drawing.Size(411, 22);
            this.movieCopiesValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available Copies";
            // 
            // movieReleaseDateValue
            // 
            this.movieReleaseDateValue.Location = new System.Drawing.Point(23, 596);
            this.movieReleaseDateValue.Margin = new System.Windows.Forms.Padding(4);
            this.movieReleaseDateValue.Name = "movieReleaseDateValue";
            this.movieReleaseDateValue.Size = new System.Drawing.Size(409, 22);
            this.movieReleaseDateValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release Date";
            // 
            // movieRatingsValue
            // 
            this.movieRatingsValue.DecimalPlaces = 1;
            this.movieRatingsValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.movieRatingsValue.Location = new System.Drawing.Point(23, 541);
            this.movieRatingsValue.Margin = new System.Windows.Forms.Padding(4);
            this.movieRatingsValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.movieRatingsValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.movieRatingsValue.Name = "movieRatingsValue";
            this.movieRatingsValue.Size = new System.Drawing.Size(411, 22);
            this.movieRatingsValue.TabIndex = 5;
            this.movieRatingsValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 514);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movie Ratings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Title";
            // 
            // movieTitleText
            // 
            this.movieTitleText.Location = new System.Drawing.Point(23, 485);
            this.movieTitleText.Margin = new System.Windows.Forms.Padding(4);
            this.movieTitleText.Name = "movieTitleText";
            this.movieTitleText.Size = new System.Drawing.Size(409, 22);
            this.movieTitleText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(344, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOVIES";
            // 
            // Tab_Customers
            // 
            this.Tab_Customers.Controls.Add(this.deleteCustomerBtn);
            this.Tab_Customers.Controls.Add(this.add_ModifyCustomerBtn);
            this.Tab_Customers.Controls.Add(this.modifyCustomerRadio);
            this.Tab_Customers.Controls.Add(this.addNewCustomerRadio);
            this.Tab_Customers.Controls.Add(this.phoneNumberField);
            this.Tab_Customers.Controls.Add(this.label11);
            this.Tab_Customers.Controls.Add(this.addressField);
            this.Tab_Customers.Controls.Add(this.AddressLabel);
            this.Tab_Customers.Controls.Add(this.lastNameField);
            this.Tab_Customers.Controls.Add(this.label10);
            this.Tab_Customers.Controls.Add(this.firstNameField);
            this.Tab_Customers.Controls.Add(this.label9);
            this.Tab_Customers.Controls.Add(this.label8);
            this.Tab_Customers.Controls.Add(this.CustomersList);
            this.Tab_Customers.Location = new System.Drawing.Point(4, 25);
            this.Tab_Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Customers.Name = "Tab_Customers";
            this.Tab_Customers.Size = new System.Drawing.Size(1589, 761);
            this.Tab_Customers.TabIndex = 2;
            this.Tab_Customers.Text = "Customers";
            this.Tab_Customers.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Enabled = false;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(453, 701);
            this.deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(419, 49);
            this.deleteCustomerBtn.TabIndex = 15;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // add_ModifyCustomerBtn
            // 
            this.add_ModifyCustomerBtn.Location = new System.Drawing.Point(16, 701);
            this.add_ModifyCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.add_ModifyCustomerBtn.Name = "add_ModifyCustomerBtn";
            this.add_ModifyCustomerBtn.Size = new System.Drawing.Size(413, 49);
            this.add_ModifyCustomerBtn.TabIndex = 14;
            this.add_ModifyCustomerBtn.Text = "Add Customer";
            this.add_ModifyCustomerBtn.UseVisualStyleBackColor = true;
            this.add_ModifyCustomerBtn.Click += new System.EventHandler(this.Add_ModifyCustomerBtn_Click);
            // 
            // modifyCustomerRadio
            // 
            this.modifyCustomerRadio.AutoSize = true;
            this.modifyCustomerRadio.Location = new System.Drawing.Point(240, 671);
            this.modifyCustomerRadio.Margin = new System.Windows.Forms.Padding(4);
            this.modifyCustomerRadio.Name = "modifyCustomerRadio";
            this.modifyCustomerRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modifyCustomerRadio.Size = new System.Drawing.Size(186, 21);
            this.modifyCustomerRadio.TabIndex = 13;
            this.modifyCustomerRadio.Text = "Modify Existing Customer";
            this.modifyCustomerRadio.UseVisualStyleBackColor = true;
            this.modifyCustomerRadio.CheckedChanged += new System.EventHandler(this.ModifyCustomerRadio_CheckedChanged);
            // 
            // addNewCustomerRadio
            // 
            this.addNewCustomerRadio.AutoSize = true;
            this.addNewCustomerRadio.Checked = true;
            this.addNewCustomerRadio.Location = new System.Drawing.Point(16, 671);
            this.addNewCustomerRadio.Margin = new System.Windows.Forms.Padding(4);
            this.addNewCustomerRadio.Name = "addNewCustomerRadio";
            this.addNewCustomerRadio.Size = new System.Drawing.Size(149, 21);
            this.addNewCustomerRadio.TabIndex = 12;
            this.addNewCustomerRadio.TabStop = true;
            this.addNewCustomerRadio.Text = "Add New Customer";
            this.addNewCustomerRadio.UseVisualStyleBackColor = true;
            this.addNewCustomerRadio.CheckedChanged += new System.EventHandler(this.AddNewCustomerRadio_CheckedChanged);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(16, 638);
            this.phoneNumberField.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberField.MaxLength = 10;
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(412, 22);
            this.phoneNumberField.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 611);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Phone Number";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(16, 583);
            this.addressField.Margin = new System.Windows.Forms.Padding(4);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(412, 22);
            this.addressField.TabIndex = 9;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(14, 557);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(80, 24);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(18, 528);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(412, 22);
            this.lastNameField.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 501);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Last Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(18, 473);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(412, 22);
            this.firstNameField.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(337, 394);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 60);
            this.label8.TabIndex = 2;
            this.label8.Text = "CUSTOMERS";
            // 
            // CustomersList
            // 
            this.CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.PhoneNumber});
            this.CustomersList.Location = new System.Drawing.Point(0, 0);
            this.CustomersList.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.RowHeadersWidth = 51;
            this.CustomersList.Size = new System.Drawing.Size(978, 366);
            this.CustomersList.TabIndex = 0;
            this.CustomersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersList_CellClick);
            // 
            // CustID
            // 
            this.CustID.DataPropertyName = "CustomerID";
            this.CustID.HeaderText = "ID";
            this.CustID.MinimumWidth = 6;
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 165;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // Tab_Rentals
            // 
            this.Tab_Rentals.Controls.Add(this.Return);
            this.Tab_Rentals.Controls.Add(this.Rent);
            this.Tab_Rentals.Controls.Add(this.returningDate);
            this.Tab_Rentals.Controls.Add(this.label14);
            this.Tab_Rentals.Controls.Add(this.rentingDate);
            this.Tab_Rentals.Controls.Add(this.label13);
            this.Tab_Rentals.Controls.Add(this.label12);
            this.Tab_Rentals.Controls.Add(this.RentalsList);
            this.Tab_Rentals.Location = new System.Drawing.Point(4, 25);
            this.Tab_Rentals.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Rentals.Name = "Tab_Rentals";
            this.Tab_Rentals.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Rentals.Size = new System.Drawing.Size(1589, 761);
            this.Tab_Rentals.TabIndex = 1;
            this.Tab_Rentals.Text = "Rentals";
            this.Tab_Rentals.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.Navy;
            this.Return.Location = new System.Drawing.Point(472, 530);
            this.Return.Margin = new System.Windows.Forms.Padding(4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(204, 55);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return Movie";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Rent
            // 
            this.Rent.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.ForeColor = System.Drawing.Color.Navy;
            this.Rent.Location = new System.Drawing.Point(131, 530);
            this.Rent.Margin = new System.Windows.Forms.Padding(4);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(204, 55);
            this.Rent.TabIndex = 8;
            this.Rent.Text = "Rent Movie";
            this.Rent.UseVisualStyleBackColor = true;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // returningDate
            // 
            this.returningDate.Location = new System.Drawing.Point(529, 465);
            this.returningDate.Margin = new System.Windows.Forms.Padding(4);
            this.returningDate.Name = "returningDate";
            this.returningDate.Size = new System.Drawing.Size(412, 22);
            this.returningDate.TabIndex = 7;
            this.returningDate.ValueChanged += new System.EventHandler(this.ReturningDate_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(525, 438);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 33);
            this.label14.TabIndex = 6;
            this.label14.Text = "Rent Till";
            // 
            // rentingDate
            // 
            this.rentingDate.Location = new System.Drawing.Point(27, 465);
            this.rentingDate.Margin = new System.Windows.Forms.Padding(4);
            this.rentingDate.Name = "rentingDate";
            this.rentingDate.Size = new System.Drawing.Size(412, 22);
            this.rentingDate.TabIndex = 5;
            this.rentingDate.ValueChanged += new System.EventHandler(this.RentingDate_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 437);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 33);
            this.label13.TabIndex = 4;
            this.label13.Text = "Rent From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(413, 379);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 56);
            this.label12.TabIndex = 3;
            this.label12.Text = "RENTING";
            // 
            // RentalsList
            // 
            this.RentalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.Movie_ID,
            this.Customer_ID,
            this.RentFrom,
            this.Rent_Till});
            this.RentalsList.Location = new System.Drawing.Point(5, 5);
            this.RentalsList.Margin = new System.Windows.Forms.Padding(4);
            this.RentalsList.Name = "RentalsList";
            this.RentalsList.RowHeadersWidth = 51;
            this.RentalsList.Size = new System.Drawing.Size(1072, 370);
            this.RentalsList.TabIndex = 0;
            this.RentalsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalsList_CellClick);
            // 
            // RentalID
            // 
            this.RentalID.DataPropertyName = "RentalID";
            this.RentalID.HeaderText = "ID";
            this.RentalID.MinimumWidth = 6;
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            this.RentalID.Width = 125;
            // 
            // Movie_ID
            // 
            this.Movie_ID.DataPropertyName = "MovieID";
            this.Movie_ID.HeaderText = "MovieID";
            this.Movie_ID.MinimumWidth = 6;
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.ReadOnly = true;
            this.Movie_ID.Width = 125;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CustomerID";
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Width = 125;
            // 
            // RentFrom
            // 
            this.RentFrom.DataPropertyName = "RentFrom";
            this.RentFrom.HeaderText = "Rent From";
            this.RentFrom.MinimumWidth = 6;
            this.RentFrom.Name = "RentFrom";
            this.RentFrom.ReadOnly = true;
            this.RentFrom.Width = 255;
            // 
            // Rent_Till
            // 
            this.Rent_Till.DataPropertyName = "RentTIll";
            this.Rent_Till.HeaderText = "RentTill";
            this.Rent_Till.MinimumWidth = 6;
            this.Rent_Till.Name = "Rent_Till";
            this.Rent_Till.ReadOnly = true;
            this.Rent_Till.Width = 255;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 790);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Movies.ResumeLayout(false);
            this.Tab_Movies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsValue)).EndInit();
            this.Tab_Customers.ResumeLayout(false);
            this.Tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).EndInit();
            this.Tab_Rentals.ResumeLayout(false);
            this.Tab_Rentals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Movies;
        private System.Windows.Forms.TabPage Tab_Rentals;
        private System.Windows.Forms.TabPage Tab_Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieTitleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown movieCopiesValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker movieReleaseDateValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown movieRatingsValue;
        private System.Windows.Forms.TextBox rentingCostValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton modifyMovieSelected;
        private System.Windows.Forms.RadioButton addMovieSelected;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button deleteMovie;
        private System.Windows.Forms.DataGridView MoviesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRentingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieGenre;
        private System.Windows.Forms.DataGridView CustomersList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.RadioButton modifyCustomerRadio;
        private System.Windows.Forms.RadioButton addNewCustomerRadio;
        private System.Windows.Forms.Button add_ModifyCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridView RentalsList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker rentingDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker returningDate;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent_Till;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button topMovieBtn;
    }
}

