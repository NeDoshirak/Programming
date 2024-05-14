namespace Music
{
    partial class SongControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            SongsListBox = new ListBox();
            AddButton = new Button();
            EditButton = new Button();
            groupBox1 = new GroupBox();
            SaveButton = new Button();
            DurationTextBox = new TextBox();
            label4 = new Label();
            GenreComboBox = new ComboBox();
            label3 = new Label();
            TitleTextBox = new TextBox();
            label2 = new Label();
            AuthorTextBox = new TextBox();
            label1 = new Label();
            DelButton = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SongsListBox
            // 
            SongsListBox.FormattingEnabled = true;
            SongsListBox.ItemHeight = 15;
            SongsListBox.Location = new Point(1, 18);
            SongsListBox.Name = "SongsListBox";
            SongsListBox.Size = new Size(237, 304);
            SongsListBox.TabIndex = 0;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(1, 328);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(82, 328);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(DurationTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(GenreComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TitleTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(AuthorTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(244, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 227);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected song:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(144, 198);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(6, 169);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(213, 23);
            DurationTextBox.TabIndex = 7;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 151);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Duration:";
            // 
            // GenreComboBox
            // 
            GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(6, 125);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(213, 23);
            GenreComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Genre:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(6, 81);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(213, 23);
            TitleTextBox.TabIndex = 3;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(6, 37);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(213, 23);
            AuthorTextBox.TabIndex = 1;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Author:";
            // 
            // DelButton
            // 
            DelButton.Location = new Point(163, 328);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 23);
            DelButton.TabIndex = 4;
            DelButton.Text = "Del";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 3);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 5;
            label5.Text = "Songs:";
            // 
            // SongControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(DelButton);
            Controls.Add(groupBox1);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(SongsListBox);
            Name = "SongControl";
            Size = new Size(465, 352);
            Enter += SongControl_Enter;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SongsListBox;
        private Button AddButton;
        private Button EditButton;
        private GroupBox groupBox1;
        private TextBox DurationTextBox;
        private Label label4;
        private ComboBox GenreComboBox;
        private Label label3;
        private TextBox TitleTextBox;
        private Label label2;
        private TextBox AuthorTextBox;
        private Label label1;
        private Button DelButton;
        private Label label5;
        private Button SaveButton;
    }
}
