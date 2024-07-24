namespace NotizY
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
            contentPanel = new Panel();
            inhaltTextBox = new TextBox();
            ueberschriftTextBox = new TextBox();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(inhaltTextBox);
            contentPanel.Controls.Add(ueberschriftTextBox);
            contentPanel.Location = new Point(225, 67);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(563, 371);
            contentPanel.TabIndex = 0;
            // 
            // inhaltTextBox
            // 
            inhaltTextBox.BorderStyle = BorderStyle.None;
            inhaltTextBox.Font = new Font("Segoe UI", 12F);
            inhaltTextBox.Location = new Point(3, 77);
            inhaltTextBox.Multiline = true;
            inhaltTextBox.Name = "inhaltTextBox";
            inhaltTextBox.ScrollBars = ScrollBars.Vertical;
            inhaltTextBox.Size = new Size(557, 291);
            inhaltTextBox.TabIndex = 1;
            // 
            // ueberschriftTextBox
            // 
            ueberschriftTextBox.BorderStyle = BorderStyle.None;
            ueberschriftTextBox.Font = new Font("Segoe UI", 18F);
            ueberschriftTextBox.Location = new Point(3, 3);
            ueberschriftTextBox.MaxLength = 64;
            ueberschriftTextBox.Multiline = true;
            ueberschriftTextBox.Name = "ueberschriftTextBox";
            ueberschriftTextBox.Size = new Size(557, 71);
            ueberschriftTextBox.TabIndex = 0;
            ueberschriftTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPanel);
            Name = "Form1";
            Text = "Form1";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private TextBox ueberschriftTextBox;
        private TextBox inhaltTextBox;
    }
}
