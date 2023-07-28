namespace WinFormsApp1
{
    partial class recipt
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
            label1 = new Label();
            name_recipt = new Label();
            car_recipt = new Label();
            label4 = new Label();
            to_recipt = new Label();
            label3 = new Label();
            from_recipt = new Label();
            label5 = new Label();
            per_day_cost_recipt = new Label();
            label6 = new Label();
            total_cost_recipt = new Label();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name_recipt
            // 
            name_recipt.AutoSize = true;
            name_recipt.Location = new Point(234, 72);
            name_recipt.Name = "name_recipt";
            name_recipt.Size = new Size(50, 20);
            name_recipt.TabIndex = 1;
            name_recipt.Text = "label2";
            // 
            // car_recipt
            // 
            car_recipt.AutoSize = true;
            car_recipt.Location = new Point(234, 121);
            car_recipt.Name = "car_recipt";
            car_recipt.Size = new Size(50, 20);
            car_recipt.TabIndex = 3;
            car_recipt.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 2;
            label4.Text = "Car";
            // 
            // to_recipt
            // 
            to_recipt.AutoSize = true;
            to_recipt.Location = new Point(240, 198);
            to_recipt.Name = "to_recipt";
            to_recipt.Size = new Size(25, 20);
            to_recipt.TabIndex = 5;
            to_recipt.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 198);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "To";
            // 
            // from_recipt
            // 
            from_recipt.AutoSize = true;
            from_recipt.Location = new Point(234, 164);
            from_recipt.Name = "from_recipt";
            from_recipt.Size = new Size(43, 20);
            from_recipt.TabIndex = 7;
            from_recipt.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 164);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 6;
            label5.Text = "From";
            // 
            // per_day_cost_recipt
            // 
            per_day_cost_recipt.AutoSize = true;
            per_day_cost_recipt.Location = new Point(234, 249);
            per_day_cost_recipt.Name = "per_day_cost_recipt";
            per_day_cost_recipt.Size = new Size(88, 20);
            per_day_cost_recipt.TabIndex = 9;
            per_day_cost_recipt.Text = "Per day cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 249);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 8;
            label6.Text = "Per day cost";
            // 
            // total_cost_recipt
            // 
            total_cost_recipt.AutoSize = true;
            total_cost_recipt.Location = new Point(240, 294);
            total_cost_recipt.Name = "total_cost_recipt";
            total_cost_recipt.Size = new Size(75, 20);
            total_cost_recipt.TabIndex = 11;
            total_cost_recipt.Text = "Total Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 294);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Total Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(338, 9);
            label2.Name = "label2";
            label2.Size = new Size(124, 46);
            label2.TabIndex = 12;
            label2.Text = "RECIPT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(415, 144);
            label8.Name = "label8";
            label8.Size = new Size(364, 46);
            label8.TabIndex = 13;
            label8.Text = "BOOKING CONFIRM !!!";
            label8.Click += label8_Click;
            // 
            // recipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(total_cost_recipt);
            Controls.Add(label7);
            Controls.Add(per_day_cost_recipt);
            Controls.Add(label6);
            Controls.Add(from_recipt);
            Controls.Add(label5);
            Controls.Add(to_recipt);
            Controls.Add(label3);
            Controls.Add(car_recipt);
            Controls.Add(label4);
            Controls.Add(name_recipt);
            Controls.Add(label1);
            Name = "recipt";
            Text = "recipt";
            Load += recipt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label name_recipt;
        private Label car_recipt;
        private Label label4;
        private Label to_recipt;
        private Label label3;
        private Label from_recipt;
        private Label label5;
        private Label per_day_cost_recipt;
        private Label label6;
        private Label total_cost_recipt;
        private Label label7;
        private Label label2;
        private Label label8;
    }
}