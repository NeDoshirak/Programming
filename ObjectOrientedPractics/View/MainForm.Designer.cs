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
            CustomersTab = new View.Panels.CustomersTab();
            CartsTabPage = new TabPage();
            CartTab = new View.Panels.CartsTab();
            tabPage2 = new TabPage();
            OrdersTab = new View.Panels.OrdersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            CustomersPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(CustomersPage);
            tabControl1.Controls.Add(CartsTabPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 610);
            tabControl1.TabIndex = 0;
            tabControl1.UseWaitCursor = true;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTabs);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(949, 582);
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
            ItemsTabs.Size = new Size(943, 576);
            ItemsTabs.TabIndex = 0;
            ItemsTabs.UseWaitCursor = true;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(4, 24);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(949, 582);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            CustomersPage.UseWaitCursor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(943, 576);
            CustomersTab.TabIndex = 0;
            CustomersTab.UseWaitCursor = true;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartTab);
            CartsTabPage.Location = new Point(4, 24);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(949, 582);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            CartsTabPage.UseWaitCursor = true;
            // 
            // CartTab
            // 
            CartTab.Dock = DockStyle.Fill;
            CartTab.Location = new Point(3, 3);
            CartTab.Name = "CartTab";
            CartTab.Size = new Size(943, 576);
            CartTab.TabIndex = 0;
            CartTab.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(OrdersTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(949, 582);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.UseWaitCursor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Margin = new Padding(4, 3, 4, 3);
            OrdersTab.MinimumSize = new Size(700, 540);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(943, 576);
            OrdersTab.TabIndex = 0;
            OrdersTab.UseWaitCursor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 610);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(973, 649);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            UseWaitCursor = true;
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private View.Panels.ItemsTabs ItemsTabs;
        private TabPage CustomersPage;
        private View.Panels.CustomersTab CustomersTab;
        private TabPage CartsTabPage;
        private View.Panels.CartsTab CartTab;
        private TabPage tabPage2;
        private View.Panels.OrdersTab OrdersTab;
    }
}