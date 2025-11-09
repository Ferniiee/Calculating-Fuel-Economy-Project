namespace Calculating_Fuel_Economy
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
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.carMPGLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(211, 12);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the number of miles driven:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the gallons of gas used:";
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(211, 50);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 3;
            // 
            // carMPGLabel
            // 
            this.carMPGLabel.AutoSize = true;
            this.carMPGLabel.Location = new System.Drawing.Point(121, 94);
            this.carMPGLabel.Name = "carMPGLabel";
            this.carMPGLabel.Size = new System.Drawing.Size(84, 13);
            this.carMPGLabel.TabIndex = 4;
            this.carMPGLabel.Text = "Your car\'s MPG:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpgLabel.Location = new System.Drawing.Point(211, 93);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(100, 23);
            this.mpgLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(61, 141);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 47);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 47);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 200);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.carMPGLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.milesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label carMPGLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

