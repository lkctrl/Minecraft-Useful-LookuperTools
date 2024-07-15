namespace PlayerInfoLookuper
{
    partial class LookuperUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookuperUI));
            this.linkLabel_op_link = new System.Windows.Forms.LinkLabel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_op_link = new System.Windows.Forms.Label();
            this.tabControl_all = new System.Windows.Forms.TabControl();
            this.tabPage_Minecraft = new System.Windows.Forms.TabPage();
            this.richTextBox_RawInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox_PlayerInfo = new System.Windows.Forms.GroupBox();
            this.button_Minecraft_SaveCape = new System.Windows.Forms.Button();
            this.pictureBox_PlayerCape = new System.Windows.Forms.PictureBox();
            this.button_Minecraft_SaveSkin = new System.Windows.Forms.Button();
            this.pictureBox_PlayerHead = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerSkin = new System.Windows.Forms.PictureBox();
            this.label_UUID = new System.Windows.Forms.Label();
            this.label_op_UUID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ops_Name = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_in_Name = new System.Windows.Forms.TextBox();
            this.tabPage_Steam = new System.Windows.Forms.TabPage();
            this.label_op_ToBeCon = new System.Windows.Forms.Label();
            this.tabPage_Xbox = new System.Windows.Forms.TabPage();
            this.label_op_ToBeCon2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_op_designer = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.tabControl_all.SuspendLayout();
            this.tabPage_Minecraft.SuspendLayout();
            this.groupBox_PlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerCape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerSkin)).BeginInit();
            this.tabPage_Steam.SuspendLayout();
            this.tabPage_Xbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel_op_link
            // 
            this.linkLabel_op_link.AutoSize = true;
            this.linkLabel_op_link.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_op_link.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_op_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_op_link.Location = new System.Drawing.Point(525, 336);
            this.linkLabel_op_link.Name = "linkLabel_op_link";
            this.linkLabel_op_link.Size = new System.Drawing.Size(76, 17);
            this.linkLabel_op_link.TabIndex = 1;
            this.linkLabel_op_link.TabStop = true;
            this.linkLabel_op_link.Text = "Mojang API";
            this.toolTip.SetToolTip(this.linkLabel_op_link, resources.GetString("linkLabel_op_link.ToolTip"));
            this.linkLabel_op_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_op_link_LinkClicked);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(58, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(489, 41);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Minecraft Player Info Lookuper";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_op_link
            // 
            this.label_op_link.AutoSize = true;
            this.label_op_link.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_link.Location = new System.Drawing.Point(478, 336);
            this.label_op_link.Name = "label_op_link";
            this.label_op_link.Size = new System.Drawing.Size(41, 17);
            this.label_op_link.TabIndex = 3;
            this.label_op_link.Text = "Using";
            // 
            // tabControl_all
            // 
            this.tabControl_all.Controls.Add(this.tabPage_Minecraft);
            this.tabControl_all.Controls.Add(this.tabPage_Steam);
            this.tabControl_all.Controls.Add(this.tabPage_Xbox);
            this.tabControl_all.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_all.Location = new System.Drawing.Point(12, 55);
            this.tabControl_all.Name = "tabControl_all";
            this.tabControl_all.SelectedIndex = 0;
            this.tabControl_all.Size = new System.Drawing.Size(589, 278);
            this.tabControl_all.TabIndex = 4;
            // 
            // tabPage_Minecraft
            // 
            this.tabPage_Minecraft.Controls.Add(this.richTextBox_RawInfo);
            this.tabPage_Minecraft.Controls.Add(this.groupBox_PlayerInfo);
            this.tabPage_Minecraft.Controls.Add(this.button_Search);
            this.tabPage_Minecraft.Controls.Add(this.textBox_in_Name);
            this.tabPage_Minecraft.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Minecraft.Name = "tabPage_Minecraft";
            this.tabPage_Minecraft.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Minecraft.Size = new System.Drawing.Size(581, 248);
            this.tabPage_Minecraft.TabIndex = 0;
            this.tabPage_Minecraft.Text = "Minecraft";
            this.tabPage_Minecraft.UseVisualStyleBackColor = true;
            // 
            // richTextBox_RawInfo
            // 
            this.richTextBox_RawInfo.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_RawInfo.Location = new System.Drawing.Point(6, 64);
            this.richTextBox_RawInfo.Name = "richTextBox_RawInfo";
            this.richTextBox_RawInfo.ReadOnly = true;
            this.richTextBox_RawInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox_RawInfo.Size = new System.Drawing.Size(134, 179);
            this.richTextBox_RawInfo.TabIndex = 9;
            this.richTextBox_RawInfo.Text = "";
            // 
            // groupBox_PlayerInfo
            // 
            this.groupBox_PlayerInfo.Controls.Add(this.button_Minecraft_SaveCape);
            this.groupBox_PlayerInfo.Controls.Add(this.pictureBox_PlayerCape);
            this.groupBox_PlayerInfo.Controls.Add(this.button_Minecraft_SaveSkin);
            this.groupBox_PlayerInfo.Controls.Add(this.pictureBox_PlayerHead);
            this.groupBox_PlayerInfo.Controls.Add(this.pictureBox_PlayerSkin);
            this.groupBox_PlayerInfo.Controls.Add(this.label_UUID);
            this.groupBox_PlayerInfo.Controls.Add(this.label_op_UUID);
            this.groupBox_PlayerInfo.Controls.Add(this.label_Name);
            this.groupBox_PlayerInfo.Controls.Add(this.label_ops_Name);
            this.groupBox_PlayerInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_PlayerInfo.Location = new System.Drawing.Point(146, 6);
            this.groupBox_PlayerInfo.Name = "groupBox_PlayerInfo";
            this.groupBox_PlayerInfo.Size = new System.Drawing.Size(429, 237);
            this.groupBox_PlayerInfo.TabIndex = 8;
            this.groupBox_PlayerInfo.TabStop = false;
            this.groupBox_PlayerInfo.Text = "Result:";
            // 
            // button_Minecraft_SaveCape
            // 
            this.button_Minecraft_SaveCape.Enabled = false;
            this.button_Minecraft_SaveCape.Location = new System.Drawing.Point(154, 205);
            this.button_Minecraft_SaveCape.Name = "button_Minecraft_SaveCape";
            this.button_Minecraft_SaveCape.Size = new System.Drawing.Size(142, 23);
            this.button_Minecraft_SaveCape.TabIndex = 15;
            this.button_Minecraft_SaveCape.Text = "SaveCape";
            this.button_Minecraft_SaveCape.UseVisualStyleBackColor = true;
            this.button_Minecraft_SaveCape.Click += new System.EventHandler(this.button_Minecraft_SaveCape_Click);
            // 
            // pictureBox_PlayerCape
            // 
            this.pictureBox_PlayerCape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerCape.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_PlayerCape.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PlayerCape.Image")));
            this.pictureBox_PlayerCape.Location = new System.Drawing.Point(154, 57);
            this.pictureBox_PlayerCape.Name = "pictureBox_PlayerCape";
            this.pictureBox_PlayerCape.Size = new System.Drawing.Size(258, 130);
            this.pictureBox_PlayerCape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PlayerCape.TabIndex = 14;
            this.pictureBox_PlayerCape.TabStop = false;
            // 
            // button_Minecraft_SaveSkin
            // 
            this.button_Minecraft_SaveSkin.Enabled = false;
            this.button_Minecraft_SaveSkin.Location = new System.Drawing.Point(6, 205);
            this.button_Minecraft_SaveSkin.Name = "button_Minecraft_SaveSkin";
            this.button_Minecraft_SaveSkin.Size = new System.Drawing.Size(142, 23);
            this.button_Minecraft_SaveSkin.TabIndex = 13;
            this.button_Minecraft_SaveSkin.Text = "SaveSkin";
            this.button_Minecraft_SaveSkin.UseVisualStyleBackColor = true;
            this.button_Minecraft_SaveSkin.Click += new System.EventHandler(this.button_SaveSkin_Click);
            // 
            // pictureBox_PlayerHead
            // 
            this.pictureBox_PlayerHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerHead.Image = global::MinecraftPlayerInfoSearcher.Properties.Resources._Old_Steve_head_shock;
            this.pictureBox_PlayerHead.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_PlayerHead.Name = "pictureBox_PlayerHead";
            this.pictureBox_PlayerHead.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_PlayerHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerHead.TabIndex = 12;
            this.pictureBox_PlayerHead.TabStop = false;
            // 
            // pictureBox_PlayerSkin
            // 
            this.pictureBox_PlayerSkin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerSkin.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_PlayerSkin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PlayerSkin.Image")));
            this.pictureBox_PlayerSkin.Location = new System.Drawing.Point(6, 57);
            this.pictureBox_PlayerSkin.Name = "pictureBox_PlayerSkin";
            this.pictureBox_PlayerSkin.Size = new System.Drawing.Size(142, 142);
            this.pictureBox_PlayerSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PlayerSkin.TabIndex = 11;
            this.pictureBox_PlayerSkin.TabStop = false;
            // 
            // label_UUID
            // 
            this.label_UUID.AutoSize = true;
            this.label_UUID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UUID.Location = new System.Drawing.Point(96, 39);
            this.label_UUID.Name = "label_UUID";
            this.label_UUID.Size = new System.Drawing.Size(14, 17);
            this.label_UUID.TabIndex = 10;
            this.label_UUID.Text = "x";
            // 
            // label_op_UUID
            // 
            this.label_op_UUID.AutoSize = true;
            this.label_op_UUID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_UUID.Location = new System.Drawing.Point(48, 39);
            this.label_op_UUID.Name = "label_op_UUID";
            this.label_op_UUID.Size = new System.Drawing.Size(42, 17);
            this.label_op_UUID.TabIndex = 9;
            this.label_op_UUID.Text = "UUID:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(96, 23);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(14, 17);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "x";
            // 
            // label_ops_Name
            // 
            this.label_ops_Name.AutoSize = true;
            this.label_ops_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ops_Name.Location = new System.Drawing.Point(44, 22);
            this.label_ops_Name.Name = "label_ops_Name";
            this.label_ops_Name.Size = new System.Drawing.Size(46, 17);
            this.label_ops_Name.TabIndex = 7;
            this.label_ops_Name.Text = "Name:";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(6, 35);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(134, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Minecraft_Search_Click);
            // 
            // textBox_in_Name
            // 
            this.textBox_in_Name.Location = new System.Drawing.Point(6, 6);
            this.textBox_in_Name.MaxLength = 16;
            this.textBox_in_Name.Name = "textBox_in_Name";
            this.textBox_in_Name.Size = new System.Drawing.Size(134, 23);
            this.textBox_in_Name.TabIndex = 0;
            this.textBox_in_Name.Text = "TypeNameHere";
            // 
            // tabPage_Steam
            // 
            this.tabPage_Steam.Controls.Add(this.label_op_ToBeCon);
            this.tabPage_Steam.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Steam.Name = "tabPage_Steam";
            this.tabPage_Steam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Steam.Size = new System.Drawing.Size(581, 249);
            this.tabPage_Steam.TabIndex = 1;
            this.tabPage_Steam.Text = "Steam";
            this.tabPage_Steam.UseVisualStyleBackColor = true;
            // 
            // label_op_ToBeCon
            // 
            this.label_op_ToBeCon.AutoSize = true;
            this.label_op_ToBeCon.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_ToBeCon.Location = new System.Drawing.Point(209, 116);
            this.label_op_ToBeCon.Name = "label_op_ToBeCon";
            this.label_op_ToBeCon.Size = new System.Drawing.Size(113, 16);
            this.label_op_ToBeCon.TabIndex = 6;
            this.label_op_ToBeCon.Text = "To be continue?";
            // 
            // tabPage_Xbox
            // 
            this.tabPage_Xbox.Controls.Add(this.label_op_ToBeCon2);
            this.tabPage_Xbox.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Xbox.Name = "tabPage_Xbox";
            this.tabPage_Xbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Xbox.Size = new System.Drawing.Size(581, 249);
            this.tabPage_Xbox.TabIndex = 2;
            this.tabPage_Xbox.Text = "Xbox";
            this.tabPage_Xbox.UseVisualStyleBackColor = true;
            // 
            // label_op_ToBeCon2
            // 
            this.label_op_ToBeCon2.AutoSize = true;
            this.label_op_ToBeCon2.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_ToBeCon2.Location = new System.Drawing.Point(209, 116);
            this.label_op_ToBeCon2.Name = "label_op_ToBeCon2";
            this.label_op_ToBeCon2.Size = new System.Drawing.Size(113, 16);
            this.label_op_ToBeCon2.TabIndex = 6;
            this.label_op_ToBeCon2.Text = "To be continue?";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Green;
            this.label_status.Location = new System.Drawing.Point(313, 336);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(52, 17);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "Waiting";
            // 
            // label_op_designer
            // 
            this.label_op_designer.AutoSize = true;
            this.label_op_designer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_designer.Location = new System.Drawing.Point(13, 336);
            this.label_op_designer.Name = "label_op_designer";
            this.label_op_designer.Size = new System.Drawing.Size(138, 17);
            this.label_op_designer.TabIndex = 5;
            this.label_op_designer.Text = "Designed by z3z in C#";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(165, 336);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(62, 17);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "_Version_";
            // 
            // LookuperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 357);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_op_designer);
            this.Controls.Add(this.tabControl_all);
            this.Controls.Add(this.label_op_link);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.linkLabel_op_link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LookuperUI";
            this.Text = "Minecraft Player Info Lookuper";
            this.Load += new System.EventHandler(this.LookuperUI_Load);
            this.tabControl_all.ResumeLayout(false);
            this.tabPage_Minecraft.ResumeLayout(false);
            this.tabPage_Minecraft.PerformLayout();
            this.groupBox_PlayerInfo.ResumeLayout(false);
            this.groupBox_PlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerCape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerSkin)).EndInit();
            this.tabPage_Steam.ResumeLayout(false);
            this.tabPage_Steam.PerformLayout();
            this.tabPage_Xbox.ResumeLayout(false);
            this.tabPage_Xbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_op_link;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_op_link;
        private System.Windows.Forms.TabControl tabControl_all;
        private System.Windows.Forms.TabPage tabPage_Minecraft;
        private System.Windows.Forms.TabPage tabPage_Steam;
        private System.Windows.Forms.TabPage tabPage_Xbox;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.TextBox textBox_in_Name;
        private System.Windows.Forms.Label label_op_designer;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_op_ToBeCon;
        private System.Windows.Forms.Label label_op_ToBeCon2;
        private System.Windows.Forms.GroupBox groupBox_PlayerInfo;
        private System.Windows.Forms.RichTextBox richTextBox_RawInfo;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ops_Name;
        private System.Windows.Forms.Label label_UUID;
        private System.Windows.Forms.Label label_op_UUID;
        private System.Windows.Forms.PictureBox pictureBox_PlayerHead;
        private System.Windows.Forms.PictureBox pictureBox_PlayerSkin;
        private System.Windows.Forms.Button button_Minecraft_SaveSkin;
        private System.Windows.Forms.Button button_Minecraft_SaveCape;
        private System.Windows.Forms.PictureBox pictureBox_PlayerCape;
    }
}

