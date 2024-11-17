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
            CartListBox = new ListBox();
            AmouthLabel = new Label();
            label4 = new Label();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            CreateButton = new Button();
            label3 = new Label();
            CustomersComboBox = new ComboBox();
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
            splitContainer1.Panel1.Controls.Add(AddToCartButton);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CartListBox);
            splitContainer1.Panel2.Controls.Add(AmouthLabel);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(RemoveItemButton);
            splitContainer1.Panel2.Controls.Add(ClearCartButton);
            splitContainer1.Panel2.Controls.Add(CreateButton);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(CustomersComboBox);
            splitContainer1.Panel2.Controls.Add(label2);
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
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(14, 69);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(484, 199);
            CartListBox.TabIndex = 11;
            // 
            // AmouthLabel
            // 
            AmouthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmouthLabel.AutoSize = true;
            AmouthLabel.Location = new Point(397, 296);
            AmouthLabel.Name = "AmouthLabel";
            AmouthLabel.Size = new Size(22, 15);
            AmouthLabel.TabIndex = 10;
            AmouthLabel.Text = "0.0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(397, 271);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Amouth:";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(290, 326);
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
            ClearCartButton.Location = new Point(397, 326);
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
            CreateButton.Location = new Point(14, 326);
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
    }
}
