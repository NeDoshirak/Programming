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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            IntEnumsIndex = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            groupBox2 = new GroupBox();
            EnumTabPage.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumTabPage
            // 
            EnumTabPage.Controls.Add(groupBox2);
            EnumTabPage.Controls.Add(groupBox1);
            EnumTabPage.Location = new Point(4, 24);
            EnumTabPage.Name = "EnumTabPage";
            EnumTabPage.Padding = new Padding(3);
            EnumTabPage.Size = new Size(624, 460);
            EnumTabPage.TabIndex = 0;
            EnumTabPage.Text = "Enums";
            EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(IntEnumsIndex);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Location = new Point(4, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 275);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumarations";
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
            tabControl1.Size = new Size(632, 488);
            tabControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(10, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 170);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 488);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            EnumTabPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}