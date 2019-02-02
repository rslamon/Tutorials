namespace HamburgerControls
{
    partial class Form1
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
            this.lblList = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foodListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburger200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drink100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(140, 105);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(23, 13);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "List";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(130, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foodListToolStripMenuItem
            // 
            this.foodListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburger200ToolStripMenuItem,
            this.friesToolStripMenuItem,
            this.drink100ToolStripMenuItem});
            this.foodListToolStripMenuItem.Name = "foodListToolStripMenuItem";
            this.foodListToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.foodListToolStripMenuItem.Text = "Food Choice";
            this.foodListToolStripMenuItem.Click += new System.EventHandler(this.foodListToolStripMenuItem_Click);
            // 
            // hamburger200ToolStripMenuItem
            // 
            this.hamburger200ToolStripMenuItem.Name = "hamburger200ToolStripMenuItem";
            this.hamburger200ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hamburger200ToolStripMenuItem.Text = "Hamburger - $2.00";
            this.hamburger200ToolStripMenuItem.Click += new System.EventHandler(this.hamburger200ToolStripMenuItem_Click);
            // 
            // friesToolStripMenuItem
            // 
            this.friesToolStripMenuItem.Name = "friesToolStripMenuItem";
            this.friesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.friesToolStripMenuItem.Text = "Fries = $ 1.50";
            this.friesToolStripMenuItem.Click += new System.EventHandler(this.friesToolStripMenuItem_Click);
            // 
            // drink100ToolStripMenuItem
            // 
            this.drink100ToolStripMenuItem.Name = "drink100ToolStripMenuItem";
            this.drink100ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drink100ToolStripMenuItem.Text = "Drink = $1.00";
            this.drink100ToolStripMenuItem.Click += new System.EventHandler(this.drink100ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Food";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foodListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburger200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drink100ToolStripMenuItem;
    }
}

