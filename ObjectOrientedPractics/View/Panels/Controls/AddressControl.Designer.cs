namespace ObjectOrientedPractics.View.Panels
{
    partial class AddressControl
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
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PostIndexTextBox.Location = new Point(82, 35);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(136, 23);
            PostIndexTextBox.TabIndex = 0;
            PostIndexTextBox.KeyPress += PostIndexTextBox_KeyPress;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(82, 64);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(194, 23);
            CountryTextBox.TabIndex = 1;
            CountryTextBox.KeyPress += CountryTextBox_KeyPress;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(82, 93);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(405, 23);
            StreetTextBox.TabIndex = 2;
            StreetTextBox.KeyPress += StreetTextBox_KeyPress;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(82, 122);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(109, 23);
            BuildingTextBox.TabIndex = 3;
            BuildingTextBox.KeyPress += BuildingTextBox_KeyPress;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CityTextBox.Location = new Point(329, 64);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(158, 23);
            CityTextBox.TabIndex = 4;
            CityTextBox.KeyPress += CityTextBox_KeyPress;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(270, 122);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(109, 23);
            ApartmentTextBox.TabIndex = 13;
            ApartmentTextBox.KeyPress += ApartmentTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Post Index:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 101);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Street:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(14, 130);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Building:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(290, 72);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(197, 125);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 11;
            label6.Text = "Apartment:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 11);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 12;
            label7.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ApartmentTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Name = "AddressControl";
            Size = new Size(528, 171);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
