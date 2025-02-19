namespace Clyde_Conservatory
{
    partial class HealthCheckForm
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
            grbxHealthStatus = new GroupBox();
            rdbSick = new RadioButton();
            rdbHealthy = new RadioButton();
            lblHealthStatus = new Label();
            txtVetName = new TextBox();
            lblVetName = new Label();
            btnConfirm = new Button();
            grbxHealthStatus.SuspendLayout();
            SuspendLayout();
            // 
            // grbxHealthStatus
            // 
            grbxHealthStatus.Controls.Add(rdbSick);
            grbxHealthStatus.Controls.Add(rdbHealthy);
            grbxHealthStatus.Location = new Point(12, 95);
            grbxHealthStatus.Name = "grbxHealthStatus";
            grbxHealthStatus.Size = new Size(246, 43);
            grbxHealthStatus.TabIndex = 39;
            grbxHealthStatus.TabStop = false;
            // 
            // rdbSick
            // 
            rdbSick.AutoSize = true;
            rdbSick.Location = new Point(97, 16);
            rdbSick.Name = "rdbSick";
            rdbSick.Size = new Size(46, 19);
            rdbSick.TabIndex = 1;
            rdbSick.TabStop = true;
            rdbSick.Text = "Sick";
            rdbSick.UseVisualStyleBackColor = true;
            // 
            // rdbHealthy
            // 
            rdbHealthy.AutoSize = true;
            rdbHealthy.Location = new Point(6, 16);
            rdbHealthy.Name = "rdbHealthy";
            rdbHealthy.Size = new Size(66, 19);
            rdbHealthy.TabIndex = 0;
            rdbHealthy.TabStop = true;
            rdbHealthy.Text = "Healthy";
            rdbHealthy.UseVisualStyleBackColor = true;
            // 
            // lblHealthStatus
            // 
            lblHealthStatus.AutoSize = true;
            lblHealthStatus.Font = new Font("Segoe UI", 10F);
            lblHealthStatus.Location = new Point(12, 73);
            lblHealthStatus.Name = "lblHealthStatus";
            lblHealthStatus.Size = new Size(91, 19);
            lblHealthStatus.TabIndex = 38;
            lblHealthStatus.Text = "Health Status";
            // 
            // txtVetName
            // 
            txtVetName.Location = new Point(12, 37);
            txtVetName.Name = "txtVetName";
            txtVetName.Size = new Size(246, 23);
            txtVetName.TabIndex = 37;
            // 
            // lblVetName
            // 
            lblVetName.AutoSize = true;
            lblVetName.Font = new Font("Segoe UI", 10F);
            lblVetName.Location = new Point(8, 15);
            lblVetName.Name = "lblVetName";
            lblVetName.Size = new Size(29, 19);
            lblVetName.TabIndex = 36;
            lblVetName.Text = "Vet";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(183, 158);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 40;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // HealthCheckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 200);
            Controls.Add(btnConfirm);
            Controls.Add(grbxHealthStatus);
            Controls.Add(lblHealthStatus);
            Controls.Add(txtVetName);
            Controls.Add(lblVetName);
            Name = "HealthCheckForm";
            Text = "HealthCheckForm";
            FormClosing += HealthCheckForm_FormClosing;
            grbxHealthStatus.ResumeLayout(false);
            grbxHealthStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbxHealthStatus;
        private RadioButton rdbSick;
        private RadioButton rdbHealthy;
        private Label lblHealthStatus;
        private TextBox txtVetName;
        private Label lblVetName;
        private Button btnConfirm;
    }
}