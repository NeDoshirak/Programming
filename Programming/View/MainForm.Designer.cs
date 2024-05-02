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
            IDTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            CenterYTextBox = new TextBox();
            CenterXTextBox = new TextBox();
            FindRecButton = new Button();
            label8 = new Label();
            lable3241 = new Label();
            lable7 = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LenghtTextBox = new TextBox();
            RectanglesLB = new ListBox();
            RectangleTabPage = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            RectanglePanel = new Panel();
            WidthTB = new TextBox();
            HeightTB = new TextBox();
            YTB = new TextBox();
            XTB = new TextBox();
            IDTB = new TextBox();
            RectanglesListBox = new ListBox();
            EnumTabPage.SuspendLayout();
            SeasonHandleGB.SuspendLayout();
            WeekdayParsingGB.SuspendLayout();
            EnumarationsrGB.SuspendLayout();
            tabControl1.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            RectangleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabControl1.Controls.Add(RectangleTabPage);
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
            ClassesTabPage.Enter += ClassesTabPage_Enter;
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
            groupBox2.Size = new Size(310, 325);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movies";
            // 
            // FindMovButton
            // 
            FindMovButton.Location = new Point(170, 244);
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
            MoviesListBox.Size = new Size(156, 244);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IDTextBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(CenterYTextBox);
            groupBox1.Controls.Add(CenterXTextBox);
            groupBox1.Controls.Add(FindRecButton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lable3241);
            groupBox1.Controls.Add(lable7);
            groupBox1.Controls.Add(ColorTextBox);
            groupBox1.Controls.Add(WidthTextBox);
            groupBox1.Controls.Add(LenghtTextBox);
            groupBox1.Controls.Add(RectanglesLB);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 325);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(170, 217);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(62, 23);
            IDTextBox.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(170, 199);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 12;
            label11.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 155);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 11;
            label10.Text = "Center:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(238, 173);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(62, 23);
            CenterYTextBox.TabIndex = 10;
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(170, 173);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(62, 23);
            CenterXTextBox.TabIndex = 9;
            // 
            // FindRecButton
            // 
            FindRecButton.Location = new Point(170, 246);
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
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(170, 129);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(130, 23);
            ColorTextBox.TabIndex = 4;
            ColorTextBox.TextChanged += ColorTB_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(170, 85);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(130, 23);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidhtTB_TextChanged;
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(170, 41);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(130, 23);
            LenghtTextBox.TabIndex = 2;
            LenghtTextBox.TextChanged += LenghtTB_TextChanged;
            // 
            // RectanglesLB
            // 
            RectanglesLB.FormattingEnabled = true;
            RectanglesLB.ItemHeight = 15;
            RectanglesLB.Items.AddRange(new object[] { "Rectangles 1", "Rectangles 2", "Rectangles 3", "Rectangles 4", "Rectangles 5" });
            RectanglesLB.Location = new Point(8, 23);
            RectanglesLB.Name = "RectanglesLB";
            RectanglesLB.Size = new Size(156, 244);
            RectanglesLB.TabIndex = 0;
            RectanglesLB.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectangleTabPage
            // 
            RectangleTabPage.Controls.Add(pictureBox2);
            RectangleTabPage.Controls.Add(pictureBox1);
            RectangleTabPage.Controls.Add(label17);
            RectangleTabPage.Controls.Add(label16);
            RectangleTabPage.Controls.Add(label15);
            RectangleTabPage.Controls.Add(label14);
            RectangleTabPage.Controls.Add(label13);
            RectangleTabPage.Controls.Add(label12);
            RectangleTabPage.Controls.Add(RectanglePanel);
            RectangleTabPage.Controls.Add(WidthTB);
            RectangleTabPage.Controls.Add(HeightTB);
            RectangleTabPage.Controls.Add(YTB);
            RectangleTabPage.Controls.Add(XTB);
            RectangleTabPage.Controls.Add(IDTB);
            RectangleTabPage.Controls.Add(RectanglesListBox);
            RectangleTabPage.Location = new Point(4, 24);
            RectangleTabPage.Name = "RectangleTabPage";
            RectangleTabPage.Size = new Size(649, 405);
            RectangleTabPage.TabIndex = 2;
            RectangleTabPage.Text = "Rectangle";
            RectangleTabPage.UseVisualStyleBackColor = true;
            RectangleTabPage.MouseLeave += RectangleTabPage_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Image = Properties.Resources._3jMsISjGmMw;
            pictureBox1.InitialImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Location = new Point(73, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(30, 11);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 14;
            label17.Text = "Rectangle:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 371);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 13;
            label16.Text = "Width:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 342);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 12;
            label15.Text = "Height:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 313);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 11;
            label14.Text = "Y:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 284);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 10;
            label13.Text = "X:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 255);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 9;
            label12.Text = "ID:";
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(235, 32);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(406, 363);
            RectanglePanel.TabIndex = 8;
            // 
            // WidthTB
            // 
            WidthTB.Location = new Point(73, 368);
            WidthTB.Name = "WidthTB";
            WidthTB.Size = new Size(156, 23);
            WidthTB.TabIndex = 7;
            WidthTB.TextChanged += WidthTB_TextChanged;
            WidthTB.Leave += WidthTB_Leave;
            // 
            // HeightTB
            // 
            HeightTB.Location = new Point(73, 339);
            HeightTB.Name = "HeightTB";
            HeightTB.Size = new Size(156, 23);
            HeightTB.TabIndex = 6;
            HeightTB.TextChanged += HeightTB_TextChanged;
            HeightTB.Leave += HeightTB_Leave;
            // 
            // YTB
            // 
            YTB.Location = new Point(73, 310);
            YTB.Name = "YTB";
            YTB.Size = new Size(156, 23);
            YTB.TabIndex = 5;
            YTB.TextChanged += YTB_TextChanged;
            YTB.Leave += YTB_Leave;
            // 
            // XTB
            // 
            XTB.Location = new Point(73, 281);
            XTB.Name = "XTB";
            XTB.Size = new Size(156, 23);
            XTB.TabIndex = 4;
            XTB.TextChanged += XTB_TextChanged;
            XTB.Leave += XTB_Leave;
            // 
            // IDTB
            // 
            IDTB.Location = new Point(73, 252);
            IDTB.Name = "IDTB";
            IDTB.ReadOnly = true;
            IDTB.Size = new Size(156, 23);
            IDTB.TabIndex = 3;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(19, 32);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(210, 154);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(657, 433);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
            RectangleTabPage.ResumeLayout(false);
            RectangleTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        public ListBox RectanglesLB;
        public TextBox ColorTextBox;
        public TextBox WidthTextBox;
        public TextBox LenghtTextBox;
        private GroupBox groupBox2;
        private Button FindMovButton;
        private Label label6;
        private Label label7;
        private Label label9;
        public TextBox RatingTB;
        public TextBox YearTB;
        public TextBox TittleTB;
        public ListBox MoviesListBox;
        private Label label10;
        public TextBox CenterYTextBox;
        public TextBox CenterXTextBox;
        public TextBox IDTextBox;
        private Label label11;
        private TabPage RectangleTabPage;
        private Panel RectanglePanel;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label16;
        private Label label17;
        public ListBox RectanglesListBox;
        public TextBox WidthTB;
        public TextBox HeightTB;
        public TextBox YTB;
        public TextBox XTB;
        public TextBox IDTB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}