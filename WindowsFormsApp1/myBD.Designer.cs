﻿namespace WindowsFormsApp1
{
    partial class myBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myBD));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБазиДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.акарологіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дослідженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дослідникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБазиДанихToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБазиДанихToolStripMenuItem
            // 
            this.таблиціБазиДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.акарологіяToolStripMenuItem,
            this.дослідженняToolStripMenuItem,
            this.дослідникToolStripMenuItem});
            this.таблиціБазиДанихToolStripMenuItem.Name = "таблиціБазиДанихToolStripMenuItem";
            this.таблиціБазиДанихToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.таблиціБазиДанихToolStripMenuItem.Text = "Таблиці бази даних";
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // акарологіяToolStripMenuItem
            // 
            this.акарологіяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("акарологіяToolStripMenuItem.Image")));
            this.акарологіяToolStripMenuItem.Name = "акарологіяToolStripMenuItem";
            this.акарологіяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.акарологіяToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.акарологіяToolStripMenuItem.Text = "Акарологія";
            this.акарологіяToolStripMenuItem.Click += new System.EventHandler(this.акарологіяToolStripMenuItem_Click);
            // 
            // дослідженняToolStripMenuItem
            // 
            this.дослідженняToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("дослідженняToolStripMenuItem.Image")));
            this.дослідженняToolStripMenuItem.Name = "дослідженняToolStripMenuItem";
            this.дослідженняToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.дослідженняToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.дослідженняToolStripMenuItem.Text = "Дослідження";
            this.дослідженняToolStripMenuItem.Click += new System.EventHandler(this.дослідженняToolStripMenuItem_Click);
            // 
            // дослідникToolStripMenuItem
            // 
            this.дослідникToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("дослідникToolStripMenuItem.Image")));
            this.дослідникToolStripMenuItem.Name = "дослідникToolStripMenuItem";
            this.дослідникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.дослідникToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.дослідникToolStripMenuItem.Text = "Дослідник";
            this.дослідникToolStripMenuItem.Click += new System.EventHandler(this.дослідникToolStripMenuItem_Click);
            // 
            // myBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myBD";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myBD_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБазиДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem акарологіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дослідженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дослідникToolStripMenuItem;
    }
}

