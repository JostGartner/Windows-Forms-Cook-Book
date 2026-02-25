using System.ComponentModel;

namespace E_Cookbook;

public class BorderedRichTextBox : RichTextBox
{
    private Color _borderColor = Color.Lime;
    private int _borderThickness = 2;
    private Padding _textPadding = new Padding(5); // Default padding

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Lime")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(2)]
    public int BorderThickness
    {
        get => _borderThickness;
        set
        {
            _borderThickness = value;
            Invalidate();
        }
    }

    [Browsable(true)]
    [Category("Layout")]
    [DefaultValue(5)]
    public Padding TextPadding
    {
        get => _textPadding;
        set
        {
            _textPadding = value;
            UpdatePadding();
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        UpdatePadding();
    }

    private void UpdatePadding()
    {
        if (!IsHandleCreated) return;

        const int EM_SETMARGINS = 0xD3;
        const int EC_LEFTMARGIN = 0x1;
        const int EC_RIGHTMARGIN = 0x2;

        int leftRight = (_textPadding.Left & 0xFFFF) | (_textPadding.Right << 16);
        SendMessage(this.Handle, EM_SETMARGINS, EC_LEFTMARGIN | EC_RIGHTMARGIN, leftRight);

        this.SelectionIndent = _textPadding.Left;
        this.SelectionRightIndent = _textPadding.Right;
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

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
