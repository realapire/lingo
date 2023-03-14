namespace Lingo
{
    partial class mainForm
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
            this.mainButton = new System.Windows.Forms.Button();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainButton.Location = new System.Drawing.Point(0, 256);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(614, 55);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "START";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTxtBox.Location = new System.Drawing.Point(0, 0);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(614, 29);
            this.inputTxtBox.TabIndex = 1;
            this.inputTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTxtBox_KeyDown);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 29);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(614, 227);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 311);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.mainButton);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Lingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
    }
}

