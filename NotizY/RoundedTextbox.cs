using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NotizY
{
    public class RoundedTextBox : Control
    {
        private TextBox baseTextBox;
        private int _radius = 15;

        public int BorderRadius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                this.Invalidate();
                AdjustTextBoxSize();
            }
        }

        public RoundedTextBox()
        {
            baseTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                ForeColor = Color.LightBlue
            };

            this.Controls.Add(baseTextBox);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(_radius / 2);
            this.Size = new Size(200, 30);
            this.Font = new Font("Segoe UI", 10);
            this.Resize += new EventHandler(RoundedTextBox_Resize);
            AdjustTextBoxSize();
        }

        private void AdjustTextBoxSize()
        {
            baseTextBox.Location = new Point(_radius / 2, _radius / 2);
            baseTextBox.Width = this.Width - _radius;
            baseTextBox.Height = this.Height - _radius;
        }

        private void RoundedTextBox_Resize(object sender, EventArgs e)
        {
            AdjustTextBoxSize();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(new Rectangle(0, 0, _radius, _radius), 180, 90);
                path.AddArc(new Rectangle(this.Width - _radius - 1, 0, _radius, _radius), 270, 90);
                path.AddArc(new Rectangle(this.Width - _radius - 1, this.Height - _radius - 1, _radius, _radius), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - _radius - 1, _radius, _radius), 90, 90);
                path.CloseAllFigures();

                e.Graphics.FillPath(new SolidBrush(Color.White), path);
                e.Graphics.DrawPath(Pens.Gray, path);
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            baseTextBox.Font = this.Font;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            //baseTextBox.BackColor = this.BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            baseTextBox.ForeColor = Color.Blue;  // Ensure the inner TextBox's ForeColor is always LightBlue
        }

        public override string Text
        {
            get { return baseTextBox.Text; }
            set { baseTextBox.Text = value; }
        }
    }
}
