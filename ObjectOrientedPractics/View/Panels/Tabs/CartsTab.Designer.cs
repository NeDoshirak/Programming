namespace ObjectOrientedPractics.View.Panels
{
    partial class CartsTab
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
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            DiscountAmountLabel = new Label();
            TotalLabel = new Label();
            label13 = new Label();
            label11 = new Label();
            label5 = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            CartListBox = new ListBox();
            AmouthLabel = new Label();
            label4 = new Label();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            CreateButton = new Button();
            label3 = new Label();
            CustomersComboBox = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            listBox2 = new ListBox();
            label6 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
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
            splitContainer1.Panel1.Controls.Add(AddToCartButton);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DiscountAmountLabel);
            splitContainer1.Panel2.Controls.Add(TotalLabel);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(DiscountsCheckedListBox);
            splitContainer1.Panel2.Controls.Add(CartListBox);
            splitContainer1.Panel2.Controls.Add(AmouthLabel);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(RemoveItemButton);
            splitContainer1.Panel2.Controls.Add(ClearCartButton);
            splitContainer1.Panel2.Controls.Add(CreateButton);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(CustomersComboBox);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(listBox2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Size = new Size(766, 531);
            splitContainer1.SplitterDistance = 244;
            splitContainer1.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(5, 476);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(101, 42);
            AddToCartButton.TabIndex = 5;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 28);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(222, 439);
            ItemsListBox.TabIndex = 4;
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
            RemoveButton.Location = new Point(112, 904);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(101, 42);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(5, 904);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(101, 42);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Location = new Point(397, 362);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(13, 15);
            DiscountAmountLabel.TabIndex = 18;
            DiscountAmountLabel.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom;
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(397, 477);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(13, 15);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "0";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Location = new Point(397, 462);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 16;
            label13.Text = "Total";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Location = new Point(397, 344);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 14;
            label11.Text = "DiscountAmount";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(14, 344);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 13;
            label5.Text = "Discounts";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(14, 362);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(120, 94);
            DiscountsCheckedListBox.TabIndex = 12;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(14, 69);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(484, 154);
            CartListBox.TabIndex = 11;
            // 
            // AmouthLabel
            // 
            AmouthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmouthLabel.AutoSize = true;
            AmouthLabel.Location = new Point(397, 256);
            AmouthLabel.Name = "AmouthLabel";
            AmouthLabel.Size = new Size(22, 15);
            AmouthLabel.TabIndex = 10;
            AmouthLabel.Text = "0.0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(397, 231);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Amouth:";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(290, 286);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(101, 42);
            RemoveItemButton.TabIndex = 8;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(397, 286);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(101, 42);
            ClearCartButton.TabIndex = 7;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateButton.Location = new Point(14, 286);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(101, 42);
            CreateButton.TabIndex = 6;
            CreateButton.Text = "Create Order";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 51);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(79, 10);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(249, 23);
            CustomersComboBox.TabIndex = 1;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Customer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 344);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label5";
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(14, 69);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(484, 154);
            listBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(397, 256);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 10;
            label6.Text = "0.0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(397, 231);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 9;
            label8.Text = "Amouth:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(290, 286);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 8;
            button1.Text = "Remove Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RemoveItemButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(397, 286);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 7;
            button2.Text = "Clear Cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClearCartButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(14, 286);
            button3.Name = "button3";
            button3.Size = new Size(101, 42);
            button3.TabIndex = 6;
            button3.Text = "Create Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 51);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 2;
            label9.Text = "Cart:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 10);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 0;
            label10.Text = "Customer";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
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
        private Label label1;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Button CreateButton;
        private ListBox listBox1;
        private Label label3;
        private ComboBox CustomersComboBox;
        private Label AmouthLabel;
        private Label label4;
        public Label label2;
        private ListBox CartListBox;
        private Label label5;
        private CheckedListBox DiscountsCheckedListBox;
        private Label label7;
        private ListBox listBox2;
        private Label label6;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label9;
        private ComboBox comboBox1;
        public Label label10;
        private Label TotalLabel;
        private Label label13;
        private Label label11;
        private Label DiscountAmountLabel;
    }
}
