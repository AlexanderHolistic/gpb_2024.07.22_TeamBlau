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
            components = new System.ComponentModel.Container();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            manuButton = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button4 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btn_loeschen = new Button();
            btn_info = new Button();
            btn_editieren = new Button();
            btn_hinzufuegen = new Button();
            btnSuchen = new Button();
            contentPanel = new Panel();
            inhaltTextBox = new TextBox();
            ueberschriftTextBox = new TextBox();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manuButton).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = SystemColors.ActiveCaption;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(panel6);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(200, 450);
            Sidebar.MinimumSize = new Size(42, 450);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(200, 450);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(manuButton);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // manuButton
            // 
            manuButton.Cursor = Cursors.Hand;
            manuButton.Location = new Point(3, 18);
            manuButton.Name = "manuButton";
            manuButton.Size = new Size(37, 50);
            manuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            manuButton.TabIndex = 1;
            manuButton.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 44);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 52);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-12, -13);
            button1.Name = "button1";
            button1.Size = new Size(218, 79);
            button1.TabIndex = 1;
            button1.Text = "          Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Location = new Point(3, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 52);
            panel4.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-12, -13);
            button2.Name = "button2";
            button2.Size = new Size(218, 79);
            button2.TabIndex = 1;
            button2.Text = "          Settings";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(3, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 52);
            panel5.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-12, -13);
            button3.Name = "button3";
            button3.Size = new Size(218, 79);
            button3.TabIndex = 1;
            button3.Text = "          Help";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 283);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 52);
            panel6.TabIndex = 5;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-12, -13);
            button4.Name = "button4";
            button4.Size = new Size(218, 79);
            button4.TabIndex = 1;
            button4.Text = "          About";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            // 
            // btn_loeschen
            // 
            btn_loeschen.Location = new Point(654, 27);
            btn_loeschen.Name = "btn_loeschen";
            btn_loeschen.Size = new Size(75, 23);
            btn_loeschen.TabIndex = 0;
            btn_loeschen.Text = "Löschen";
            btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(561, 27);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(75, 23);
            btn_info.TabIndex = 1;
            btn_info.Text = "info";
            btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_editieren
            // 
            btn_editieren.Location = new Point(380, 27);
            btn_editieren.Name = "btn_editieren";
            btn_editieren.Size = new Size(75, 23);
            btn_editieren.TabIndex = 2;
            btn_editieren.Text = "Editieren";
            btn_editieren.UseVisualStyleBackColor = true;
            // 
            // btn_hinzufuegen
            // 
            btn_hinzufuegen.Location = new Point(472, 27);
            btn_hinzufuegen.Name = "btn_hinzufuegen";
            btn_hinzufuegen.Size = new Size(83, 23);
            btn_hinzufuegen.TabIndex = 3;
            btn_hinzufuegen.Text = "Hinzufügen";
            btn_hinzufuegen.UseVisualStyleBackColor = true;
            // 
            // btnSuchen
            // 
            btnSuchen.Location = new Point(276, 27);
            btnSuchen.Name = "btnSuchen";
            btnSuchen.Size = new Size(75, 23);
            btnSuchen.TabIndex = 4;
            btnSuchen.Text = "Suchen";
            btnSuchen.UseVisualStyleBackColor = true;
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
            Controls.Add(btnSuchen);
            Controls.Add(btn_hinzufuegen);
            Controls.Add(btn_editieren);
            Controls.Add(btn_info);
            Controls.Add(btn_loeschen);
            Controls.Add(contentPanel);
            Controls.Add(Sidebar);
            Name = "Form1";
            Text = "Form1";
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manuButton).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_loeschen;
        private Button btn_info;
        private Button btn_editieren;
        private Button btn_hinzufuegen;
        private Button btnSuchen;
        private Panel contentPanel;
        private TextBox ueberschriftTextBox;
        private TextBox inhaltTextBox;

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private Panel panel5;
        private Button button3;
        private Panel panel6;
        private Button button4;
        private Label label1;
        private PictureBox manuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private RoundedTextBox roundedTextBox = new RoundedTextBox
        {
            Location = new Point(20, 20),
            Width = 200,
            Height = 30,
            BorderRadius = 15,
            BackColor = Color.White,
            ForeColor = Color.Black
        };
    }
}
