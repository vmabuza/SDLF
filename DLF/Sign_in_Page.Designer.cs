﻿namespace DLF
{
    partial class DLF
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
            this.Heading = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.streamLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.imprtntMsgLabel = new System.Windows.Forms.Label();
            this.selfieBox = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.signInMsg = new System.Windows.Forms.Label();
            this.timeContainerLabel = new System.Windows.Forms.Label();
            this.dateContainerLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.startCamButton = new System.Windows.Forms.Button();
            this.stopCamButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.streamList = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.selfieBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(12, 39);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(262, 29);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Student Daily Log Form";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(14, 141);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 16);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname:";
            // 
            // streamLabel
            // 
            this.streamLabel.AutoSize = true;
            this.streamLabel.Location = new System.Drawing.Point(14, 191);
            this.streamLabel.Name = "streamLabel";
            this.streamLabel.Size = new System.Drawing.Size(100, 16);
            this.streamLabel.TabIndex = 3;
            this.streamLabel.Text = "Designated Lab:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 244);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // imprtntMsgLabel
            // 
            this.imprtntMsgLabel.AutoSize = true;
            this.imprtntMsgLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprtntMsgLabel.Location = new System.Drawing.Point(258, 439);
            this.imprtntMsgLabel.Name = "imprtntMsgLabel";
            this.imprtntMsgLabel.Size = new System.Drawing.Size(173, 23);
            this.imprtntMsgLabel.TabIndex = 5;
            this.imprtntMsgLabel.Text = "Please take a selfie!";
            // 
            // selfieBox
            // 
            this.selfieBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selfieBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selfieBox.Location = new System.Drawing.Point(17, 324);
            this.selfieBox.Name = "selfieBox";
            this.selfieBox.Size = new System.Drawing.Size(669, 291);
            this.selfieBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.selfieBox.TabIndex = 6;
            this.selfieBox.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(585, 186);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(42, 16);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(22, 721);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 16);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "label1";
            // 
            // signInMsg
            // 
            this.signInMsg.AutoSize = true;
            this.signInMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signInMsg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signInMsg.Location = new System.Drawing.Point(520, 96);
            this.signInMsg.Name = "signInMsg";
            this.signInMsg.Size = new System.Drawing.Size(110, 16);
            this.signInMsg.TabIndex = 9;
            this.signInMsg.Text = "You are signing in";
            // 
            // timeContainerLabel
            // 
            this.timeContainerLabel.AutoSize = true;
            this.timeContainerLabel.Location = new System.Drawing.Point(520, 186);
            this.timeContainerLabel.Name = "timeContainerLabel";
            this.timeContainerLabel.Size = new System.Drawing.Size(46, 16);
            this.timeContainerLabel.TabIndex = 10;
            this.timeContainerLabel.Text = "Time :";
            // 
            // dateContainerLabel
            // 
            this.dateContainerLabel.AutoSize = true;
            this.dateContainerLabel.Location = new System.Drawing.Point(520, 141);
            this.dateContainerLabel.Name = "dateContainerLabel";
            this.dateContainerLabel.Size = new System.Drawing.Size(43, 16);
            this.dateContainerLabel.TabIndex = 11;
            this.dateContainerLabel.Text = "Date :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 89);
            this.nameTextBox.MaxLength = 15;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 23);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameValidate);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(140, 134);
            this.surnameTextBox.MaxLength = 20;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(227, 23);
            this.surnameTextBox.TabIndex = 16;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameValidation);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(611, 644);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "button1";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startCamButton
            // 
            this.startCamButton.Location = new System.Drawing.Point(17, 643);
            this.startCamButton.Name = "startCamButton";
            this.startCamButton.Size = new System.Drawing.Size(75, 23);
            this.startCamButton.TabIndex = 18;
            this.startCamButton.Text = "button1";
            this.startCamButton.UseVisualStyleBackColor = true;
            this.startCamButton.Click += new System.EventHandler(this.startCamButton_Click);
            // 
            // stopCamButton
            // 
            this.stopCamButton.Location = new System.Drawing.Point(111, 643);
            this.stopCamButton.Name = "stopCamButton";
            this.stopCamButton.Size = new System.Drawing.Size(75, 23);
            this.stopCamButton.TabIndex = 19;
            this.stopCamButton.Text = "button1";
            this.stopCamButton.UseVisualStyleBackColor = true;
            this.stopCamButton.Click += new System.EventHandler(this.stopCamButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 643);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // streamList
            // 
            this.streamList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.streamList.Items.AddRange(new object[] {
            "IE",
            "Safari",
            "Opera",
            "Chrome",
            "Dev Zone",
            "MCSD",
            "MCSA",
            "CISCO",
            "SAP",
            "SAP-2"});
            this.streamList.Location = new System.Drawing.Point(140, 183);
            this.streamList.Name = "streamList";
            this.streamList.Size = new System.Drawing.Size(227, 24);
            this.streamList.TabIndex = 21;
            this.streamList.Text = "Please select";
            this.streamList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.streamInputValidate);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.signoutToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 25);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.signInToolStripMenuItem.Text = "Sign-in";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.signoutToolStripMenuItem.Text = "Sign-out";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(140, 237);
            this.passwordTextBox.MaxLength = 13;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(227, 23);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordValidate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Selfie poimt...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // DLF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.streamList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stopCamButton);
            this.Controls.Add(this.startCamButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dateContainerLabel);
            this.Controls.Add(this.timeContainerLabel);
            this.Controls.Add(this.signInMsg);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.imprtntMsgLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.streamLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.selfieBox);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DLF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLF";
            this.Load += new System.EventHandler(this.DLF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selfieBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label streamLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label imprtntMsgLabel;
        private System.Windows.Forms.PictureBox selfieBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label signInMsg;
        private System.Windows.Forms.Label timeContainerLabel;
        private System.Windows.Forms.Label dateContainerLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button startCamButton;
        private System.Windows.Forms.Button stopCamButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox streamList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

