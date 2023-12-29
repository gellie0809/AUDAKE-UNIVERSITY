namespace AUDAKE_UNIVERSITY
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            sign_up = new Button();
            log_in = new Button();
            textBox2 = new TextBox();
            password = new Label();
            textBox1 = new TextBox();
            username = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Frescito Regular PERSONAL USE", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(470, 60);
            label1.Name = "label1";
            label1.Size = new Size(313, 88);
            label1.TabIndex = 0;
            label1.Text = "AUDAKE UNIVERSITY \r\nAPPLICATION";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sign_up
            // 
            sign_up.BackColor = Color.Purple;
            sign_up.FlatStyle = FlatStyle.Popup;
            sign_up.Font = new Font("Poppins", 9.75F);
            sign_up.ForeColor = Color.White;
            sign_up.Location = new Point(631, 308);
            sign_up.Margin = new Padding(4, 3, 4, 3);
            sign_up.Name = "sign_up";
            sign_up.Size = new Size(98, 36);
            sign_up.TabIndex = 12;
            sign_up.Text = "Sign Up";
            sign_up.UseVisualStyleBackColor = false;
            sign_up.Click += button2_Click;
            // 
            // log_in
            // 
            log_in.BackColor = Color.Snow;
            log_in.FlatStyle = FlatStyle.Popup;
            log_in.Font = new Font("Poppins", 9.75F);
            log_in.ForeColor = Color.Indigo;
            log_in.Location = new Point(524, 308);
            log_in.Margin = new Padding(4, 3, 4, 3);
            log_in.Name = "log_in";
            log_in.Size = new Size(97, 36);
            log_in.TabIndex = 11;
            log_in.Text = "Log In";
            log_in.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox2.Location = new Point(524, 260);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(205, 20);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Font = new Font("Poppins", 9F);
            password.ForeColor = Color.PaleGoldenrod;
            password.Location = new Point(524, 242);
            password.Margin = new Padding(4, 0, 4, 0);
            password.Name = "password";
            password.Size = new Size(67, 21);
            password.TabIndex = 9;
            password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox1.Location = new Point(523, 206);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 20);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Font = new Font("Poppins", 9F);
            username.ForeColor = Color.PaleGoldenrod;
            username.Location = new Point(523, 188);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(70, 21);
            username.TabIndex = 7;
            username.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 497);
            Controls.Add(sign_up);
            Controls.Add(log_in);
            Controls.Add(textBox2);
            Controls.Add(password);
            Controls.Add(textBox1);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sign_up;
        private Button log_in;
        private TextBox textBox2;
        private Label password;
        private TextBox textBox1;
        private Label username;
    }
}
