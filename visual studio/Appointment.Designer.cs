
namespace Login
{
    partial class Form1
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblaccount = new System.Windows.Forms.Label();
            this.linklblsignup = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(12, 40);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(340, 31);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = " Appointment Companion";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnenter.Location = new System.Drawing.Point(181, 251);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(116, 28);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "ENTER";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnclear.Location = new System.Drawing.Point(43, 251);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 28);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsignup.Location = new System.Drawing.Point(111, 330);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(116, 28);
            this.btnsignup.TabIndex = 4;
            this.btnsignup.Text = "SIGNUP";
            this.btnsignup.UseVisualStyleBackColor = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(39, 123);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(105, 20);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "USERNAME:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(37, 179);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(107, 20);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "PASSWORD:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(181, 123);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(118, 20);
            this.txt1.TabIndex = 7;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(179, 181);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(118, 20);
            this.txt2.TabIndex = 8;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Location = new System.Drawing.Point(76, 303);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(133, 13);
            this.lblaccount.TabIndex = 10;
            this.lblaccount.Text = "Don\'t have account? Click";
            // 
            // linklblsignup
            // 
            this.linklblsignup.AutoSize = true;
            this.linklblsignup.Location = new System.Drawing.Point(205, 303);
            this.linklblsignup.Name = "linklblsignup";
            this.linklblsignup.Size = new System.Drawing.Size(43, 13);
            this.linklblsignup.TabIndex = 11;
            this.linklblsignup.TabStop = true;
            this.linklblsignup.Text = "Sign up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Login.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(358, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 401);
            this.Controls.Add(this.linklblsignup);
            this.Controls.Add(this.lblaccount);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.LinkLabel linklblsignup;
    }
}

