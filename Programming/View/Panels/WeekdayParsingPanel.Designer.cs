namespace Programming.View.Panels
{
    partial class WeekdayParsingPanel
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
            WeekdayResultLable = new Label();
            ParseButton = new Button();
            label4 = new Label();
            ParsingListBox = new TextBox();
            SuspendLayout();
            // 
            // WeekdayResultLable
            // 
            WeekdayResultLable.AutoSize = true;
            WeekdayResultLable.Location = new Point(24, 46);
            WeekdayResultLable.Name = "WeekdayResultLable";
            WeekdayResultLable.Size = new Size(114, 15);
            WeekdayResultLable.TabIndex = 14;
            WeekdayResultLable.Text = "Этот текст не видно";
            WeekdayResultLable.Visible = false;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(187, 20);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(84, 23);
            ParseButton.TabIndex = 13;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 2);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 12;
            label4.Text = "Type value for parsing:";
            // 
            // ParsingListBox
            // 
            ParsingListBox.Location = new Point(3, 20);
            ParsingListBox.Name = "ParsingListBox";
            ParsingListBox.ScrollBars = ScrollBars.Both;
            ParsingListBox.Size = new Size(178, 23);
            ParsingListBox.TabIndex = 11;
            // 
            // WeekdayParsingPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayResultLable);
            Controls.Add(ParseButton);
            Controls.Add(label4);
            Controls.Add(ParsingListBox);
            Name = "WeekdayParsingPanel";
            Size = new Size(276, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label WeekdayResultLable;
        private Button ParseButton;
        private Label label4;
        public TextBox ParsingListBox;
    }
}
