﻿namespace VotingSystem
{
    partial class FrmBackup
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblPercent = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.lnkBrowse = new MetroFramework.Controls.MetroLink();
            this.txtBackupLocation = new MetroFramework.Controls.MetroTextBox();
            this.lnkBackup = new MetroFramework.Controls.MetroLink();
            this.lnkCancel = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblPercent);
            this.metroPanel1.Controls.Add(this.lblStatus);
            this.metroPanel1.Controls.Add(this.progressBar);
            this.metroPanel1.Controls.Add(this.lblError);
            this.metroPanel1.Controls.Add(this.lnkBrowse);
            this.metroPanel1.Controls.Add(this.txtBackupLocation);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(550, 214);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(430, 147);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(31, 19);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "0 %";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.Location = new System.Drawing.Point(2, 193);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 0);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblStatus.TabIndex = 9;
            this.lblStatus.UseStyleColors = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(90, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 23);
            this.progressBar.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblError.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.Location = new System.Drawing.Point(90, 92);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 0);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 4;
            this.lblError.UseStyleColors = true;
            // 
            // lnkBrowse
            // 
            this.lnkBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkBrowse.Image = global::VotingSystem.Properties.Resources.folder__2_;
            this.lnkBrowse.ImageSize = 32;
            this.lnkBrowse.Location = new System.Drawing.Point(430, 66);
            this.lnkBrowse.Name = "lnkBrowse";
            this.lnkBrowse.NoFocusImage = global::VotingSystem.Properties.Resources.folder__3_;
            this.lnkBrowse.Size = new System.Drawing.Size(30, 23);
            this.lnkBrowse.TabIndex = 3;
            this.lnkBrowse.UseSelectable = true;
            this.lnkBrowse.Click += new System.EventHandler(this.lnkBrowse_Click);
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBackupLocation.CustomButton.Image = null;
            this.txtBackupLocation.CustomButton.Location = new System.Drawing.Point(316, 2);
            this.txtBackupLocation.CustomButton.Name = "";
            this.txtBackupLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBackupLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBackupLocation.CustomButton.TabIndex = 1;
            this.txtBackupLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBackupLocation.CustomButton.UseSelectable = true;
            this.txtBackupLocation.CustomButton.Visible = false;
            this.txtBackupLocation.DisplayIcon = true;
            this.txtBackupLocation.Icon = global::VotingSystem.Properties.Resources.folder__1_;
            this.txtBackupLocation.Lines = new string[0];
            this.txtBackupLocation.Location = new System.Drawing.Point(90, 63);
            this.txtBackupLocation.MaxLength = 32767;
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.PasswordChar = '\0';
            this.txtBackupLocation.PromptText = "Database backup location";
            this.txtBackupLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBackupLocation.SelectedText = "";
            this.txtBackupLocation.SelectionLength = 0;
            this.txtBackupLocation.SelectionStart = 0;
            this.txtBackupLocation.ShortcutsEnabled = true;
            this.txtBackupLocation.Size = new System.Drawing.Size(340, 26);
            this.txtBackupLocation.TabIndex = 2;
            this.txtBackupLocation.UseSelectable = true;
            this.txtBackupLocation.WaterMark = "Database backup location";
            this.txtBackupLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBackupLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBackupLocation.TextChanged += new System.EventHandler(this.txtBackupLocation_TextChanged);
            // 
            // lnkBackup
            // 
            this.lnkBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkBackup.Image = global::VotingSystem.Properties.Resources._checked;
            this.lnkBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkBackup.ImageSize = 32;
            this.lnkBackup.Location = new System.Drawing.Point(488, 9);
            this.lnkBackup.Name = "lnkBackup";
            this.lnkBackup.NoFocusImage = global::VotingSystem.Properties.Resources.checked__1_;
            this.lnkBackup.Size = new System.Drawing.Size(50, 45);
            this.lnkBackup.TabIndex = 5;
            this.lnkBackup.Text = "&backup";
            this.lnkBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBackup.UseSelectable = true;
            this.lnkBackup.Click += new System.EventHandler(this.lnkBackup_Click);
            // 
            // lnkCancel
            // 
            this.lnkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCancel.Image = global::VotingSystem.Properties.Resources.cancel__1_;
            this.lnkCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkCancel.ImageSize = 32;
            this.lnkCancel.Location = new System.Drawing.Point(535, 9);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.NoFocusImage = global::VotingSystem.Properties.Resources.cancel__2_;
            this.lnkCancel.Size = new System.Drawing.Size(48, 45);
            this.lnkCancel.TabIndex = 4;
            this.lnkCancel.Text = "&cancel";
            this.lnkCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkCancel.UseSelectable = true;
            this.lnkCancel.Click += new System.EventHandler(this.lnkCancel_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.ControlBox = false;
            this.Controls.Add(this.lnkBackup);
            this.Controls.Add(this.lnkCancel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmBackup";
            this.Text = "Database  Backup";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtBackupLocation;
        private MetroFramework.Controls.MetroLink lnkBrowse;
        private MetroFramework.Controls.MetroLink lnkCancel;
        private MetroFramework.Controls.MetroLink lnkBackup;
        private MetroFramework.Controls.MetroLabel lblError;
        private MetroFramework.Controls.MetroLabel lblPercent;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroProgressBar progressBar;
    }
}