namespace Assignment5._2Winforms
{
    partial class FormSearch
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labeluserinstructions = new System.Windows.Forms.Label();
            this.textBoxSerch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(142, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labeluserinstructions
            // 
            this.labeluserinstructions.AutoSize = true;
            this.labeluserinstructions.Location = new System.Drawing.Point(12, 9);
            this.labeluserinstructions.Name = "labeluserinstructions";
            this.labeluserinstructions.Size = new System.Drawing.Size(139, 30);
            this.labeluserinstructions.TabIndex = 1;
            this.labeluserinstructions.Text = "Enter last name to search\r\n\r\n";
            // 
            // textBoxSerch
            // 
            this.textBoxSerch.Location = new System.Drawing.Point(12, 41);
            this.textBoxSerch.Name = "textBoxSerch";
            this.textBoxSerch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSerch.TabIndex = 2;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 87);
            this.Controls.Add(this.textBoxSerch);
            this.Controls.Add(this.labeluserinstructions);
            this.Controls.Add(this.buttonSearch);
            this.Name = "FormSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSearch;
        private Label labeluserinstructions;
        private TextBox textBoxSerch;
    }
}