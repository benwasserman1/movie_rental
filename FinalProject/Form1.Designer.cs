namespace FinalProject
{
    partial class Form1
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
            this.buttonDisplayInventory = new System.Windows.Forms.Button();
            this.buttonDisplayRented = new System.Windows.Forms.Button();
            this.buttonSearchGenre = new System.Windows.Forms.Button();
            this.buttonSearchTitle = new System.Windows.Forms.Button();
            this.buttonSearchPrice = new System.Windows.Forms.Button();
            this.textBoxGenreInput = new System.Windows.Forms.TextBox();
            this.textBoxPriceInput = new System.Windows.Forms.TextBox();
            this.textBoxTitleInput = new System.Windows.Forms.TextBox();
            this.textBoxAddMovieTitleInput = new System.Windows.Forms.TextBox();
            this.textBoxAddMovieGenreInput = new System.Windows.Forms.TextBox();
            this.textBoxAddMovieCategoryInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnterGenre = new System.Windows.Forms.Label();
            this.lblEnterCategory = new System.Windows.Forms.Label();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBoxMovieSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxMovieSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisplayInventory
            // 
            this.buttonDisplayInventory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDisplayInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayInventory.Location = new System.Drawing.Point(32, 272);
            this.buttonDisplayInventory.Name = "buttonDisplayInventory";
            this.buttonDisplayInventory.Size = new System.Drawing.Size(167, 53);
            this.buttonDisplayInventory.TabIndex = 0;
            this.buttonDisplayInventory.Text = "Show Movie Inventory";
            this.buttonDisplayInventory.UseVisualStyleBackColor = false;
            this.buttonDisplayInventory.Click += new System.EventHandler(this.buttonDisplayInventory_Click);
            // 
            // buttonDisplayRented
            // 
            this.buttonDisplayRented.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDisplayRented.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayRented.Location = new System.Drawing.Point(237, 272);
            this.buttonDisplayRented.Name = "buttonDisplayRented";
            this.buttonDisplayRented.Size = new System.Drawing.Size(171, 53);
            this.buttonDisplayRented.TabIndex = 2;
            this.buttonDisplayRented.Text = "Show Rented Movies";
            this.buttonDisplayRented.UseVisualStyleBackColor = false;
            this.buttonDisplayRented.Click += new System.EventHandler(this.buttonDisplayRented_Click);
            // 
            // buttonSearchGenre
            // 
            this.buttonSearchGenre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSearchGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchGenre.Location = new System.Drawing.Point(20, 55);
            this.buttonSearchGenre.Name = "buttonSearchGenre";
            this.buttonSearchGenre.Size = new System.Drawing.Size(122, 23);
            this.buttonSearchGenre.TabIndex = 3;
            this.buttonSearchGenre.Text = "Search Genre";
            this.buttonSearchGenre.UseVisualStyleBackColor = false;
            this.buttonSearchGenre.Click += new System.EventHandler(this.buttonSearchGenre_Click);
            // 
            // buttonSearchTitle
            // 
            this.buttonSearchTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSearchTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchTitle.Location = new System.Drawing.Point(20, 190);
            this.buttonSearchTitle.Name = "buttonSearchTitle";
            this.buttonSearchTitle.Size = new System.Drawing.Size(122, 23);
            this.buttonSearchTitle.TabIndex = 4;
            this.buttonSearchTitle.Text = "Search Title";
            this.buttonSearchTitle.UseVisualStyleBackColor = false;
            this.buttonSearchTitle.Click += new System.EventHandler(this.buttonSearchTitle_Click);
            // 
            // buttonSearchPrice
            // 
            this.buttonSearchPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSearchPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchPrice.Location = new System.Drawing.Point(20, 125);
            this.buttonSearchPrice.Name = "buttonSearchPrice";
            this.buttonSearchPrice.Size = new System.Drawing.Size(122, 21);
            this.buttonSearchPrice.TabIndex = 5;
            this.buttonSearchPrice.Text = "Search Price";
            this.buttonSearchPrice.UseVisualStyleBackColor = false;
            this.buttonSearchPrice.Click += new System.EventHandler(this.buttonSearchPrice_Click);
            // 
            // textBoxGenreInput
            // 
            this.textBoxGenreInput.Location = new System.Drawing.Point(20, 29);
            this.textBoxGenreInput.Name = "textBoxGenreInput";
            this.textBoxGenreInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxGenreInput.TabIndex = 6;
            // 
            // textBoxPriceInput
            // 
            this.textBoxPriceInput.Location = new System.Drawing.Point(20, 97);
            this.textBoxPriceInput.Name = "textBoxPriceInput";
            this.textBoxPriceInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxPriceInput.TabIndex = 7;
            // 
            // textBoxTitleInput
            // 
            this.textBoxTitleInput.Location = new System.Drawing.Point(20, 164);
            this.textBoxTitleInput.Name = "textBoxTitleInput";
            this.textBoxTitleInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxTitleInput.TabIndex = 8;
            // 
            // textBoxAddMovieTitleInput
            // 
            this.textBoxAddMovieTitleInput.Location = new System.Drawing.Point(19, 51);
            this.textBoxAddMovieTitleInput.Name = "textBoxAddMovieTitleInput";
            this.textBoxAddMovieTitleInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxAddMovieTitleInput.TabIndex = 9;
            // 
            // textBoxAddMovieGenreInput
            // 
            this.textBoxAddMovieGenreInput.Location = new System.Drawing.Point(19, 139);
            this.textBoxAddMovieGenreInput.Name = "textBoxAddMovieGenreInput";
            this.textBoxAddMovieGenreInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxAddMovieGenreInput.TabIndex = 10;
            // 
            // textBoxAddMovieCategoryInput
            // 
            this.textBoxAddMovieCategoryInput.Location = new System.Drawing.Point(19, 97);
            this.textBoxAddMovieCategoryInput.Name = "textBoxAddMovieCategoryInput";
            this.textBoxAddMovieCategoryInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxAddMovieCategoryInput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnterGenre);
            this.groupBox1.Controls.Add(this.lblEnterCategory);
            this.groupBox1.Controls.Add(this.lblEnterTitle);
            this.groupBox1.Controls.Add(this.buttonAddMovie);
            this.groupBox1.Controls.Add(this.textBoxAddMovieTitleInput);
            this.groupBox1.Controls.Add(this.textBoxAddMovieGenreInput);
            this.groupBox1.Controls.Add(this.textBoxAddMovieCategoryInput);
            this.groupBox1.Location = new System.Drawing.Point(237, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a movie";
            // 
            // lblEnterGenre
            // 
            this.lblEnterGenre.AutoSize = true;
            this.lblEnterGenre.Location = new System.Drawing.Point(16, 124);
            this.lblEnterGenre.Name = "lblEnterGenre";
            this.lblEnterGenre.Size = new System.Drawing.Size(36, 13);
            this.lblEnterGenre.TabIndex = 19;
            this.lblEnterGenre.Text = "Genre";
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Location = new System.Drawing.Point(16, 81);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(49, 13);
            this.lblEnterCategory.TabIndex = 18;
            this.lblEnterCategory.Text = "Category";
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Location = new System.Drawing.Point(16, 35);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(27, 13);
            this.lblEnterTitle.TabIndex = 17;
            this.lblEnterTitle.Text = "Title";
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddMovie.Location = new System.Drawing.Point(19, 169);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(122, 44);
            this.buttonAddMovie.TabIndex = 14;
            this.buttonAddMovie.Text = "Add the Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = false;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(101, 313);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 17;
            // 
            // groupBoxMovieSearch
            // 
            this.groupBoxMovieSearch.Controls.Add(this.buttonSearchPrice);
            this.groupBoxMovieSearch.Controls.Add(this.buttonSearchGenre);
            this.groupBoxMovieSearch.Controls.Add(this.buttonSearchTitle);
            this.groupBoxMovieSearch.Controls.Add(this.textBoxGenreInput);
            this.groupBoxMovieSearch.Controls.Add(this.textBoxPriceInput);
            this.groupBoxMovieSearch.Controls.Add(this.textBoxTitleInput);
            this.groupBoxMovieSearch.Location = new System.Drawing.Point(32, 29);
            this.groupBoxMovieSearch.Name = "groupBoxMovieSearch";
            this.groupBoxMovieSearch.Size = new System.Drawing.Size(167, 228);
            this.groupBoxMovieSearch.TabIndex = 18;
            this.groupBoxMovieSearch.TabStop = false;
            this.groupBoxMovieSearch.Text = "Search for a movie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 345);
            this.Controls.Add(this.groupBoxMovieSearch);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDisplayRented);
            this.Controls.Add(this.buttonDisplayInventory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMovieSearch.ResumeLayout(false);
            this.groupBoxMovieSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplayInventory;
        private System.Windows.Forms.Button buttonDisplayRented;
        private System.Windows.Forms.Button buttonSearchGenre;
        private System.Windows.Forms.Button buttonSearchTitle;
        private System.Windows.Forms.Button buttonSearchPrice;
        private System.Windows.Forms.TextBox textBoxGenreInput;
        private System.Windows.Forms.TextBox textBoxPriceInput;
        private System.Windows.Forms.TextBox textBoxTitleInput;
        private System.Windows.Forms.TextBox textBoxAddMovieTitleInput;
        private System.Windows.Forms.TextBox textBoxAddMovieGenreInput;
        private System.Windows.Forms.TextBox textBoxAddMovieCategoryInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.Label lblEnterGenre;
        private System.Windows.Forms.Label lblEnterCategory;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBoxMovieSearch;
    }
}

