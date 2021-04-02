namespace ExtractDBDataToExcel
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
            this.serverUrl_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.filepath_textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.runScript_button = new System.Windows.Forms.Button();
            this.browseScript_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.remember_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // serverUrl_textBox
            // 
            this.serverUrl_textBox.Location = new System.Drawing.Point(100, 33);
            this.serverUrl_textBox.Name = "serverUrl_textBox";
            this.serverUrl_textBox.Size = new System.Drawing.Size(227, 20);
            this.serverUrl_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(436, 33);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(166, 20);
            this.username_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(705, 32);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(171, 20);
            this.password_textBox.TabIndex = 4;
            // 
            // filepath_textBox
            // 
            this.filepath_textBox.Enabled = false;
            this.filepath_textBox.Location = new System.Drawing.Point(1190, 33);
            this.filepath_textBox.Name = "filepath_textBox";
            this.filepath_textBox.Size = new System.Drawing.Size(216, 20);
            this.filepath_textBox.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // runScript_button
            // 
            this.runScript_button.Location = new System.Drawing.Point(1480, 31);
            this.runScript_button.Name = "runScript_button";
            this.runScript_button.Size = new System.Drawing.Size(108, 23);
            this.runScript_button.TabIndex = 10;
            this.runScript_button.Text = "Run Script";
            this.runScript_button.UseVisualStyleBackColor = true;
            this.runScript_button.Click += new System.EventHandler(this.runScript_button_Click);
            // 
            // browseScript_button
            // 
            this.browseScript_button.Location = new System.Drawing.Point(1059, 31);
            this.browseScript_button.Name = "browseScript_button";
            this.browseScript_button.Size = new System.Drawing.Size(125, 23);
            this.browseScript_button.TabIndex = 8;
            this.browseScript_button.Text = "Browse Script File";
            this.browseScript_button.UseVisualStyleBackColor = true;
            this.browseScript_button.Click += new System.EventHandler(this.browseScript_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(1619, 31);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(108, 23);
            this.reset_button.TabIndex = 12;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // remember_checkBox
            // 
            this.remember_checkBox.AutoSize = true;
            this.remember_checkBox.Location = new System.Drawing.Point(921, 35);
            this.remember_checkBox.Name = "remember_checkBox";
            this.remember_checkBox.Size = new System.Drawing.Size(77, 17);
            this.remember_checkBox.TabIndex = 6;
            this.remember_checkBox.Text = "Remember";
            this.remember_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1693, 381);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering Section";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.remember_checkBox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.browseScript_button);
            this.Controls.Add(this.runScript_button);
            this.Controls.Add(this.filepath_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverUrl_textBox);
            this.Name = "Form1";
            this.Text = "Extract Data To Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverUrl_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox filepath_textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button runScript_button;
        private System.Windows.Forms.Button browseScript_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.CheckBox remember_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

