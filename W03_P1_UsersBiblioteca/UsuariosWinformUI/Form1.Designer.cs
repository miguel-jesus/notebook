namespace UsuariosWinformUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iPueblo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iCPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.iEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iLlinatge = new System.Windows.Forms.TextBox();
            this.lLlinatge = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.tNif = new System.Windows.Forms.TextBox();
            this.nif = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iPueblo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.iCPassword);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.iPassword);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.iEmail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.iLlinatge);
            this.tabPage1.Controls.Add(this.lLlinatge);
            this.tabPage1.Controls.Add(this.tName);
            this.tabPage1.Controls.Add(this.Lname);
            this.tabPage1.Controls.Add(this.tNif);
            this.tabPage1.Controls.Add(this.nif);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iPueblo
            // 
            this.iPueblo.Location = new System.Drawing.Point(216, 117);
            this.iPueblo.Name = "iPueblo";
            this.iPueblo.Size = new System.Drawing.Size(100, 20);
            this.iPueblo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pueblo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iCPassword
            // 
            this.iCPassword.Location = new System.Drawing.Point(110, 188);
            this.iCPassword.Margin = new System.Windows.Forms.Padding(2);
            this.iCPassword.Name = "iCPassword";
            this.iCPassword.Size = new System.Drawing.Size(80, 20);
            this.iCPassword.TabIndex = 20;
            this.iCPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Confirm password";
            // 
            // iPassword
            // 
            this.iPassword.Location = new System.Drawing.Point(110, 153);
            this.iPassword.Margin = new System.Windows.Forms.Padding(2);
            this.iPassword.Name = "iPassword";
            this.iPassword.Size = new System.Drawing.Size(80, 20);
            this.iPassword.TabIndex = 18;
            this.iPassword.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "PASSWORD";
            // 
            // iEmail
            // 
            this.iEmail.Location = new System.Drawing.Point(110, 117);
            this.iEmail.Margin = new System.Windows.Forms.Padding(2);
            this.iEmail.Name = "iEmail";
            this.iEmail.Size = new System.Drawing.Size(80, 20);
            this.iEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // iLlinatge
            // 
            this.iLlinatge.Location = new System.Drawing.Point(110, 82);
            this.iLlinatge.Margin = new System.Windows.Forms.Padding(2);
            this.iLlinatge.Name = "iLlinatge";
            this.iLlinatge.Size = new System.Drawing.Size(80, 20);
            this.iLlinatge.TabIndex = 13;
            // 
            // lLlinatge
            // 
            this.lLlinatge.AutoSize = true;
            this.lLlinatge.Location = new System.Drawing.Point(15, 82);
            this.lLlinatge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLlinatge.Name = "lLlinatge";
            this.lLlinatge.Size = new System.Drawing.Size(44, 13);
            this.lLlinatge.TabIndex = 12;
            this.lLlinatge.Text = "Llinatge";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(110, 42);
            this.tName.Margin = new System.Windows.Forms.Padding(2);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(80, 20);
            this.tName.TabIndex = 11;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(15, 45);
            this.Lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(35, 13);
            this.Lname.TabIndex = 10;
            this.Lname.Text = "Name";
            // 
            // tNif
            // 
            this.tNif.Location = new System.Drawing.Point(110, 14);
            this.tNif.Margin = new System.Windows.Forms.Padding(2);
            this.tNif.Name = "tNif";
            this.tNif.Size = new System.Drawing.Size(80, 20);
            this.tNif.TabIndex = 9;
            // 
            // nif
            // 
            this.nif.AutoSize = true;
            this.nif.Location = new System.Drawing.Point(15, 14);
            this.nif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(24, 13);
            this.nif.TabIndex = 8;
            this.nif.Text = "NIF";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(574, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 108);
            this.listBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pueblo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Llinatge";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(69, 67);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 20);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iCPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox iPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox iEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iLlinatge;
        private System.Windows.Forms.Label lLlinatge;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox tNif;
        private System.Windows.Forms.Label nif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iPueblo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

