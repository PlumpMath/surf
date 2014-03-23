﻿namespace Surf.browser
{
    partial class tab_frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_frame));
            this.maincontainer = new System.Windows.Forms.Panel();
            this.pnlTabCrash = new System.Windows.Forms.Panel();
            this.crashlblDetails = new System.Windows.Forms.Label();
            this.crashbtnReload = new System.Windows.Forms.Button();
            this.toolbarBackground = new System.Windows.Forms.Panel();
            this.btnStar = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.upgradeBadge = new System.Windows.Forms.PictureBox();
            this.btnTools = new System.Windows.Forms.PictureBox();
            this.OneBoxBackround = new System.Windows.Forms.Panel();
            this.OneBoxFavIcon = new System.Windows.Forms.PictureBox();
            this.OneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maincontainer.SuspendLayout();
            this.pnlTabCrash.SuspendLayout();
            this.toolbarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeBadge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTools)).BeginInit();
            this.OneBoxBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OneBoxFavIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // maincontainer
            // 
            this.maincontainer.Controls.Add(this.pnlTabCrash);
            this.maincontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maincontainer.Location = new System.Drawing.Point(0, 36);
            this.maincontainer.Name = "maincontainer";
            this.maincontainer.Size = new System.Drawing.Size(800, 564);
            this.maincontainer.TabIndex = 1;
            // 
            // pnlTabCrash
            // 
            this.pnlTabCrash.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTabCrash.Controls.Add(this.crashlblDetails);
            this.pnlTabCrash.Controls.Add(this.crashbtnReload);
            this.pnlTabCrash.Location = new System.Drawing.Point(0, 154);
            this.pnlTabCrash.Name = "pnlTabCrash";
            this.pnlTabCrash.Size = new System.Drawing.Size(146, 111);
            this.pnlTabCrash.TabIndex = 5;
            this.pnlTabCrash.Visible = false;
            // 
            // crashlblDetails
            // 
            this.crashlblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crashlblDetails.AutoEllipsis = true;
            this.crashlblDetails.ForeColor = System.Drawing.Color.White;
            this.crashlblDetails.Location = new System.Drawing.Point(9, 6);
            this.crashlblDetails.Name = "crashlblDetails";
            this.crashlblDetails.Size = new System.Drawing.Size(126, 50);
            this.crashlblDetails.TabIndex = 3;
            this.crashlblDetails.Text = "Oops, something went wrong and this tab crashed. Reload to continue.";
            this.crashlblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crashbtnReload
            // 
            this.crashbtnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crashbtnReload.Location = new System.Drawing.Point(30, 59);
            this.crashbtnReload.Name = "crashbtnReload";
            this.crashbtnReload.Size = new System.Drawing.Size(87, 27);
            this.crashbtnReload.TabIndex = 2;
            this.crashbtnReload.Text = "Reload";
            this.crashbtnReload.UseVisualStyleBackColor = true;
            // 
            // toolbarBackground
            // 
            this.toolbarBackground.BackgroundImage = global::Surf.Properties.Resources.toolbarBackground;
            this.toolbarBackground.Controls.Add(this.btnStar);
            this.toolbarBackground.Controls.Add(this.upgradeBadge);
            this.toolbarBackground.Controls.Add(this.btnBack);
            this.toolbarBackground.Controls.Add(this.btnForward);
            this.toolbarBackground.Controls.Add(this.btnHome);
            this.toolbarBackground.Controls.Add(this.btnTools);
            this.toolbarBackground.Controls.Add(this.OneBoxBackround);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(800, 36);
            this.toolbarBackground.TabIndex = 4;
            // 
            // btnStar
            // 
            this.btnStar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStar.BackColor = System.Drawing.Color.Transparent;
            this.btnStar.Image = global::Surf.Properties.Resources.bookmarksStar;
            this.btnStar.Location = new System.Drawing.Point(710, 9);
            this.btnStar.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(19, 19);
            this.btnStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar.TabIndex = 7;
            this.btnStar.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::Surf.Properties.Resources.backDisabled;
            this.btnBack.Location = new System.Drawing.Point(4, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.Image = global::Surf.Properties.Resources.forwardDisabled;
            this.btnForward.Location = new System.Drawing.Point(38, 2);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(32, 32);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnForward.TabIndex = 3;
            this.btnForward.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::Surf.Properties.Resources.homeNormal;
            this.btnHome.Location = new System.Drawing.Point(736, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 27);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            // 
            // upgradeBadge
            // 
            this.upgradeBadge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.upgradeBadge.BackColor = System.Drawing.Color.Transparent;
            this.upgradeBadge.Image = global::Surf.Properties.Resources.UpdateBadge1;
            this.upgradeBadge.Location = new System.Drawing.Point(770, 22);
            this.upgradeBadge.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.upgradeBadge.Name = "upgradeBadge";
            this.upgradeBadge.Size = new System.Drawing.Size(10, 10);
            this.upgradeBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgradeBadge.TabIndex = 5;
            this.upgradeBadge.TabStop = false;
            this.upgradeBadge.Visible = false;
            // 
            // btnTools
            // 
            this.btnTools.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTools.BackColor = System.Drawing.Color.Transparent;
            this.btnTools.Image = global::Surf.Properties.Resources.toolsNormal;
            this.btnTools.Location = new System.Drawing.Point(770, 5);
            this.btnTools.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(27, 27);
            this.btnTools.TabIndex = 4;
            this.btnTools.TabStop = false;
            // 
            // OneBoxBackround
            // 
            this.OneBoxBackround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBoxBackround.BackColor = System.Drawing.Color.White;
            this.OneBoxBackround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OneBoxBackround.Controls.Add(this.label1);
            this.OneBoxBackround.Controls.Add(this.OneBoxFavIcon);
            this.OneBoxBackround.Controls.Add(this.OneBox);
            this.OneBoxBackround.ForeColor = System.Drawing.Color.Silver;
            this.OneBoxBackround.Location = new System.Drawing.Point(76, 5);
            this.OneBoxBackround.Name = "OneBoxBackround";
            this.OneBoxBackround.Size = new System.Drawing.Size(627, 27);
            this.OneBoxBackround.TabIndex = 2;
            // 
            // OneBoxFavIcon
            // 
            this.OneBoxFavIcon.Image = global::Surf.Properties.Resources.favicondefault;
            this.OneBoxFavIcon.Location = new System.Drawing.Point(3, 5);
            this.OneBoxFavIcon.Name = "OneBoxFavIcon";
            this.OneBoxFavIcon.Size = new System.Drawing.Size(16, 16);
            this.OneBoxFavIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OneBoxFavIcon.TabIndex = 6;
            this.OneBoxFavIcon.TabStop = false;
            // 
            // OneBox
            // 
            this.OneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OneBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OneBox.Location = new System.Drawing.Point(22, 4);
            this.OneBox.Margin = new System.Windows.Forms.Padding(9);
            this.OneBox.Name = "OneBox";
            this.OneBox.Size = new System.Drawing.Size(594, 20);
            this.OneBox.TabIndex = 0;
            this.OneBox.Text = "surf://newtab";
            this.OneBox.WordWrap = false;
            this.OneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // tab_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.maincontainer);
            this.Controls.Add(this.toolbarBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tab_frame";
            this.maincontainer.ResumeLayout(false);
            this.pnlTabCrash.ResumeLayout(false);
            this.toolbarBackground.ResumeLayout(false);
            this.toolbarBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeBadge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTools)).EndInit();
            this.OneBoxBackround.ResumeLayout(false);
            this.OneBoxBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OneBoxFavIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel maincontainer;
        private System.Windows.Forms.Panel toolbarBackground;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TextBox OneBox;
        private System.Windows.Forms.Panel OneBoxBackround;
        private System.Windows.Forms.Panel pnlTabCrash;
        private System.Windows.Forms.Label crashlblDetails;
        private System.Windows.Forms.Button crashbtnReload;
        private System.Windows.Forms.PictureBox OneBoxFavIcon;
        private System.Windows.Forms.PictureBox btnTools;
        private System.Windows.Forms.PictureBox btnStar;
        private System.Windows.Forms.PictureBox btnHome;
        public System.Windows.Forms.PictureBox upgradeBadge;
        public System.Windows.Forms.Label label1;


    }
}