
namespace Appointment
{
    partial class newcustomer
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
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.Txtphone = new System.Windows.Forms.TextBox();
            Name = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 41);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(312, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name.Location = new System.Drawing.Point(51, 109);
            Name.Name = "Name";
            Name.Size = new System.Drawing.Size(113, 17);
            Name.TabIndex = 20;
            Name.Text = "Customer Name:";
            Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(208, 106);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(115, 23);
            this.TxtName.TabIndex = 21;
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IDLabel.Location = new System.Drawing.Point(51, 135);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(87, 17);
            customer_IDLabel.TabIndex = 22;
            customer_IDLabel.Text = "Customer Id:";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(208, 132);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(115, 23);
            this.TxtId.TabIndex = 23;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(135, 279);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 24;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Txtphone
            // 
            this.Txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtphone.Location = new System.Drawing.Point(209, 161);
            this.Txtphone.Name = "Txtphone";
            this.Txtphone.Size = new System.Drawing.Size(115, 23);
            this.Txtphone.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(51, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 17);
            label3.TabIndex = 29;
            label3.Text = "Customer Phone:";
            // 
            // newcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(label3);
            this.Controls.Add(this.Txtphone);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(Name);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newcustomer";
            this.Text = "newcustomer";
            this.Load += new System.EventHandler(this.newcustomer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.TextBox Txtphone;
    }
}