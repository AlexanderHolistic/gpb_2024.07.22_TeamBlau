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
<<<<<<< .merge_file_vjSLkM
            btn_loeschen = new Button();
            btn_info = new Button();
            btn_editieren = new Button();
            btn_hinzufuegen = new Button();
            btnSuchen = new Button();
            SuspendLayout();
            // 
            // btn_loeschen
            // 
            btn_loeschen.Location = new Point(667, 146);
            btn_loeschen.Name = "btn_loeschen";
            btn_loeschen.Size = new Size(75, 23);
            btn_loeschen.TabIndex = 0;
            btn_loeschen.Text = "Löschen";
            btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(574, 146);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(75, 23);
            btn_info.TabIndex = 1;
            btn_info.Text = "info";
            btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_editieren
            // 
            btn_editieren.Location = new Point(393, 146);
            btn_editieren.Name = "btn_editieren";
            btn_editieren.Size = new Size(75, 23);
            btn_editieren.TabIndex = 2;
            btn_editieren.Text = "Editieren";
            btn_editieren.UseVisualStyleBackColor = true;
            // 
            // btn_hinzufuegen
            // 
            btn_hinzufuegen.Location = new Point(485, 146);
            btn_hinzufuegen.Name = "btn_hinzufuegen";
            btn_hinzufuegen.Size = new Size(83, 23);
            btn_hinzufuegen.TabIndex = 3;
            btn_hinzufuegen.Text = "Hinzufügen";
            btn_hinzufuegen.UseVisualStyleBackColor = true;
            // 
            // btnSuchen
            // 
            btnSuchen.Location = new Point(289, 146);
            btnSuchen.Name = "btnSuchen";
            btnSuchen.Size = new Size(75, 23);
            btnSuchen.TabIndex = 4;
            btnSuchen.Text = "Suchen";
            btnSuchen.UseVisualStyleBackColor = true;
=======
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
>>>>>>> .merge_file_apwkUf
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< .merge_file_vjSLkM
            Controls.Add(btnSuchen);
            Controls.Add(btn_hinzufuegen);
            Controls.Add(btn_editieren);
            Controls.Add(btn_info);
            Controls.Add(btn_loeschen);
            Name = "Form1";
            Text = "Form1";
=======
            Controls.Add(contentPanel);
            Name = "Form1";
            Text = "Form1";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
>>>>>>> .merge_file_apwkUf
            ResumeLayout(false);
        }

        #endregion

<<<<<<< .merge_file_vjSLkM
        private Button btn_loeschen;
        private Button btn_info;
        private Button btn_editieren;
        private Button btn_hinzufuegen;
        private Button btnSuchen;
=======
        private Panel contentPanel;
        private TextBox ueberschriftTextBox;
        private TextBox inhaltTextBox;
>>>>>>> .merge_file_apwkUf
    }
}
