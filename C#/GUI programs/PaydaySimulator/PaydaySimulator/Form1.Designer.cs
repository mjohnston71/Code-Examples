namespace PaydaySimulator
{
    partial class PaydayWindow
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
            this.components = new System.ComponentModel.Container();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HourlyWageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalMadeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 226);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset);
            // 
            // HourlyWageTextBox
            // 
            this.HourlyWageTextBox.Location = new System.Drawing.Point(50, 6);
            this.HourlyWageTextBox.Name = "HourlyWageTextBox";
            this.HourlyWageTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourlyWageTextBox.TabIndex = 2;
            this.HourlyWageTextBox.Text = "7.25";
            this.HourlyWageTextBox.TextChanged += new System.EventHandler(this.Hourly_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hourly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progress to next penny:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Made:";
            // 
            // TotalMadeLabel
            // 
            this.TotalMadeLabel.AutoSize = true;
            this.TotalMadeLabel.Location = new System.Drawing.Point(83, 49);
            this.TotalMadeLabel.Name = "TotalMadeLabel";
            this.TotalMadeLabel.Size = new System.Drawing.Size(28, 13);
            this.TotalMadeLabel.TabIndex = 6;
            this.TotalMadeLabel.Text = "0.00";
            // 
            // PaydayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.TotalMadeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HourlyWageTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.progressBar1);
            this.Name = "PaydayWindow";
            this.Text = "Payday Simulator";
            this.Load += new System.EventHandler(this.LoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox HourlyWageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalMadeLabel;
        public System.Windows.Forms.Timer updateTimer;
    }
}

