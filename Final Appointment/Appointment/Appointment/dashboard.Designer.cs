
namespace Appointment
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNCustomer = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.appointmentDataSet1 = new Appointment.appointmentDataSet1();
            this.dashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardTableAdapter = new Appointment.appointmentDataSet1TableAdapters.dashboardTableAdapter();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 62);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(561, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNCustomer
            // 
            this.btnNCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNCustomer.Location = new System.Drawing.Point(194, 12);
            this.btnNCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnNCustomer.Name = "btnNCustomer";
            this.btnNCustomer.Size = new System.Drawing.Size(197, 39);
            this.btnNCustomer.TabIndex = 7;
            this.btnNCustomer.Text = "New Customer";
            this.btnNCustomer.UseVisualStyleBackColor = false;
            this.btnNCustomer.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(3, 12);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(93, 39);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Time";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // appointmentDataSet1
            // 
            this.appointmentDataSet1.DataSetName = "appointmentDataSet1";
            this.appointmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dashboardBindingSource
            // 
            this.dashboardBindingSource.DataMember = "dashboard";
            this.dashboardBindingSource.DataSource = this.appointmentDataSet1;
            // 
            // dashboardTableAdapter
            // 
            this.dashboardTableAdapter.ClearBeforeFill = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(97, 85);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(399, 313);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNCustomer;
        private System.Windows.Forms.Label lbl3;
        private appointmentDataSet1 appointmentDataSet1;
        private System.Windows.Forms.BindingSource dashboardBindingSource;
        private appointmentDataSet1TableAdapters.dashboardTableAdapter dashboardTableAdapter;
        private System.Windows.Forms.DataGridView dgv;
    }
}