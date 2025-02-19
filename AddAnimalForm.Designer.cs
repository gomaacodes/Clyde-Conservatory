namespace Clyde_Conservatory
{
    partial class AddAnimalForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblBirthDate = new Label();
            lblType = new Label();
            btnSave = new Button();
            btnExit = new Button();
            clbTypes = new CheckedListBox();
            dtpDateOfBirth = new DateTimePicker();
            lblAnimalGroup = new Label();
            grbxGroup = new GroupBox();
            rdbBirdNonFlying = new RadioButton();
            rdbBirdFlying = new RadioButton();
            rdbReptile = new RadioButton();
            rdbMammal = new RadioButton();
            grbxSex = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            lblSex = new Label();
            grbxAcquisitionType = new GroupBox();
            rdbBorrowed = new RadioButton();
            rdbOwned = new RadioButton();
            lblAcquisitionType = new Label();
            dtpAcquisitionDate = new DateTimePicker();
            lblAcquisitionDate = new Label();
            txtDangerRating = new TextBox();
            lblDangerRating = new Label();
            grbxSize = new GroupBox();
            rdbLarge = new RadioButton();
            rdbMedium = new RadioButton();
            rdbSmall = new RadioButton();
            lblSize = new Label();
            txtInsurance = new TextBox();
            lblInsurance = new Label();
            txtEnvironment = new TextBox();
            lblEnvironment = new Label();
            txtHabitatTemp = new TextBox();
            lblHabitatTemp = new Label();
            txtFeedingRequirement = new TextBox();
            lblFeedingRequirement = new Label();
            txtNestEnvironment = new TextBox();
            lblNestEnvironment = new Label();
            txtWingSpan = new TextBox();
            lblWingSpan = new Label();
            txtFlightSpeed = new TextBox();
            lblFlightSpeed = new Label();
            txtPreferredHabitat = new TextBox();
            lblPreferredHabitat = new Label();
            txtLandSpeed = new TextBox();
            lblLandSpeed = new Label();
            grbxGroup.SuspendLayout();
            grbxSex.SuspendLayout();
            grbxAcquisitionType.SuspendLayout();
            grbxSize.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(20, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 2;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F);
            lblBirthDate.Location = new Point(20, 257);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(87, 19);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Date of Birth";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.Location = new Point(20, 169);
            lblType.Name = "lblType";
            lblType.Size = new Size(37, 19);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.Location = new Point(381, 424);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 48);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(381, 478);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(175, 48);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // clbTypes
            // 
            clbTypes.FormattingEnabled = true;
            clbTypes.Location = new Point(24, 191);
            clbTypes.Name = "clbTypes";
            clbTypes.Size = new Size(265, 58);
            clbTypes.TabIndex = 9;
            clbTypes.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(24, 279);
            dtpDateOfBirth.MaxDate = new DateTime(2024, 11, 13, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(265, 23);
            dtpDateOfBirth.TabIndex = 29;
            dtpDateOfBirth.Value = new DateTime(2024, 11, 13, 0, 0, 0, 0);
            // 
            // lblAnimalGroup
            // 
            lblAnimalGroup.AutoSize = true;
            lblAnimalGroup.Font = new Font("Segoe UI", 10F);
            lblAnimalGroup.Location = new Point(24, 99);
            lblAnimalGroup.Name = "lblAnimalGroup";
            lblAnimalGroup.Size = new Size(48, 19);
            lblAnimalGroup.TabIndex = 30;
            lblAnimalGroup.Text = "Group";
            // 
            // grbxGroup
            // 
            grbxGroup.Controls.Add(rdbBirdNonFlying);
            grbxGroup.Controls.Add(rdbBirdFlying);
            grbxGroup.Controls.Add(rdbReptile);
            grbxGroup.Controls.Add(rdbMammal);
            grbxGroup.Location = new Point(24, 116);
            grbxGroup.Name = "grbxGroup";
            grbxGroup.Size = new Size(265, 43);
            grbxGroup.TabIndex = 31;
            grbxGroup.TabStop = false;
            // 
            // rdbBirdNonFlying
            // 
            rdbBirdNonFlying.AutoSize = true;
            rdbBirdNonFlying.Location = new Point(201, 16);
            rdbBirdNonFlying.Name = "rdbBirdNonFlying";
            rdbBirdNonFlying.Size = new Size(63, 19);
            rdbBirdNonFlying.TabIndex = 3;
            rdbBirdNonFlying.TabStop = true;
            rdbBirdNonFlying.Text = "Bird(N)";
            rdbBirdNonFlying.UseVisualStyleBackColor = true;
            rdbBirdNonFlying.CheckedChanged += rdbGroup_CheckedChanged;
            // 
            // rdbBirdFlying
            // 
            rdbBirdFlying.AutoSize = true;
            rdbBirdFlying.Location = new Point(139, 16);
            rdbBirdFlying.Name = "rdbBirdFlying";
            rdbBirdFlying.Size = new Size(60, 19);
            rdbBirdFlying.TabIndex = 2;
            rdbBirdFlying.TabStop = true;
            rdbBirdFlying.Text = "Bird(F)";
            rdbBirdFlying.UseVisualStyleBackColor = true;
            rdbBirdFlying.CheckedChanged += rdbGroup_CheckedChanged;
            // 
            // rdbReptile
            // 
            rdbReptile.AutoSize = true;
            rdbReptile.Location = new Point(76, 16);
            rdbReptile.Name = "rdbReptile";
            rdbReptile.Size = new Size(61, 19);
            rdbReptile.TabIndex = 1;
            rdbReptile.TabStop = true;
            rdbReptile.Text = "Reptile";
            rdbReptile.UseVisualStyleBackColor = true;
            rdbReptile.CheckedChanged += rdbGroup_CheckedChanged;
            // 
            // rdbMammal
            // 
            rdbMammal.AutoSize = true;
            rdbMammal.Location = new Point(2, 16);
            rdbMammal.Name = "rdbMammal";
            rdbMammal.Size = new Size(73, 19);
            rdbMammal.TabIndex = 0;
            rdbMammal.TabStop = true;
            rdbMammal.Text = "Mammal";
            rdbMammal.UseVisualStyleBackColor = true;
            rdbMammal.CheckedChanged += rdbGroup_CheckedChanged;
            // 
            // grbxSex
            // 
            grbxSex.Controls.Add(rdbFemale);
            grbxSex.Controls.Add(rdbMale);
            grbxSex.Location = new Point(24, 325);
            grbxSex.Name = "grbxSex";
            grbxSex.Size = new Size(265, 43);
            grbxSex.TabIndex = 33;
            grbxSex.TabStop = false;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(97, 16);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(63, 19);
            rdbFemale.TabIndex = 1;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(6, 16);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(51, 19);
            rdbMale.TabIndex = 0;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 10F);
            lblSex.Location = new Point(24, 308);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(29, 19);
            lblSex.TabIndex = 32;
            lblSex.Text = "Sex";
            // 
            // grbxAcquisitionType
            // 
            grbxAcquisitionType.Controls.Add(rdbBorrowed);
            grbxAcquisitionType.Controls.Add(rdbOwned);
            grbxAcquisitionType.Location = new Point(329, 116);
            grbxAcquisitionType.Name = "grbxAcquisitionType";
            grbxAcquisitionType.Size = new Size(246, 43);
            grbxAcquisitionType.TabIndex = 35;
            grbxAcquisitionType.TabStop = false;
            // 
            // rdbBorrowed
            // 
            rdbBorrowed.AutoSize = true;
            rdbBorrowed.Location = new Point(97, 16);
            rdbBorrowed.Name = "rdbBorrowed";
            rdbBorrowed.Size = new Size(76, 19);
            rdbBorrowed.TabIndex = 1;
            rdbBorrowed.TabStop = true;
            rdbBorrowed.Text = "Borrowed";
            rdbBorrowed.UseVisualStyleBackColor = true;
            // 
            // rdbOwned
            // 
            rdbOwned.AutoSize = true;
            rdbOwned.Location = new Point(6, 16);
            rdbOwned.Name = "rdbOwned";
            rdbOwned.Size = new Size(50, 19);
            rdbOwned.TabIndex = 0;
            rdbOwned.TabStop = true;
            rdbOwned.Text = "Own";
            rdbOwned.UseVisualStyleBackColor = true;
            // 
            // lblAcquisitionType
            // 
            lblAcquisitionType.AutoSize = true;
            lblAcquisitionType.Font = new Font("Segoe UI", 10F);
            lblAcquisitionType.Location = new Point(325, 99);
            lblAcquisitionType.Name = "lblAcquisitionType";
            lblAcquisitionType.Size = new Size(108, 19);
            lblAcquisitionType.TabIndex = 34;
            lblAcquisitionType.Text = "Acquisition Type";
            // 
            // dtpAcquisitionDate
            // 
            dtpAcquisitionDate.Location = new Point(329, 68);
            dtpAcquisitionDate.MaxDate = new DateTime(2024, 11, 13, 0, 0, 0, 0);
            dtpAcquisitionDate.Name = "dtpAcquisitionDate";
            dtpAcquisitionDate.Size = new Size(246, 23);
            dtpAcquisitionDate.TabIndex = 37;
            dtpAcquisitionDate.Value = new DateTime(2024, 11, 13, 0, 0, 0, 0);
            // 
            // lblAcquisitionDate
            // 
            lblAcquisitionDate.AutoSize = true;
            lblAcquisitionDate.Font = new Font("Segoe UI", 10F);
            lblAcquisitionDate.Location = new Point(325, 46);
            lblAcquisitionDate.Name = "lblAcquisitionDate";
            lblAcquisitionDate.Size = new Size(109, 19);
            lblAcquisitionDate.TabIndex = 36;
            lblAcquisitionDate.Text = "Acquisition Date";
            // 
            // txtDangerRating
            // 
            txtDangerRating.Location = new Point(329, 252);
            txtDangerRating.Name = "txtDangerRating";
            txtDangerRating.Size = new Size(246, 23);
            txtDangerRating.TabIndex = 39;
            // 
            // lblDangerRating
            // 
            lblDangerRating.AutoSize = true;
            lblDangerRating.Font = new Font("Segoe UI", 10F);
            lblDangerRating.Location = new Point(325, 230);
            lblDangerRating.Name = "lblDangerRating";
            lblDangerRating.Size = new Size(97, 19);
            lblDangerRating.TabIndex = 38;
            lblDangerRating.Text = "Danger Rating";
            // 
            // grbxSize
            // 
            grbxSize.Controls.Add(rdbLarge);
            grbxSize.Controls.Add(rdbMedium);
            grbxSize.Controls.Add(rdbSmall);
            grbxSize.Location = new Point(329, 325);
            grbxSize.Name = "grbxSize";
            grbxSize.Size = new Size(246, 43);
            grbxSize.TabIndex = 41;
            grbxSize.TabStop = false;
            // 
            // rdbLarge
            // 
            rdbLarge.AutoSize = true;
            rdbLarge.Location = new Point(173, 16);
            rdbLarge.Name = "rdbLarge";
            rdbLarge.Size = new Size(54, 19);
            rdbLarge.TabIndex = 2;
            rdbLarge.TabStop = true;
            rdbLarge.Text = "Large";
            rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            rdbMedium.AutoSize = true;
            rdbMedium.Location = new Point(82, 16);
            rdbMedium.Name = "rdbMedium";
            rdbMedium.Size = new Size(70, 19);
            rdbMedium.TabIndex = 1;
            rdbMedium.TabStop = true;
            rdbMedium.Text = "Medium";
            rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbSmall
            // 
            rdbSmall.AutoSize = true;
            rdbSmall.Location = new Point(6, 16);
            rdbSmall.Name = "rdbSmall";
            rdbSmall.Size = new Size(54, 19);
            rdbSmall.TabIndex = 0;
            rdbSmall.TabStop = true;
            rdbSmall.Text = "Small";
            rdbSmall.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 10F);
            lblSize.Location = new Point(329, 308);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(32, 19);
            lblSize.TabIndex = 40;
            lblSize.Text = "Size";
            // 
            // txtInsurance
            // 
            txtInsurance.Location = new Point(329, 191);
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(246, 23);
            txtInsurance.TabIndex = 43;
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Font = new Font("Segoe UI", 10F);
            lblInsurance.Location = new Point(325, 169);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(68, 19);
            lblInsurance.TabIndex = 42;
            lblInsurance.Text = "Insurance";
            // 
            // txtEnvironment
            // 
            txtEnvironment.Location = new Point(630, 68);
            txtEnvironment.Name = "txtEnvironment";
            txtEnvironment.Size = new Size(246, 23);
            txtEnvironment.TabIndex = 47;
            txtEnvironment.Visible = false;
            // 
            // lblEnvironment
            // 
            lblEnvironment.AutoSize = true;
            lblEnvironment.Font = new Font("Segoe UI", 10F);
            lblEnvironment.Location = new Point(626, 46);
            lblEnvironment.Name = "lblEnvironment";
            lblEnvironment.Size = new Size(87, 19);
            lblEnvironment.TabIndex = 46;
            lblEnvironment.Text = "Environment";
            lblEnvironment.Visible = false;
            // 
            // txtHabitatTemp
            // 
            txtHabitatTemp.Location = new Point(630, 121);
            txtHabitatTemp.Name = "txtHabitatTemp";
            txtHabitatTemp.Size = new Size(246, 23);
            txtHabitatTemp.TabIndex = 45;
            txtHabitatTemp.Visible = false;
            // 
            // lblHabitatTemp
            // 
            lblHabitatTemp.AutoSize = true;
            lblHabitatTemp.Font = new Font("Segoe UI", 10F);
            lblHabitatTemp.Location = new Point(626, 99);
            lblHabitatTemp.Name = "lblHabitatTemp";
            lblHabitatTemp.Size = new Size(161, 19);
            lblHabitatTemp.TabIndex = 44;
            lblHabitatTemp.Text = "Habitat Temperature (C°)";
            lblHabitatTemp.Visible = false;
            // 
            // txtFeedingRequirement
            // 
            txtFeedingRequirement.Location = new Point(630, 68);
            txtFeedingRequirement.Name = "txtFeedingRequirement";
            txtFeedingRequirement.Size = new Size(246, 23);
            txtFeedingRequirement.TabIndex = 51;
            txtFeedingRequirement.Visible = false;
            // 
            // lblFeedingRequirement
            // 
            lblFeedingRequirement.AutoSize = true;
            lblFeedingRequirement.Font = new Font("Segoe UI", 10F);
            lblFeedingRequirement.Location = new Point(626, 46);
            lblFeedingRequirement.Name = "lblFeedingRequirement";
            lblFeedingRequirement.Size = new Size(139, 19);
            lblFeedingRequirement.TabIndex = 50;
            lblFeedingRequirement.Text = "Feeding Requirement";
            lblFeedingRequirement.Visible = false;
            // 
            // txtNestEnvironment
            // 
            txtNestEnvironment.Location = new Point(630, 121);
            txtNestEnvironment.Name = "txtNestEnvironment";
            txtNestEnvironment.Size = new Size(246, 23);
            txtNestEnvironment.TabIndex = 49;
            txtNestEnvironment.Visible = false;
            // 
            // lblNestEnvironment
            // 
            lblNestEnvironment.AutoSize = true;
            lblNestEnvironment.Font = new Font("Segoe UI", 10F);
            lblNestEnvironment.Location = new Point(626, 99);
            lblNestEnvironment.Name = "lblNestEnvironment";
            lblNestEnvironment.Size = new Size(119, 19);
            lblNestEnvironment.TabIndex = 48;
            lblNestEnvironment.Text = "Nest Environment";
            lblNestEnvironment.Visible = false;
            // 
            // txtWingSpan
            // 
            txtWingSpan.Location = new Point(630, 181);
            txtWingSpan.Name = "txtWingSpan";
            txtWingSpan.Size = new Size(246, 23);
            txtWingSpan.TabIndex = 55;
            txtWingSpan.Visible = false;
            // 
            // lblWingSpan
            // 
            lblWingSpan.AutoSize = true;
            lblWingSpan.Font = new Font("Segoe UI", 10F);
            lblWingSpan.Location = new Point(626, 159);
            lblWingSpan.Name = "lblWingSpan";
            lblWingSpan.Size = new Size(105, 19);
            lblWingSpan.TabIndex = 54;
            lblWingSpan.Text = "Wing Span (cm)";
            lblWingSpan.Visible = false;
            // 
            // txtFlightSpeed
            // 
            txtFlightSpeed.Location = new Point(630, 234);
            txtFlightSpeed.Name = "txtFlightSpeed";
            txtFlightSpeed.Size = new Size(246, 23);
            txtFlightSpeed.TabIndex = 53;
            txtFlightSpeed.Visible = false;
            // 
            // lblFlightSpeed
            // 
            lblFlightSpeed.AutoSize = true;
            lblFlightSpeed.Font = new Font("Segoe UI", 10F);
            lblFlightSpeed.Location = new Point(626, 212);
            lblFlightSpeed.Name = "lblFlightSpeed";
            lblFlightSpeed.Size = new Size(191, 19);
            lblFlightSpeed.TabIndex = 52;
            lblFlightSpeed.Text = "Optimum Flight Speed (km/h)";
            lblFlightSpeed.Visible = false;
            // 
            // txtPreferredHabitat
            // 
            txtPreferredHabitat.Location = new Point(630, 181);
            txtPreferredHabitat.Name = "txtPreferredHabitat";
            txtPreferredHabitat.Size = new Size(246, 23);
            txtPreferredHabitat.TabIndex = 59;
            txtPreferredHabitat.Visible = false;
            // 
            // lblPreferredHabitat
            // 
            lblPreferredHabitat.AutoSize = true;
            lblPreferredHabitat.Font = new Font("Segoe UI", 10F);
            lblPreferredHabitat.Location = new Point(626, 159);
            lblPreferredHabitat.Name = "lblPreferredHabitat";
            lblPreferredHabitat.Size = new Size(114, 19);
            lblPreferredHabitat.TabIndex = 58;
            lblPreferredHabitat.Text = "Preferred Habitat";
            lblPreferredHabitat.Visible = false;
            // 
            // txtLandSpeed
            // 
            txtLandSpeed.Location = new Point(630, 234);
            txtLandSpeed.Name = "txtLandSpeed";
            txtLandSpeed.Size = new Size(246, 23);
            txtLandSpeed.TabIndex = 57;
            txtLandSpeed.Visible = false;
            // 
            // lblLandSpeed
            // 
            lblLandSpeed.AutoSize = true;
            lblLandSpeed.Font = new Font("Segoe UI", 10F);
            lblLandSpeed.Location = new Point(626, 212);
            lblLandSpeed.Name = "lblLandSpeed";
            lblLandSpeed.Size = new Size(187, 19);
            lblLandSpeed.TabIndex = 56;
            lblLandSpeed.Text = "Optimum Land Speed (km/h)";
            lblLandSpeed.Visible = false;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 538);
            Controls.Add(txtPreferredHabitat);
            Controls.Add(lblPreferredHabitat);
            Controls.Add(txtLandSpeed);
            Controls.Add(lblLandSpeed);
            Controls.Add(txtWingSpan);
            Controls.Add(lblWingSpan);
            Controls.Add(txtFlightSpeed);
            Controls.Add(lblFlightSpeed);
            Controls.Add(txtFeedingRequirement);
            Controls.Add(lblFeedingRequirement);
            Controls.Add(txtNestEnvironment);
            Controls.Add(lblNestEnvironment);
            Controls.Add(txtEnvironment);
            Controls.Add(lblEnvironment);
            Controls.Add(txtHabitatTemp);
            Controls.Add(lblHabitatTemp);
            Controls.Add(txtInsurance);
            Controls.Add(lblInsurance);
            Controls.Add(grbxSize);
            Controls.Add(lblSize);
            Controls.Add(txtDangerRating);
            Controls.Add(lblDangerRating);
            Controls.Add(dtpAcquisitionDate);
            Controls.Add(lblAcquisitionDate);
            Controls.Add(grbxAcquisitionType);
            Controls.Add(lblAcquisitionType);
            Controls.Add(grbxSex);
            Controls.Add(lblSex);
            Controls.Add(grbxGroup);
            Controls.Add(lblAnimalGroup);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(clbTypes);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblType);
            Controls.Add(lblBirthDate);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            FormClosed += AddAnimalForm_FormClosed;
            Load += AddAnimalForm_Load;
            grbxGroup.ResumeLayout(false);
            grbxGroup.PerformLayout();
            grbxSex.ResumeLayout(false);
            grbxSex.PerformLayout();
            grbxAcquisitionType.ResumeLayout(false);
            grbxAcquisitionType.PerformLayout();
            grbxSize.ResumeLayout(false);
            grbxSize.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecord;
        private Label lblName;
        private TextBox txtName;
        private Label lblBirthDate;
        private Label lblType;
        private Button btnSave;
        private Button btnExit;
        private CheckedListBox clbTypes;
        private DateTimePicker dtpDateOfBirth;
        private Label lblAnimalGroup;
        private GroupBox grbxGroup;
        private RadioButton rdbMammal;
        private RadioButton rdbReptile;
        private RadioButton rdbBirdFlying;
        private GroupBox grbxSex;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label lblSex;
        private GroupBox grbxAcquisitionType;
        private RadioButton rdbBorrowed;
        private RadioButton rdbOwned;
        private Label lblAcquisitionType;
        private DateTimePicker dtpAcquisitionDate;
        private Label lblAcquisitionDate;
        private TextBox txtDangerRating;
        private Label lblDangerRating;
        private GroupBox grbxSize;
        private RadioButton rdbMedium;
        private Label lblSize;
        private RadioButton rdbLarge;
        private TextBox txtInsurance;
        private Label lblInsurance;
        private RadioButton rdbSmall;
        private TextBox txtEnvironment;
        private Label lblEnvironment;
        private TextBox txtHabitatTemp;
        private Label lblHabitatTemp;
        private TextBox txtFeedingRequirement;
        private Label lblFeedingRequirement;
        private TextBox txtNestEnvironment;
        private Label lblNestEnvironment;
        private TextBox txtWingSpan;
        private Label lblWingSpan;
        private TextBox txtFlightSpeed;
        private Label lblFlightSpeed;
        private TextBox txtPreferredHabitat;
        private Label lblPreferredHabitat;
        private TextBox txtLandSpeed;
        private Label lblLandSpeed;
        private RadioButton rdbBirdNonFlying;
    }
}