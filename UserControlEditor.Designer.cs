namespace E_Cookbook
{
    partial class UserControlEditor
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
            btnRemoveInstruction = new Button();
            btnAddInstruction = new Button();
            textBoxAddInstruction = new TextBox();
            btnRemoveIngredient = new Button();
            btnAddIngredient = new Button();
            textBoxAddIngredient = new TextBox();
            textBoxDescriptionEdit = new TextBox();
            btnCancel = new Button();
            btnChooseImage = new Button();
            listBoxInstructionsEdit = new ListBox();
            labelIngredientsEdit = new Label();
            pictureBoxEdit = new PictureBox();
            textBoxTitleEdit = new TextBox();
            labelInstructionsEdit = new Label();
            listBoxIngredientsEdit = new ListBox();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRemoveInstruction, 7, 7);
            tableLayoutPanel1.Controls.Add(btnAddInstruction, 6, 7);
            tableLayoutPanel1.Controls.Add(textBoxAddInstruction, 2, 7);
            tableLayoutPanel1.Controls.Add(btnRemoveIngredient, 7, 4);
            tableLayoutPanel1.Controls.Add(btnAddIngredient, 6, 4);
            tableLayoutPanel1.Controls.Add(textBoxAddIngredient, 5, 4);
            tableLayoutPanel1.Controls.Add(textBoxDescriptionEdit, 2, 1);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 8);
            tableLayoutPanel1.Controls.Add(btnChooseImage, 2, 2);
            tableLayoutPanel1.Controls.Add(listBoxInstructionsEdit, 2, 6);
            tableLayoutPanel1.Controls.Add(labelIngredientsEdit, 5, 2);
            tableLayoutPanel1.Controls.Add(pictureBoxEdit, 2, 3);
            tableLayoutPanel1.Controls.Add(textBoxTitleEdit, 2, 0);
            tableLayoutPanel1.Controls.Add(labelInstructionsEdit, 2, 5);
            tableLayoutPanel1.Controls.Add(listBoxIngredientsEdit, 5, 3);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1461, 862);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemoveInstruction
            // 
            btnRemoveInstruction.BackColor = Color.FromArgb(18, 18, 18);
            btnRemoveInstruction.Dock = DockStyle.Fill;
            btnRemoveInstruction.FlatAppearance.BorderColor = Color.White;
            btnRemoveInstruction.FlatAppearance.BorderSize = 2;
            btnRemoveInstruction.FlatStyle = FlatStyle.Flat;
            btnRemoveInstruction.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRemoveInstruction.ForeColor = Color.Red;
            btnRemoveInstruction.Location = new Point(1205, 762);
            btnRemoveInstruction.Margin = new Padding(0);
            btnRemoveInstruction.Name = "btnRemoveInstruction";
            btnRemoveInstruction.Size = new Size(50, 50);
            btnRemoveInstruction.TabIndex = 21;
            btnRemoveInstruction.TabStop = false;
            btnRemoveInstruction.Text = "-";
            btnRemoveInstruction.UseVisualStyleBackColor = false;
            btnRemoveInstruction.Click += btnRemoveInstruction_Click;
            // 
            // btnAddInstruction
            // 
            btnAddInstruction.BackColor = Color.FromArgb(18, 18, 18);
            btnAddInstruction.Dock = DockStyle.Fill;
            btnAddInstruction.FlatAppearance.BorderColor = Color.White;
            btnAddInstruction.FlatAppearance.BorderSize = 2;
            btnAddInstruction.FlatStyle = FlatStyle.Flat;
            btnAddInstruction.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAddInstruction.ForeColor = Color.Lime;
            btnAddInstruction.Location = new Point(1155, 762);
            btnAddInstruction.Margin = new Padding(0);
            btnAddInstruction.Name = "btnAddInstruction";
            btnAddInstruction.Size = new Size(50, 50);
            btnAddInstruction.TabIndex = 20;
            btnAddInstruction.TabStop = false;
            btnAddInstruction.Text = "+";
            btnAddInstruction.UseVisualStyleBackColor = false;
            btnAddInstruction.Click += btnAddInstruction_Click;
            // 
            // textBoxAddInstruction
            // 
            textBoxAddInstruction.BackColor = Color.FromArgb(18, 18, 18);
            textBoxAddInstruction.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(textBoxAddInstruction, 4);
            textBoxAddInstruction.Dock = DockStyle.Fill;
            textBoxAddInstruction.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxAddInstruction.ForeColor = Color.White;
            textBoxAddInstruction.Location = new Point(205, 762);
            textBoxAddInstruction.Margin = new Padding(0);
            textBoxAddInstruction.Multiline = true;
            textBoxAddInstruction.Name = "textBoxAddInstruction";
            textBoxAddInstruction.PlaceholderText = " Vpišite novo vrstico navodila...";
            textBoxAddInstruction.Size = new Size(950, 50);
            textBoxAddInstruction.TabIndex = 19;
            textBoxAddInstruction.KeyDown += textBoxAddInstruction_KeyDown;
            // 
            // btnRemoveIngredient
            // 
            btnRemoveIngredient.BackColor = Color.FromArgb(18, 18, 18);
            btnRemoveIngredient.Dock = DockStyle.Fill;
            btnRemoveIngredient.FlatAppearance.BorderColor = Color.White;
            btnRemoveIngredient.FlatAppearance.BorderSize = 2;
            btnRemoveIngredient.FlatStyle = FlatStyle.Flat;
            btnRemoveIngredient.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRemoveIngredient.ForeColor = Color.Red;
            btnRemoveIngredient.Location = new Point(1205, 450);
            btnRemoveIngredient.Margin = new Padding(0);
            btnRemoveIngredient.Name = "btnRemoveIngredient";
            btnRemoveIngredient.Size = new Size(50, 50);
            btnRemoveIngredient.TabIndex = 18;
            btnRemoveIngredient.TabStop = false;
            btnRemoveIngredient.Text = "-";
            btnRemoveIngredient.UseVisualStyleBackColor = false;
            btnRemoveIngredient.Click += btnRemoveIngredient_Click;
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.BackColor = Color.FromArgb(18, 18, 18);
            btnAddIngredient.Dock = DockStyle.Fill;
            btnAddIngredient.FlatAppearance.BorderColor = Color.White;
            btnAddIngredient.FlatAppearance.BorderSize = 2;
            btnAddIngredient.FlatStyle = FlatStyle.Flat;
            btnAddIngredient.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAddIngredient.ForeColor = Color.Lime;
            btnAddIngredient.Location = new Point(1155, 450);
            btnAddIngredient.Margin = new Padding(0);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(50, 50);
            btnAddIngredient.TabIndex = 17;
            btnAddIngredient.TabStop = false;
            btnAddIngredient.Text = "+";
            btnAddIngredient.UseVisualStyleBackColor = false;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // textBoxAddIngredient
            // 
            textBoxAddIngredient.BackColor = Color.FromArgb(18, 18, 18);
            textBoxAddIngredient.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddIngredient.Dock = DockStyle.Fill;
            textBoxAddIngredient.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxAddIngredient.ForeColor = Color.White;
            textBoxAddIngredient.Location = new Point(755, 450);
            textBoxAddIngredient.Margin = new Padding(0);
            textBoxAddIngredient.Multiline = true;
            textBoxAddIngredient.Name = "textBoxAddIngredient";
            textBoxAddIngredient.PlaceholderText = "Vpišite novo sestavino...";
            textBoxAddIngredient.Size = new Size(400, 50);
            textBoxAddIngredient.TabIndex = 16;
            textBoxAddIngredient.KeyDown += textBoxAddIngredient_KeyDown;
            // 
            // textBoxDescriptionEdit
            // 
            textBoxDescriptionEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescriptionEdit.BackColor = Color.FromArgb(18, 18, 18);
            textBoxDescriptionEdit.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(textBoxDescriptionEdit, 6);
            textBoxDescriptionEdit.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxDescriptionEdit.ForeColor = Color.White;
            textBoxDescriptionEdit.Location = new Point(205, 107);
            textBoxDescriptionEdit.Margin = new Padding(0);
            textBoxDescriptionEdit.Multiline = true;
            textBoxDescriptionEdit.Name = "textBoxDescriptionEdit";
            textBoxDescriptionEdit.PlaceholderText = "Opis...";
            textBoxDescriptionEdit.Size = new Size(1050, 36);
            textBoxDescriptionEdit.TabIndex = 14;
            textBoxDescriptionEdit.TextAlign = HorizontalAlignment.Center;
            textBoxDescriptionEdit.KeyDown += textBoxDescriptionEdit_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.SetColumnSpan(btnCancel, 2);
            btnCancel.FlatAppearance.BorderColor = Color.Lime;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(735, 817);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 40);
            btnCancel.TabIndex = 13;
            btnCancel.TabStop = false;
            btnCancel.Text = "Prekliči";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnChooseImage.BackColor = Color.FromArgb(18, 18, 18);
            btnChooseImage.FlatAppearance.BorderColor = Color.Lime;
            btnChooseImage.FlatAppearance.BorderSize = 2;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(210, 155);
            btnChooseImage.Margin = new Padding(5);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(200, 40);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.TabStop = false;
            btnChooseImage.Text = "Izberite Sliko";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // listBoxInstructionsEdit
            // 
            listBoxInstructionsEdit.BackColor = Color.FromArgb(18, 18, 18);
            listBoxInstructionsEdit.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(listBoxInstructionsEdit, 6);
            listBoxInstructionsEdit.Dock = DockStyle.Fill;
            listBoxInstructionsEdit.ForeColor = Color.White;
            listBoxInstructionsEdit.FormattingEnabled = true;
            listBoxInstructionsEdit.Location = new Point(205, 550);
            listBoxInstructionsEdit.Margin = new Padding(0);
            listBoxInstructionsEdit.Name = "listBoxInstructionsEdit";
            listBoxInstructionsEdit.Size = new Size(1050, 212);
            listBoxInstructionsEdit.TabIndex = 10;
            listBoxInstructionsEdit.MouseDoubleClick += listBoxInstructionsEdit_MouseDoubleClick;
            // 
            // labelIngredientsEdit
            // 
            labelIngredientsEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelIngredientsEdit.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelIngredientsEdit, 3);
            labelIngredientsEdit.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelIngredientsEdit.ForeColor = Color.Lime;
            labelIngredientsEdit.Location = new Point(755, 158);
            labelIngredientsEdit.Margin = new Padding(0);
            labelIngredientsEdit.Name = "labelIngredientsEdit";
            labelIngredientsEdit.Size = new Size(500, 34);
            labelIngredientsEdit.TabIndex = 7;
            labelIngredientsEdit.Text = "Sestavine";
            labelIngredientsEdit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.Dock = DockStyle.Fill;
            pictureBoxEdit.Location = new Point(205, 200);
            pictureBoxEdit.Margin = new Padding(0);
            pictureBoxEdit.Name = "pictureBoxEdit";
            tableLayoutPanel1.SetRowSpan(pictureBoxEdit, 2);
            pictureBoxEdit.Size = new Size(500, 300);
            pictureBoxEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxEdit.TabIndex = 6;
            pictureBoxEdit.TabStop = false;
            pictureBoxEdit.Paint += pictureBoxEdit_Paint;
            // 
            // textBoxTitleEdit
            // 
            textBoxTitleEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitleEdit.BackColor = Color.FromArgb(18, 18, 18);
            textBoxTitleEdit.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(textBoxTitleEdit, 6);
            textBoxTitleEdit.Font = new Font("Consolas", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxTitleEdit.ForeColor = Color.Lime;
            textBoxTitleEdit.Location = new Point(205, 22);
            textBoxTitleEdit.Margin = new Padding(0);
            textBoxTitleEdit.Multiline = true;
            textBoxTitleEdit.Name = "textBoxTitleEdit";
            textBoxTitleEdit.PlaceholderText = "Naslov...";
            textBoxTitleEdit.Size = new Size(1050, 56);
            textBoxTitleEdit.TabIndex = 0;
            textBoxTitleEdit.TextAlign = HorizontalAlignment.Center;
            textBoxTitleEdit.KeyDown += textBoxTitleEdit_KeyDown;
            // 
            // labelInstructionsEdit
            // 
            labelInstructionsEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelInstructionsEdit.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelInstructionsEdit, 6);
            labelInstructionsEdit.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelInstructionsEdit.ForeColor = Color.Lime;
            labelInstructionsEdit.Location = new Point(205, 508);
            labelInstructionsEdit.Margin = new Padding(0);
            labelInstructionsEdit.Name = "labelInstructionsEdit";
            labelInstructionsEdit.Size = new Size(1050, 34);
            labelInstructionsEdit.TabIndex = 8;
            labelInstructionsEdit.Text = "Navodila";
            labelInstructionsEdit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxIngredientsEdit
            // 
            listBoxIngredientsEdit.BackColor = Color.FromArgb(18, 18, 18);
            listBoxIngredientsEdit.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(listBoxIngredientsEdit, 3);
            listBoxIngredientsEdit.Dock = DockStyle.Fill;
            listBoxIngredientsEdit.ForeColor = Color.White;
            listBoxIngredientsEdit.FormattingEnabled = true;
            listBoxIngredientsEdit.Location = new Point(755, 200);
            listBoxIngredientsEdit.Margin = new Padding(0);
            listBoxIngredientsEdit.Name = "listBoxIngredientsEdit";
            listBoxIngredientsEdit.Size = new Size(500, 250);
            listBoxIngredientsEdit.TabIndex = 9;
            listBoxIngredientsEdit.MouseDoubleClick += listBoxIngredientsEdit_MouseDoubleClick;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.FlatAppearance.BorderColor = Color.Lime;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(600, 817);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 40);
            btnSave.TabIndex = 12;
            btnSave.TabStop = false;
            btnSave.Text = "Shrani";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // UserControlEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "UserControlEditor";
            Size = new Size(1461, 862);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxTitleEdit;
        private PictureBox pictureBoxEdit;
        private Label labelIngredientsEdit;
        private Label labelInstructionsEdit;
        private ListBox listBoxIngredientsEdit;
        private ListBox listBoxInstructionsEdit;
        private Button btnChooseImage;
        private Button btnCancel;
        private Button btnSave;
        private TextBox textBoxDescriptionEdit;
        private TextBox textBoxAddIngredient;
        public Button btnRemoveIngredient;
        public Button btnAddIngredient;
        private TextBox textBoxAddInstruction;
        public Button btnRemoveInstruction;
        public Button btnAddInstruction;
    }
}
