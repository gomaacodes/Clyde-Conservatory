namespace Clyde_Conservatory
{
    partial class AnimalEditingForm
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
            lblRecord = new Label();
            btnSave = new Button();
            btnExit = new Button();
            grbxEmergencyShare = new GroupBox();
            rdbYes = new RadioButton();
            rdbNo = new RadioButton();
            btnEndLoan = new Button();
            lblGaveBirth = new Label();
            dtpGaveBirth = new DateTimePicker();
            lblMates = new Label();
            lblFlightSpeed = new Label();
            txtWingSpan = new TextBox();
            lblWingSpan = new Label();
            rtxtGaveBirth = new RichTextBox();
            txtFlightSpeed = new TextBox();
            btnAdd = new Button();
            lblLandSpeed = new Label();
            txtLandSpeed = new TextBox();
            clbMates = new CheckedListBox();
            btnLoanOut = new Button();
            lblEmergencyShare = new Label();
            clbCages = new CheckedListBox();
            lblCage = new Label();
            grbxUpdate = new GroupBox();
            rdbDetails = new RadioButton();
            rdbAcquisition = new RadioButton();
            rdbUnit = new RadioButton();
            lblUpdate = new Label();
            btnCheckHealth = new Button();
            grbxEmergencyShare.SuspendLayout();
            grbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Segoe UI", 12F);
            lblRecord.Location = new Point(16, 13);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(52, 21);
            lblRecord.TabIndex = 0;
            lblRecord.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(45, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(170, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grbxEmergencyShare
            // 
            grbxEmergencyShare.Controls.Add(rdbYes);
            grbxEmergencyShare.Controls.Add(rdbNo);
            grbxEmergencyShare.Location = new Point(20, 141);
            grbxEmergencyShare.Name = "grbxEmergencyShare";
            grbxEmergencyShare.Size = new Size(246, 41);
            grbxEmergencyShare.TabIndex = 51;
            grbxEmergencyShare.TabStop = false;
            grbxEmergencyShare.Visible = false;
            // 
            // rdbYes
            // 
            rdbYes.AutoSize = true;
            rdbYes.Location = new Point(83, 13);
            rdbYes.Name = "rdbYes";
            rdbYes.Size = new Size(42, 19);
            rdbYes.TabIndex = 1;
            rdbYes.Text = "Yes";
            rdbYes.UseVisualStyleBackColor = true;
            rdbYes.Visible = false;
            // 
            // rdbNo
            // 
            rdbNo.AutoSize = true;
            rdbNo.Checked = true;
            rdbNo.Location = new Point(6, 13);
            rdbNo.Name = "rdbNo";
            rdbNo.Size = new Size(41, 19);
            rdbNo.TabIndex = 0;
            rdbNo.TabStop = true;
            rdbNo.Text = "No";
            rdbNo.UseVisualStyleBackColor = true;
            rdbNo.Visible = false;
            // 
            // btnEndLoan
            // 
            btnEndLoan.Location = new Point(20, 127);
            btnEndLoan.Name = "btnEndLoan";
            btnEndLoan.Size = new Size(246, 63);
            btnEndLoan.TabIndex = 62;
            btnEndLoan.Text = "Terminate Loan";
            btnEndLoan.UseVisualStyleBackColor = true;
            btnEndLoan.Visible = false;
            // 
            // lblGaveBirth
            // 
            lblGaveBirth.AutoSize = true;
            lblGaveBirth.Font = new Font("Segoe UI", 10F);
            lblGaveBirth.Location = new Point(24, 210);
            lblGaveBirth.Name = "lblGaveBirth";
            lblGaveBirth.Size = new Size(96, 19);
            lblGaveBirth.TabIndex = 58;
            lblGaveBirth.Text = "Gave Birth On";
            lblGaveBirth.Visible = false;
            // 
            // dtpGaveBirth
            // 
            dtpGaveBirth.Location = new Point(24, 232);
            dtpGaveBirth.Name = "dtpGaveBirth";
            dtpGaveBirth.Size = new Size(242, 23);
            dtpGaveBirth.TabIndex = 57;
            dtpGaveBirth.Visible = false;
            // 
            // lblMates
            // 
            lblMates.AutoSize = true;
            lblMates.Font = new Font("Segoe UI", 10F);
            lblMates.Location = new Point(24, 119);
            lblMates.Name = "lblMates";
            lblMates.Size = new Size(82, 19);
            lblMates.TabIndex = 52;
            lblMates.Text = "Mated With";
            lblMates.Visible = false;
            // 
            // lblFlightSpeed
            // 
            lblFlightSpeed.AutoSize = true;
            lblFlightSpeed.Font = new Font("Segoe UI", 10F);
            lblFlightSpeed.Location = new Point(24, 167);
            lblFlightSpeed.Name = "lblFlightSpeed";
            lblFlightSpeed.Size = new Size(191, 19);
            lblFlightSpeed.TabIndex = 63;
            lblFlightSpeed.Text = "Optimum Flight Speed (km/h)";
            lblFlightSpeed.Visible = false;
            // 
            // txtWingSpan
            // 
            txtWingSpan.Location = new Point(24, 141);
            txtWingSpan.Name = "txtWingSpan";
            txtWingSpan.Size = new Size(246, 23);
            txtWingSpan.TabIndex = 62;
            txtWingSpan.Visible = false;
            // 
            // lblWingSpan
            // 
            lblWingSpan.AutoSize = true;
            lblWingSpan.Font = new Font("Segoe UI", 10F);
            lblWingSpan.Location = new Point(24, 119);
            lblWingSpan.Name = "lblWingSpan";
            lblWingSpan.Size = new Size(100, 19);
            lblWingSpan.TabIndex = 61;
            lblWingSpan.Text = "Wingspan (cm)";
            lblWingSpan.Visible = false;
            lblWingSpan.Click += label2_Click;
            // 
            // rtxtGaveBirth
            // 
            rtxtGaveBirth.Location = new Point(24, 261);
            rtxtGaveBirth.Name = "rtxtGaveBirth";
            rtxtGaveBirth.Size = new Size(242, 96);
            rtxtGaveBirth.TabIndex = 60;
            rtxtGaveBirth.Text = "";
            rtxtGaveBirth.Visible = false;
            // 
            // txtFlightSpeed
            // 
            txtFlightSpeed.Location = new Point(24, 188);
            txtFlightSpeed.Name = "txtFlightSpeed";
            txtFlightSpeed.Size = new Size(248, 23);
            txtFlightSpeed.TabIndex = 66;
            txtFlightSpeed.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(191, 206);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 59;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            // 
            // lblLandSpeed
            // 
            lblLandSpeed.AutoSize = true;
            lblLandSpeed.Font = new Font("Segoe UI", 10F);
            lblLandSpeed.Location = new Point(20, 119);
            lblLandSpeed.Name = "lblLandSpeed";
            lblLandSpeed.Size = new Size(187, 19);
            lblLandSpeed.TabIndex = 65;
            lblLandSpeed.Text = "Optimum Land Speed (km/h)";
            lblLandSpeed.Visible = false;
            // 
            // txtLandSpeed
            // 
            txtLandSpeed.Location = new Point(20, 141);
            txtLandSpeed.Name = "txtLandSpeed";
            txtLandSpeed.Size = new Size(246, 23);
            txtLandSpeed.TabIndex = 64;
            txtLandSpeed.Visible = false;
            // 
            // clbMates
            // 
            clbMates.FormattingEnabled = true;
            clbMates.Location = new Point(24, 141);
            clbMates.Name = "clbMates";
            clbMates.Size = new Size(242, 58);
            clbMates.TabIndex = 53;
            clbMates.Visible = false;
            // 
            // btnLoanOut
            // 
            btnLoanOut.Location = new Point(20, 126);
            btnLoanOut.Name = "btnLoanOut";
            btnLoanOut.Size = new Size(246, 63);
            btnLoanOut.TabIndex = 61;
            btnLoanOut.Text = "Loan Out";
            btnLoanOut.UseVisualStyleBackColor = true;
            btnLoanOut.Visible = false;
            // 
            // lblEmergencyShare
            // 
            lblEmergencyShare.AutoSize = true;
            lblEmergencyShare.Font = new Font("Segoe UI", 10F);
            lblEmergencyShare.Location = new Point(20, 119);
            lblEmergencyShare.Name = "lblEmergencyShare";
            lblEmergencyShare.Size = new Size(114, 19);
            lblEmergencyShare.TabIndex = 50;
            lblEmergencyShare.Text = "Emergency Share";
            lblEmergencyShare.Visible = false;
            // 
            // clbCages
            // 
            clbCages.FormattingEnabled = true;
            clbCages.Location = new Point(24, 232);
            clbCages.Name = "clbCages";
            clbCages.Size = new Size(242, 58);
            clbCages.TabIndex = 49;
            clbCages.Visible = false;
            // 
            // lblCage
            // 
            lblCage.AutoSize = true;
            lblCage.Font = new Font("Segoe UI", 10F);
            lblCage.Location = new Point(20, 210);
            lblCage.Name = "lblCage";
            lblCage.Size = new Size(35, 19);
            lblCage.TabIndex = 48;
            lblCage.Text = "Unit";
            lblCage.Visible = false;
            // 
            // grbxUpdate
            // 
            grbxUpdate.Controls.Add(rdbDetails);
            grbxUpdate.Controls.Add(rdbAcquisition);
            grbxUpdate.Controls.Add(rdbUnit);
            grbxUpdate.Location = new Point(20, 70);
            grbxUpdate.Name = "grbxUpdate";
            grbxUpdate.Size = new Size(246, 43);
            grbxUpdate.TabIndex = 55;
            grbxUpdate.TabStop = false;
            // 
            // rdbDetails
            // 
            rdbDetails.AutoSize = true;
            rdbDetails.Location = new Point(150, 16);
            rdbDetails.Name = "rdbDetails";
            rdbDetails.Size = new Size(60, 19);
            rdbDetails.TabIndex = 2;
            rdbDetails.TabStop = true;
            rdbDetails.Text = "Details";
            rdbDetails.UseVisualStyleBackColor = true;
            rdbDetails.CheckedChanged += grbxUpdate_CheckedChanged;
            // 
            // rdbAcquisition
            // 
            rdbAcquisition.AutoSize = true;
            rdbAcquisition.Location = new Point(59, 16);
            rdbAcquisition.Name = "rdbAcquisition";
            rdbAcquisition.Size = new Size(85, 19);
            rdbAcquisition.TabIndex = 1;
            rdbAcquisition.TabStop = true;
            rdbAcquisition.Text = "Acquisition";
            rdbAcquisition.UseVisualStyleBackColor = true;
            rdbAcquisition.CheckedChanged += grbxUpdate_CheckedChanged;
            // 
            // rdbUnit
            // 
            rdbUnit.AutoSize = true;
            rdbUnit.Location = new Point(6, 16);
            rdbUnit.Name = "rdbUnit";
            rdbUnit.Size = new Size(47, 19);
            rdbUnit.TabIndex = 0;
            rdbUnit.TabStop = true;
            rdbUnit.Text = "Unit";
            rdbUnit.UseVisualStyleBackColor = true;
            rdbUnit.CheckedChanged += grbxUpdate_CheckedChanged;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 10F);
            lblUpdate.Location = new Point(20, 53);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(54, 19);
            lblUpdate.TabIndex = 56;
            lblUpdate.Text = "Update";
            // 
            // btnCheckHealth
            // 
            btnCheckHealth.Location = new Point(170, 206);
            btnCheckHealth.Name = "btnCheckHealth";
            btnCheckHealth.Size = new Size(96, 23);
            btnCheckHealth.TabIndex = 69;
            btnCheckHealth.Text = "Health Check";
            btnCheckHealth.UseVisualStyleBackColor = true;
            btnCheckHealth.Visible = false;
            btnCheckHealth.Click += btnCheckHealth_Click;
            // 
            // AnimalEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 433);
            Controls.Add(lblMates);
            Controls.Add(lblFlightSpeed);
            Controls.Add(lblGaveBirth);
            Controls.Add(btnEndLoan);
            Controls.Add(dtpGaveBirth);
            Controls.Add(lblLandSpeed);
            Controls.Add(txtFlightSpeed);
            Controls.Add(txtLandSpeed);
            Controls.Add(txtWingSpan);
            Controls.Add(btnLoanOut);
            Controls.Add(lblWingSpan);
            Controls.Add(clbMates);
            Controls.Add(lblRecord);
            Controls.Add(btnCheckHealth);
            Controls.Add(btnAdd);
            Controls.Add(lblUpdate);
            Controls.Add(grbxUpdate);
            Controls.Add(grbxEmergencyShare);
            Controls.Add(rtxtGaveBirth);
            Controls.Add(lblEmergencyShare);
            Controls.Add(clbCages);
            Controls.Add(lblCage);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Name = "AnimalEditingForm";
            Text = "Animal Editing";
            FormClosed += LecturerCUForm_FormClosed;
            Load += AnimalEditingForm_Load;
            grbxEmergencyShare.ResumeLayout(false);
            grbxEmergencyShare.PerformLayout();
            grbxUpdate.ResumeLayout(false);
            grbxUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecord;
        private Button btnSave;
        private Button btnExit;
        private TextBox txtWingSpan;
        private TextBox txtLandSpeed;
        private Label lblMates;
        private Label lblPersonalEmail;
        private TextBox txtPersonalEmail;
        private GroupBox grbxEmergencyShare;
        private RadioButton rdbYes;
        private RadioButton rdbNo;
        private Label lblEmergencyShare;
        private CheckedListBox clbCages;
        private Label lblCage;
        private GroupBox grbxUpdate;
        private RadioButton rdbDetails;
        private RadioButton rdbAcquisition;
        private RadioButton rdbUnit;
        private CheckedListBox clbMates;
        private Label lblUpdate;
        private DateTimePicker dtpGaveBirth;
        private Label lblGaveBirth;
        private Button btnAdd;
        private RichTextBox rtxtGaveBirth;
        private Button btnLoanOut;
        private Button btnEndLoan;
        private Label lblWingSpan;
        private Label lblFlightSpeed;
        private Label lblLandSpeed;
        private TextBox txtFlightSpeed;
        private Button btnCheckHealth;
    }
}