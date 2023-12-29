namespace AUDAKE_UNIVERSITY
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            yearLevel = new ListBox();
            label9 = new Label();
            course = new ListBox();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            sex = new ListBox();
            label7 = new Label();
            label6 = new Label();
            Age = new TextBox();
            label5 = new Label();
            ContactNumber = new TextBox();
            label4 = new Label();
            LastName = new TextBox();
            label3 = new Label();
            MiddleName = new TextBox();
            label10 = new Label();
            firstName = new TextBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            bsck_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // yearLevel
            // 
            yearLevel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearLevel.FormattingEnabled = true;
            yearLevel.ItemHeight = 21;
            yearLevel.Items.AddRange(new object[] { "1st year", "2nd year", "3rd year", "4th year" });
            yearLevel.Location = new Point(467, 343);
            yearLevel.Name = "yearLevel";
            yearLevel.Size = new Size(88, 25);
            yearLevel.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Poppins", 9F);
            label9.ForeColor = Color.PowderBlue;
            label9.Location = new Point(469, 319);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 27;
            label9.Text = "Year Level";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // course
            // 
            course.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            course.FormattingEnabled = true;
            course.ItemHeight = 21;
            course.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science", "Bachelor os Science in Accountancy", "Bachelor of Science in Business Administration" });
            course.Location = new Point(467, 282);
            course.Name = "course";
            course.Size = new Size(295, 25);
            course.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppins", 9F);
            label8.ForeColor = Color.PowderBlue;
            label8.Location = new Point(469, 258);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 25;
            label8.Text = "Course";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Frescito Regular PERSONAL USE", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(458, 148);
            label1.Name = "label1";
            label1.Size = new Size(330, 52);
            label1.TabIndex = 35;
            label1.Text = "INTENDED COURSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 200);
            label2.Name = "label2";
            label2.Size = new Size(292, 23);
            label2.TabIndex = 37;
            label2.Text = "Please select your choice year and course.";
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(526, 415);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 38;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sex
            // 
            sex.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sex.FormattingEnabled = true;
            sex.ItemHeight = 21;
            sex.Items.AddRange(new object[] { "Male", "Female" });
            sex.Location = new Point(295, 343);
            sex.Name = "sex";
            sex.Size = new Size(118, 25);
            sex.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Poppins", 9F);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(292, 320);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 49;
            label7.Text = "Sex";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Poppins", 9F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(212, 320);
            label6.Name = "label6";
            label6.Size = new Size(33, 21);
            label6.TabIndex = 48;
            label6.Text = "Age\r\n";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Age
            // 
            Age.Font = new Font("Poppins", 9F);
            Age.Location = new Point(204, 343);
            Age.Name = "Age";
            Age.Size = new Size(85, 25);
            Age.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Poppins", 9F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(44, 320);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 46;
            label5.Text = "Contact Number";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ContactNumber
            // 
            ContactNumber.Font = new Font("Poppins", 9F);
            ContactNumber.Location = new Point(47, 343);
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Size = new Size(151, 25);
            ContactNumber.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Poppins", 9F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(292, 259);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 44;
            label4.Text = "Last Name\r\n";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LastName
            // 
            LastName.Font = new Font("Poppins", 9F);
            LastName.Location = new Point(295, 282);
            LastName.Name = "LastName";
            LastName.Size = new Size(118, 25);
            LastName.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Poppins", 9F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(168, 259);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 42;
            label3.Text = "Mddle Name\r\n";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MiddleName
            // 
            MiddleName.Font = new Font("Poppins", 9F);
            MiddleName.Location = new Point(171, 282);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(118, 25);
            MiddleName.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.WhiteSmoke;
            label10.Font = new Font("Poppins", 9F);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(44, 259);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 40;
            label10.Text = "First Name\r\n";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // firstName
            // 
            firstName.Font = new Font("Poppins", 9F);
            firstName.Location = new Point(47, 282);
            firstName.Name = "firstName";
            firstName.Size = new Size(118, 25);
            firstName.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkCyan;
            label11.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Cornsilk;
            label11.Location = new Point(29, 200);
            label11.Name = "label11";
            label11.Size = new Size(244, 23);
            label11.TabIndex = 52;
            label11.Text = "Please fill up the information below\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.WhiteSmoke;
            label12.Font = new Font("Frescito Regular PERSONAL USE", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(19, 148);
            label12.Name = "label12";
            label12.Size = new Size(433, 52);
            label12.TabIndex = 51;
            label12.Text = "PERSONAL INFORMATION";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(14, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 359);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // bsck_button
            // 
            bsck_button.BackColor = Color.White;
            bsck_button.FlatStyle = FlatStyle.Popup;
            bsck_button.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bsck_button.ForeColor = Color.Purple;
            bsck_button.Location = new Point(649, 415);
            bsck_button.Name = "bsck_button";
            bsck_button.Size = new Size(110, 43);
            bsck_button.TabIndex = 54;
            bsck_button.Text = "Back";
            bsck_button.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 497);
            Controls.Add(bsck_button);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(sex);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Age);
            Controls.Add(label5);
            Controls.Add(ContactNumber);
            Controls.Add(label4);
            Controls.Add(LastName);
            Controls.Add(label3);
            Controls.Add(MiddleName);
            Controls.Add(label10);
            Controls.Add(firstName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yearLevel);
            Controls.Add(label9);
            Controls.Add(course);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUDAKE UNIVERSITY";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox yearLevel;
        private Label label9;
        private ListBox course;
        private Label label8;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox sex;
        private Label label7;
        private Label label6;
        private TextBox Age;
        private Label label5;
        private TextBox ContactNumber;
        private Label label4;
        private TextBox LastName;
        private Label label3;
        private TextBox MiddleName;
        private Label label10;
        private TextBox firstName;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox1;
        private Button bsck_button;
    }
}