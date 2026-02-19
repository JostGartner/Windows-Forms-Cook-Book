using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace E_Cookbook;

public partial class Application : Form
{
    private List<Recipe>? recipes;
    private Color _accentColor = Color.Lime;

    private Button? closeButton;
    private Button? maximizeButton;
    private Button? minimizeButton;

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;

    public Application()
    {
        InitializeComponent();

        this.DoubleBuffered = true;
    }

    private void Application_Load(object sender, EventArgs e)
    {
        //this.FormBorderStyle = FormBorderStyle.None;

        panelRecipe.Padding = new Padding(2);
        panelBar.Padding = new Padding(2);

        ButtonStyling();

        Label title = new Label();
        title.Text = "Kuharska Knjiga v-1.0";
        title.ForeColor = Color.White;
        title.Font = new Font("Consolas", 12);
        title.AutoSize = true;
        title.Location = new Point(20, 20);

        panelBar.Controls.Add(title);

        panelBar.MouseDown += (s, e) =>
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        };

        closeButton = CreateButton("🗙︎");
        closeButton.ForeColor = _accentColor;
        closeButton.Location = new Point(panelBar.Width - closeButton.Width - 25, 15);
        closeButton.Click += (s, e) => this.Close();

        panelBar.Controls.Add(closeButton);

        maximizeButton = CreateButton("🗖");
        maximizeButton.ForeColor = _accentColor;
        maximizeButton.Location = new Point(closeButton.Left - maximizeButton.Width - 5, 15);

