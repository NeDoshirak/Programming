namespace Programming.View.Panels
{
    partial class EnumerationsPanel
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            IntEnumsIndex = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 5);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Int value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 6);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 11;
            label2.Text = "Choose enumiration:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 6);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 10;
            label1.Text = "Choose value:";
            // 
            // IntEnumsIndex
            // 
            IntEnumsIndex.Location = new Point(312, 24);
            IntEnumsIndex.Name = "IntEnumsIndex";
            IntEnumsIndex.ReadOnly = true;
            IntEnumsIndex.Size = new Size(145, 23);
            IntEnumsIndex.TabIndex = 9;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(171, 24);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(135, 229);
            ValuesListBox.TabIndex = 8;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Genre", "Season", "StudyForm", "Weekday", "Manufacturers" });
            EnumsListBox.Location = new Point(5, 24);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(135, 229);
            EnumsListBox.TabIndex = 7;
            EnumsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // EnumerationsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IntEnumsIndex);
            Controls.Add(ValuesListBox);
            Controls.Add(EnumsListBox);
            Name = "EnumerationsPanel";
            Size = new Size(464, 263);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox IntEnumsIndex;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
