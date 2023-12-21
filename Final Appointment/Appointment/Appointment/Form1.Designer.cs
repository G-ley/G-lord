
namespace Appointment
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
            System.Windows.Forms.Label Name;
            System.Windows.Forms.Label customer_IDLabel;
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            Name = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name.Location = new System.Drawing.Point(115, 166);
            Name.Name = "Name";
            Name.Size = new System.Drawing.Size(49, 17);
            Name.TabIndex = 16;
            Name.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(236, 163);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(243, 23);
            this.TxtName.TabIndex = 17;
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IDLabel.Location = new System.Drawing.Point(115, 192);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(73, 17);
            customer_IDLabel.TabIndex = 18;
            customer_IDLabel.Text = "Password:";
            customer_IDLabel.Click += new System.EventHandler(this.customer_IDLabel_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(236, 189);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(243, 23);
            this.TxtPass.TabIndex = 19;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(404, 281);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 20;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(236, 281);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 21;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 52);
            this.panel1.TabIndex = 22;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(229, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(265, 39);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "APPOINTMENT";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Location = new System.Drawing.Point(1315, 4);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 38);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "LOGOUT";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(264, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(Name);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.TxtPass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
    }
}

