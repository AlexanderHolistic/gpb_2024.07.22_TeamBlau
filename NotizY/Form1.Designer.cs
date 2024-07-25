using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_loeschen = new Button();
            btn_info = new Button();
            btn_hinzufuegen = new Button();
            contentPanel = new Panel();
            inhaltTextBox = new TextBox();
            ueberschriftTextBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Sidebar = new FlowLayoutPanel();
            listBox1 = new ListBox();
            contentPanel.SuspendLayout();
            panel1.SuspendLayout();
            Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_loeschen
            // 
            btn_loeschen.BackgroundImage = (Image)resources.GetObject("btn_loeschen.BackgroundImage");
            btn_loeschen.BackgroundImageLayout = ImageLayout.Stretch;
            btn_loeschen.Location = new Point(759, 27);
            btn_loeschen.Name = "btn_loeschen";
            btn_loeschen.Size = new Size(29, 29);
            btn_loeschen.TabIndex = 0;
            btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            btn_info.BackgroundImage = (Image)resources.GetObject("btn_info.BackgroundImage");
            btn_info.BackgroundImageLayout = ImageLayout.Stretch;
            btn_info.Location = new Point(725, 27);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(28, 29);
            btn_info.TabIndex = 1;
            btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_hinzufuegen
            // 
            btn_hinzufuegen.BackgroundImage = (Image)resources.GetObject("btn_hinzufuegen.BackgroundImage");
            btn_hinzufuegen.BackgroundImageLayout = ImageLayout.Stretch;
            btn_hinzufuegen.Location = new Point(691, 27);
            btn_hinzufuegen.Name = "btn_hinzufuegen";
            btn_hinzufuegen.Size = new Size(28, 29);
            btn_hinzufuegen.TabIndex = 3;
            btn_hinzufuegen.UseVisualStyleBackColor = true;
            btn_hinzufuegen.Click += btn_hinzufuegen_Click;
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
            inhaltTextBox.TextChanged += inhaltTextBox_TextChanged;
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
            ueberschriftTextBox.TextChanged += ueberschriftTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 6);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Notizen";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 44);
            panel2.TabIndex = 2;
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.DimGray;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(listBox1);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(3, 64);
            Sidebar.MaximumSize = new Size(200, 450);
            Sidebar.MinimumSize = new Size(47, 450);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(200, 450);
            Sidebar.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 274);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_hinzufuegen);
            Controls.Add(btn_info);
            Controls.Add(Sidebar);
            Controls.Add(btn_loeschen);
            Controls.Add(contentPanel);
            Name = "Form1";
            Text = "Form1";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_loeschen;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel Sidebar;
        private Button btn_info;
        private Button btn_hinzufuegen;
        private Panel contentPanel;
        private TextBox ueberschriftTextBox;
        private TextBox inhaltTextBox;
        private RoundedTextBox roundedTextBox = new RoundedTextBox
        {
            Location = new Point(20, 20),
            Width = 200,
            Height = 30,
            BorderRadius = 15,
            BackColor = Color.White,
            ForeColor = Color.Black
        };
        private ListBox listBox1;


    }
}
