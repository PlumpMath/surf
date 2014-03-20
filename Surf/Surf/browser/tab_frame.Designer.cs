namespace Surf.browser
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
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.OneBox = new System.Windows.Forms.TextBox();
            this.urlBorder = new System.Windows.Forms.Panel();
            this.urlBackground = new System.Windows.Forms.Panel();
            this.OneBoxFavIcon = new System.Windows.Forms.PictureBox();
            this.maincontainer.SuspendLayout();
            this.pnlTabCrash.SuspendLayout();
            this.toolbarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.urlBorder.SuspendLayout();
            this.urlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OneBoxFavIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // maincontainer
            // 
            this.maincontainer.Controls.Add(this.pnlTabCrash);
            this.maincontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maincontainer.Location = new System.Drawing.Point(0, 36);
            this.maincontainer.Name = "maincontainer";
            this.maincontainer.Size = new System.Drawing.Size(331, 265);
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
            this.toolbarBackground.Controls.Add(this.btnForward);
            this.toolbarBackground.Controls.Add(this.btnBack);
            this.toolbarBackground.Controls.Add(this.OneBox);
            this.toolbarBackground.Controls.Add(this.urlBorder);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(331, 36);
            this.toolbarBackground.TabIndex = 4;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.Image = global::Surf.Properties.Resources.forwardActive;
            this.btnForward.Location = new System.Drawing.Point(37, 5);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(27, 27);
            this.btnForward.TabIndex = 3;
            this.btnForward.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::Surf.Properties.Resources.backActive;
            this.btnBack.Location = new System.Drawing.Point(6, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 27);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            // 
            // OneBox
            // 
            this.OneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OneBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OneBox.Location = new System.Drawing.Point(97, 8);
            this.OneBox.Margin = new System.Windows.Forms.Padding(9);
            this.OneBox.Name = "OneBox";
            this.OneBox.Size = new System.Drawing.Size(225, 20);
            this.OneBox.TabIndex = 0;
            this.OneBox.Text = "surf://newtab";
            this.OneBox.WordWrap = false;
            this.OneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneBox_KeyDown);
            // 
            // urlBorder
            // 
            this.urlBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBorder.BackColor = System.Drawing.Color.Silver;
            this.urlBorder.Controls.Add(this.urlBackground);
            this.urlBorder.ForeColor = System.Drawing.Color.Silver;
            this.urlBorder.Location = new System.Drawing.Point(69, 5);
            this.urlBorder.Name = "urlBorder";
            this.urlBorder.Size = new System.Drawing.Size(258, 26);
            this.urlBorder.TabIndex = 1;
            // 
            // urlBackground
            // 
            this.urlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBackground.BackColor = System.Drawing.Color.White;
            this.urlBackground.Controls.Add(this.OneBoxFavIcon);
            this.urlBackground.ForeColor = System.Drawing.Color.Silver;
            this.urlBackground.Location = new System.Drawing.Point(1, 1);
            this.urlBackground.Name = "urlBackground";
            this.urlBackground.Size = new System.Drawing.Size(256, 24);
            this.urlBackground.TabIndex = 2;
            // 
            // OneBoxFavIcon
            // 
            this.OneBoxFavIcon.Image = global::Surf.Properties.Resources.favicondefault;
            this.OneBoxFavIcon.Location = new System.Drawing.Point(5, 4);
            this.OneBoxFavIcon.Name = "OneBoxFavIcon";
            this.OneBoxFavIcon.Size = new System.Drawing.Size(16, 16);
            this.OneBoxFavIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OneBoxFavIcon.TabIndex = 6;
            this.OneBoxFavIcon.TabStop = false;
            // 
            // tab_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 301);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.urlBorder.ResumeLayout(false);
            this.urlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OneBoxFavIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel maincontainer;
        private System.Windows.Forms.Panel toolbarBackground;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TextBox OneBox;
        private System.Windows.Forms.Panel urlBorder;
        private System.Windows.Forms.Panel urlBackground;
        private System.Windows.Forms.Panel pnlTabCrash;
        private System.Windows.Forms.Label crashlblDetails;
        private System.Windows.Forms.Button crashbtnReload;
        private System.Windows.Forms.PictureBox OneBoxFavIcon;


    }
}