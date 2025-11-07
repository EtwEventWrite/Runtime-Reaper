using System.Drawing;
using System.Windows.Forms;

namespace RR.Controls
{
    public class Line : Control
    {
        public enum Allignment { Horizontal, Vertical }

        public Allignment LineAllignment { get; set; }

        public Line()
        {
            this.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.LightGray)), new Point(5, 5),
                LineAllignment == Allignment.Horizontal ? new Point(500, 5) : new Point(5, 500));
        }
    }
}
