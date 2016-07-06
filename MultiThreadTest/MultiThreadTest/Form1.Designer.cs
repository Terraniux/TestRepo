namespace MultiThreadTest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.secondThreadLabel = new System.Windows.Forms.Label();
            this.runThreadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainThreadLabel = new System.Windows.Forms.Label();
            this.mainThreadButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Thread Activity:";
            // 
            // secondThreadLabel
            // 
            this.secondThreadLabel.AutoSize = true;
            this.secondThreadLabel.Location = new System.Drawing.Point(6, 95);
            this.secondThreadLabel.Name = "secondThreadLabel";
            this.secondThreadLabel.Size = new System.Drawing.Size(52, 13);
            this.secondThreadLabel.TabIndex = 1;
            this.secondThreadLabel.Text = "Waiting...";
            // 
            // runThreadButton
            // 
            this.runThreadButton.Location = new System.Drawing.Point(29, 45);
            this.runThreadButton.Name = "runThreadButton";
            this.runThreadButton.Size = new System.Drawing.Size(75, 23);
            this.runThreadButton.TabIndex = 2;
            this.runThreadButton.Text = "Run Thread";
            this.runThreadButton.UseVisualStyleBackColor = true;
            this.runThreadButton.Click += new System.EventHandler(this.runThreadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Main Thread Activity:";
            // 
            // mainThreadLabel
            // 
            this.mainThreadLabel.AutoSize = true;
            this.mainThreadLabel.Location = new System.Drawing.Point(6, 43);
            this.mainThreadLabel.Name = "mainThreadLabel";
            this.mainThreadLabel.Size = new System.Drawing.Size(52, 13);
            this.mainThreadLabel.TabIndex = 4;
            this.mainThreadLabel.Text = "Waiting...";
            // 
            // mainThreadButton
            // 
            this.mainThreadButton.Location = new System.Drawing.Point(29, 16);
            this.mainThreadButton.Name = "mainThreadButton";
            this.mainThreadButton.Size = new System.Drawing.Size(75, 23);
            this.mainThreadButton.TabIndex = 6;
            this.mainThreadButton.Text = "Update Sum";
            this.mainThreadButton.UseVisualStyleBackColor = true;
            this.mainThreadButton.Click += new System.EventHandler(this.mainThreadButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(330, 28);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(71, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Time Passed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sum can only be updated when\r\nremaining seconds in second thread = 1,\r\nand second" +
    "s passed is evenly divisible by 10.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mainThreadButton);
            this.groupBox1.Controls.Add(this.runThreadButton);
            this.groupBox1.Location = new System.Drawing.Point(330, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.secondThreadLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.mainThreadLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 129);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 239);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label secondThreadLabel;
        private System.Windows.Forms.Button runThreadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainThreadLabel;
        private System.Windows.Forms.Button mainThreadButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

