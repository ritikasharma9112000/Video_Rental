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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customertab.SuspendLayout();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_grid)).BeginInit();
            this.movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).BeginInit();
            this.rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rental_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // customertab
            // 
            this.customertab.Controls.Add(this.customer);
            this.customertab.Controls.Add(this.movie);
            this.customertab.Controls.Add(this.rental);
            this.customertab.Location = new System.Drawing.Point(419, 0);
            this.customertab.Name = "customertab";
            this.customertab.SelectedIndex = 0;
            this.customertab.Size = new System.Drawing.Size(339, 226);
            this.customertab.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.DarkKhaki;
            this.customer.Controls.Add(this.customer_grid);
            this.customer.Location = new System.Drawing.Point(4, 22);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(331, 200);
            this.customer.TabIndex = 0;
            this.customer.Text = "customer";
            // 
            // customer_grid
            // 
            this.customer_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_grid.Location = new System.Drawing.Point(9, 6);
            this.customer_grid.Name = "customer_grid";
            this.customer_grid.Size = new System.Drawing.Size(319, 188);
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
            this.movie_grid.Location = new System.Drawing.Point(6, 6);
            this.movie_grid.Name = "movie_grid";
            this.movie_grid.Size = new System.Drawing.Size(319, 191);
            this.movie_grid.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 126);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(38, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 127);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(423, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 100);
            this.panel3.TabIndex = 3;
            // 
            // Video_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

