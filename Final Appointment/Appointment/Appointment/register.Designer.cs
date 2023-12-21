
namespace Appointment
{
    partial class register
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            Name = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name.Location = new System.Drawing.Point(94, 132);
            Name.Name = "Name";
            Name.Size = new System.Drawing.Size(74, 17);
            Name.TabIndex = 24;
            Name.Text = "Firstname:";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IDLabel.Location = new System.Drawing.Point(94, 158);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(74, 17);
            customer_IDLabel.TabIndex = 26;
            customer_IDLabel.Text = "Lastname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(94, 182);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 17);
            label2.TabIndex = 30;
            label2.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(94, 212);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(73, 17);
            label6.TabIndex = 33;
            label6.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(94, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 17);
            label1.TabIndex = 39;
            label1.Text = "role:";
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
            this.panel1.Size = new System.Drawing.Size(548, 52);
            this.panel1.TabIndex = 23;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(167, 13);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(265, 39);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "APPOINTMENT";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(215, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 23);
            this.txtName.TabIndex = 25;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(215, 155);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(243, 23);
            this.txtLname.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(215, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 23);
            this.txtAddress.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "SIGN UP";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(215, 209);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(243, 23);
            this.txtpass.TabIndex = 34;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(383, 297);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 37;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Client ",
            "Seller",
            "Admin"});
            this.cmbrole.Location = new System.Drawing.Point(215, 245);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(121, 21);
            this.cmbrole.TabIndex = 38;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.cmbrole_SelectedIndexChanged);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 498);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(Name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.ComboBox cmbrole;
    }
}