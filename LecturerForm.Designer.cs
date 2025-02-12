namespace Clyde_Conservatory
{
    partial class KeeperForm
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
            lblSearch = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            rdoFirstName = new RadioButton();
            rdoLastName = new RadioButton();
            btnAdd = new Button();
            lvRecords = new ListView();
            lblRecord = new Label();
            rtbRecord = new RichTextBox();
            rdoLecturerID = new RadioButton();
            rdoDepartment = new RadioButton();
            btnExport = new Button();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 14.25F);
            lblSearch.Location = new Point(12, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(94, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(776, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(889, 413);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(249, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // rdoFirstName
            // 
            rdoFirstName.AutoSize = true;
            rdoFirstName.Location = new Point(289, 36);
            rdoFirstName.Name = "rdoFirstName";
            rdoFirstName.Size = new Size(82, 19);
            rdoFirstName.TabIndex = 6;
            rdoFirstName.TabStop = true;
            rdoFirstName.Text = "First Name";
            rdoFirstName.UseVisualStyleBackColor = true;
            rdoFirstName.CheckedChanged += rdo_CheckedChanged;
            // 
            // rdoLastName
            // 
            rdoLastName.AutoSize = true;
            rdoLastName.Location = new Point(377, 36);
            rdoLastName.Name = "rdoLastName";
            rdoLastName.Size = new Size(81, 19);
            rdoLastName.TabIndex = 8;
            rdoLastName.TabStop = true;
            rdoLastName.Text = "Last Name";
            rdoLastName.UseVisualStyleBackColor = true;
            rdoLastName.CheckedChanged += rdo_CheckedChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(12, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvRecords
            // 
            lvRecords.Font = new Font("Segoe UI", 12F);
            lvRecords.Location = new Point(12, 65);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(639, 342);
            lvRecords.TabIndex = 12;
            lvRecords.UseCompatibleStateImageBehavior = false;
            lvRecords.ItemSelectionChanged += lvRecords_ItemSelectionChanged;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Segoe UI", 12F);
            lblRecord.Location = new Point(661, 34);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(52, 21);
            lblRecord.TabIndex = 13;
            lblRecord.Text = "label2";
            // 
            // rtbRecord
            // 
            rtbRecord.Location = new Point(661, 65);
            rtbRecord.Name = "rtbRecord";
            rtbRecord.Size = new Size(335, 342);
            rtbRecord.TabIndex = 15;
            rtbRecord.Text = "";
            // 
            // rdoLecturerID
            // 
            rdoLecturerID.AutoSize = true;
            rdoLecturerID.Location = new Point(558, 36);
            rdoLecturerID.Name = "rdoLecturerID";
            rdoLecturerID.Size = new Size(82, 19);
            rdoLecturerID.TabIndex = 16;
            rdoLecturerID.TabStop = true;
            rdoLecturerID.Text = "Lecturer ID";
            rdoLecturerID.UseVisualStyleBackColor = true;
            rdoLecturerID.CheckedChanged += rdo_CheckedChanged;
            // 
            // rdoDepartment
            // 
            rdoDepartment.AutoSize = true;
            rdoDepartment.Location = new Point(464, 36);
            rdoDepartment.Name = "rdoDepartment";
            rdoDepartment.Size = new Size(88, 19);
            rdoDepartment.TabIndex = 18;
            rdoDepartment.TabStop = true;
            rdoDepartment.Text = "Department";
            rdoDepartment.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.Location = new Point(125, 413);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(107, 33);
            btnExport.TabIndex = 19;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // KeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 469);
            Controls.Add(btnExport);
            Controls.Add(rdoDepartment);
            Controls.Add(rdoLecturerID);
            Controls.Add(rtbRecord);
            Controls.Add(lblRecord);
            Controls.Add(lvRecords);
            Controls.Add(btnAdd);
            Controls.Add(rdoLastName);
            Controls.Add(rdoFirstName);
            Controls.Add(txtSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblSearch);
            Name = "KeeperForm";
            Text = "Form2";
            FormClosed += KeeperForm_FormClosed;
            Load += KeeperForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSearch;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtSearch;
        private RadioButton rdoFirstName;
        private RadioButton rdoLastName;
        private Button btnAdd;
        private ListView lvRecords;
        private Label lblRecord;
        private RichTextBox rtbRecord;
        private RadioButton rdoLecturerID;
        private RadioButton rdoDepartment;
        private Button btnExport;
    }
}