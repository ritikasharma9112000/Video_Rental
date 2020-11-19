namespace Video_Rental
{
    partial class Video_Rental
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
            this.customertab = new System.Windows.Forms.TabControl();
            this.customer = new System.Windows.Forms.TabPage();
            this.customer_grid = new System.Windows.Forms.DataGridView();
            this.movie = new System.Windows.Forms.TabPage();
            this.movie_grid = new System.Windows.Forms.DataGridView();
            this.rental = new System.Windows.Forms.TabPage();
            this.rental_grid = new System.Windows.Forms.DataGridView();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.panelRental = new System.Windows.Forms.Panel();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.Movie_features = new System.Windows.Forms.Label();
            this.Rental_features = new System.Windows.Forms.Label();
            this.Customer_features = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Rental_cost = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Movie_ID = new System.Windows.Forms.Label();
            this.Customer_ID = new System.Windows.Forms.Label();
            this.Date_rented = new System.Windows.Forms.Label();
            this.Date_returned = new System.Windows.Forms.Label();
            this.First_name = new System.Windows.Forms.Label();
            this.Last_name = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Add_movie_btn = new System.Windows.Forms.Button();
            this.Delete_movie_btn = new System.Windows.Forms.Button();
            this.Update_movie_btn = new System.Windows.Forms.Button();
            this.Add_rental_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Update_renatl_btn = new System.Windows.Forms.Button();
            this.Add_customer_btn = new System.Windows.Forms.Button();
            this.Delete_customer_btn = new System.Windows.Forms.Button();
            this.Update_customer_btn = new System.Windows.Forms.Button();
            this.Delete_rental_btn = new System.Windows.Forms.Button();
            this.customertab.SuspendLayout();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_grid)).BeginInit();
            this.movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).BeginInit();
            this.rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rental_grid)).BeginInit();
            this.panelMovie.SuspendLayout();
            this.panelRental.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // customertab
            // 
            this.customertab.Controls.Add(this.customer);
            this.customertab.Controls.Add(this.movie);
            this.customertab.Controls.Add(this.rental);
            this.customertab.Location = new System.Drawing.Point(441, 12);
            this.customertab.Name = "customertab";
            this.customertab.SelectedIndex = 0;
            this.customertab.Size = new System.Drawing.Size(423, 309);
            this.customertab.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.DarkKhaki;
            this.customer.Controls.Add(this.customer_grid);
            this.customer.Controls.Add(this.button5);
            this.customer.Location = new System.Drawing.Point(4, 22);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(415, 283);
            this.customer.TabIndex = 0;
            this.customer.Text = "customer";
            // 
            // customer_grid
            // 
            this.customer_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_grid.Location = new System.Drawing.Point(6, 10);
            this.customer_grid.Name = "customer_grid";
            this.customer_grid.Size = new System.Drawing.Size(406, 267);
            this.customer_grid.TabIndex = 1;
            // 
            // movie
            // 
            this.movie.BackColor = System.Drawing.Color.RosyBrown;
            this.movie.Controls.Add(this.movie_grid);
            this.movie.Location = new System.Drawing.Point(4, 22);
            this.movie.Name = "movie";
            this.movie.Padding = new System.Windows.Forms.Padding(3);
            this.movie.Size = new System.Drawing.Size(331, 200);
            this.movie.TabIndex = 1;
            this.movie.Text = "movie";
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie_grid
            // 
            this.movie_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.movie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_grid.Location = new System.Drawing.Point(10, 6);
            this.movie_grid.Name = "movie_grid";
            this.movie_grid.Size = new System.Drawing.Size(315, 212);
            this.movie_grid.TabIndex = 0;
            this.movie_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movie_grid_CellContentClick);
            // 
            // rental
            // 
            this.rental.BackColor = System.Drawing.Color.DarkCyan;
            this.rental.Controls.Add(this.rental_grid);
            this.rental.Location = new System.Drawing.Point(4, 22);
            this.rental.Name = "rental";
            this.rental.Padding = new System.Windows.Forms.Padding(3);
            this.rental.Size = new System.Drawing.Size(331, 200);
            this.rental.TabIndex = 2;
            this.rental.Text = "rental";
            // 
            // rental_grid
            // 
            this.rental_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rental_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rental_grid.Location = new System.Drawing.Point(25, 25);
            this.rental_grid.Name = "rental_grid";
            this.rental_grid.Size = new System.Drawing.Size(300, 169);
            this.rental_grid.TabIndex = 1;
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.Update_movie_btn);
            this.panelMovie.Controls.Add(this.Delete_movie_btn);
            this.panelMovie.Controls.Add(this.Add_movie_btn);
            this.panelMovie.Controls.Add(this.textBox7);
            this.panelMovie.Controls.Add(this.Genre);
            this.panelMovie.Controls.Add(this.textBox5);
            this.panelMovie.Controls.Add(this.textBox6);
            this.panelMovie.Controls.Add(this.textBox4);
            this.panelMovie.Controls.Add(this.Plot);
            this.panelMovie.Controls.Add(this.Copies);
            this.panelMovie.Controls.Add(this.Rental_cost);
            this.panelMovie.Controls.Add(this.Year);
            this.panelMovie.Controls.Add(this.textBox3);
            this.panelMovie.Controls.Add(this.textBox1);
            this.panelMovie.Controls.Add(this.Movie_features);
            this.panelMovie.Controls.Add(this.textBox2);
            this.panelMovie.Controls.Add(this.Tittle);
            this.panelMovie.Controls.Add(this.Rating);
            this.panelMovie.Location = new System.Drawing.Point(38, 28);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(337, 332);
            this.panelMovie.TabIndex = 1;
            // 
            // panelRental
            // 
            this.panelRental.Controls.Add(this.Delete_rental_btn);
            this.panelRental.Controls.Add(this.textBox11);
            this.panelRental.Controls.Add(this.textBox10);
            this.panelRental.Controls.Add(this.Update_renatl_btn);
            this.panelRental.Controls.Add(this.textBox9);
            this.panelRental.Controls.Add(this.Add_rental_btn);
            this.panelRental.Controls.Add(this.textBox8);
            this.panelRental.Controls.Add(this.Date_returned);
            this.panelRental.Controls.Add(this.Date_rented);
            this.panelRental.Controls.Add(this.Rental_features);
            this.panelRental.Controls.Add(this.Movie_ID);
            this.panelRental.Controls.Add(this.Customer_ID);
            this.panelRental.Location = new System.Drawing.Point(38, 391);
            this.panelRental.Name = "panelRental";
            this.panelRental.Size = new System.Drawing.Size(337, 260);
            this.panelRental.TabIndex = 2;
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.Update_customer_btn);
            this.panelCustomer.Controls.Add(this.Delete_customer_btn);
            this.panelCustomer.Controls.Add(this.textBox15);
            this.panelCustomer.Controls.Add(this.Add_customer_btn);
            this.panelCustomer.Controls.Add(this.textBox14);
            this.panelCustomer.Controls.Add(this.textBox13);
            this.panelCustomer.Controls.Add(this.First_name);
            this.panelCustomer.Controls.Add(this.textBox12);
            this.panelCustomer.Controls.Add(this.Phone);
            this.panelCustomer.Controls.Add(this.Last_name);
            this.panelCustomer.Controls.Add(this.Address);
            this.panelCustomer.Controls.Add(this.Customer_features);
            this.panelCustomer.Location = new System.Drawing.Point(441, 357);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(419, 294);
            this.panelCustomer.TabIndex = 3;
            // 
            // Movie_features
            // 
            this.Movie_features.AutoSize = true;
            this.Movie_features.Location = new System.Drawing.Point(90, 4);
            this.Movie_features.Name = "Movie_features";
            this.Movie_features.Size = new System.Drawing.Size(77, 13);
            this.Movie_features.TabIndex = 0;
            this.Movie_features.Text = "Movie features";
            // 
            // Rental_features
            // 
            this.Rental_features.AutoSize = true;
            this.Rental_features.Location = new System.Drawing.Point(100, 7);
            this.Rental_features.Name = "Rental_features";
            this.Rental_features.Size = new System.Drawing.Size(79, 13);
            this.Rental_features.TabIndex = 4;
            this.Rental_features.Text = "Rental features";
            // 
            // Customer_features
            // 
            this.Customer_features.AutoSize = true;
            this.Customer_features.Location = new System.Drawing.Point(143, 12);
            this.Customer_features.Name = "Customer_features";
            this.Customer_features.Size = new System.Drawing.Size(92, 13);
            this.Customer_features.TabIndex = 4;
            this.Customer_features.Text = "Customer features";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(18, 28);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 5;
            this.Rating.Text = "Rating";
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Location = new System.Drawing.Point(18, 61);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(30, 13);
            this.Tittle.TabIndex = 6;
            this.Tittle.Text = "Tittle";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(18, 96);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 7;
            this.Year.Text = "Year";
            // 
            // Rental_cost
            // 
            this.Rental_cost.AutoSize = true;
            this.Rental_cost.Location = new System.Drawing.Point(18, 134);
            this.Rental_cost.Name = "Rental_cost";
            this.Rental_cost.Size = new System.Drawing.Size(61, 13);
            this.Rental_cost.TabIndex = 4;
            this.Rental_cost.Text = "Rental cost";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(18, 168);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 8;
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(18, 201);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(25, 13);
            this.Plot.TabIndex = 4;
            this.Plot.Text = "Plot";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(18, 236);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 9;
            this.Genre.Text = "Genre";
            // 
            // Movie_ID
            // 
            this.Movie_ID.AutoSize = true;
            this.Movie_ID.Location = new System.Drawing.Point(24, 53);
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Size = new System.Drawing.Size(50, 13);
            this.Movie_ID.TabIndex = 10;
            this.Movie_ID.Text = "Movie ID";
            // 
            // Customer_ID
            // 
            this.Customer_ID.AutoSize = true;
            this.Customer_ID.Location = new System.Drawing.Point(24, 95);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(65, 13);
            this.Customer_ID.TabIndex = 11;
            this.Customer_ID.Text = "Customer ID";
            this.Customer_ID.Click += new System.EventHandler(this.label9_Click);
            // 
            // Date_rented
            // 
            this.Date_rented.AutoSize = true;
            this.Date_rented.Location = new System.Drawing.Point(24, 142);
            this.Date_rented.Name = "Date_rented";
            this.Date_rented.Size = new System.Drawing.Size(63, 13);
            this.Date_rented.TabIndex = 12;
            this.Date_rented.Text = "Date rented";
            // 
            // Date_returned
            // 
            this.Date_returned.AutoSize = true;
            this.Date_returned.Location = new System.Drawing.Point(24, 186);
            this.Date_returned.Name = "Date_returned";
            this.Date_returned.Size = new System.Drawing.Size(72, 13);
            this.Date_returned.TabIndex = 4;
            this.Date_returned.Text = "Date returned";
            // 
            // First_name
            // 
            this.First_name.AutoSize = true;
            this.First_name.Location = new System.Drawing.Point(28, 77);
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(55, 13);
            this.First_name.TabIndex = 13;
            this.First_name.Text = "First name";
            // 
            // Last_name
            // 
            this.Last_name.AutoSize = true;
            this.Last_name.Location = new System.Drawing.Point(28, 118);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(56, 13);
            this.Last_name.TabIndex = 14;
            this.Last_name.Text = "Last name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(28, 167);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 15;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(28, 213);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(207, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(207, 236);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(198, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(198, 92);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(198, 139);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(198, 179);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 12;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(250, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(250, 110);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 16;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(250, 160);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 17;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(250, 206);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 18;
            // 
            // Add_movie_btn
            // 
            this.Add_movie_btn.Location = new System.Drawing.Point(27, 290);
            this.Add_movie_btn.Name = "Add_movie_btn";
            this.Add_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_movie_btn.TabIndex = 23;
            this.Add_movie_btn.Text = "Add";
            this.Add_movie_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_movie_btn
            // 
            this.Delete_movie_btn.Location = new System.Drawing.Point(130, 290);
            this.Delete_movie_btn.Name = "Delete_movie_btn";
            this.Delete_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_movie_btn.TabIndex = 24;
            this.Delete_movie_btn.Text = "Delete";
            this.Delete_movie_btn.UseVisualStyleBackColor = true;
            // 
            // Update_movie_btn
            // 
            this.Update_movie_btn.Location = new System.Drawing.Point(244, 290);
            this.Update_movie_btn.Name = "Update_movie_btn";
            this.Update_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_movie_btn.TabIndex = 25;
            this.Update_movie_btn.Text = "Update";
            this.Update_movie_btn.UseVisualStyleBackColor = true;
            // 
            // Add_rental_btn
            // 
            this.Add_rental_btn.Location = new System.Drawing.Point(27, 222);
            this.Add_rental_btn.Name = "Add_rental_btn";
            this.Add_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_rental_btn.TabIndex = 26;
            this.Add_rental_btn.Text = "Add";
            this.Add_rental_btn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Update_renatl_btn
            // 
            this.Update_renatl_btn.Location = new System.Drawing.Point(223, 222);
            this.Update_renatl_btn.Name = "Update_renatl_btn";
            this.Update_renatl_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_renatl_btn.TabIndex = 28;
            this.Update_renatl_btn.Text = "Update";
            this.Update_renatl_btn.UseVisualStyleBackColor = true;
            // 
            // Add_customer_btn
            // 
            this.Add_customer_btn.Location = new System.Drawing.Point(46, 256);
            this.Add_customer_btn.Name = "Add_customer_btn";
            this.Add_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_customer_btn.TabIndex = 29;
            this.Add_customer_btn.Text = "Add";
            this.Add_customer_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_customer_btn
            // 
            this.Delete_customer_btn.Location = new System.Drawing.Point(180, 256);
            this.Delete_customer_btn.Name = "Delete_customer_btn";
            this.Delete_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_customer_btn.TabIndex = 30;
            this.Delete_customer_btn.Text = "Delete";
            this.Delete_customer_btn.UseVisualStyleBackColor = true;
            // 
            // Update_customer_btn
            // 
            this.Update_customer_btn.Location = new System.Drawing.Point(292, 259);
            this.Update_customer_btn.Name = "Update_customer_btn";
            this.Update_customer_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_customer_btn.TabIndex = 26;
            this.Update_customer_btn.Text = "Update";
            this.Update_customer_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_rental_btn
            // 
            this.Delete_rental_btn.Location = new System.Drawing.Point(130, 222);
            this.Delete_rental_btn.Name = "Delete_rental_btn";
            this.Delete_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_rental_btn.TabIndex = 29;
            this.Delete_rental_btn.Text = "Delete";
            this.Delete_rental_btn.UseVisualStyleBackColor = true;
            // 
            // Video_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 682);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelRental);
            this.Controls.Add(this.panelMovie);
            this.Controls.Add(this.customertab);
            this.Name = "Video_Rental";
            this.Text = "Video_Rental ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customertab.ResumeLayout(false);
            this.customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_grid)).EndInit();
            this.movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).EndInit();
            this.rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rental_grid)).EndInit();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.panelRental.ResumeLayout(false);
            this.panelRental.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl customertab;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.TabPage movie;
        private System.Windows.Forms.TabPage rental;
        private System.Windows.Forms.DataGridView customer_grid;
        private System.Windows.Forms.DataGridView movie_grid;
        private System.Windows.Forms.DataGridView rental_grid;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Panel panelRental;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label Movie_features;
        private System.Windows.Forms.Label Rental_features;
        private System.Windows.Forms.Label Customer_features;
        private System.Windows.Forms.Label Date_rented;
        private System.Windows.Forms.Label Customer_ID;
        private System.Windows.Forms.Label Movie_ID;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label Rental_cost;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Date_returned;
        private System.Windows.Forms.Label First_name;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Last_name;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Update_movie_btn;
        private System.Windows.Forms.Button Delete_movie_btn;
        private System.Windows.Forms.Button Add_movie_btn;
        private System.Windows.Forms.Button Delete_rental_btn;
        private System.Windows.Forms.Button Update_renatl_btn;
        private System.Windows.Forms.Button Add_rental_btn;
        private System.Windows.Forms.Button Update_customer_btn;
        private System.Windows.Forms.Button Delete_customer_btn;
        private System.Windows.Forms.Button Add_customer_btn;
    }
}

