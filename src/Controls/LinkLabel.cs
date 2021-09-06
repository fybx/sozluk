using System;

namespace sozluk.Controls
{
    public enum LinkLabelType { WikipediaArticle = 0, Article = 1, WordReference = 2 };

    class LinkLabel : System.Windows.Forms.Label
    {

        public override System.Drawing.Font Font { get; set; }

        public System.Drawing.Color HoverColor { get; set; }

        public System.Drawing.Color InactiveColor { get; set; }

        public override string Text { get; set; }

        public LinkLabelType LabelType;

        public string Link { get; set; }

        public float Indent { get; set; }

        public LinkLabel(string theme, string langCode, string text, string link, LinkLabelType labelType, float indent = 0)
        {
            InactiveColor = theme is "black" ? System.Drawing.Color.White : System.Drawing.Color.Black;
            HoverColor = System.Drawing.Color.Cyan;
            Font = new("Arial", 9f);
            LabelType = labelType;
            Text = text;
            Link = link;
            Indent = indent;

            Size = CreateGraphics().MeasureString(Text, Font).ToSize() + new System.Drawing.Size((int)Indent, 0);
            ForeColor = InactiveColor;
            BackColor = System.Drawing.Color.Transparent;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            ForeColor = HoverColor;
            Invalidate();
        }

        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e) => base.OnMouseClick(e);

        protected override void OnMouseLeave(EventArgs e)
        {
            ForeColor = InactiveColor;
            Invalidate();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Brush brush = new System.Drawing.SolidBrush(ForeColor);
            e.Graphics.DrawString(Text, Font, brush, 0f + Indent, 0f);
        }
    }
}
