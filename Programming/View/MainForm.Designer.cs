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
            EnumTabPage = new TabPage();
            IntEnumsIndex = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            EnumTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumTabPage
            // 
            EnumTabPage.Controls.Add(IntEnumsIndex);
            EnumTabPage.Controls.Add(ValuesListBox);
            EnumTabPage.Controls.Add(EnumsListBox);
            EnumTabPage.Location = new Point(4, 24);
            EnumTabPage.Name = "EnumTabPage";
            EnumTabPage.Padding = new Padding(3);
            EnumTabPage.Size = new Size(792, 422);
            EnumTabPage.TabIndex = 0;
            EnumTabPage.Text = "Enums";
            EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // IntEnumsIndex
            // 
            IntEnumsIndex.Location = new Point(337, 32);
            IntEnumsIndex.Name = "IntEnumsIndex";
            IntEnumsIndex.Size = new Size(145, 23);
            IntEnumsIndex.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(174, 32);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(135, 229);
            ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Genre", "Season", "StudyForm", "Weekday", "Manufacturers" });
            EnumsListBox.Location = new Point(8, 32);
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
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            EnumTabPage.ResumeLayout(false);
            EnumTabPage.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage EnumTabPage;
        private TextBox IntEnumsIndex;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabControl tabControl1;
    }
}