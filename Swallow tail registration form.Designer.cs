namespace WindowsFormsApp3
{
    partial class Registreationform1
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
            this.textfirstname = new System.Windows.Forms.TextBox();
            this.textmiddlename = new System.Windows.Forms.TextBox();
            this.textlastname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.texttelephone = new System.Windows.Forms.TextBox();
            this.lbltelephone = new System.Windows.Forms.Label();
            this.radiobtnmale = new System.Windows.Forms.RadioButton();
            this.radiobtnfemale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.textconfirmpassword = new System.Windows.Forms.TextBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textfirstname
            // 
            this.textfirstname.Location = new System.Drawing.Point(31, 59);
            this.textfirstname.Name = "textfirstname";
            this.textfirstname.Size = new System.Drawing.Size(164, 20);
            this.textfirstname.TabIndex = 0;
            // 
            // textmiddlename
            // 
            this.textmiddlename.Location = new System.Drawing.Point(265, 58);
            this.textmiddlename.Name = "textmiddlename";
            this.textmiddlename.Size = new System.Drawing.Size(164, 20);
            this.textmiddlename.TabIndex = 1;
            // 
            // textlastname
            // 
            this.textlastname.Location = new System.Drawing.Point(505, 58);
            this.textlastname.Name = "textlastname";
            this.textlastname.Size = new System.Drawing.Size(168, 20);
            this.textlastname.TabIndex = 2;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(47, 40);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(57, 13);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "First Name";
            this.lblfirstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Location = new System.Drawing.Point(297, 39);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(69, 13);
            this.lblmiddlename.TabIndex = 4;
            this.lblmiddlename.Text = "Middle Name";
            this.lblmiddlename.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(552, 38);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(58, 13);
            this.lbllastname.TabIndex = 5;
            this.lbllastname.Text = "Last Name";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(31, 152);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(509, 40);
            this.textemail.TabIndex = 6;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(47, 126);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "E-mail";
            // 
            // texttelephone
            // 
            this.texttelephone.Location = new System.Drawing.Point(12, 505);
            this.texttelephone.Name = "texttelephone";
            this.texttelephone.Size = new System.Drawing.Size(276, 20);
            this.texttelephone.TabIndex = 8;
            // 
            // lbltelephone
            // 
            this.lbltelephone.AutoSize = true;
            this.lbltelephone.Location = new System.Drawing.Point(36, 479);
            this.lbltelephone.Name = "lbltelephone";
            this.lbltelephone.Size = new System.Drawing.Size(68, 13);
            this.lbltelephone.TabIndex = 9;
            this.lbltelephone.Text = "Telephone #";
            this.lbltelephone.Click += new System.EventHandler(this.label5_Click);
            // 
            // radiobtnmale
            // 
            this.radiobtnmale.AutoSize = true;
            this.radiobtnmale.Location = new System.Drawing.Point(39, 370);
            this.radiobtnmale.Name = "radiobtnmale";
            this.radiobtnmale.Size = new System.Drawing.Size(48, 17);
            this.radiobtnmale.TabIndex = 10;
            this.radiobtnmale.TabStop = true;
            this.radiobtnmale.Text = "Male";
            this.radiobtnmale.UseVisualStyleBackColor = true;
            // 
            // radiobtnfemale
            // 
            this.radiobtnfemale.AutoSize = true;
            this.radiobtnfemale.Location = new System.Drawing.Point(39, 393);
            this.radiobtnfemale.Name = "radiobtnfemale";
            this.radiobtnfemale.Size = new System.Drawing.Size(59, 17);
            this.radiobtnfemale.TabIndex = 11;
            this.radiobtnfemale.TabStop = true;
            this.radiobtnfemale.Text = "Female";
            this.radiobtnfemale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(36, 345);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 12;
            this.lblgender.Text = "Gender";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(31, 244);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(317, 28);
            this.textpassword.TabIndex = 13;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(47, 218);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 14;
            this.lblpassword.Text = "Password";
            // 
            // textconfirmpassword
            // 
            this.textconfirmpassword.Location = new System.Drawing.Point(31, 303);
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(317, 20);
            this.textconfirmpassword.TabIndex = 15;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(50, 284);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(91, 13);
            this.lblconfirmpassword.TabIndex = 16;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(409, 659);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 57);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Registreationform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 749);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.textconfirmpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.radiobtnfemale);
            this.Controls.Add(this.radiobtnmale);
            this.Controls.Add(this.lbltelephone);
            this.Controls.Add(this.texttelephone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblmiddlename);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.textlastname);
            this.Controls.Add(this.textmiddlename);
            this.Controls.Add(this.textfirstname);
            this.Name = "Registreationform1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfirstname;
        private System.Windows.Forms.TextBox textmiddlename;
        private System.Windows.Forms.TextBox textlastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox texttelephone;
        private System.Windows.Forms.Label lbltelephone;
        private System.Windows.Forms.RadioButton radiobtnmale;
        private System.Windows.Forms.RadioButton radiobtnfemale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox textconfirmpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Button btnRegister;
    }
}

