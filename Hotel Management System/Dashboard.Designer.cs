
namespace Hotel_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_report = new Guna.UI2.WinForms.Guna2Button();
            this.btn_emp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cusdetails = new Guna.UI2.WinForms.Guna2Button();
            this.btn_checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cusregi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addroom = new Guna.UI2.WinForms.Guna2Button();
            this.movingpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_min = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_employee1 = new Hotel_Management_System.All_User_Controller.UC_employee();
            this.uC_customerdetails1 = new Hotel_Management_System.All_User_Controller.UC_customerdetails();
            this.uC_CheckOut1 = new Hotel_Management_System.All_User_Controller.UC_CheckOut();
            this.uC_CustomerRegi1 = new Hotel_Management_System.All_User_Controller.UC_CustomerRegi();
            this.uC_addroom1 = new Hotel_Management_System.All_User_Controller.UC_addroom();
            this.uC_HotelReport1 = new Hotel_Management_System.All_User_Controller.UC_HotelReport();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_emp);
            this.panel1.Controls.Add(this.btn_cusdetails);
            this.panel1.Controls.Add(this.btn_checkout);
            this.panel1.Controls.Add(this.btn_cusregi);
            this.panel1.Controls.Add(this.btn_addroom);
            this.panel1.Controls.Add(this.movingpanel);
            this.panel1.Location = new System.Drawing.Point(42, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_report
            // 
            this.btn_report.BorderRadius = 26;
            this.btn_report.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_report.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_report.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_report.CheckedState.Parent = this.btn_report;
            this.btn_report.CustomImages.Parent = this.btn_report;
            this.btn_report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.HoverState.Parent = this.btn_report;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_report.Location = new System.Drawing.Point(1034, 20);
            this.btn_report.Name = "btn_report";
            this.btn_report.ShadowDecoration.Parent = this.btn_report;
            this.btn_report.Size = new System.Drawing.Size(198, 85);
            this.btn_report.TabIndex = 7;
            this.btn_report.Text = "Report";
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_emp
            // 
            this.btn_emp.BorderRadius = 26;
            this.btn_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_emp.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_emp.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_emp.CheckedState.Parent = this.btn_emp;
            this.btn_emp.CustomImages.Parent = this.btn_emp;
            this.btn_emp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_emp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.ForeColor = System.Drawing.Color.White;
            this.btn_emp.HoverState.Parent = this.btn_emp;
            this.btn_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp.Image")));
            this.btn_emp.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_emp.Location = new System.Drawing.Point(830, 20);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.ShadowDecoration.Parent = this.btn_emp;
            this.btn_emp.Size = new System.Drawing.Size(198, 85);
            this.btn_emp.TabIndex = 6;
            this.btn_emp.Text = "Employee";
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click_1);
            // 
            // btn_cusdetails
            // 
            this.btn_cusdetails.BorderRadius = 26;
            this.btn_cusdetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_cusdetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_cusdetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_cusdetails.CheckedState.Parent = this.btn_cusdetails;
            this.btn_cusdetails.CustomImages.Parent = this.btn_cusdetails;
            this.btn_cusdetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_cusdetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusdetails.ForeColor = System.Drawing.Color.White;
            this.btn_cusdetails.HoverState.Parent = this.btn_cusdetails;
            this.btn_cusdetails.Image = ((System.Drawing.Image)(resources.GetObject("btn_cusdetails.Image")));
            this.btn_cusdetails.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_cusdetails.Location = new System.Drawing.Point(626, 20);
            this.btn_cusdetails.Name = "btn_cusdetails";
            this.btn_cusdetails.ShadowDecoration.Parent = this.btn_cusdetails;
            this.btn_cusdetails.Size = new System.Drawing.Size(198, 85);
            this.btn_cusdetails.TabIndex = 4;
            this.btn_cusdetails.Text = "Customer Details";
            this.btn_cusdetails.Click += new System.EventHandler(this.btn_cusdetails_Click_1);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BorderRadius = 26;
            this.btn_checkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_checkout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_checkout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_checkout.CheckedState.Parent = this.btn_checkout;
            this.btn_checkout.CustomImages.Parent = this.btn_checkout;
            this.btn_checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.HoverState.Parent = this.btn_checkout;
            this.btn_checkout.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkout.Image")));
            this.btn_checkout.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_checkout.Location = new System.Drawing.Point(422, 20);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.ShadowDecoration.Parent = this.btn_checkout;
            this.btn_checkout.Size = new System.Drawing.Size(198, 85);
            this.btn_checkout.TabIndex = 3;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click_1);
            // 
            // btn_cusregi
            // 
            this.btn_cusregi.BorderRadius = 26;
            this.btn_cusregi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_cusregi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_cusregi.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_cusregi.CheckedState.Parent = this.btn_cusregi;
            this.btn_cusregi.CustomImages.Parent = this.btn_cusregi;
            this.btn_cusregi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_cusregi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusregi.ForeColor = System.Drawing.Color.White;
            this.btn_cusregi.HoverState.Parent = this.btn_cusregi;
            this.btn_cusregi.Image = ((System.Drawing.Image)(resources.GetObject("btn_cusregi.Image")));
            this.btn_cusregi.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_cusregi.Location = new System.Drawing.Point(218, 20);
            this.btn_cusregi.Name = "btn_cusregi";
            this.btn_cusregi.ShadowDecoration.Parent = this.btn_cusregi;
            this.btn_cusregi.Size = new System.Drawing.Size(198, 85);
            this.btn_cusregi.TabIndex = 2;
            this.btn_cusregi.Text = "Customer Registration";
            this.btn_cusregi.Click += new System.EventHandler(this.btn_cusregi_Click_1);
            // 
            // btn_addroom
            // 
            this.btn_addroom.BorderRadius = 26;
            this.btn_addroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addroom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_addroom.CheckedState.Parent = this.btn_addroom;
            this.btn_addroom.CustomImages.Parent = this.btn_addroom;
            this.btn_addroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_addroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addroom.ForeColor = System.Drawing.Color.White;
            this.btn_addroom.HoverState.Parent = this.btn_addroom;
            this.btn_addroom.Image = ((System.Drawing.Image)(resources.GetObject("btn_addroom.Image")));
            this.btn_addroom.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_addroom.Location = new System.Drawing.Point(14, 20);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.ShadowDecoration.Parent = this.btn_addroom;
            this.btn_addroom.Size = new System.Drawing.Size(198, 85);
            this.btn_addroom.TabIndex = 1;
            this.btn_addroom.Text = "Add Room";
            this.btn_addroom.Click += new System.EventHandler(this.btn_addroom_Click_1);
            // 
            // movingpanel
            // 
            this.movingpanel.BackColor = System.Drawing.Color.Teal;
            this.movingpanel.Location = new System.Drawing.Point(30, 111);
            this.movingpanel.Name = "movingpanel";
            this.movingpanel.Size = new System.Drawing.Size(159, 10);
            this.movingpanel.TabIndex = 1;
            this.movingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.movingpanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.uC_HotelReport1);
            this.panel2.Controls.Add(this.uC_employee1);
            this.panel2.Controls.Add(this.uC_customerdetails1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegi1);
            this.panel2.Controls.Add(this.uC_addroom1);
            this.panel2.Location = new System.Drawing.Point(20, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 505);
            this.panel2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.Color.Empty;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_cancel.Location = new System.Drawing.Point(4, 28);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(32, 38);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_min
            // 
            this.btn_min.CheckedState.Parent = this.btn_min;
            this.btn_min.CustomImages.Parent = this.btn_min;
            this.btn_min.FillColor = System.Drawing.Color.Empty;
            this.btn_min.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.HoverState.Parent = this.btn_min;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_min.Location = new System.Drawing.Point(4, 72);
            this.btn_min.Name = "btn_min";
            this.btn_min.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_min.ShadowDecoration.Parent = this.btn_min;
            this.btn_min.Size = new System.Drawing.Size(32, 38);
            this.btn_min.TabIndex = 2;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // uC_employee1
            // 
            this.uC_employee1.BackColor = System.Drawing.Color.White;
            this.uC_employee1.Location = new System.Drawing.Point(-8, -6);
            this.uC_employee1.Name = "uC_employee1";
            this.uC_employee1.Size = new System.Drawing.Size(1342, 583);
            this.uC_employee1.TabIndex = 4;
            // 
            // uC_customerdetails1
            // 
            this.uC_customerdetails1.BackColor = System.Drawing.Color.White;
            this.uC_customerdetails1.Location = new System.Drawing.Point(3, 0);
            this.uC_customerdetails1.Name = "uC_customerdetails1";
            this.uC_customerdetails1.Size = new System.Drawing.Size(1342, 583);
            this.uC_customerdetails1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.AutoSize = true;
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uC_CheckOut1.Location = new System.Drawing.Point(3, 3);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1360, 586);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegi1
            // 
            this.uC_CustomerRegi1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegi1.Location = new System.Drawing.Point(3, 3);
            this.uC_CustomerRegi1.Name = "uC_CustomerRegi1";
            this.uC_CustomerRegi1.Size = new System.Drawing.Size(1291, 583);
            this.uC_CustomerRegi1.TabIndex = 1;
            // 
            // uC_addroom1
            // 
            this.uC_addroom1.BackColor = System.Drawing.Color.White;
            this.uC_addroom1.Location = new System.Drawing.Point(5, 3);
            this.uC_addroom1.Name = "uC_addroom1";
            this.uC_addroom1.Size = new System.Drawing.Size(1289, 499);
            this.uC_addroom1.TabIndex = 0;
            // 
            // uC_HotelReport1
            // 
            this.uC_HotelReport1.BackColor = System.Drawing.Color.White;
            this.uC_HotelReport1.Location = new System.Drawing.Point(-45, -81);
            this.uC_HotelReport1.Name = "uC_HotelReport1";
            this.uC_HotelReport1.Size = new System.Drawing.Size(1342, 583);
            this.uC_HotelReport1.TabIndex = 5;
            this.uC_HotelReport1.Load += new System.EventHandler(this.uC_HotelReport1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btn_cancel;
        private Guna.UI2.WinForms.Guna2CircleButton btn_min;
        private System.Windows.Forms.Panel movingpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Controller.UC_addroom uC_addroom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Controller.UC_CustomerRegi uC_CustomerRegi1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Controller.UC_CheckOut uC_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Controller.UC_customerdetails uC_customerdetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Controller.UC_employee uC_employee1;
        private Guna.UI2.WinForms.Guna2Button btn_addroom;
        private Guna.UI2.WinForms.Guna2Button btn_cusregi;
        private Guna.UI2.WinForms.Guna2Button btn_report;
        private Guna.UI2.WinForms.Guna2Button btn_emp;
        private Guna.UI2.WinForms.Guna2Button btn_checkout;
        private Guna.UI2.WinForms.Guna2Button btn_cusdetails;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private All_User_Controller.UC_HotelReport uC_HotelReport1;
    }
}