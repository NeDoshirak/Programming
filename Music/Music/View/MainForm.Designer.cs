using System;
using System.Windows.Forms;

namespace Music
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            songControl1 = new SongControl();
            SuspendLayout();
            // 
            // songControl1
            // 
            songControl1.Dock = DockStyle.Fill;
            songControl1.Location = new Point(0, 0);
            songControl1.Name = "songControl1";
            songControl1.Size = new Size(466, 354);
            songControl1.TabIndex = 0;
            songControl1.Load += songControl1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 354);
            Controls.Add(songControl1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private SongControl songControl1;
    }
}