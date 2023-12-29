namespace AUDAKE_UNIVERSITY
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            exit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackColor = Color.Purple;
            exit.FlatStyle = FlatStyle.Popup;
            exit.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(363, 431);
            exit.Name = "exit";
            exit.Size = new Size(97, 36);
            exit.TabIndex = 0;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(787, 496);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 497);
            Controls.Add(exit);
            Controls.Add(pictureBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUDAKE UNIVERSITY";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exit;
        private PictureBox pictureBox1;
    }
}