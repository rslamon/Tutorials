namespace Hamburger
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
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkDrink = new System.Windows.Forms.CheckBox();
            this.grpDessert = new System.Windows.Forms.GroupBox();
            this.rdCake = new System.Windows.Forms.RadioButton();
            this.rdIce = new System.Windows.Forms.RadioButton();
            this.lblCalc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDessert.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Checked = true;
            this.chkHamburger.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.Location = new System.Drawing.Point(180, 70);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(104, 20);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Checked = true;
            this.chkFries.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFries.Location = new System.Drawing.Point(180, 107);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(62, 20);
            this.chkFries.TabIndex = 1;
            this.chkFries.Text = "Fries";
            this.chkFries.UseVisualStyleBackColor = true;
            // 
            // chkDrink
            // 
            this.chkDrink.AutoSize = true;
            this.chkDrink.Checked = true;
            this.chkDrink.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrink.Location = new System.Drawing.Point(180, 146);
            this.chkDrink.Name = "chkDrink";
            this.chkDrink.Size = new System.Drawing.Size(63, 20);
            this.chkDrink.TabIndex = 2;
            this.chkDrink.Text = "Drink";
            this.chkDrink.UseVisualStyleBackColor = true;
            // 
            // grpDessert
            // 
            this.grpDessert.Controls.Add(this.rdIce);
            this.grpDessert.Controls.Add(this.rdCake);
            this.grpDessert.Location = new System.Drawing.Point(397, 70);
            this.grpDessert.Name = "grpDessert";
            this.grpDessert.Size = new System.Drawing.Size(200, 100);
            this.grpDessert.TabIndex = 3;
            this.grpDessert.TabStop = false;
            this.grpDessert.Text = "Dessert (No charge)";
            // 
            // rdCake
            // 
            this.rdCake.AutoSize = true;
            this.rdCake.Location = new System.Drawing.Point(6, 19);
            this.rdCake.Name = "rdCake";
            this.rdCake.Size = new System.Drawing.Size(50, 17);
            this.rdCake.TabIndex = 0;
            this.rdCake.TabStop = true;
            this.rdCake.Text = "Cake";
            this.rdCake.UseVisualStyleBackColor = true;
            // 
            // rdIce
            // 
            this.rdIce.AutoSize = true;
            this.rdIce.Location = new System.Drawing.Point(7, 43);
            this.rdIce.Name = "rdIce";
            this.rdIce.Size = new System.Drawing.Size(73, 17);
            this.rdIce.TabIndex = 1;
            this.rdIce.TabStop = true;
            this.rdIce.Text = "Ice Cream";
            this.rdIce.UseVisualStyleBackColor = true;
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(339, 318);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(0, 13);
            this.lblCalc.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.grpDessert);
            this.Controls.Add(this.chkDrink);
            this.Controls.Add(this.chkFries);
            this.Controls.Add(this.chkHamburger);
            this.Name = "Form1";
            this.Text = "Lunch Menu";
            this.grpDessert.ResumeLayout(false);
            this.grpDessert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkDrink;
        private System.Windows.Forms.GroupBox grpDessert;
        private System.Windows.Forms.RadioButton rdIce;
        private System.Windows.Forms.RadioButton rdCake;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Button button1;
    }
}

