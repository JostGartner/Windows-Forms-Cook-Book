using System.Text.RegularExpressions;

namespace E_Cookbook;

public partial class UserControlRecipe : UserControl
{
    private Color _accentColor = Color.Lime;

    public UserControlRecipe()
    {
        InitializeComponent();
    }

    public void LoadRecipe(Recipe recipe)
    {
        labelTitle.Text = recipe.Name;
        labelImage.Text = string.IsNullOrEmpty(recipe.ImagePath) ? "No Image" : "\"" + Path.GetFileName(recipe.ImagePath) + "\"";
        richTextBoxDescription.Text = recipe.Description;

        richTextBoxDescription.SelectAll();
        richTextBoxDescription.SelectionAlignment = HorizontalAlignment.Center;
        richTextBoxDescription.DeselectAll();

        richTextBoxIngredients.Clear();

        for (int i = 0; i < recipe.Ingredients!.Count; i++)
        {
            richTextBoxIngredients.AppendText($"• {recipe.Ingredients[i]}\n");
        }

        richTextBoxInstructions.Clear();

        for (int i = 0; i < recipe.Instructions!.Count; i++)
        {
            richTextBoxInstructions.AppendText($"{i + 1}. {recipe.Instructions[i]}\n");
        }

        if (!string.IsNullOrEmpty(recipe.ImagePath) && File.Exists(recipe.ImagePath))
        {
            pictureBox.Image?.Dispose();
            using (var img = Image.FromFile(recipe.ImagePath))
            {
                pictureBox.Image = UserControlRecipe.ResizeAndCrop(img, pictureBox.Width, pictureBox.Height);
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }
        else
        {
            pictureBox.Image = null;
        }

        richTextBoxDescription.Cursor = Cursors.Arrow;
        richTextBoxIngredients.Cursor = Cursors.Arrow;
        richTextBoxInstructions.Cursor = Cursors.Arrow;
    }

    private void HighlightIngredients(Color color)
    {
        string text = richTextBoxIngredients.Text;
        int selectStart = richTextBoxIngredients.SelectionStart;

        richTextBoxIngredients.SelectAll();
        richTextBoxIngredients.SelectionColor = Color.White;

        Regex unitRegex = new Regex(@"\b\d+\s?(g|ml|kg|l|žlica|žlici|žlice)\b");
        foreach (Match match in unitRegex.Matches(text))
        {
            richTextBoxIngredients.Select(match.Index, match.Length);
            richTextBoxIngredients.SelectionColor = color;
        }

        Regex numberRegex = new Regex(@"\b\d+\b");
        foreach (Match match in numberRegex.Matches(text))
        {
            richTextBoxIngredients.Select(match.Index, match.Length);
            richTextBoxIngredients.SelectionColor = color;
        }

        richTextBoxIngredients.Select(selectStart, 0);
        richTextBoxIngredients.SelectionColor = Color.White;
    }

    private void HighlightInstructions(Color color)
    {
        string text = richTextBoxInstructions.Text;
        int selectStart = richTextBoxInstructions.SelectionStart;

        richTextBoxInstructions.SelectAll();
        richTextBoxInstructions.SelectionColor = Color.White;

        Regex regex = new Regex(@"\b\d+\.");
        foreach (Match match in regex.Matches(text))
        {
            richTextBoxInstructions.Select(match.Index, match.Length);
            richTextBoxInstructions.SelectionColor = color;
        }

        richTextBoxInstructions.Select(selectStart, 0);
        richTextBoxInstructions.SelectionColor = Color.White;
    }

    private void richTextBoxInstructions_TextChanged(object sender, EventArgs e)
    {
        HighlightInstructions(_accentColor);
    }

    private void richTextBoxIngredients_TextChanged(object sender, EventArgs e)
    {
        HighlightIngredients(_accentColor);
    }

    public static Image ResizeAndCrop(Image img, int width, int height)
    {
        float ratio = Math.Max((float)width / img.Width, (float)height / img.Height);
        int newWidth = (int)(img.Width * ratio);
        int newHeight = (int)(img.Height * ratio);

        Bitmap bmp = new Bitmap(width, height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, (width - newWidth) / 2, (height - newHeight) / 2, newWidth, newHeight);
        }
        return bmp;
    }

    private void richTextBoxIngredients_MouseDown(object sender, MouseEventArgs e)
    {
        richTextBoxDescription.Parent!.Focus();
    }

    private void richTextBoxDescription_MouseDown(object sender, MouseEventArgs e)
    {
        richTextBoxDescription.Parent!.Focus();
    }

    private void richTextBoxInstructions_MouseDown(object sender, MouseEventArgs e)
    {
        richTextBoxInstructions.Parent!.Focus();
    }

    private void pictureBox_Paint(object sender, PaintEventArgs e)
    {
        int thickness = 2;
        using (Pen pen = new Pen(_accentColor, thickness))
        {
            int offset = thickness / 2;
            e.Graphics.DrawRectangle(pen,
                offset,
                offset,
                pictureBox.Width - thickness,
                pictureBox.Height - thickness);
        }
    }

    public void SetAccentColor(Color color)
    {
        _accentColor = color;

        labelTitle.ForeColor = color;
        labelImage.ForeColor = color;
        labelIngredients.ForeColor = color;
        labelInstructions.ForeColor = color;

        HighlightIngredients(color);
        HighlightInstructions(color);

        pictureBox.Invalidate();
    }

    private void panelIngredients_Paint(object sender, PaintEventArgs e)
    {
        Panel panel = (Panel)sender;
        int thickness = 2;
        using (Pen pen = new Pen(_accentColor, thickness))
        {
            int offset = thickness / 2;
            e.Graphics.DrawRectangle(pen,
                offset,
                offset,
                panel.Width - thickness,
                panel.Height - thickness);
        }
    }
}