        maximizeButton.Click += (s, e) =>
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizeButton.Text = "🗗︎";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizeButton.Text = "🗖";
            }
        };

        panelBar.Controls.Add(maximizeButton);

        minimizeButton = CreateButton("🗕");
        minimizeButton.ForeColor = _accentColor;
        minimizeButton.Location = new Point(maximizeButton.Left - minimizeButton.Width - 5, 15);
        minimizeButton.Click += (s, e) =>
        {
            this.WindowState = FormWindowState.Minimized;
        };

        panelBar.Controls.Add(minimizeButton);

        recipes = LoadFromJson();

        if (recipes.Count > 0)
        {
            LoadRecipe(recipes[0]);
        }

        LoadToGrid();
        dataGrid.Parent!.Paint += DataGridPanel_Paint!;
    }

    private async void LoadRecipe(Recipe recipe)
    {
        panelRecipe.SuspendLayout();

        panelRecipe.Controls.Clear();

        UserControlRecipe viewer = new UserControlRecipe();
        viewer.Dock = DockStyle.Fill;
        viewer.SetAccentColor(_accentColor);
        viewer.LoadRecipe(recipe);

        panelRecipe.Controls.Add(viewer);

        panelRecipe.ResumeLayout();

        viewer.Visible = false;

        await Task.Delay(0);

        viewer.Visible = true;
    }

    private List<Recipe> LoadFromJson()
    {
        string path = "recipes.json";

        if (!File.Exists(path)) return new List<Recipe>();

        string json = File.ReadAllText(path, Encoding.UTF8);

        return JsonSerializer.Deserialize<List<Recipe>>(json)!;
    }
    private void LoadToGrid()
    {
        dataGrid.SelectionChanged -= dataGrid_SelectionChanged!;

        dataGrid.DataSource = null;
        dataGrid.DataSource = recipes;

        dataGrid.Columns["Description"]!.Visible = false;
        dataGrid.Columns["ImagePath"]!.Visible = false;

        ApplyGridStyle();

        dataGrid.SelectionChanged += dataGrid_SelectionChanged!;
    }

    private void ApplyGridStyle()
    {
        dataGrid.DefaultCellStyle.Font = new Font("Consolas", 12);
        dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGrid.RowTemplate.Height = 50;
        dataGrid.BorderStyle = BorderStyle.None;
        dataGrid.EnableHeadersVisualStyles = false;

        dataGrid.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
        dataGrid.DefaultCellStyle.ForeColor = Color.White;

        dataGrid.DefaultCellStyle.SelectionBackColor = Color.White;
        dataGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(18, 18, 18);
    }

    private void dataGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGrid.CurrentRow != null &&
        dataGrid.CurrentRow.DataBoundItem != null &&
        dataGrid.CurrentRow.DataBoundItem is Recipe selectedRecipe)
        {
            LoadRecipe(selectedRecipe);
        }
    }

    private Button CreateButton(string text)
    {
        Button btn = new Button();
        btn.Text = text.Trim();
        btn.Font = new Font("Consolas", 14, FontStyle.Bold);
        btn.TextAlign = ContentAlignment.MiddleCenter;
        btn.ForeColor = Color.White;
        btn.BackColor = Color.FromArgb(18, 18, 18);
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 2;
        btn.Size = new Size(35, 35);
        btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn.TabStop = false;

        btn.MouseEnter += (s, e) =>
        {
            btn.BackColor = Color.FromArgb(70, 70, 70);
        };

        btn.MouseLeave += (s, e) =>
        {
            btn.BackColor = Color.FromArgb(18, 18, 18);
        };

        return btn;
    }

    private void ButtonStyling()
    {
        btnAdd.MouseEnter += (s, e) =>
        {
            btnAdd.BackColor = Color.FromArgb(70, 70, 70);
        };

        btnAdd.MouseLeave += (s, e) =>
        {
            btnAdd.BackColor = Color.FromArgb(18, 18, 18);
        };

        btnEdit.MouseEnter += (s, e) =>
        {
            btnEdit.BackColor = Color.FromArgb(70, 70, 70);
        };

        btnEdit.MouseLeave += (s, e) =>
        {
            btnEdit.BackColor = Color.FromArgb(18, 18, 18);
        };

        btnDelete.MouseEnter += (s, e) =>
        {
            btnDelete.BackColor = Color.FromArgb(70, 70, 70);
        };

        btnDelete.MouseLeave += (s, e) =>
        {
            btnDelete.BackColor = Color.FromArgb(18, 18, 18);
        };
    }

    private void dataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
    {
        dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);
    }

    private void dataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
    {
        dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
    }

    private void panelRecipe_Paint(object sender, PaintEventArgs e)
    {
        int thickness = 2;
        using (Pen pen = new Pen(_accentColor, thickness))
        {
            int offset = thickness / 2;
            e.Graphics.DrawRectangle(pen,
                offset,
                offset,
                panelRecipe.Width - thickness,
                panelRecipe.Height - thickness);
        }
    }
    private void SetAccentColor(Color color)
    {
        _accentColor = color;

        btnAdd.FlatAppearance.BorderColor = color;
        btnEdit.FlatAppearance.BorderColor = color;
        btnDelete.FlatAppearance.BorderColor = color;
        panelRecipe.Invalidate();
        dataGrid.Parent?.Invalidate();

        if (closeButton != null) closeButton.ForeColor = color;
        if (maximizeButton != null) maximizeButton.ForeColor = color;
        if (minimizeButton != null) minimizeButton.ForeColor = color;

        if (panelRecipe.Controls.Count > 0)
        {
            if (panelRecipe.Controls[0] is UserControlRecipe viewer)
            {
                viewer.SetAccentColor(color);
            }
            else if (panelRecipe.Controls[0] is UserControlEditor editor)
            {
                editor.SetAccentColor(color);
            }
        }
    }

    private void btnLime_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Lime);
    }

    private void btnYellow_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Yellow);
    }

    private void btnOrange_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Orange);
    }

    private void btnRed_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Red);
    }

    private void btnPink_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Fuchsia);
    }

    private void btnBlue_Click(object sender, EventArgs e)
    {
        SetAccentColor(Color.Blue);
    }

    private void DataGridPanel_Paint(object sender, PaintEventArgs e)
    {
        int thickness = 2;
        using (Pen pen = new Pen(_accentColor, thickness))
        {
            int offset = thickness / 2;
            Rectangle rect = new Rectangle(
                dataGrid.Left - offset,
                dataGrid.Top - offset,
                dataGrid.Width + thickness - 1,
                dataGrid.Height + thickness - 1
            );
            e.Graphics.DrawRectangle(pen, rect);
        }
    }

    private void ShowRecipeEditor(Recipe? recipeToEdit)
    {
        panelRecipe.Controls.Clear();

        UserControlEditor editor = new UserControlEditor();
        editor.Dock = DockStyle.Fill;
        editor.SetAccentColor(_accentColor);

        if (recipeToEdit != null)
        {
            editor.LoadRecipe(recipeToEdit);
        }

        editor.OnSave += (recipe) =>
        {
            if (recipeToEdit == null)
            {
                recipes!.Add(recipe);
            }
            else
            {
                int index = recipes!.IndexOf(recipeToEdit);
                recipes[index] = recipe;
            }

            SaveToJson();
            LoadToGrid();
            LoadRecipe(recipe);
        };

        editor.OnCancel += () =>
        {
            if (recipes!.Count > 0)
            {
                LoadRecipe(recipes[0]);
            }
        };

        panelRecipe.Controls.Add(editor);
    }

    private void SaveToJson()
    {
        string path = "recipes.json";
        string json = JsonSerializer.Serialize(recipes, new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        });
        File.WriteAllText(path, json, Encoding.UTF8);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        ShowRecipeEditor(null);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dataGrid.CurrentRow?.DataBoundItem is Recipe selected)
        {
            ShowRecipeEditor(selected);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGrid.CurrentRow?.DataBoundItem is Recipe selected)
        {
            var result = MessageBox.Show(
                $"Ali res želiš izbrisati recept '{selected.Name}'?",
                "Potrdi brisanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                recipes!.Remove(selected);
                SaveToJson();
                LoadToGrid();

                if (recipes.Count > 0)
                {
                    LoadRecipe(recipes[0]);
                }
                else
                {
                    panelRecipe.Controls.Clear();
                }
            }
        }
    }
}
