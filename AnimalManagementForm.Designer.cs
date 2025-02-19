namespace Clyde_Conservatory
{
    partial class AnimalForm
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
            btnEdit = new Button();
            lvRecords = new ListView();
            rtbRecord = new RichTextBox();
            btnEmergencyCheck = new Button();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(867, 372);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(201, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lvRecords
            // 
            lvRecords.Font = new Font("Segoe UI", 12F);
            lvRecords.Location = new Point(12, 12);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(692, 342);
            lvRecords.TabIndex = 12;
            lvRecords.UseCompatibleStateImageBehavior = false;
            lvRecords.ItemSelectionChanged += lvRecords_ItemSelectionChanged;
            // 
            // rtbRecord
            // 
            rtbRecord.Location = new Point(710, 12);
            rtbRecord.Name = "rtbRecord";
            rtbRecord.Size = new Size(358, 342);
            rtbRecord.TabIndex = 15;
            rtbRecord.Text = "";
            // 
            // btnEmergencyCheck
            // 
            btnEmergencyCheck.Font = new Font("Segoe UI", 12F);
            btnEmergencyCheck.Location = new Point(867, 411);
            btnEmergencyCheck.Name = "btnEmergencyCheck";
            btnEmergencyCheck.Size = new Size(201, 33);
            btnEmergencyCheck.TabIndex = 16;
            btnEmergencyCheck.Text = "Emergency Health Check";
            btnEmergencyCheck.UseVisualStyleBackColor = true;
            btnEmergencyCheck.Click += btnEmergencyCheck_Click;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 466);
            Controls.Add(btnEmergencyCheck);
            Controls.Add(rtbRecord);
            Controls.Add(lvRecords);
            Controls.Add(btnEdit);
            Name = "AnimalForm";
            Text = "Animal Management";
            FormClosed += AnimalForm_FormClosed;
            Load += AnimalForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnEdit;
        private ListView lvRecords;
        private RichTextBox rtbRecord;
        private Button btnEmergencyCheck;
    }
}