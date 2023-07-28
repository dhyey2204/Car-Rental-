namespace WinFormsApp1
{
    partial class selectCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.avail = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "type";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(206, 73);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(50, 20);
            this.type.TabIndex = 1;
            this.type.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "model";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(206, 136);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(50, 20);
            this.model.TabIndex = 3;
            this.model.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "cost per day";
            // 
            // avail
            // 
            this.avail.AutoSize = true;
            this.avail.Location = new System.Drawing.Point(206, 255);
            this.avail.Name = "avail";
            this.avail.Size = new System.Drawing.Size(50, 20);
            this.avail.TabIndex = 5;
            this.avail.Text = "label4";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(95, 255);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 20);
            this.label.TabIndex = 6;
            this.label.Text = "availblility";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(206, 198);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(0, 20);
            this.cost.TabIndex = 7;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(444, 65);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(94, 29);
            this.select.TabIndex = 8;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(444, 132);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 29);
            this.next.TabIndex = 10;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(444, 198);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(94, 29);
            this.previous.TabIndex = 11;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // selectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 514);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.select);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label);
            this.Controls.Add(this.avail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label1);
            this.Name = "selectCar";
            this.Text = "selectCar";
            this.Load += new System.EventHandler(this.selectCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label type;
        private Label label3;
        private Label model;
        private Label label5;
        private Label avail;
        private Label label;
        private Label cost;
        private Button select;
        private Button next;
        private Button previous;
    }
}