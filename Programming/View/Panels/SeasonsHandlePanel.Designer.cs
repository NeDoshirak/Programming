namespace Programming.View.Panels
{
    partial class SeasonsHandlePanel
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
            label5 = new Label();
            SeasonResultLable = new Label();
            SeasonResulrButton = new Button();
            SeasonsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 2);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 16;
            label5.Text = "Choose season:";
            // 
            // SeasonResultLable
            // 
            SeasonResultLable.AutoSize = true;
            SeasonResultLable.Location = new Point(22, 46);
            SeasonResultLable.Name = "SeasonResultLable";
            SeasonResultLable.Size = new Size(72, 15);
            SeasonResultLable.TabIndex = 15;
            SeasonResultLable.Text = "И этот тоже";
            SeasonResultLable.Visible = false;
            // 
            // SeasonResulrButton
            // 
            SeasonResulrButton.Location = new Point(132, 20);
            SeasonResulrButton.Name = "SeasonResulrButton";
            SeasonResulrButton.Size = new Size(84, 23);
            SeasonResulrButton.TabIndex = 14;
            SeasonResulrButton.Text = "Go!";
            SeasonResulrButton.UseVisualStyleBackColor = true;
            SeasonResulrButton.Click += SeasonResulrButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.AccessibleRole = AccessibleRole.MenuBar;
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Location = new Point(2, 20);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(124, 23);
            SeasonsComboBox.TabIndex = 13;
            // 
            // SeasonsHandlePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(SeasonResultLable);
            Controls.Add(SeasonResulrButton);
            Controls.Add(SeasonsComboBox);
            Name = "SeasonsHandlePanel";
            Size = new Size(220, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        public Label SeasonResultLable;
        private Button SeasonResulrButton;
        private ComboBox SeasonsComboBox;
    }
}
