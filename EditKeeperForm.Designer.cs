namespace College_Admissions
{
    partial class EditKeeperForm
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
            clbCages = new CheckedListBox();
            lblCages = new Label();
            lblKeeper = new Label();
            btnExit = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // clbCages
            // 
            clbCages.FormattingEnabled = true;
            clbCages.Location = new Point(12, 80);
            clbCages.Name = "clbCages";
            clbCages.Size = new Size(263, 184);
            clbCages.TabIndex = 12;
            clbCages.ItemCheck += clbCages_ItemCheck;
            // 
            // lblCages
            // 
            lblCages.AutoSize = true;
            lblCages.Font = new Font("Segoe UI", 10F);
            lblCages.Location = new Point(12, 49);
            lblCages.Name = "lblCages";
            lblCages.Size = new Size(105, 19);
            lblCages.TabIndex = 11;
            lblCages.Text = "Assigned Cages";
            // 
            // lblKeeper
            // 
            lblKeeper.AutoSize = true;
            lblKeeper.Font = new Font("Segoe UI", 12F);
            lblKeeper.Location = new Point(12, 9);
            lblKeeper.Name = "lblKeeper";
            lblKeeper.Size = new Size(52, 21);
            lblKeeper.TabIndex = 10;
            lblKeeper.Text = "label1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(175, 287);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditKeeperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 323);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(clbCages);
            Controls.Add(lblCages);
            Controls.Add(lblKeeper);
            Name = "EditKeeperForm";
            Text = "EditKeeperForm";
            Load += EditKeeperForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbCages;
        private Label lblCages;
        private Label lblKeeper;
        private Button btnExit;
        private Button btnSave;
    }
}