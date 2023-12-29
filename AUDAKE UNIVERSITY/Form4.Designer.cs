namespace AUDAKE_UNIVERSITY
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(273, 444);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 1;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(412, 444);
            button2.Name = "button2";
            button2.Size = new Size(120, 41);
            button2.TabIndex = 2;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 497);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUDAKE UNIVERSITY";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}