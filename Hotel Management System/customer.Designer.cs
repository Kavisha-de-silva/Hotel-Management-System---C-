
namespace Hotel_Management_System
{
    partial class customer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new Hotel_Management_System.customerDataSet();
            this.CustomerTableAdapter = new Hotel_Management_System.customerDataSetTableAdapters.CustomerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 100);
            this.panel1.TabIndex = 11;
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
            this.btn_min.Location = new System.Drawing.Point(62, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_min.ShadowDecoration.Parent = this.btn_min;
            this.btn_min.Size = new System.Drawing.Size(32, 38);
            this.btn_min.TabIndex = 12;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
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
            this.btn_cancel.Location = new System.Drawing.Point(12, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(32, 38);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(658, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 32);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(695, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(777, 159);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 32);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.Location = new System.Drawing.Point(633, 164);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(100, 22);
            this.txt_gender.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotel_Management_System.CustomerWizard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(200, 223);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 314);
            this.reportViewer1.TabIndex = 15;
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.Color.Empty;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_back.Location = new System.Drawing.Point(111, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(32, 38);
            this.btn_back.TabIndex = 14;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_min;
        private Guna.UI2.WinForms.Guna2CircleButton btn_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private customerDataSet customerDataSet;
        private customerDataSetTableAdapters.CustomerTableAdapter CustomerTableAdapter;
        private Guna.UI2.WinForms.Guna2CircleButton btn_back;
    }
}