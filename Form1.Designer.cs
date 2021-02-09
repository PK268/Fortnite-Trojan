
namespace funni
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
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterAmt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Title.Location = new System.Drawing.Point(95, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(633, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "FORTNITE VBUCS GENERATOR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 1;
            // 
            // enterAmt
            // 
            this.enterAmt.AutoSize = true;
            this.enterAmt.Location = new System.Drawing.Point(317, 231);
            this.enterAmt.Name = "enterAmt";
            this.enterAmt.Size = new System.Drawing.Size(151, 17);
            this.enterAmt.TabIndex = 2;
            this.enterAmt.Text = "Enter Desired Amount:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(140, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 148);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(179, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "       ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "V1.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterAmt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "FVG V1.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label enterAmt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

