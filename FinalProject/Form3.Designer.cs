namespace FinalProject
{
    partial class Form3
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMoviePrice = new System.Windows.Forms.Label();
            this.buttonReturnHome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblDaysRented = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(20, 67);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(0, 13);
            this.lblMovieTitle.TabIndex = 0;
            // 
            // lblMoviePrice
            // 
            this.lblMoviePrice.AutoSize = true;
            this.lblMoviePrice.Location = new System.Drawing.Point(20, 99);
            this.lblMoviePrice.Name = "lblMoviePrice";
            this.lblMoviePrice.Size = new System.Drawing.Size(0, 13);
            this.lblMoviePrice.TabIndex = 1;
            // 
            // buttonReturnHome
            // 
            this.buttonReturnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturnHome.Location = new System.Drawing.Point(23, 186);
            this.buttonReturnHome.Name = "buttonReturnHome";
            this.buttonReturnHome.Size = new System.Drawing.Size(139, 23);
            this.buttonReturnHome.TabIndex = 3;
            this.buttonReturnHome.Text = "Return to Movies";
            this.buttonReturnHome.UseVisualStyleBackColor = false;
            this.buttonReturnHome.Click += new System.EventHandler(this.buttonReturnHome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(216, 186);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Location = new System.Drawing.Point(20, 33);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(132, 13);
            this.lblThankYou.TabIndex = 5;
            this.lblThankYou.Text = "Thanks for renting with us!";
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Location = new System.Drawing.Point(20, 128);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(0, 13);
            this.lblDaysRented.TabIndex = 6;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(20, 158);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCost.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDaysRented);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReturnHome);
            this.Controls.Add(this.lblMoviePrice);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMoviePrice;
        private System.Windows.Forms.Button buttonReturnHome;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblDaysRented;
        private System.Windows.Forms.Label lblTotalCost;
    }
}