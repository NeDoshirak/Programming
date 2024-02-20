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
            EnumTabPage.SuspendLayout();
            SeasonHandleGB.SuspendLayout();
            WeekdayParsingGB.SuspendLayout();
            EnumarationsrGB.SuspendLayout();
            tabControl1.SuspendLayout();
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
            EnumTabPage.Size = new Size(624, 405);
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
            SeasonHandleGB.Size = new Size(301, 121);
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
            SeasonsComboBox.SelectedIndexChanged += SeasonsComboBox_SelectedIndexChanged;
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
            EnumarationsrGB.Size = new Size(612, 275);
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(632, 433);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(632, 433);
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
    }
}