namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            SuspendLayout();
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(166, 204);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(62, 23);
            IDTextBox.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(166, 186);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 25;
            label11.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(166, 142);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 23;
            label10.Text = "Center:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(234, 160);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(62, 23);
            CenterYTextBox.TabIndex = 22;
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(166, 160);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(62, 23);
            CenterXTextBox.TabIndex = 21;
            // 
            // FindRecButton
            // 
            FindRecButton.Location = new Point(166, 233);
            FindRecButton.Name = "FindRecButton";
            FindRecButton.Size = new Size(130, 23);
            FindRecButton.TabIndex = 20;
            FindRecButton.Text = "Find";
            FindRecButton.UseVisualStyleBackColor = true;
            FindRecButton.Click += FindButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 98);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 19;
            label8.Text = "Color:";
            // 
            // lable3241
            // 
            lable3241.AutoSize = true;
            lable3241.Location = new Point(166, 54);
            lable3241.Name = "lable3241";
            lable3241.Size = new Size(42, 15);
            lable3241.TabIndex = 18;
            lable3241.Text = "Width:";
            // 
            // lable7
            // 
            lable7.AutoSize = true;
            lable7.Location = new Point(166, 10);
            lable7.Name = "lable7";
            lable7.Size = new Size(47, 15);
            lable7.TabIndex = 17;
            lable7.Text = "Lenght:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(166, 116);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(130, 23);
            ColorTextBox.TabIndex = 16;
            ColorTextBox.TextChanged += ColorTB_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(166, 72);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(130, 23);
            WidthTextBox.TabIndex = 15;
            WidthTextBox.TextChanged += WidhtTB_TextChanged;
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(166, 28);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(130, 23);
            LenghtTextBox.TabIndex = 14;
            LenghtTextBox.TextChanged += LenghtTB_TextChanged;
            // 
            // RectanglesLB
            // 
            RectanglesLB.FormattingEnabled = true;
            RectanglesLB.ItemHeight = 15;
            RectanglesLB.Items.AddRange(new object[] { "Rectangles 1", "Rectangles 2", "Rectangles 3", "Rectangles 4", "Rectangles 5" });
            RectanglesLB.Location = new Point(4, 10);
            RectanglesLB.Name = "RectanglesLB";
            RectanglesLB.Size = new Size(156, 244);
            RectanglesLB.TabIndex = 13;
            RectanglesLB.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IDTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(CenterYTextBox);
            Controls.Add(CenterXTextBox);
            Controls.Add(FindRecButton);
            Controls.Add(label8);
            Controls.Add(lable3241);
            Controls.Add(lable7);
            Controls.Add(ColorTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(LenghtTextBox);
            Controls.Add(RectanglesLB);
            Name = "RectanglesControl";
            Size = new Size(298, 260);
            Enter += RectanglesControl_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox IDTextBox;
        private Label label11;
        private Label label10;
        public TextBox CenterYTextBox;
        public TextBox CenterXTextBox;
        private Button FindRecButton;
        private Label label8;
        private Label lable3241;
        private Label lable7;
        public TextBox ColorTextBox;
        public TextBox WidthTextBox;
        public TextBox LenghtTextBox;
        public ListBox RectanglesLB;
    }
}
