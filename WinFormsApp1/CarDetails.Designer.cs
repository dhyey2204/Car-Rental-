namespace WinFormsApp1
{
    partial class CarDetails
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
            back = new Button();
            book = new Button();
            cost = new Label();
            label = new Label();
            avail = new Label();
            label5 = new Label();
            model = new Label();
            label3 = new Label();
            type = new Label();
            label1 = new Label();
            label2 = new Label();
            description = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            toDate = new DateTimePicker();
            fromDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(25, 393);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 22;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // book
            // 
            book.Location = new Point(488, 167);
            book.Name = "book";
            book.Size = new Size(264, 70);
            book.TabIndex = 20;
            book.Text = "Book";
            book.UseVisualStyleBackColor = true;
            book.Click += book_Click;
            // 
            // cost
            // 
            cost.AutoSize = true;
            cost.Location = new Point(180, 155);
            cost.Name = "cost";
            cost.Size = new Size(127, 20);
            cost.TabIndex = 19;
            cost.Text = "cost per day label";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(25, 207);
            label.Name = "label";
            label.Size = new Size(77, 20);
            label.TabIndex = 18;
            label.Text = "availblility";
            // 
            // avail
            // 
            avail.AutoSize = true;
            avail.Location = new Point(180, 207);
            avail.Name = "avail";
            avail.Size = new Size(50, 20);
            avail.TabIndex = 17;
            avail.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 16;
            label5.Text = "cost per day";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Location = new Point(180, 98);
            model.Name = "model";
            model.Size = new Size(50, 20);
            model.TabIndex = 15;
            model.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 98);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 14;
            label3.Text = "model";
            // 
            // type
            // 
            type.AutoSize = true;
            type.Location = new Point(178, 50);
            type.Name = "type";
            type.Size = new Size(50, 20);
            type.TabIndex = 13;
            type.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 12;
            label1.Text = "type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 262);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 23;
            label2.Text = "Description";
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(180, 262);
            description.Name = "description";
            description.Size = new Size(85, 20);
            description.TabIndex = 24;
            description.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(240, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 139);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 50);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 26;
            label4.Text = "Booking From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 109);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 29;
            label6.Text = "Booking to";
            // 
            // toDate
            // 
            toDate.Location = new Point(488, 109);
            toDate.Name = "toDate";
            toDate.Size = new Size(264, 27);
            toDate.TabIndex = 30;
            toDate.ValueChanged += toDate_ValueChanged;
            // 
            // fromDate
            // 
            fromDate.Location = new Point(488, 50);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(264, 27);
            fromDate.TabIndex = 31;
            // 
            // CarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fromDate);
            Controls.Add(toDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(back);
            Controls.Add(book);
            Controls.Add(cost);
            Controls.Add(label);
            Controls.Add(avail);
            Controls.Add(label5);
            Controls.Add(model);
            Controls.Add(label3);
            Controls.Add(type);
            Controls.Add(label1);
            Name = "CarDetails";
            Text = "CarDetails";
            Load += CarDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button book;
        private Label cost;
        private Label label;
        private Label avail;
        private Label label5;
        private Label model;
        private Label label3;
        private Label type;
        private Label label1;
        private Label label2;
        private Label description;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private DateTimePicker toDate;
        private DateTimePicker fromDate;
    }
}