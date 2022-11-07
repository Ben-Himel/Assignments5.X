namespace Assignment5._2Winforms
{
    partial class FormAddPerson
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxWork = new System.Windows.Forms.TextBox();
            this.textBoxAddresss = new System.Windows.Forms.TextBox();
            this.labelfname = new System.Windows.Forms.Label();
            this.labellname = new System.Windows.Forms.Label();
            this.labelmnumber = new System.Windows.Forms.Label();
            this.labelwnumber = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(213, 6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(74, 139);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Scrawl in book";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(107, 6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(107, 35);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(107, 64);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(100, 23);
            this.textBoxMobile.TabIndex = 3;
            // 
            // textBoxWork
            // 
            this.textBoxWork.Location = new System.Drawing.Point(107, 93);
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(100, 23);
            this.textBoxWork.TabIndex = 4;
            // 
            // textBoxAddresss
            // 
            this.textBoxAddresss.Location = new System.Drawing.Point(107, 122);
            this.textBoxAddresss.Name = "textBoxAddresss";
            this.textBoxAddresss.Size = new System.Drawing.Size(100, 23);
            this.textBoxAddresss.TabIndex = 5;
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Location = new System.Drawing.Point(12, 9);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(64, 15);
            this.labelfname.TabIndex = 6;
            this.labelfname.Text = "First Name";
            // 
            // labellname
            // 
            this.labellname.AutoSize = true;
            this.labellname.Location = new System.Drawing.Point(12, 38);
            this.labellname.Name = "labellname";
            this.labellname.Size = new System.Drawing.Size(63, 15);
            this.labellname.TabIndex = 7;
            this.labellname.Text = "Last Name";
            // 
            // labelmnumber
            // 
            this.labelmnumber.AutoSize = true;
            this.labelmnumber.Location = new System.Drawing.Point(12, 67);
            this.labelmnumber.Name = "labelmnumber";
            this.labelmnumber.Size = new System.Drawing.Size(91, 15);
            this.labelmnumber.TabIndex = 8;
            this.labelmnumber.Text = "Mobile Number";
            // 
            // labelwnumber
            // 
            this.labelwnumber.AutoSize = true;
            this.labelwnumber.Location = new System.Drawing.Point(12, 96);
            this.labelwnumber.Name = "labelwnumber";
            this.labelwnumber.Size = new System.Drawing.Size(82, 15);
            this.labelwnumber.TabIndex = 9;
            this.labelwnumber.Text = "Work Number";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(12, 125);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(49, 15);
            this.labeladdress.TabIndex = 10;
            this.labeladdress.Text = "Address";
            // 
            // FormAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelwnumber);
            this.Controls.Add(this.labelmnumber);
            this.Controls.Add(this.labellname);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.textBoxAddresss);
            this.Controls.Add(this.textBoxWork);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "FormAddPerson";
            this.Text = "Add Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSubmit;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxMobile;
        private TextBox textBoxWork;
        private TextBox textBoxAddresss;
        private Label labelfname;
        private Label labellname;
        private Label labelmnumber;
        private Label labelwnumber;
        private Label labeladdress;
    }
}