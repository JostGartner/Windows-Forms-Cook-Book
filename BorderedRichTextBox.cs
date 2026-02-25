namespace E_Cookbook;

public class BorderedRichTextBox : RichTextBox
{
    private Color _borderColor = Color.Lime;
    private int _borderThickness = 2;

    //public Color BorderColor
    //{
    //    get => _borderColor;
    //    set
    //    {
    //        _borderColor = value;
    //        Invalidate();
    //    }
    //}

    //public int BorderThickness
    //{
    //    get => _borderThickness;
    //    set
    //    {
    //        _borderThickness = value;
    //        Invalidate();
    //    }
    //}

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        const int WM_PAINT = 0x000F;
        const int WM_NCPAINT = 0x0085;

        if (m.Msg == WM_PAINT || m.Msg == WM_NCPAINT)
        {
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                using (Pen pen = new Pen(_borderColor, _borderThickness))
                {
                    g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }
}
