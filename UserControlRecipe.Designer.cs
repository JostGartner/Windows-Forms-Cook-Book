namespace E_Cookbook
{
    partial class UserControlRecipe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox = new PictureBox();
            labelTitle = new Label();
            richTextBoxInstructions = new RichTextBox();
            richTextBoxDescription = new RichTextBox();
            labelIngredients = new Label();
            labelInstructions = new Label();
            richTextBoxIngredients = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox, 2, 2);
            tableLayoutPanel1.Controls.Add(labelTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBoxInstructions, 1, 5);
            tableLayoutPanel1.Controls.Add(richTextBoxDescription, 1, 1);
            tableLayoutPanel1.Controls.Add(labelIngredients, 5, 2);
            tableLayoutPanel1.Controls.Add(labelInstructions, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBoxIngredients, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1195, 750);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(76, 153);
            pictureBox.Name = "pictureBox";
            tableLayoutPanel1.SetRowSpan(pictureBox, 2);
            pictureBox.Size = new Size(494, 344);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelTitle, 6);
            labelTitle.Font = new Font("Consolas", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.ForeColor = Color.Lime;
            labelTitle.Location = new Point(-24, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1244, 51);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Naslov recepta";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInstructions
            // 
            richTextBoxInstructions.BackColor = Color.FromArgb(18, 18, 18);
            richTextBoxInstructions.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(richTextBoxInstructions, 6);
            richTextBoxInstructions.Dock = DockStyle.Fill;
            richTextBoxInstructions.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBoxInstructions.ForeColor = Color.White;
            richTextBoxInstructions.Location = new Point(73, 550);
            richTextBoxInstructions.Margin = new Padding(100, 0, 100, 0);
            richTextBoxInstructions.Name = "richTextBoxInstructions";
            richTextBoxInstructions.ReadOnly = true;
            richTextBoxInstructions.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxInstructions.Size = new Size(1050, 200);
            richTextBoxInstructions.TabIndex = 2;
            richTextBoxInstructions.TabStop = false;
            richTextBoxInstructions.Text = "";
            richTextBoxInstructions.TextChanged += richTextBoxInstructions_TextChanged;
            richTextBoxInstructions.MouseDown += richTextBoxInstructions_MouseDown;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.BackColor = Color.FromArgb(18, 18, 18);
            richTextBoxDescription.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(richTextBoxDescription, 6);
            richTextBoxDescription.Dock = DockStyle.Fill;
            richTextBoxDescription.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBoxDescription.ForeColor = Color.White;
            richTextBoxDescription.Location = new Point(-24, 103);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxDescription.Size = new Size(1244, 44);
            richTextBoxDescription.TabIndex = 4;
            richTextBoxDescription.TabStop = false;
            richTextBoxDescription.Text = "";
            richTextBoxDescription.MouseDown += richTextBoxDescription_MouseDown;
            // 
            // labelIngredients
            // 
            labelIngredients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelIngredients.AutoSize = true;
            labelIngredients.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelIngredients.ForeColor = Color.Lime;
            labelIngredients.Location = new Point(626, 156);
            labelIngredients.Name = "labelIngredients";
            labelIngredients.Size = new Size(494, 37);
            labelIngredients.TabIndex = 6;
            labelIngredients.Text = "Sestavine";
            labelIngredients.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInstructions
            // 
            labelInstructions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelInstructions.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelInstructions, 6);
            labelInstructions.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelInstructions.ForeColor = Color.Lime;
            labelInstructions.Location = new Point(73, 506);
            labelInstructions.Margin = new Padding(100, 0, 100, 0);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(1050, 37);
            labelInstructions.TabIndex = 7;
            labelInstructions.Text = "Navodila";
            labelInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBoxIngredients
            // 
            richTextBoxIngredients.BackColor = Color.FromArgb(18, 18, 18);
            richTextBoxIngredients.BorderStyle = BorderStyle.None;
            richTextBoxIngredients.Dock = DockStyle.Fill;
            richTextBoxIngredients.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBoxIngredients.ForeColor = Color.White;
            richTextBoxIngredients.Location = new Point(623, 200);
            richTextBoxIngredients.Margin = new Padding(0, 0, 100, 0);
            richTextBoxIngredients.Name = "richTextBoxIngredients";
            richTextBoxIngredients.Size = new Size(400, 300);
            richTextBoxIngredients.TabIndex = 9;
            richTextBoxIngredients.TabStop = false;
            richTextBoxIngredients.Text = "";
            richTextBoxIngredients.TextChanged += richTextBoxIngredients_TextChanged;
            richTextBoxIngredients.MouseDown += richTextBoxIngredients_MouseDown;
            // 
            // UserControlRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlRecipe";
            Size = new Size(1195, 750);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox;
        private Label labelTitle;
        private RichTextBox richTextBoxInstructions;
        private RichTextBox richTextBoxDescription;
        private Label labelIngredients;
        private Label labelInstructions;
        private RichTextBox richTextBoxIngredients;
    }
}
