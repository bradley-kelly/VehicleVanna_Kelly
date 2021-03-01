
namespace VehicleVanna_Test
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CarMake = new System.Windows.Forms.Label();
            this.CarMakeBox = new System.Windows.Forms.TextBox();
            this.CarModel = new System.Windows.Forms.Label();
            this.CarModelBox = new System.Windows.Forms.TextBox();
            this.CarYear = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ListPrice = new System.Windows.Forms.Label();
            this.VehicleType = new System.Windows.Forms.Label();
            this.ListPriceBox = new System.Windows.Forms.NumericUpDown();
            this.VehicleTypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListPriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(60, 169);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(225, 30);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Tag = "";
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(9, 14);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(12, 30);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 2;
            this.FirstNameBox.Tag = "";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(115, 14);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(118, 29);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(221, 14);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(224, 30);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // CarMake
            // 
            this.CarMake.AutoSize = true;
            this.CarMake.Location = new System.Drawing.Point(9, 63);
            this.CarMake.Name = "CarMake";
            this.CarMake.Size = new System.Drawing.Size(53, 13);
            this.CarMake.TabIndex = 7;
            this.CarMake.Text = "Car Make";
            // 
            // CarMakeBox
            // 
            this.CarMakeBox.Location = new System.Drawing.Point(12, 79);
            this.CarMakeBox.Name = "CarMakeBox";
            this.CarMakeBox.Size = new System.Drawing.Size(100, 20);
            this.CarMakeBox.TabIndex = 8;
            // 
            // CarModel
            // 
            this.CarModel.AutoSize = true;
            this.CarModel.Location = new System.Drawing.Point(115, 63);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(55, 13);
            this.CarModel.TabIndex = 9;
            this.CarModel.Text = "Car Model";
            // 
            // CarModelBox
            // 
            this.CarModelBox.Location = new System.Drawing.Point(118, 79);
            this.CarModelBox.Name = "CarModelBox";
            this.CarModelBox.Size = new System.Drawing.Size(100, 20);
            this.CarModelBox.TabIndex = 10;
            // 
            // CarYear
            // 
            this.CarYear.AutoSize = true;
            this.CarYear.Location = new System.Drawing.Point(221, 63);
            this.CarYear.Name = "CarYear";
            this.CarYear.Size = new System.Drawing.Size(48, 13);
            this.CarYear.TabIndex = 11;
            this.CarYear.Text = "Car Year";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(224, 79);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(100, 20);
            this.YearBox.TabIndex = 12;
            // 
            // ListPrice
            // 
            this.ListPrice.AutoSize = true;
            this.ListPrice.Location = new System.Drawing.Point(9, 111);
            this.ListPrice.Name = "ListPrice";
            this.ListPrice.Size = new System.Drawing.Size(50, 13);
            this.ListPrice.TabIndex = 13;
            this.ListPrice.Text = "List Price";
            // 
            // VehicleType
            // 
            this.VehicleType.AutoSize = true;
            this.VehicleType.Location = new System.Drawing.Point(221, 111);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(69, 13);
            this.VehicleType.TabIndex = 15;
            this.VehicleType.Text = "Vehicle Type";
            // 
            // ListPriceBox
            // 
            this.ListPriceBox.Location = new System.Drawing.Point(12, 127);
            this.ListPriceBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ListPriceBox.Name = "ListPriceBox";
            this.ListPriceBox.Size = new System.Drawing.Size(100, 20);
            this.ListPriceBox.TabIndex = 19;
            // 
            // VehicleTypeBox
            // 
            this.VehicleTypeBox.FormattingEnabled = true;
            this.VehicleTypeBox.Items.AddRange(new object[] {
            "Car",
            "Sports Car",
            "Truck",
            "Motorcycle",
            "MotorHome"});
            this.VehicleTypeBox.Location = new System.Drawing.Point(224, 127);
            this.VehicleTypeBox.Name = "VehicleTypeBox";
            this.VehicleTypeBox.Size = new System.Drawing.Size(100, 21);
            this.VehicleTypeBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 211);
            this.Controls.Add(this.VehicleTypeBox);
            this.Controls.Add(this.ListPriceBox);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.ListPrice);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.CarYear);
            this.Controls.Add(this.CarModelBox);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.CarMakeBox);
            this.Controls.Add(this.CarMake);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListPriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label CarMake;
        private System.Windows.Forms.TextBox CarMakeBox;
        private System.Windows.Forms.Label CarModel;
        private System.Windows.Forms.TextBox CarModelBox;
        private System.Windows.Forms.Label CarYear;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.Label ListPrice;
        private System.Windows.Forms.Label VehicleType;
        private System.Windows.Forms.NumericUpDown ListPriceBox;
        private System.Windows.Forms.ComboBox VehicleTypeBox;
    }
}

