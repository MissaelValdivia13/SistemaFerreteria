using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 20; 
    public Color BorderColor { get; set; } = Color.Black; 
    public int BorderThickness { get; set; } = 2; 

    public RoundedPanel()
    {
        this.DoubleBuffered = true; 
        this.BackColor = Color.FromArgb(100, Color.White); 
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        using (GraphicsPath path = GetRoundRectPath(ClientRectangle, BorderRadius))
        {
            Region = new Region(path);
            if (BorderThickness > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        using (Brush brush = new SolidBrush(this.BackColor))
        {
            g.FillPath(brush, GetRoundRectPath(ClientRectangle, BorderRadius));
        }
    }

    private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
    {
        float r2 = radius / 2f;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }
}
