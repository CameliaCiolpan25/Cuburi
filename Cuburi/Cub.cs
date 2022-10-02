using System;
using System.Drawing;

class Cub
{
    int x, y, l, dx, dy;
    Brush c1, c2, c3;
    String text;
    Pen pen;
    System.Drawing.Font f;
    SizeF ms;

    public Cub(int x, int y, int l, int dx, int dy, String text, Color c1, Color c2, Color c3)
    {
        this.x = x;
        this.y = y;
        this.l = l;
        this.dx = dx;
        this.dy = dy;
        this.c1 = new SolidBrush(c1);
        this.c2 = new SolidBrush(c2);
        this.c3 = new SolidBrush(c3);
        this.text = text;
        this.pen = new Pen(Color.Black, 1);
        this.f = new System.Drawing.Font("Times New Roman", 30, FontStyle.Bold);
    }

    public int X
    {
        get { return x; }
        set { this.x = value; }
    }
    public int Y
    {
        get { return y; }
        set { this.y = value; }
    }
    public int L
    {
        get { return l; }
        set { this.l = value; }
    }
    public int Dx
    {
        get { return dx; }
        set { this.dx = value; }
    }
    public int Dy
    {
        get { return dy; }
        set { this.dy = value; }
    }
    public String Text
    {
        get { return text; }
        set { this.text = value; }
    }
    public bool esteDeasupra(int x, int y)
    {
        if (x > this.x && x < this.x + l)
            if (y < this.y && y > this.y - l)
                return true;
        return false;
    }
    public void deseneaza(Graphics g)
    {
        ms = g.MeasureString(text, f);
        g.FillRectangle(c1, x, y - l, l, l);
        g.DrawRectangle(pen, x, y - l, l, l);
        g.DrawString(text, f, Brushes.White, x + (l - ms.Width) / 2, y - (l + ms.Height) / 2);
        Point[] P = { new Point(x + l, y - l), new Point(x + l, y), new Point(x + l + dx, y - dy), new Point(x + l + dx, y - dy - l) };
        g.FillPolygon(c2, P);
        g.DrawPolygon(pen, P);
        Point[] Q = { new Point(x, y - l), new Point(x + l, y - l), new Point(x + l + dx, y - dy - l), new Point(x + dx, y - l - dy) };
        g.FillPolygon(c3, Q);
        g.DrawPolygon(pen, Q);
    }
}