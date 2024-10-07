namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ItemsTabs = new View.Panels.ItemsTabs();
            CustomersPage = new TabPage();
            customersTab1 = new View.Panels.CustomersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            CustomersPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(CustomersPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(705, 507);
            tabControl1.TabIndex = 0;
            tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTabs);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(697, 479);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.UseWaitCursor = true;
            // 
            // ItemsTabs
            // 
            ItemsTabs.Dock = DockStyle.Fill;
            ItemsTabs.Location = new Point(3, 3);
            ItemsTabs.Name = "ItemsTabs";
            ItemsTabs.Size = new Size(691, 473);
            ItemsTabs.TabIndex = 0;
            ItemsTabs.UseWaitCursor = true;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(customersTab1);
            CustomersPage.Location = new Point(4, 24);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(697, 479);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            CustomersPage.UseWaitCursor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(691, 473);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 507);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            UseWaitCursor = true;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private View.Panels.ItemsTabs ItemsTabs;
        private TabPage CustomersPage;
        private View.Panels.CustomersTab customersTab1;
    }
}