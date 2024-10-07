namespace ObjectOrientedPractics.View.Panels
{
    partial class ItemsTabs
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            CategoryComboBox = new ComboBox();
            label7 = new Label();
            DescriptionTextBox = new TextBox();
            label6 = new Label();
            NameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(AddButton);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CategoryComboBox);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(DescriptionTextBox);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(CostTextBox);
            splitContainer1.Panel2.Controls.Add(IdTextBox);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(766, 531);
            splitContainer1.SplitterDistance = 377;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Items";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(112, 473);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(101, 42);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(5, 473);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(101, 42);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 28);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(360, 439);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(66, 89);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(214, 23);
            CategoryComboBox.TabIndex = 15;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            CategoryComboBox.Enter += CategoryComboBox_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 92);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 14;
            label7.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(3, 269);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(346, 163);
            DescriptionTextBox.TabIndex = 12;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            DescriptionTextBox.Leave += DescriptionTextBox_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 251);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 11;
            label6.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 141);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(346, 96);
            NameTextBox.TabIndex = 10;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 122);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 63);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Cost:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(66, 60);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(214, 23);
            CostTextBox.TabIndex = 7;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            CostTextBox.Leave += CostTextBox_Leave;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(66, 31);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(214, 23);
            IdTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Selected Item";
            // 
            // ItemsTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTabs";
            Size = new Size(766, 531);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label label1;
        private Label label2;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label label3;
        private Label label4;
        private TextBox DescriptionTextBox;
        private Label label6;
        private TextBox NameTextBox;
        private Label label5;
        private ComboBox CategoryComboBox;
        private Label label7;
    }
}
