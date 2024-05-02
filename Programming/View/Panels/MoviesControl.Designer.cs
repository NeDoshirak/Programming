namespace Programming.View.Panels
{
    partial class MoviesControl
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
            FindMovButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            RatingTB = new TextBox();
            YearTB = new TextBox();
            TittleTB = new TextBox();
            MoviesListBox = new ListBox();
            SuspendLayout();
            // 
            // FindMovButton
            // 
            FindMovButton.Location = new Point(165, 224);
            FindMovButton.Name = "FindMovButton";
            FindMovButton.Size = new Size(130, 23);
            FindMovButton.TabIndex = 16;
            FindMovButton.Text = "Find";
            FindMovButton.UseVisualStyleBackColor = true;
            FindMovButton.Click += FindMovButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 91);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 15;
            label6.Text = "Rating:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 47);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(165, 3);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 13;
            label9.Text = "Title:";
            // 
            // RatingTB
            // 
            RatingTB.Location = new Point(165, 109);
            RatingTB.Name = "RatingTB";
            RatingTB.Size = new Size(130, 23);
            RatingTB.TabIndex = 12;
            RatingTB.TextChanged += RatingTB_TextChanged;
            // 
            // YearTB
            // 
            YearTB.Location = new Point(165, 65);
            YearTB.Name = "YearTB";
            YearTB.Size = new Size(130, 23);
            YearTB.TabIndex = 11;
            YearTB.TextChanged += YearTB_TextChanged;
            // 
            // TittleTB
            // 
            TittleTB.Location = new Point(165, 21);
            TittleTB.Name = "TittleTB";
            TittleTB.Size = new Size(130, 23);
            TittleTB.TabIndex = 10;
            TittleTB.TextChanged += TittleTB_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(3, 3);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(156, 244);
            MoviesListBox.TabIndex = 9;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FindMovButton);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(RatingTB);
            Controls.Add(YearTB);
            Controls.Add(TittleTB);
            Controls.Add(MoviesListBox);
            Name = "MoviesControl";
            Size = new Size(299, 252);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
