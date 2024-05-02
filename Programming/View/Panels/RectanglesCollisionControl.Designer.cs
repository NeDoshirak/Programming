using System.Windows.Forms;

namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            RectanglePanel = new Panel();
            WidthTB = new TextBox();
            HeightTB = new TextBox();
            YTB = new TextBox();
            XTB = new TextBox();
            IDTB = new TextBox();
            RectanglesListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(135, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Image = Properties.Resources._3jMsISjGmMw;
            pictureBox1.InitialImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Location = new Point(64, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseEnter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 6);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 29;
            label17.Text = "Rectangle:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 366);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 28;
            label16.Text = "Width:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 337);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 27;
            label15.Text = "Height:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 308);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 26;
            label14.Text = "Y:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 279);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 25;
            label13.Text = "X:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 250);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 24;
            label12.Text = "ID:";
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(226, 27);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(406, 363);
            RectanglePanel.TabIndex = 23;
            // 
            // WidthTB
            // 
            WidthTB.Location = new Point(64, 363);
            WidthTB.Name = "WidthTB";
            WidthTB.Size = new Size(156, 23);
            WidthTB.TabIndex = 22;
            WidthTB.TextChanged += WidthTB_TextChanged;
            WidthTB.Leave += WidthTB_Leave;
            // 
            // HeightTB
            // 
            HeightTB.Location = new Point(64, 334);
            HeightTB.Name = "HeightTB";
            HeightTB.Size = new Size(156, 23);
            HeightTB.TabIndex = 21;
            HeightTB.TextChanged += HeightTB_TextChanged;
            HeightTB.Leave += HeightTB_Leave;
            // 
            // YTB
            // 
            YTB.Location = new Point(64, 305);
            YTB.Name = "YTB";
            YTB.Size = new Size(156, 23);
            YTB.TabIndex = 20;
            YTB.TextChanged += YTB_TextChanged;
            YTB.Leave += YTB_Leave;
            // 
            // XTB
            // 
            XTB.Location = new Point(64, 276);
            XTB.Name = "XTB";
            XTB.Size = new Size(156, 23);
            XTB.TabIndex = 19;
            XTB.TextChanged += XTB_TextChanged;
            XTB.Leave += XTB_Leave;
            // 
            // IDTB
            // 
            IDTB.Location = new Point(64, 247);
            IDTB.Name = "IDTB";
            IDTB.ReadOnly = true;
            IDTB.Size = new Size(156, 23);
            IDTB.TabIndex = 18;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(10, 27);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(210, 154);
            RectanglesListBox.TabIndex = 17;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged_1;
            // 
            // RectanglesCollisionControl
            // 
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(RectanglePanel);
            Controls.Add(WidthTB);
            Controls.Add(HeightTB);
            Controls.Add(YTB);
            Controls.Add(XTB);
            Controls.Add(IDTB);
            Controls.Add(RectanglesListBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(640, 401);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Panel RectanglePanel;
        public TextBox WidthTB;
        public TextBox HeightTB;
        public TextBox YTB;
        public TextBox XTB;
        public TextBox IDTB;
        public ListBox RectanglesListBox;
    }
}
