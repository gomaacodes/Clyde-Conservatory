namespace Clyde_Conservatory
{
    partial class CageForm
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
            lvRecords = new ListView();
            rtbRecord = new RichTextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lvRecords
            // 
            lvRecords.Font = new Font("Segoe UI", 12F);
            lvRecords.Location = new Point(12, 12);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(600, 342);
            lvRecords.TabIndex = 12;
            lvRecords.UseCompatibleStateImageBehavior = false;
            lvRecords.ItemSelectionChanged += lvRecords_ItemSelectionChanged;
            // 
            // rtbRecord
            // 
            rtbRecord.Location = new Point(624, 12);
            rtbRecord.Name = "rtbRecord";
            rtbRecord.Size = new Size(335, 342);
            rtbRecord.TabIndex = 15;
            rtbRecord.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(884, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "button1";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 399);
            Controls.Add(btnDelete);
            Controls.Add(rtbRecord);
            Controls.Add(lvRecords);
            Name = "CageForm";
            Text = "Unit Management";
            FormClosed += CageForm_FormClosed;
            Load += CageForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblSearch;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtSearch;
        private RadioButton rdoTitle;
        private RadioButton rdoLevel;
        private Button btnAdd;
        private ListView lvRecords;
        private Label lblRecord;
        private RichTextBox rtbRecord;
        private RadioButton rdoDepartment;
        private RadioButton rdoType;
        private RadioButton rdoCode;
        private Button btnExport;
        private Button button1;
    }
}