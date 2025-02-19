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
            btnEdit = new Button();
            btnAdd = new Button();
            lvRecords = new ListView();
            rtbRecord = new RichTextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(889, 413);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(889, 374);
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
            lvRecords.Location = new Point(13, 13);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(639, 342);
            lvRecords.TabIndex = 12;
            lvRecords.UseCompatibleStateImageBehavior = false;
            lvRecords.ItemSelectionChanged += lvRecords_ItemSelectionChanged;
            // 
            // rtbRecord
            // 
            rtbRecord.Location = new Point(661, 12);
            rtbRecord.Name = "rtbRecord";
            rtbRecord.Size = new Size(335, 342);
            rtbRecord.TabIndex = 15;
            rtbRecord.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(776, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 33);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // KeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 469);
            Controls.Add(btnDelete);
            Controls.Add(rtbRecord);
            Controls.Add(lvRecords);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Name = "KeeperForm";
            Text = "Keeper Management";
            FormClosed += KeeperForm_FormClosed;
            Load += KeeperForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblSearch;
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
        private Button btnDelete;
    }
}