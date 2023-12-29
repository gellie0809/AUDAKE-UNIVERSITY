namespace AUDAKE_UNIVERSITY
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Submit_button = new Button();
            Back_button = new Button();
            label10 = new Label();
            username = new TextBox();
            label11 = new Label();
            password = new TextBox();
            label12 = new Label();
            mypassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Submit_button
            // 
            Submit_button.BackColor = Color.Purple;
            Submit_button.FlatStyle = FlatStyle.Popup;
            Submit_button.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold);
            Submit_button.ForeColor = Color.White;
            Submit_button.Location = new Point(474, 384);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(101, 34);
            Submit_button.TabIndex = 26;
            Submit_button.Text = "Submit";
            Submit_button.UseVisualStyleBackColor = false;
            Submit_button.Click += Submit_button_Click;
            // 
            // Back_button
            // 
            Back_button.BackColor = Color.Snow;
            Back_button.FlatStyle = FlatStyle.Popup;
            Back_button.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold);
            Back_button.ForeColor = Color.Purple;
            Back_button.Location = new Point(593, 384);
            Back_button.Name = "Back_button";
            Back_button.Size = new Size(106, 34);
            Back_button.TabIndex = 27;
            Back_button.Text = "Back";
            Back_button.UseVisualStyleBackColor = false;
            Back_button.Click += Back_button_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Poppins", 9F);
            label10.ForeColor = Color.PowderBlue;
            label10.Location = new Point(489, 176);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 29;
            label10.Text = "Username";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // username
            // 
            username.Font = new Font("Poppins", 9F);
            username.Location = new Point(489, 200);
            username.Name = "username";
            username.Size = new Size(200, 25);
            username.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Poppins", 9F);
            label11.ForeColor = Color.PowderBlue;
            label11.Location = new Point(489, 240);
            label11.Name = "label11";
            label11.Size = new Size(109, 21);
            label11.TabIndex = 31;
            label11.Text = "Create Password";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // password
            // 
            password.Font = new Font("Poppins", 9F);
            password.Location = new Point(489, 264);
            password.Name = "password";
            password.PasswordChar = '●';
            password.Size = new Size(200, 25);
            password.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Poppins", 9F);
            label12.ForeColor = Color.PowderBlue;
            label12.Location = new Point(489, 305);
            label12.Name = "label12";
            label12.Size = new Size(119, 21);
            label12.TabIndex = 33;
            label12.Text = "Re-Type Password";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mypassword
            // 
            mypassword.Font = new Font("Poppins", 9F);
            mypassword.Location = new Point(489, 329);
            mypassword.Name = "mypassword";
            mypassword.PasswordChar = '●';
            mypassword.Size = new Size(200, 25);
            mypassword.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Frescito Regular PERSONAL USE", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(42, 149);
            label1.Name = "label1";
            label1.Size = new Size(247, 52);
            label1.TabIndex = 34;
            label1.Text = "FILL UP FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleGoldenrod;
            label2.Location = new Point(42, 211);
            label2.Name = "label2";
            label2.Size = new Size(310, 69);
            label2.TabIndex = 53;
            label2.Text = "Kindly fill out the information below.\r\nIncomplete requirements will not be accepted.\r\nThank you!\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(30, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 305);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(267, 395);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 55;
            label3.Text = "- AU Faculties";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 488);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(mypassword);
            Controls.Add(label11);
            Controls.Add(password);
            Controls.Add(label10);
            Controls.Add(username);
            Controls.Add(Back_button);
            Controls.Add(Submit_button);
            Controls.Add(pictureBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUDAKE UNIVERSITY ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Submit_button;
        private Button Back_button;
        private Label label10;
        private TextBox username;
        private Label label11;
        private TextBox password;
        private Label label12;
        private TextBox mypassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}