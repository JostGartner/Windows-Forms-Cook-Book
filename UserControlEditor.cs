using System.Windows.Forms;

namespace E_Cookbook;

public partial class UserControlEditor : UserControl
{
    private Color _accentColor = Color.Lime;
    private string? _imagePath;

    public event Action<Recipe>? OnSave;
    public event Action? OnCancel;

    public UserControlEditor()
    {
        InitializeComponent();
    }

    public void SetAccentColor(Color color)
    {
        _accentColor = color;

        textBoxTitleEdit.ForeColor = color;
        labelIngredientsEdit.ForeColor = color;
        labelInstructionsEdit.ForeColor = color;

        btnSave.FlatAppearance.BorderColor = color;
        btnCancel.FlatAppearance.BorderColor = color;
        btnChooseImage.FlatAppearance.BorderColor = color;
    }

    public void LoadRecipe(Recipe recipe)
    {
        textBoxTitleEdit.Text = recipe.Name;
        textBoxDescriptionEdit.Text = recipe.Description;
        _imagePath = recipe.ImagePath;

        listBoxIngredientsEdit.Items.Clear();
        foreach (var ingredient in recipe.Ingredients!)
        {
            listBoxIngredientsEdit.Items.Add(ingredient);
        }

        listBoxInstructionsEdit.Items.Clear();
        foreach (var instruction in recipe.Instructions!)
        {
            listBoxInstructionsEdit.Items.Add(instruction);
        }

        if (!string.IsNullOrEmpty(_imagePath) && File.Exists(_imagePath))
        {
            pictureBoxEdit.Image?.Dispose();
            using (var img = Image.FromFile(_imagePath))
            {
                pictureBoxEdit.Image = UserControlRecipe.ResizeAndCrop(img, pictureBoxEdit.Width, pictureBoxEdit.Height);
            }
            pictureBoxEdit.SizeMode = PictureBoxSizeMode.Normal;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxTitleEdit.Text))
        {
            MessageBox.Show("Prosim vnesi ime recepta.", "Napaka",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        List<string> ingredients = new List<string>();
        foreach (var item in listBoxIngredientsEdit.Items)
        {
            ingredients.Add(item.ToString()!);
        }

        List<string> instructions = new List<string>();
        foreach (var item in listBoxInstructionsEdit.Items)
        {
            instructions.Add(item.ToString()!);
        }

        Recipe newRecipe = new Recipe(
            textBoxTitleEdit.Text,
            textBoxDescriptionEdit.Text,
            _imagePath!,
            ingredients,
            instructions
        );

        OnSave?.Invoke(newRecipe);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        OnCancel?.Invoke();
    }

    private void btnChooseImage_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog dialog = new OpenFileDialog())
        {
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Title = "Izberi sliko recepta";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _imagePath = dialog.FileName;
                pictureBoxEdit.Image?.Dispose();
                using (var img = Image.FromFile(_imagePath))
                {
                    pictureBoxEdit.Image = UserControlRecipe.ResizeAndCrop(img, pictureBoxEdit.Width, pictureBoxEdit.Height);
                }
                pictureBoxEdit.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }

    private void btnAddIngredient_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBoxAddIngredient.Text))
        {
            listBoxIngredientsEdit.Items.Add(textBoxAddIngredient.Text);
            textBoxAddIngredient.Clear();
            textBoxAddIngredient.Focus();
        }
    }

    private void btnRemoveIngredient_Click(object sender, EventArgs e)
    {
        if (listBoxIngredientsEdit.SelectedIndex >= 0)
        {
            listBoxIngredientsEdit.Items.RemoveAt(listBoxIngredientsEdit.SelectedIndex);
        }
    }

    private void listBoxIngredientsEdit_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        int index = listBoxIngredientsEdit.IndexFromPoint(e.Location);
        if (index != ListBox.NoMatches)
        {
            string currentText = listBoxIngredientsEdit.Items[index].ToString()!;
            string? newText = ShowInputDialog("Uredi sestavino", currentText);

            if (!string.IsNullOrWhiteSpace(newText))
            {
                listBoxIngredientsEdit.Items[index] = newText;
            }
        }
    }

    private string? ShowInputDialog(string title, string defaultValue)
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = title,
            StartPosition = FormStartPosition.CenterParent,
            BackColor = Color.FromArgb(18, 18, 18),
            MaximizeBox = false,
            MinimizeBox = false
        };

        TextBox textBox = new TextBox()
        {
            Left = 20,
            Top = 20,
            Width = 340,
            Text = defaultValue,
            Font = new Font("Consolas", 12),
            BackColor = Color.FromArgb(30, 30, 30),
            ForeColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle
        };

        Button btnOk = new Button()
        {
            Text = "Potrdi",
            Left = 200,
            Width = 80,
            Top = 60,
            DialogResult = DialogResult.OK,
            BackColor = Color.FromArgb(18, 18, 18),
            ForeColor = _accentColor,
            FlatStyle = FlatStyle.Flat
        };
        btnOk.FlatAppearance.BorderColor = _accentColor;

        Button btnCancel = new Button()
        {
            Text = "Prekliči",
            Left = 290,
            Width = 80,
            Top = 60,
            DialogResult = DialogResult.Cancel,
            BackColor = Color.FromArgb(18, 18, 18),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };

        prompt.Controls.Add(textBox);
        prompt.Controls.Add(btnOk);
        prompt.Controls.Add(btnCancel);
        prompt.AcceptButton = btnOk;
        prompt.CancelButton = btnCancel;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
    }

    private void btnAddInstruction_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBoxAddInstruction.Text))
        {
            listBoxInstructionsEdit.Items.Add(textBoxAddInstruction.Text);
            textBoxAddInstruction.Clear();
            textBoxAddInstruction.Focus();
        }
    }

    private void btnRemoveInstruction_Click(object sender, EventArgs e)
    {
        if (listBoxInstructionsEdit.SelectedIndex >= 0)
        {
            listBoxInstructionsEdit.Items.RemoveAt(listBoxInstructionsEdit.SelectedIndex);
        }
    }

    private void listBoxInstructionsEdit_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        int index = listBoxInstructionsEdit.IndexFromPoint(e.Location);
        if (index != ListBox.NoMatches)
        {
            string currentText = listBoxInstructionsEdit.Items[index].ToString()!;
            string? newText = ShowInputDialog("Uredi navodilo", currentText);
            if (!string.IsNullOrWhiteSpace(newText))
            {
                listBoxInstructionsEdit.Items[index] = newText;
            }
        }
    }

    private void textBoxTitleEdit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
        }
    }

    private void textBoxDescriptionEdit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
        }
    }

    private void textBoxAddIngredient_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
        }
    }

    private void textBoxAddInstruction_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
        }
    }

    private void pictureBoxEdit_Paint(object sender, PaintEventArgs e)
    {
        int thickness = 2;
        using (Pen pen = new Pen(_accentColor, thickness))
        {
            int offset = thickness / 2;
            e.Graphics.DrawRectangle(pen,
                offset,
                offset,
                pictureBoxEdit.Width - thickness,
                pictureBoxEdit.Height - thickness);
        }
    }
}
