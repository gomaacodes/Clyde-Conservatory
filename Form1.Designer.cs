namespace Clyde_Conservatory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAnimalManagement = new Button();
            btnCageManagement = new Button();
            btnNewAnimal = new Button();
            btnKeeperManagement = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAnimalManagement
            // 
            btnAnimalManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnimalManagement.Location = new Point(12, 12);
            btnAnimalManagement.Name = "btnAnimalManagement";
            btnAnimalManagement.Size = new Size(291, 47);
            btnAnimalManagement.TabIndex = 2;
            btnAnimalManagement.Text = "Manage Animals";
            btnAnimalManagement.UseVisualStyleBackColor = true;
            btnAnimalManagement.Click += btnAnimalManagement_Click;
            // 
            // btnCageManagement
            // 
            btnCageManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCageManagement.Location = new Point(12, 171);
            btnCageManagement.Name = "btnCageManagement";
            btnCageManagement.Size = new Size(291, 47);
            btnCageManagement.TabIndex = 3;
            btnCageManagement.Text = "Manage Cages";
            btnCageManagement.UseVisualStyleBackColor = true;
            btnCageManagement.Click += btnCageManagement_Click;
            // 
            // btnNewAnimal
            // 
            btnNewAnimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewAnimal.Location = new Point(12, 65);
            btnNewAnimal.Name = "btnNewAnimal";
            btnNewAnimal.Size = new Size(291, 47);
            btnNewAnimal.TabIndex = 4;
            btnNewAnimal.Text = "Add New Animal";
            btnNewAnimal.UseVisualStyleBackColor = true;
            btnNewAnimal.Click += btnNewAnimal_Click;
            // 
            // btnKeeperManagement
            // 
            btnKeeperManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeeperManagement.Location = new Point(12, 118);
            btnKeeperManagement.Name = "btnKeeperManagement";
            btnKeeperManagement.Size = new Size(291, 47);
            btnKeeperManagement.TabIndex = 8;
            btnKeeperManagement.Text = "Manage Keepers";
            btnKeeperManagement.UseVisualStyleBackColor = true;
            btnKeeperManagement.Click += btnKeeperManagement_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 224);
            button1.Name = "button1";
            button1.Size = new Size(291, 47);
            button1.TabIndex = 9;
            button1.Text = "Generate Weekly Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 286);
            Controls.Add(button1);
            Controls.Add(btnKeeperManagement);
            Controls.Add(btnNewAnimal);
            Controls.Add(btnCageManagement);
            Controls.Add(btnAnimalManagement);
            Name = "Form1";
            Text = "Conservatory System";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAnimalManagement;
        private Button btnCageManagement;
        private Button btnNewAnimal;
        private Button btnKeeperManagement;
        private Button button1;
    }
}
