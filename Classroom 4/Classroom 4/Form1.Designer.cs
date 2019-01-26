namespace Classroom_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.chkAir = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCalc = new System.Windows.Forms.Label();
            this.rdPersonal = new System.Windows.Forms.RadioButton();
            this.rdBusiness = new System.Windows.Forms.RadioButton();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdWhite = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpType.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose from the following options:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkWindow
            // 
            this.chkWindow.AutoSize = true;
            this.chkWindow.Checked = true;
            this.chkWindow.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWindow.Location = new System.Drawing.Point(195, 100);
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.Size = new System.Drawing.Size(136, 20);
            this.chkWindow.TabIndex = 2;
            this.chkWindow.Text = "Power Windows";
            this.chkWindow.UseVisualStyleBackColor = true;
            // 
            // chkAir
            // 
            this.chkAir.AutoSize = true;
            this.chkAir.Checked = true;
            this.chkAir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAir.Location = new System.Drawing.Point(195, 135);
            this.chkAir.Name = "chkAir";
            this.chkAir.Size = new System.Drawing.Size(136, 20);
            this.chkAir.TabIndex = 3;
            this.chkAir.Text = "Air Conditioning";
            this.chkAir.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Checked = true;
            this.chkChrome.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChrome.Location = new System.Drawing.Point(195, 161);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(80, 20);
            this.chkChrome.TabIndex = 4;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            this.chkChrome.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(292, 279);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(95, 64);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "&Calculate\r\n Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(289, 330);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(0, 13);
            this.lblCalc.TabIndex = 5;
            // 
            // rdPersonal
            // 
            this.rdPersonal.AutoSize = true;
            this.rdPersonal.Checked = true;
            this.rdPersonal.Location = new System.Drawing.Point(6, 19);
            this.rdPersonal.Name = "rdPersonal";
            this.rdPersonal.Size = new System.Drawing.Size(66, 17);
            this.rdPersonal.TabIndex = 5;
            this.rdPersonal.TabStop = true;
            this.rdPersonal.Text = "Personal";
            this.rdPersonal.UseVisualStyleBackColor = true;
            // 
            // rdBusiness
            // 
            this.rdBusiness.AutoSize = true;
            this.rdBusiness.Location = new System.Drawing.Point(5, 42);
            this.rdBusiness.Name = "rdBusiness";
            this.rdBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdBusiness.TabIndex = 6;
            this.rdBusiness.Text = "Business";
            this.rdBusiness.UseVisualStyleBackColor = true;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdPersonal);
            this.grpType.Controls.Add(this.rdBusiness);
            this.grpType.Location = new System.Drawing.Point(365, 100);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(89, 100);
            this.grpType.TabIndex = 8;
            this.grpType.TabStop = false;
            this.grpType.Text = "Account Type";
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.rdWhite);
            this.grpColor.Controls.Add(this.rdBlue);
            this.grpColor.Location = new System.Drawing.Point(523, 100);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(113, 100);
            this.grpColor.TabIndex = 9;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(6, 19);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(46, 17);
            this.rdBlue.TabIndex = 7;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            // 
            // rdWhite
            // 
            this.rdWhite.AutoSize = true;
            this.rdWhite.Location = new System.Drawing.Point(6, 42);
            this.rdWhite.Name = "rdWhite";
            this.rdWhite.Size = new System.Drawing.Size(53, 17);
            this.rdWhite.TabIndex = 8;
            this.rdWhite.TabStop = true;
            this.rdWhite.Text = "White";
            this.rdWhite.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(368, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(423, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkAir);
            this.Controls.Add(this.chkWindow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "New Car Sales";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkWindow;
        private System.Windows.Forms.CheckBox chkAir;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.RadioButton rdPersonal;
        private System.Windows.Forms.RadioButton rdBusiness;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton rdWhite;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

