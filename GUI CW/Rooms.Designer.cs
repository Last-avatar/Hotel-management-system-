namespace GUI_CW
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RoomsDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.RTypeCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RnameTb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDGV)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.RoomsDGV);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.StatusCb);
            this.panel2.Controls.Add(this.RTypeCb);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.RnameTb);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(214, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 631);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(689, 126);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(138, 37);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DimGray;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(511, 126);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 37);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.DimGray;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(332, 126);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(138, 37);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomsDGV
            // 
            this.RoomsDGV.BackgroundColor = System.Drawing.Color.White;
            this.RoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDGV.Location = new System.Drawing.Point(3, 188);
            this.RoomsDGV.Name = "RoomsDGV";
            this.RoomsDGV.RowHeadersWidth = 51;
            this.RoomsDGV.RowTemplate.Height = 24;
            this.RoomsDGV.Size = new System.Drawing.Size(1133, 440);
            this.RoomsDGV.TabIndex = 5;
            this.RoomsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomsDGV_RowHeaderMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(480, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 34);
            this.label10.TabIndex = 4;
            this.label10.Text = "Manage Rooms";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Booked",
            "Available"});
            this.StatusCb.Location = new System.Drawing.Point(822, 66);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(196, 35);
            this.StatusCb.TabIndex = 3;
            this.StatusCb.Text = "Status";
            this.StatusCb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // RTypeCb
            // 
            this.RTypeCb.FormattingEnabled = true;
            this.RTypeCb.Items.AddRange(new object[] {
            "Standard",
            "Single",
            "VIP",
            "King"});
            this.RTypeCb.Location = new System.Drawing.Point(532, 67);
            this.RTypeCb.Name = "RTypeCb";
            this.RTypeCb.Size = new System.Drawing.Size(196, 35);
            this.RTypeCb.TabIndex = 2;
            this.RTypeCb.Text = "Room Types";
            this.RTypeCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RnameTb
            // 
            this.RnameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RnameTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RnameTb.Location = new System.Drawing.Point(254, 72);
            this.RnameTb.Multiline = true;
            this.RnameTb.Name = "RnameTb";
            this.RnameTb.Size = new System.Drawing.Size(196, 26);
            this.RnameTb.TabIndex = 0;
            this.RnameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(1, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 56);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rooms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(218, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel Management System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categories";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 723);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 493);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dashboard";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(7, 427);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(70, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bookings";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(7, 363);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(7, 297);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(67, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customers";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(68, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Users";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 666);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 59);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logout";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1360, 726);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RnameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView RoomsDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox RTypeCb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusCb;
    }
}

