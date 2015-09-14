namespace PrimalityTest
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
            this.inBox = new System.Windows.Forms.TextBox();
            this.kvalBox = new System.Windows.Forms.TextBox();
            this.solveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(59, 12);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(75, 20);
            this.inBox.TabIndex = 0;
            // 
            // kvalBox
            // 
            this.kvalBox.Location = new System.Drawing.Point(59, 51);
            this.kvalBox.Name = "kvalBox";
            this.kvalBox.Size = new System.Drawing.Size(54, 20);
            this.kvalBox.TabIndex = 1;
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(59, 88);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 3;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "K-Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(59, 221);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(156, 23);
            this.testBtn.TabIndex = 7;
            this.testBtn.Text = "Test Quite A Few Primes";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(59, 130);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(156, 68);
            this.outBox.TabIndex = 8;
            this.outBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 256);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.kvalBox);
            this.Controls.Add(this.inBox);
            this.Name = "Form1";
            this.Text = "Primality Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.TextBox kvalBox;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.RichTextBox outBox;
    }
}

