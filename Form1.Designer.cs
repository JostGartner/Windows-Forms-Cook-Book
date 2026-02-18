namespace E_Cookbook
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBar = new Panel();
            panelRecipe = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGrid = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnYellow = new Button();
            btnBlue = new Button();
            btnPink = new Button();
            btnRed = new Button();
            btnOrange = new Button();
            btnLime = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            tableLayoutPanel1.SetColumnSpan(panelBar, 8);
            panelBar.Dock = DockStyle.Fill;
            panelBar.Location = new Point(0, 0);
            panelBar.Margin = new Padding(0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1584, 50);
            panelBar.TabIndex = 5;
            // 
            // panelRecipe
            // 
            tableLayoutPanel1.SetColumnSpan(panelRecipe, 2);
            panelRecipe.Dock = DockStyle.Fill;
            panelRecipe.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            panelRecipe.ForeColor = Color.Black;
            panelRecipe.Location = new Point(385, 55);
            panelRecipe.Margin = new Padding(5, 5, 25, 25);
            panelRecipe.Name = "panelRecipe";
            tableLayoutPanel1.SetRowSpan(panelRecipe, 4);
            panelRecipe.Size = new Size(1174, 904);
            panelRecipe.TabIndex = 4;
            panelRecipe.Paint += panelRecipe_Paint;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.SetColumnSpan(btnDelete, 2);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.Lime;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDelete.Location = new Point(265, 913);
            btnDelete.Margin = new Padding(5, 5, 5, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 46);
            btnDelete.TabIndex = 3;
            btnDelete.TabStop = false;
            btnDelete.Text = "Izbriši";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.SetColumnSpan(btnEdit, 2);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.Lime;
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEdit.Location = new Point(145, 913);
            btnEdit.Margin = new Padding(5, 5, 5, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 46);
            btnEdit.TabIndex = 2;
            btnEdit.TabStop = false;
            btnEdit.Text = "Uredi";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.SetColumnSpan(btnAdd, 2);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderColor = Color.Lime;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(25, 913);
            btnAdd.Margin = new Padding(25, 5, 5, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 46);
            btnAdd.TabIndex = 1;
            btnAdd.TabStop = false;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.FromArgb(18, 18, 18);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.ColumnHeadersVisible = false;
            tableLayoutPanel1.SetColumnSpan(dataGrid, 6);
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.White;
            dataGrid.Location = new Point(25, 55);
            dataGrid.Margin = new Padding(25, 5, 5, 5);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(dataGrid, 2);
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(350, 798);
            dataGrid.TabIndex = 0;
            dataGrid.TabStop = false;
            dataGrid.CellMouseLeave += dataGrid_CellMouseLeave;
            dataGrid.CellMouseMove += dataGrid_CellMouseMove;
            dataGrid.SelectionChanged += dataGrid_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnYellow, 1, 3);
            tableLayoutPanel1.Controls.Add(btnBlue, 5, 3);
            tableLayoutPanel1.Controls.Add(btnPink, 4, 3);
            tableLayoutPanel1.Controls.Add(btnRed, 3, 3);
            tableLayoutPanel1.Controls.Add(btnOrange, 2, 3);
            tableLayoutPanel1.Controls.Add(dataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 4);
            tableLayoutPanel1.Controls.Add(btnEdit, 2, 4);
            tableLayoutPanel1.Controls.Add(btnDelete, 4, 4);
            tableLayoutPanel1.Controls.Add(panelRecipe, 6, 1);
            tableLayoutPanel1.Controls.Add(panelBar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLime, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(1584, 984);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Dock = DockStyle.Fill;
            btnYellow.FlatAppearance.BorderColor = Color.Yellow;
            btnYellow.FlatAppearance.BorderSize = 2;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Location = new Point(85, 863);
            btnYellow.Margin = new Padding(5);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(50, 40);
            btnYellow.TabIndex = 12;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.Dock = DockStyle.Fill;
            btnBlue.FlatAppearance.BorderColor = Color.Blue;
            btnBlue.FlatAppearance.BorderSize = 2;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Location = new Point(325, 863);
            btnBlue.Margin = new Padding(5);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(50, 40);
            btnBlue.TabIndex = 11;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnPink
            // 
            btnPink.BackColor = Color.Fuchsia;
            btnPink.Dock = DockStyle.Fill;
            btnPink.FlatAppearance.BorderColor = Color.Fuchsia;
            btnPink.FlatAppearance.BorderSize = 2;
            btnPink.FlatStyle = FlatStyle.Flat;
            btnPink.Location = new Point(265, 863);
            btnPink.Margin = new Padding(5);
            btnPink.Name = "btnPink";
            btnPink.Size = new Size(50, 40);
            btnPink.TabIndex = 10;
            btnPink.UseVisualStyleBackColor = false;
            btnPink.Click += btnPink_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Dock = DockStyle.Fill;
            btnRed.FlatAppearance.BorderColor = Color.Red;
            btnRed.FlatAppearance.BorderSize = 2;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Location = new Point(205, 863);
            btnRed.Margin = new Padding(5);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(50, 40);
            btnRed.TabIndex = 9;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.FromArgb(255, 128, 0);
            btnOrange.Dock = DockStyle.Fill;
            btnOrange.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnOrange.FlatAppearance.BorderSize = 2;
            btnOrange.FlatStyle = FlatStyle.Flat;
            btnOrange.Location = new Point(145, 863);
            btnOrange.Margin = new Padding(5);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(50, 40);
            btnOrange.TabIndex = 8;
            btnOrange.UseVisualStyleBackColor = false;
            btnOrange.Click += btnOrange_Click;
            // 
            // btnLime
            // 
            btnLime.BackColor = Color.Lime;
            btnLime.Dock = DockStyle.Fill;
            btnLime.FlatAppearance.BorderColor = Color.Lime;
            btnLime.FlatAppearance.BorderSize = 2;
            btnLime.FlatStyle = FlatStyle.Flat;
            btnLime.Location = new Point(25, 863);
            btnLime.Margin = new Padding(25, 5, 5, 5);
            btnLime.Name = "btnLime";
            btnLime.Size = new Size(50, 40);
            btnLime.TabIndex = 6;
            btnLime.UseVisualStyleBackColor = false;
            btnLime.Click += btnLime_Click;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1584, 984);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            MinimumSize = new Size(1600, 900);
            Name = "Application";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Application_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBar;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGrid;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Panel panelRecipe;
        private Button btnYellow;
        private Button btnBlue;
        private Button btnPink;
        private Button btnRed;
        private Button btnOrange;
        private Button btnLime;
    }
}
