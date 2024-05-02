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
            pictureBox2.Location = new Point(184, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Image = Properties.Resources._3jMsISjGmMw;
            pictureBox1.InitialImage = Properties.Resources._3jMsISjGmMw;
            pictureBox1.Location = new Point(113, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(70, 56);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 29;
            label17.Text = "Rectangle:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(63, 416);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 28;
            label16.Text = "Width:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 387);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 27;
            label15.Text = "Height:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(86, 358);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 26;
            label14.Text = "Y:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(86, 329);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 25;
            label13.Text = "X:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(86, 300);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 24;
            label12.Text = "ID:";
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(275, 77);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(406, 363);
            RectanglePanel.TabIndex = 23;
            // 
            // WidthTB
            // 
            WidthTB.Location = new Point(113, 413);
            WidthTB.Name = "WidthTB";
            WidthTB.Size = new Size(156, 23);
            WidthTB.TabIndex = 22;
            // 
            // HeightTB
            // 
            HeightTB.Location = new Point(113, 384);
            HeightTB.Name = "HeightTB";
            HeightTB.Size = new Size(156, 23);
            HeightTB.TabIndex = 21;
            // 
            // YTB
            // 
            YTB.Location = new Point(113, 355);
            YTB.Name = "YTB";
            YTB.Size = new Size(156, 23);
            YTB.TabIndex = 20;
            // 
            // XTB
            // 
            XTB.Location = new Point(113, 326);
            XTB.Name = "XTB";
            XTB.Size = new Size(156, 23);
            XTB.TabIndex = 19;
            // 
            // IDTB
            // 
            IDTB.Location = new Point(113, 297);
            IDTB.Name = "IDTB";
            IDTB.ReadOnly = true;
            IDTB.Size = new Size(156, 23);
            IDTB.TabIndex = 18;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(59, 77);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(210, 154);
            RectanglesListBox.TabIndex = 17;
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
            Size = new Size(740, 496);
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
