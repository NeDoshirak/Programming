namespace Programming
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EnumTabPage = new TabPage();
            SeasonHandleGB = new GroupBox();
            label5 = new Label();
            SeasonResultLable = new Label();
            SeasonResulrButton = new Button();
            SeasonsComboBox = new ComboBox();
            WeekdayParsingGB = new GroupBox();
            WeekdayResultLable = new Label();
            ParseButton = new Button();
            label4 = new Label();
            ParsingListBox = new TextBox();
            EnumarationsrGB = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            IntEnumsIndex = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            ClassesTabPage = new TabPage();
            groupBox2 = new GroupBox();
            FindMovButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            RatingTB = new TextBox();
            YearTB = new TextBox();
            TittleTB = new TextBox();
            MoviesListBox = new ListBox();
            groupBox1 = new GroupBox();
            FindRecButton = new Button();
            label8 = new Label();
            lable3241 = new Label();
            lable7 = new Label();
            ColorTB = new TextBox();
            WidthTB = new TextBox();
            LenghtTB = new TextBox();
            RectanglesListBox = new ListBox();
            EnumTabPage.SuspendLayout();
            SeasonHandleGB.SuspendLayout();
            WeekdayParsingGB.SuspendLayout();
            EnumarationsrGB.SuspendLayout();
            tabControl1.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumTabPage
            // 
            EnumTabPage.Controls.Add(SeasonHandleGB);
            EnumTabPage.Controls.Add(WeekdayParsingGB);
            EnumTabPage.Controls.Add(EnumarationsrGB);
            EnumTabPage.Location = new Point(4, 24);
            EnumTabPage.Name = "EnumTabPage";
            EnumTabPage.Padding = new Padding(3);
            EnumTabPage.Size = new Size(649, 405);
            EnumTabPage.TabIndex = 0;
            EnumTabPage.Text = "Enums";
            EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGB
            // 
            SeasonHandleGB.Controls.Add(label5);
            SeasonHandleGB.Controls.Add(SeasonResultLable);
            SeasonHandleGB.Controls.Add(SeasonResulrButton);
            SeasonHandleGB.Controls.Add(SeasonsComboBox);
            SeasonHandleGB.Location = new Point(315, 281);
            SeasonHandleGB.Name = "SeasonHandleGB";
            SeasonHandleGB.Size = new Size(326, 121);
            SeasonHandleGB.TabIndex = 9;
            SeasonHandleGB.TabStop = false;
            SeasonHandleGB.Text = "Season Handle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 12;
            label5.Text = "Choose season:";
            // 
            // SeasonResultLable
            // 
            SeasonResultLable.AutoSize = true;
            SeasonResultLable.Location = new Point(26, 85);
            SeasonResultLable.Name = "SeasonResultLable";
            SeasonResultLable.Size = new Size(72, 15);
            SeasonResultLable.TabIndex = 11;
            SeasonResultLable.Text = "И этот тоже";
            SeasonResultLable.Visible = false;
            // 
            // SeasonResulrButton
            // 
            SeasonResulrButton.Location = new Point(136, 59);
            SeasonResulrButton.Name = "SeasonResulrButton";
            SeasonResulrButton.Size = new Size(84, 23);
            SeasonResulrButton.TabIndex = 10;
            SeasonResulrButton.Text = "Go!";
            SeasonResulrButton.UseVisualStyleBackColor = true;
            SeasonResulrButton.Click += SeasonResulrButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.AccessibleRole = AccessibleRole.MenuBar;
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Location = new Point(6, 59);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(124, 23);
            SeasonsComboBox.TabIndex = 0;
            // 
            // WeekdayParsingGB
            // 
            WeekdayParsingGB.Controls.Add(WeekdayResultLable);
            WeekdayParsingGB.Controls.Add(ParseButton);
            WeekdayParsingGB.Controls.Add(label4);
            WeekdayParsingGB.Controls.Add(ParsingListBox);
            WeekdayParsingGB.Location = new Point(4, 281);
            WeekdayParsingGB.Name = "WeekdayParsingGB";
            WeekdayParsingGB.Size = new Size(304, 121);
            WeekdayParsingGB.TabIndex = 8;
            WeekdayParsingGB.TabStop = false;
            WeekdayParsingGB.Text = "Weekday Parsing";
            // 
            // WeekdayResultLable
            // 
            WeekdayResultLable.AutoSize = true;
            WeekdayResultLable.Location = new Point(25, 85);
            WeekdayResultLable.Name = "WeekdayResultLable";
            WeekdayResultLable.Size = new Size(114, 15);
            WeekdayResultLable.TabIndex = 10;
            WeekdayResultLable.Text = "Этот текст не видно";
            WeekdayResultLable.Visible = false;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(188, 59);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(84, 23);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 41);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 8;
            label4.Text = "Type value for parsing:";
            // 
            // ParsingListBox
            // 
            ParsingListBox.Location = new Point(4, 59);
            ParsingListBox.Name = "ParsingListBox";
            ParsingListBox.ScrollBars = ScrollBars.Both;
            ParsingListBox.Size = new Size(178, 23);
            ParsingListBox.TabIndex = 7;
            // 
            // EnumarationsrGB
            // 
            EnumarationsrGB.Controls.Add(label3);
            EnumarationsrGB.Controls.Add(label2);
            EnumarationsrGB.Controls.Add(label1);
            EnumarationsrGB.Controls.Add(IntEnumsIndex);
            EnumarationsrGB.Controls.Add(ValuesListBox);
            EnumarationsrGB.Controls.Add(EnumsListBox);
            EnumarationsrGB.Location = new Point(4, 6);
            EnumarationsrGB.Name = "EnumarationsrGB";
            EnumarationsrGB.Size = new Size(637, 275);
            EnumarationsrGB.TabIndex = 7;
            EnumarationsrGB.TabStop = false;
            EnumarationsrGB.Text = "Enumarations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 22);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Int value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 5;
            label2.Text = "Choose enumiration:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose value:";
            // 
            // IntEnumsIndex
            // 
            IntEnumsIndex.Location = new Point(311, 40);
            IntEnumsIndex.Name = "IntEnumsIndex";
            IntEnumsIndex.ReadOnly = true;
            IntEnumsIndex.Size = new Size(145, 23);
            IntEnumsIndex.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(170, 40);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(135, 229);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Genre", "Season", "StudyForm", "Weekday", "Manufacturers" });
            EnumsListBox.Location = new Point(4, 40);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(135, 229);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumTabPage);
            tabControl1.Controls.Add(ClassesTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(657, 433);
            tabControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(groupBox2);
            ClassesTabPage.Controls.Add(groupBox1);
            ClassesTabPage.Location = new Point(4, 24);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Size = new Size(649, 405);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FindMovButton);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(RatingTB);
            groupBox2.Controls.Add(YearTB);
            groupBox2.Controls.Add(TittleTB);
            groupBox2.Controls.Add(MoviesListBox);
            groupBox2.Location = new Point(333, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 269);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movies";
            // 
            // FindMovButton
            // 
            FindMovButton.Location = new Point(170, 229);
            FindMovButton.Name = "FindMovButton";
            FindMovButton.Size = new Size(130, 23);
            FindMovButton.TabIndex = 8;
            FindMovButton.Text = "Find";
            FindMovButton.UseVisualStyleBackColor = true;
            FindMovButton.Click += FindMovButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 111);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 7;
            label6.Text = "Rating:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 67);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(170, 23);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 5;
            label9.Text = "Title:";
            // 
            // RatingTB
            // 
            RatingTB.Location = new Point(170, 129);
            RatingTB.Name = "RatingTB";
            RatingTB.Size = new Size(130, 23);
            RatingTB.TabIndex = 4;
            RatingTB.TextChanged += RatingTB_TextChanged;
            // 
            // YearTB
            // 
            YearTB.Location = new Point(170, 85);
            YearTB.Name = "YearTB";
            YearTB.Size = new Size(130, 23);
            YearTB.TabIndex = 3;
            YearTB.TextChanged += YearTB_TextChanged;
            // 
            // TittleTB
            // 
            TittleTB.Location = new Point(170, 41);
            TittleTB.Name = "TittleTB";
            TittleTB.Size = new Size(130, 23);
            TittleTB.TabIndex = 2;
            TittleTB.TextChanged += TittleTB_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(8, 23);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(156, 229);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FindRecButton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lable3241);
            groupBox1.Controls.Add(lable7);
            groupBox1.Controls.Add(ColorTB);
            groupBox1.Controls.Add(WidthTB);
            groupBox1.Controls.Add(LenghtTB);
            groupBox1.Controls.Add(RectanglesListBox);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 269);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // FindRecButton
            // 
            FindRecButton.Location = new Point(170, 229);
            FindRecButton.Name = "FindRecButton";
            FindRecButton.Size = new Size(130, 23);
            FindRecButton.TabIndex = 8;
            FindRecButton.Text = "Find";
            FindRecButton.UseVisualStyleBackColor = true;
            FindRecButton.Click += FindButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 111);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Color:";
            // 
            // lable3241
            // 
            lable3241.AutoSize = true;
            lable3241.Location = new Point(170, 67);
            lable3241.Name = "lable3241";
            lable3241.Size = new Size(42, 15);
            lable3241.TabIndex = 6;
            lable3241.Text = "Width:";
            // 
            // lable7
            // 
            lable7.AutoSize = true;
            lable7.Location = new Point(170, 23);
            lable7.Name = "lable7";
            lable7.Size = new Size(47, 15);
            lable7.TabIndex = 5;
            lable7.Text = "Lenght:";
            // 
            // ColorTB
            // 
            ColorTB.Location = new Point(170, 129);
            ColorTB.Name = "ColorTB";
            ColorTB.Size = new Size(130, 23);
            ColorTB.TabIndex = 4;
            ColorTB.TextChanged += ColorTB_TextChanged;
            // 
            // WidthTB
            // 
            WidthTB.Location = new Point(170, 85);
            WidthTB.Name = "WidthTB";
            WidthTB.Size = new Size(130, 23);
            WidthTB.TabIndex = 3;
            WidthTB.TextChanged += WidhtTB_TextChanged;
            // 
            // LenghtTB
            // 
            LenghtTB.Location = new Point(170, 41);
            LenghtTB.Name = "LenghtTB";
            LenghtTB.Size = new Size(130, 23);
            LenghtTB.TabIndex = 2;
            LenghtTB.TextChanged += LenghtTB_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangles 1", "Rectangles 2", "Rectangles 3", "Rectangles 4", "Rectangles 5" });
            RectanglesListBox.Location = new Point(8, 23);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(156, 229);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(657, 433);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            EnumTabPage.ResumeLayout(false);
            SeasonHandleGB.ResumeLayout(false);
            SeasonHandleGB.PerformLayout();
            WeekdayParsingGB.ResumeLayout(false);
            WeekdayParsingGB.PerformLayout();
            EnumarationsrGB.ResumeLayout(false);
            EnumarationsrGB.PerformLayout();
            tabControl1.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage EnumTabPage;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabControl tabControl1;
        public TextBox IntEnumsIndex;
        private Label label2;
        private Label label1;
        private Label label3;
        private GroupBox EnumarationsrGB;
        private GroupBox WeekdayParsingGB;
        private Label label4;
        public TextBox ParsingListBox;
        private Button ParseButton;
        public Label WeekdayResultLable;
        private GroupBox SeasonHandleGB;
        private ComboBox SeasonsComboBox;
        private Button SeasonResulrButton;
        public Label SeasonResultLable;
        private Label label5;
        private TabPage ClassesTabPage;
        private Label label8;
        private Label lable3241;
        private Label lable7;
        private Button FindRecButton;
        private GroupBox groupBox1;
        public ListBox RectanglesListBox;
        public TextBox ColorTB;
        public TextBox WidthTB;
        public TextBox LenghtTB;
        private GroupBox groupBox2;
        private Button FindMovButton;
        private Label label6;
        private Label label7;
        private Label label9;
        public TextBox RatingTB;
        public TextBox YearTB;
        public TextBox TittleTB;
        public ListBox MoviesListBox;
    }
}