namespace Clyde_Conservatory
{
    partial class CageAllocationForm
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
            lblCage = new Label();
            btnSave = new Button();
            btnExit = new Button();
            clbCages = new CheckedListBox();
            btnToggle = new Button();
            lblEmergencyShare = new Label();
            lblShareState = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(16, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCage
            // 
            lblCage.AutoSize = true;
            lblCage.Font = new Font("Segoe UI", 10F);
            lblCage.Location = new Point(22, 76);
            lblCage.Name = "lblCage";
            lblCage.Size = new Size(40, 19);
            lblCage.TabIndex = 5;
            lblCage.Text = "Cage";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(194, 185);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // clbCages
            // 
            clbCages.FormattingEnabled = true;
            clbCages.Location = new Point(26, 98);
            clbCages.Name = "clbCages";
            clbCages.Size = new Size(246, 76);
            clbCages.TabIndex = 9;
            clbCages.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(194, 45);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(75, 23);
            btnToggle.TabIndex = 10;
            btnToggle.Text = "Toggle";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // lblEmergencyShare
            // 
            lblEmergencyShare.AutoSize = true;
            lblEmergencyShare.Font = new Font("Segoe UI", 10F);
            lblEmergencyShare.Location = new Point(22, 47);
            lblEmergencyShare.Name = "lblEmergencyShare";
            lblEmergencyShare.Size = new Size(121, 19);
            lblEmergencyShare.TabIndex = 11;
            lblEmergencyShare.Text = "Emergency Share: ";
            // 
            // lblShareState
            // 
            lblShareState.AutoSize = true;
            lblShareState.Font = new Font("Segoe UI", 10F);
            lblShareState.Location = new Point(137, 47);
            lblShareState.Name = "lblShareState";
            lblShareState.Size = new Size(28, 19);
            lblShareState.TabIndex = 12;
            lblShareState.Text = "Off";
            // 
            // CageAllocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 218);
            Controls.Add(lblShareState);
            Controls.Add(lblEmergencyShare);
            Controls.Add(btnToggle);
            Controls.Add(clbCages);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblCage);
            Controls.Add(lblName);
            Name = "CageAllocationForm";
            Text = "CageAllocationForm";
            FormClosed += CageAllocationForm_FormClosed;
            Load += CageAllocationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCage;
        private Button btnSave;
        private Button btnExit;
        private CheckedListBox clbCages;
        private Button btnToggle;
        private Label lblEmergencyShare;
        private Label lblShareState;
    }
}