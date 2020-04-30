namespace Unit_Conversion
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
            this.inputlabel = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inchToCmButton = new System.Windows.Forms.Button();
            this.CmToInchButton = new System.Windows.Forms.Button();
            this.FootToCmButton = new System.Windows.Forms.Button();
            this.CmToFootButton = new System.Windows.Forms.Button();
            this.YardToCmButton = new System.Windows.Forms.Button();
            this.CmToYardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputlabel
            // 
            this.inputlabel.AutoSize = true;
            this.inputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlabel.Location = new System.Drawing.Point(24, 96);
            this.inputlabel.Name = "inputlabel";
            this.inputlabel.Size = new System.Drawing.Size(49, 22);
            this.inputlabel.TabIndex = 0;
            this.inputlabel.Text = "Input";
            this.inputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.Location = new System.Drawing.Point(475, 90);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(64, 22);
            this.outputlabel.TabIndex = 5;
            this.outputlabel.Text = "Output";
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(175, 90);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(264, 28);
            this.inputTextBox.TabIndex = 6;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(635, 90);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(266, 28);
            this.outputTextBox.TabIndex = 7;
            // 
            // inchToCmButton
            // 
            this.inchToCmButton.AutoSize = true;
            this.inchToCmButton.Location = new System.Drawing.Point(28, 213);
            this.inchToCmButton.Name = "inchToCmButton";
            this.inchToCmButton.Size = new System.Drawing.Size(113, 35);
            this.inchToCmButton.TabIndex = 8;
            this.inchToCmButton.Text = "Inch to Cm";
            this.inchToCmButton.UseVisualStyleBackColor = true;
            this.inchToCmButton.Click += new System.EventHandler(this.inchToCmButton_Click);
            // 
            // CmToInchButton
            // 
            this.CmToInchButton.AutoSize = true;
            this.CmToInchButton.Location = new System.Drawing.Point(175, 213);
            this.CmToInchButton.Name = "CmToInchButton";
            this.CmToInchButton.Size = new System.Drawing.Size(113, 35);
            this.CmToInchButton.TabIndex = 9;
            this.CmToInchButton.Text = "Cm to Inch";
            this.CmToInchButton.UseVisualStyleBackColor = true;
            this.CmToInchButton.Click += new System.EventHandler(this.CmToInchButton_Click);
            // 
            // FootToCmButton
            // 
            this.FootToCmButton.AutoSize = true;
            this.FootToCmButton.Location = new System.Drawing.Point(326, 213);
            this.FootToCmButton.Name = "FootToCmButton";
            this.FootToCmButton.Size = new System.Drawing.Size(113, 35);
            this.FootToCmButton.TabIndex = 10;
            this.FootToCmButton.Text = "Foot to Cm";
            this.FootToCmButton.UseVisualStyleBackColor = true;
            this.FootToCmButton.Click += new System.EventHandler(this.FootToCmButton_Click);
            // 
            // CmToFootButton
            // 
            this.CmToFootButton.AutoSize = true;
            this.CmToFootButton.Location = new System.Drawing.Point(479, 213);
            this.CmToFootButton.Name = "CmToFootButton";
            this.CmToFootButton.Size = new System.Drawing.Size(113, 35);
            this.CmToFootButton.TabIndex = 11;
            this.CmToFootButton.Text = "Cm to Foot";
            this.CmToFootButton.UseVisualStyleBackColor = true;
            this.CmToFootButton.Click += new System.EventHandler(this.CmToFootButton_Click);
            // 
            // YardToCmButton
            // 
            this.YardToCmButton.AutoSize = true;
            this.YardToCmButton.Location = new System.Drawing.Point(635, 213);
            this.YardToCmButton.Name = "YardToCmButton";
            this.YardToCmButton.Size = new System.Drawing.Size(113, 35);
            this.YardToCmButton.TabIndex = 12;
            this.YardToCmButton.Text = "Yard to Cm";
            this.YardToCmButton.UseVisualStyleBackColor = true;
            this.YardToCmButton.Click += new System.EventHandler(this.YardToCmButton_Click);
            // 
            // CmToYardButton
            // 
            this.CmToYardButton.AutoSize = true;
            this.CmToYardButton.Location = new System.Drawing.Point(788, 213);
            this.CmToYardButton.Name = "CmToYardButton";
            this.CmToYardButton.Size = new System.Drawing.Size(113, 35);
            this.CmToYardButton.TabIndex = 13;
            this.CmToYardButton.Text = "Cm to Yard";
            this.CmToYardButton.UseVisualStyleBackColor = true;
            this.CmToYardButton.Click += new System.EventHandler(this.CmToYardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 278);
            this.Controls.Add(this.CmToYardButton);
            this.Controls.Add(this.YardToCmButton);
            this.Controls.Add(this.CmToFootButton);
            this.Controls.Add(this.FootToCmButton);
            this.Controls.Add(this.CmToInchButton);
            this.Controls.Add(this.inchToCmButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.inputlabel);
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputlabel;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button inchToCmButton;
        private System.Windows.Forms.Button CmToInchButton;
        private System.Windows.Forms.Button FootToCmButton;
        private System.Windows.Forms.Button CmToFootButton;
        private System.Windows.Forms.Button YardToCmButton;
        private System.Windows.Forms.Button CmToYardButton;
    }
}

