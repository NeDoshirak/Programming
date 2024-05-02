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
            seasonsHandlePanel1 = new View.Panels.SeasonsHandlePanel();
            WeekdayParsingGB = new GroupBox();
            weekdayParsingPanel1 = new View.Panels.WeekdayParsingPanel();
            EnumarationsrGB = new GroupBox();
            enumerationsPanel1 = new View.Panels.EnumerationsPanel();
            tabControl1 = new TabControl();
            ClassesTabPage = new TabPage();
            groupBox2 = new GroupBox();
            moviesControl1 = new View.Panels.MoviesControl();
            groupBox1 = new GroupBox();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            RectangleTabPage = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            EnumTabPage.SuspendLayout();
            SeasonHandleGB.SuspendLayout();
            WeekdayParsingGB.SuspendLayout();
            EnumarationsrGB.SuspendLayout();
            tabControl1.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            RectangleTabPage.SuspendLayout();
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
            SeasonHandleGB.Controls.Add(seasonsHandlePanel1);
            SeasonHandleGB.Location = new Point(315, 281);
            SeasonHandleGB.Name = "SeasonHandleGB";
            SeasonHandleGB.Size = new Size(326, 121);
            SeasonHandleGB.TabIndex = 9;
            SeasonHandleGB.TabStop = false;
            SeasonHandleGB.Text = "Season Handle";
            // 
            // seasonsHandlePanel1
            // 
            seasonsHandlePanel1.Location = new Point(6, 33);
            seasonsHandlePanel1.Name = "seasonsHandlePanel1";
            seasonsHandlePanel1.Size = new Size(220, 65);
            seasonsHandlePanel1.TabIndex = 0;
            // 
            // WeekdayParsingGB
            // 
            WeekdayParsingGB.Controls.Add(weekdayParsingPanel1);
            WeekdayParsingGB.Location = new Point(4, 281);
            WeekdayParsingGB.Name = "WeekdayParsingGB";
            WeekdayParsingGB.Size = new Size(304, 121);
            WeekdayParsingGB.TabIndex = 8;
            WeekdayParsingGB.TabStop = false;
            WeekdayParsingGB.Text = "Weekday Parsing";
            // 
            // weekdayParsingPanel1
            // 
            weekdayParsingPanel1.Location = new Point(6, 33);
            weekdayParsingPanel1.Name = "weekdayParsingPanel1";
            weekdayParsingPanel1.Size = new Size(276, 67);
            weekdayParsingPanel1.TabIndex = 0;
            // 
            // EnumarationsrGB
            // 
            EnumarationsrGB.Controls.Add(enumerationsPanel1);
            EnumarationsrGB.Location = new Point(4, 6);
            EnumarationsrGB.Name = "EnumarationsrGB";
            EnumarationsrGB.Size = new Size(637, 275);
            EnumarationsrGB.TabIndex = 7;
            EnumarationsrGB.TabStop = false;
            EnumarationsrGB.Text = "Enumarations";
            // 
            // enumerationsPanel1
            // 
            enumerationsPanel1.Location = new Point(6, 12);
            enumerationsPanel1.Name = "enumerationsPanel1";
            enumerationsPanel1.Size = new Size(464, 263);
            enumerationsPanel1.TabIndex = 0;
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(moviesControl1);
            groupBox2.Location = new Point(333, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 325);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movies";
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(5, 21);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(299, 252);
            moviesControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rectanglesControl1);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 325);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(0, 13);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(298, 260);
            rectanglesControl1.TabIndex = 0;
            // 
            // RectangleTabPage
            // 
            RectangleTabPage.Controls.Add(rectanglesCollisionControl1);
            RectangleTabPage.Location = new Point(4, 24);
            RectangleTabPage.Name = "RectangleTabPage";
            RectangleTabPage.Size = new Size(649, 405);
            RectangleTabPage.TabIndex = 2;
            RectangleTabPage.Text = "Rectangle";
            RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(3, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(640, 401);
            rectanglesCollisionControl1.TabIndex = 0;
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
            EnumTabPage.ResumeLayout(false);
            SeasonHandleGB.ResumeLayout(false);
            WeekdayParsingGB.ResumeLayout(false);
            EnumarationsrGB.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            RectangleTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage EnumTabPage;
        private TabControl tabControl1;
        private GroupBox EnumarationsrGB;
        private GroupBox WeekdayParsingGB;
        private GroupBox SeasonHandleGB;
        private TabPage ClassesTabPage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabPage RectangleTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsPanel enumerationsPanel1;
        private View.Panels.WeekdayParsingPanel weekdayParsingPanel1;
        private View.Panels.SeasonsHandlePanel seasonsHandlePanel1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
    }
}