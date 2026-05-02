namespace finals
{
    partial class MemberDetails
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
            txtFullName = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            cmbMembershipplan = new ComboBox();
            dtpStartdate = new DateTimePicker();
            dtpEndate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtGender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(143, 73);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(276, 31);
            txtFullName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(158, 166);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(95, 31);
            txtAge.TabIndex = 2;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(194, 248);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(276, 31);
            txtContact.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 301);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 31);
            txtEmail.TabIndex = 5;
            // 
            // cmbMembershipplan
            // 
            cmbMembershipplan.FormattingEnabled = true;
            cmbMembershipplan.Items.AddRange(new object[] { "1MONTH ", "2MONTHS", "3MONTHS", "4MONTHS", "5MONTHS" });
            cmbMembershipplan.Location = new Point(194, 365);
            cmbMembershipplan.Name = "cmbMembershipplan";
            cmbMembershipplan.Size = new Size(219, 33);
            cmbMembershipplan.TabIndex = 6;
            // 
            // dtpStartdate
            // 
            dtpStartdate.Location = new Point(143, 432);
            dtpStartdate.Name = "dtpStartdate";
            dtpStartdate.Size = new Size(300, 31);
            dtpStartdate.TabIndex = 7;
            // 
            // dtpEndate
            // 
            dtpEndate.Location = new Point(143, 511);
            dtpEndate.Name = "dtpEndate";
            dtpEndate.Size = new Size(300, 31);
            dtpEndate.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "Full name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(101, 172);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 10;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(290, 172);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 11;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(30, 254);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 12;
            label4.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(74, 301);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(23, 368);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 14;
            label6.Text = "Membership Plan:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(38, 437);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 15;
            label7.Text = "Start Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(43, 517);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 16;
            label8.Text = "End Date:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(536, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 227);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(376, 172);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(95, 31);
            txtGender.TabIndex = 18;
            // 
            // MemberDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(797, 666);
            Controls.Add(txtGender);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEndate);
            Controls.Add(dtpStartdate);
            Controls.Add(cmbMembershipplan);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Name = "MemberDetails";
            Text = "MemberDetails";
            Load += MemberDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtEmail;
        private ComboBox cmbMembershipplan;
        private DateTimePicker dtpStartdate;
        private DateTimePicker dtpEndate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtGender;
    }
}