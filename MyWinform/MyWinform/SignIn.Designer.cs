namespace MyWinform
{
    partial class SignIn
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
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBookingRoom = new System.Windows.Forms.Button();
            this.buttonSearchRooms = new System.Windows.Forms.Button();
            this.textBoxBronDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBronLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 20;
            this.listBoxRooms.Location = new System.Drawing.Point(33, 43);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(742, 184);
            this.listBoxRooms.TabIndex = 0;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(165, 277);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(125, 27);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xona Raqami";
            // 
            // buttonBookingRoom
            // 
            this.buttonBookingRoom.Location = new System.Drawing.Point(463, 332);
            this.buttonBookingRoom.Name = "buttonBookingRoom";
            this.buttonBookingRoom.Size = new System.Drawing.Size(234, 29);
            this.buttonBookingRoom.TabIndex = 3;
            this.buttonBookingRoom.Text = "Booking Room";
            this.buttonBookingRoom.UseVisualStyleBackColor = true;
            this.buttonBookingRoom.Click += new System.EventHandler(this.buttonBookingRoom_Click);
            // 
            // buttonSearchRooms
            // 
            this.buttonSearchRooms.Location = new System.Drawing.Point(311, 8);
            this.buttonSearchRooms.Name = "buttonSearchRooms";
            this.buttonSearchRooms.Size = new System.Drawing.Size(158, 29);
            this.buttonSearchRooms.TabIndex = 4;
            this.buttonSearchRooms.Text = "Search Free Rooms";
            this.buttonSearchRooms.UseVisualStyleBackColor = true;
            this.buttonSearchRooms.Click += new System.EventHandler(this.buttonSearchRooms_Click);
            // 
            // textBoxBronDate
            // 
            this.textBoxBronDate.Location = new System.Drawing.Point(165, 333);
            this.textBoxBronDate.Name = "textBoxBronDate";
            this.textBoxBronDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxBronDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bron muddati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bron Sanasi";
            // 
            // textBoxBronLimit
            // 
            this.textBoxBronLimit.Location = new System.Drawing.Point(165, 386);
            this.textBoxBronLimit.Name = "textBoxBronLimit";
            this.textBoxBronLimit.Size = new System.Drawing.Size(125, 27);
            this.textBoxBronLimit.TabIndex = 8;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBronLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBronDate);
            this.Controls.Add(this.buttonSearchRooms);
            this.Controls.Add(this.buttonBookingRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.listBoxRooms);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox textBoxRoomNumber;
        private Label label1;
        private Button buttonBookingRoom;
        private Button button2;
        private Button buttonSearchRooms;
        private ListBox listBoxRooms;
        private TextBox textBoxBronDate;
        private Label label2;
        private Label label3;
        private TextBox textBoxBronLimit;
    }
}