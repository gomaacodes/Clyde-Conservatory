namespace Clyde_Conservatory
{
    partial class NewKeeperForm
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
            txtForename = new TextBox();
            lblForename = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtNumCages = new TextBox();
            lblNumCages = new Label();
            txtSurname = new TextBox();
            lblSurname = new Label();
            txtPosition = new TextBox();
            lblPosition = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            btnExit = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtForename
            // 
            txtForename.Location = new Point(20, 67);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(265, 23);
            txtForename.TabIndex = 5;
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 10F);
            lblForename.Location = new Point(16, 45);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(70, 19);
            lblForename.TabIndex = 4;
            lblForename.Text = "Forename";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(265, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(16, 102);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 19);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // txtNumCages
            // 
            txtNumCages.Location = new Point(20, 183);
            txtNumCages.Name = "txtNumCages";
            txtNumCages.Size = new Size(265, 23);
            txtNumCages.TabIndex = 9;
            // 
            // lblNumCages
            // 
            lblNumCages.AutoSize = true;
            lblNumCages.Font = new Font("Segoe UI", 10F);
            lblNumCages.Location = new Point(16, 161);
            lblNumCages.Name = "lblNumCages";
            lblNumCages.Size = new Size(116, 19);
            lblNumCages.TabIndex = 8;
            lblNumCages.Text = "Number of Cages";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(330, 68);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(265, 23);
            txtSurname.TabIndex = 13;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10F);
            lblSurname.Location = new Point(326, 46);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(63, 19);
            lblSurname.TabIndex = 12;
            lblSurname.Text = "Surname";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(330, 182);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(265, 23);
            txtPosition.TabIndex = 17;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.Location = new Point(326, 160);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 19);
            lblPosition.TabIndex = 16;
            lblPosition.Text = "Position";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(330, 124);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(265, 23);
            txtPhone.TabIndex = 15;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(326, 102);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(102, 19);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Phone Number";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(326, 238);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(175, 48);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.Location = new Point(110, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 48);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewKeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 314);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtNumCages);
            Controls.Add(lblNumCages);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtForename);
            Controls.Add(lblForename);
            Name = "NewKeeperForm";
            Text = "NewKeeperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtForename;
        private Label lblForename;
        private Label lblRecord;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtNumCages;
        private Label lblNumCages;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtPosition;
        private Label lblPosition;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button btnExit;
        private Button btnSave;
    }
}