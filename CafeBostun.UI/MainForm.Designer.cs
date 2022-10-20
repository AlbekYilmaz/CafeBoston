﻿namespace CafeBostun.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwTables = new System.Windows.Forms.ListView();
            this.imlTables = new System.Windows.Forms.ImageList(this.components);
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProducts,
            this.tsmiOrderHistory});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(791, 28);
            this.msTop.TabIndex = 3;
            this.msTop.Text = "menuStrip1";
            this.msTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiProducts
            // 
            this.tsmiProducts.Name = "tsmiProducts";
            this.tsmiProducts.Size = new System.Drawing.Size(80, 24);
            this.tsmiProducts.Text = "Products";
            this.tsmiProducts.Click += new System.EventHandler(this.tsmiProducts_Click);
            // 
            // tsmiOrderHistory
            // 
            this.tsmiOrderHistory.Name = "tsmiOrderHistory";
            this.tsmiOrderHistory.Size = new System.Drawing.Size(112, 24);
            this.tsmiOrderHistory.Text = "Order History";
            this.tsmiOrderHistory.Click += new System.EventHandler(this.tsmiOrderHistory_Click);
            // 
            // lvwTables
            // 
            this.lvwTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTables.LargeImageList = this.imlTables;
            this.lvwTables.Location = new System.Drawing.Point(0, 28);
            this.lvwTables.Name = "lvwTables";
            this.lvwTables.Size = new System.Drawing.Size(791, 459);
            this.lvwTables.TabIndex = 4;
            this.lvwTables.UseCompatibleStateImageBehavior = false;
            this.lvwTables.SelectedIndexChanged += new System.EventHandler(this.lvwTables_SelectedIndexChanged);
            this.lvwTables.DoubleClick += new System.EventHandler(this.lvwTables_DoubleClick);
            // 
            // imlTables
            // 
            this.imlTables.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTables.ImageStream")));
            this.imlTables.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTables.Images.SetKeyName(0, "empty");
            this.imlTables.Images.SetKeyName(1, "full");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 487);
            this.Controls.Add(this.lvwTables);
            this.Controls.Add(this.msTop);
            this.MainMenuStrip = this.msTop;
            this.Name = "MainForm";
            this.Text = "CafeBoston";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip msTop;
        private ToolStripMenuItem tsmiProducts;
        private ToolStripMenuItem tsmiOrderHistory;
        private ListView lvwTables;
        private ImageList imlTables;
    }
}