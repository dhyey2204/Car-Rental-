namespace WinFormsApp1
{
    partial class addCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.phoneNo = new System.Windows.Forms.Label();
            this.creditCard = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.cardTb = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(41, 50);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(80, 20);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(41, 92);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(79, 20);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // phoneNo
            // 
            this.phoneNo.AutoSize = true;
            this.phoneNo.Location = new System.Drawing.Point(41, 140);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(74, 20);
            this.phoneNo.TabIndex = 2;
            this.phoneNo.Text = "Phone no.";
            // 
            // creditCard
            // 
            this.creditCard.AutoSize = true;
            this.creditCard.Location = new System.Drawing.Point(41, 186);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(108, 20);
            this.creditCard.TabIndex = 3;
            this.creditCard.Text = "Credit Card no.";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(169, 50);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(125, 27);
            this.firstNameTb.TabIndex = 5;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(169, 92);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(125, 27);
            this.lastNameTb.TabIndex = 6;
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(169, 140);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(125, 27);
            this.phoneTb.TabIndex = 7;
            // 
            // cardTb
            // 
            this.cardTb.Location = new System.Drawing.Point(169, 186);
            this.cardTb.Name = "cardTb";
            this.cardTb.Size = new System.Drawing.Size(125, 27);
            this.cardTb.TabIndex = 8;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(418, 55);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(94, 29);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(418, 193);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 20);
            this.msg.TabIndex = 10;
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cardTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "addCustomer";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstName;
        private Label lastName;
        private Label phoneNo;
        private Label creditCard;
        private TextBox firstNameTb;
        private TextBox lastNameTb;
        private TextBox phoneTb;
        private TextBox cardTb;
        private Button submit;
        private Label msg;
    }
}