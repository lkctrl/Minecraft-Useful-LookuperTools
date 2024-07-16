namespace MinecraftUsefulApiTools
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
            this.linkLabel_Mojang = new System.Windows.Forms.LinkLabel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_op_link = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel_mcsrvstat = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Github = new System.Windows.Forms.LinkLabel();
            this.label_op_designer = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.tabPage_PlayerInfo = new System.Windows.Forms.TabPage();
            this.richTextBox_PlayerInfo_RawInfo = new System.Windows.Forms.RichTextBox();
            this.textBox_PlayerInfo_in_Name = new System.Windows.Forms.TextBox();
            this.groupBox_PlayerInfo_Result = new System.Windows.Forms.GroupBox();
            this.button_PlayerInfo_SaveCape = new System.Windows.Forms.Button();
            this.pictureBox_PlayerInfo_PlayerCape = new System.Windows.Forms.PictureBox();
            this.button_PlayerInfo_SaveSkin = new System.Windows.Forms.Button();
            this.pictureBox_PlayerInfo_PlayerHead = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerInfo_PlayerSkin = new System.Windows.Forms.PictureBox();
            this.label_PlayerInfo_UUID = new System.Windows.Forms.Label();
            this.label_PlayerInfo_op_UUID = new System.Windows.Forms.Label();
            this.label_PlayerInfo_Name = new System.Windows.Forms.Label();
            this.label_PlayerInfo_ops_Name = new System.Windows.Forms.Label();
            this.button_PlayerInfo_Search = new System.Windows.Forms.Button();
            this.tabControl_all = new System.Windows.Forms.TabControl();
            this.tabPage_ServerStatus = new System.Windows.Forms.TabPage();
            this.button_ServerStatus_Ping = new System.Windows.Forms.Button();
            this.textBox_ServerStatus_in_Port = new System.Windows.Forms.TextBox();
            this.comboBox_ServerStatus_PingType = new System.Windows.Forms.ComboBox();
            this.textBox_ServerStatus_in_IP = new System.Windows.Forms.TextBox();
            this.groupBox_ServerStatus = new System.Windows.Forms.GroupBox();
            this.label_IsServerOnline = new System.Windows.Forms.Label();
            this.label_ServerAddress = new System.Windows.Forms.Label();
            this.label_op_ServerAddress = new System.Windows.Forms.Label();
            this.pictureBox_ServerIcon = new System.Windows.Forms.PictureBox();
            this.label_op_link2 = new System.Windows.Forms.Label();
            this.richTextBox_ServerStatus = new System.Windows.Forms.RichTextBox();
            this.tabPage_PlayerInfo.SuspendLayout();
            this.groupBox_PlayerInfo_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerCape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerSkin)).BeginInit();
            this.tabControl_all.SuspendLayout();
            this.tabPage_ServerStatus.SuspendLayout();
            this.groupBox_ServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ServerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_Mojang
            // 
            this.linkLabel_Mojang.AutoSize = true;
            this.linkLabel_Mojang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Mojang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_Mojang.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_Mojang.Location = new System.Drawing.Point(353, 0);
            this.linkLabel_Mojang.Name = "linkLabel_Mojang";
            this.linkLabel_Mojang.Size = new System.Drawing.Size(76, 17);
            this.linkLabel_Mojang.TabIndex = 1;
            this.linkLabel_Mojang.TabStop = true;
            this.linkLabel_Mojang.Text = "Mojang API";
            this.toolTip.SetToolTip(this.linkLabel_Mojang, resources.GetString("linkLabel_Mojang.ToolTip"));
            this.linkLabel_Mojang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Mojang_LinkClicked);
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(587, 41);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Minecraft useful api tools";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_op_link
            // 
            this.label_op_link.AutoSize = true;
            this.label_op_link.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_link.Location = new System.Drawing.Point(306, 0);
            this.label_op_link.Name = "label_op_link";
            this.label_op_link.Size = new System.Drawing.Size(41, 17);
            this.label_op_link.TabIndex = 3;
            this.label_op_link.Text = "Using";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Green;
            this.label_status.Location = new System.Drawing.Point(536, 336);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(52, 17);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "Waiting";
            // 
            // linkLabel_mcsrvstat
            // 
            this.linkLabel_mcsrvstat.AutoSize = true;
            this.linkLabel_mcsrvstat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_mcsrvstat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_mcsrvstat.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_mcsrvstat.Location = new System.Drawing.Point(340, 0);
            this.linkLabel_mcsrvstat.Name = "linkLabel_mcsrvstat";
            this.linkLabel_mcsrvstat.Size = new System.Drawing.Size(89, 17);
            this.linkLabel_mcsrvstat.TabIndex = 4;
            this.linkLabel_mcsrvstat.TabStop = true;
            this.linkLabel_mcsrvstat.Text = "MCsrvstat API";
            this.toolTip.SetToolTip(this.linkLabel_mcsrvstat, "Minecraft Server Status API combines the Ping and Query protocols into one simple" +
        " JSON output.\r\nYou can Get information about Minecraft servers quickly");
            // 
            // linkLabel_Github
            // 
            this.linkLabel_Github.AutoSize = true;
            this.linkLabel_Github.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Github.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_Github.Location = new System.Drawing.Point(145, 336);
            this.linkLabel_Github.Name = "linkLabel_Github";
            this.linkLabel_Github.Size = new System.Drawing.Size(46, 17);
            this.linkLabel_Github.TabIndex = 8;
            this.linkLabel_Github.TabStop = true;
            this.linkLabel_Github.Text = "Github";
            this.toolTip.SetToolTip(this.linkLabel_Github, "Minecraft Server Status API combines the Ping and Query protocols into one simple" +
        " JSON output.\r\nYou can Get information about Minecraft servers quickly");
            this.linkLabel_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Github_LinkClicked);
            // 
            // label_op_designer
            // 
            this.label_op_designer.AutoSize = true;
            this.label_op_designer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_designer.Location = new System.Drawing.Point(13, 336);
            this.label_op_designer.Name = "label_op_designer";
            this.label_op_designer.Size = new System.Drawing.Size(126, 17);
            this.label_op_designer.TabIndex = 5;
            this.label_op_designer.Text = "Made by lkctrl in C#";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(197, 336);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(62, 17);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "_Version_";
            // 
            // tabPage_PlayerInfo
            // 
            this.tabPage_PlayerInfo.Controls.Add(this.richTextBox_PlayerInfo_RawInfo);
            this.tabPage_PlayerInfo.Controls.Add(this.textBox_PlayerInfo_in_Name);
            this.tabPage_PlayerInfo.Controls.Add(this.groupBox_PlayerInfo_Result);
            this.tabPage_PlayerInfo.Controls.Add(this.button_PlayerInfo_Search);
            this.tabPage_PlayerInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPage_PlayerInfo.Name = "tabPage_PlayerInfo";
            this.tabPage_PlayerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PlayerInfo.Size = new System.Drawing.Size(581, 248);
            this.tabPage_PlayerInfo.TabIndex = 0;
            this.tabPage_PlayerInfo.Text = "PlayerInfo";
            this.tabPage_PlayerInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox_PlayerInfo_RawInfo
            // 
            this.richTextBox_PlayerInfo_RawInfo.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_PlayerInfo_RawInfo.Location = new System.Drawing.Point(6, 64);
            this.richTextBox_PlayerInfo_RawInfo.Name = "richTextBox_PlayerInfo_RawInfo";
            this.richTextBox_PlayerInfo_RawInfo.ReadOnly = true;
            this.richTextBox_PlayerInfo_RawInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox_PlayerInfo_RawInfo.Size = new System.Drawing.Size(134, 179);
            this.richTextBox_PlayerInfo_RawInfo.TabIndex = 9;
            this.richTextBox_PlayerInfo_RawInfo.Text = "";
            // 
            // textBox_PlayerInfo_in_Name
            // 
            this.textBox_PlayerInfo_in_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PlayerInfo_in_Name.Location = new System.Drawing.Point(6, 6);
            this.textBox_PlayerInfo_in_Name.MaxLength = 16;
            this.textBox_PlayerInfo_in_Name.Name = "textBox_PlayerInfo_in_Name";
            this.textBox_PlayerInfo_in_Name.Size = new System.Drawing.Size(134, 23);
            this.textBox_PlayerInfo_in_Name.TabIndex = 0;
            this.textBox_PlayerInfo_in_Name.Text = "TypeNameHere";
            // 
            // groupBox_PlayerInfo_Result
            // 
            this.groupBox_PlayerInfo_Result.Controls.Add(this.button_PlayerInfo_SaveCape);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.pictureBox_PlayerInfo_PlayerCape);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.button_PlayerInfo_SaveSkin);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.label_op_link);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.pictureBox_PlayerInfo_PlayerHead);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.pictureBox_PlayerInfo_PlayerSkin);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.label_PlayerInfo_UUID);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.linkLabel_Mojang);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.label_PlayerInfo_op_UUID);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.label_PlayerInfo_Name);
            this.groupBox_PlayerInfo_Result.Controls.Add(this.label_PlayerInfo_ops_Name);
            this.groupBox_PlayerInfo_Result.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_PlayerInfo_Result.Location = new System.Drawing.Point(146, 6);
            this.groupBox_PlayerInfo_Result.Name = "groupBox_PlayerInfo_Result";
            this.groupBox_PlayerInfo_Result.Size = new System.Drawing.Size(429, 237);
            this.groupBox_PlayerInfo_Result.TabIndex = 8;
            this.groupBox_PlayerInfo_Result.TabStop = false;
            this.groupBox_PlayerInfo_Result.Text = "Result:";
            // 
            // button_PlayerInfo_SaveCape
            // 
            this.button_PlayerInfo_SaveCape.Enabled = false;
            this.button_PlayerInfo_SaveCape.Location = new System.Drawing.Point(154, 205);
            this.button_PlayerInfo_SaveCape.Name = "button_PlayerInfo_SaveCape";
            this.button_PlayerInfo_SaveCape.Size = new System.Drawing.Size(142, 23);
            this.button_PlayerInfo_SaveCape.TabIndex = 15;
            this.button_PlayerInfo_SaveCape.Text = "SaveCape";
            this.button_PlayerInfo_SaveCape.UseVisualStyleBackColor = true;
            this.button_PlayerInfo_SaveCape.Click += new System.EventHandler(this.button_Minecraft_SaveCape_Click);
            // 
            // pictureBox_PlayerInfo_PlayerCape
            // 
            this.pictureBox_PlayerInfo_PlayerCape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerInfo_PlayerCape.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_PlayerInfo_PlayerCape.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PlayerInfo_PlayerCape.Image")));
            this.pictureBox_PlayerInfo_PlayerCape.Location = new System.Drawing.Point(154, 57);
            this.pictureBox_PlayerInfo_PlayerCape.Name = "pictureBox_PlayerInfo_PlayerCape";
            this.pictureBox_PlayerInfo_PlayerCape.Size = new System.Drawing.Size(258, 130);
            this.pictureBox_PlayerInfo_PlayerCape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PlayerInfo_PlayerCape.TabIndex = 14;
            this.pictureBox_PlayerInfo_PlayerCape.TabStop = false;
            // 
            // button_PlayerInfo_SaveSkin
            // 
            this.button_PlayerInfo_SaveSkin.Enabled = false;
            this.button_PlayerInfo_SaveSkin.Location = new System.Drawing.Point(6, 205);
            this.button_PlayerInfo_SaveSkin.Name = "button_PlayerInfo_SaveSkin";
            this.button_PlayerInfo_SaveSkin.Size = new System.Drawing.Size(142, 23);
            this.button_PlayerInfo_SaveSkin.TabIndex = 13;
            this.button_PlayerInfo_SaveSkin.Text = "SaveSkin";
            this.button_PlayerInfo_SaveSkin.UseVisualStyleBackColor = true;
            this.button_PlayerInfo_SaveSkin.Click += new System.EventHandler(this.button_SaveSkin_Click);
            // 
            // pictureBox_PlayerInfo_PlayerHead
            // 
            this.pictureBox_PlayerInfo_PlayerHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerInfo_PlayerHead.Image = global::MinecraftPlayerInfoSearcher.Properties.Resources._Old_Steve_head_shock;
            this.pictureBox_PlayerInfo_PlayerHead.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_PlayerInfo_PlayerHead.Name = "pictureBox_PlayerInfo_PlayerHead";
            this.pictureBox_PlayerInfo_PlayerHead.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_PlayerInfo_PlayerHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerInfo_PlayerHead.TabIndex = 12;
            this.pictureBox_PlayerInfo_PlayerHead.TabStop = false;
            // 
            // pictureBox_PlayerInfo_PlayerSkin
            // 
            this.pictureBox_PlayerInfo_PlayerSkin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PlayerInfo_PlayerSkin.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_PlayerInfo_PlayerSkin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_PlayerInfo_PlayerSkin.Image")));
            this.pictureBox_PlayerInfo_PlayerSkin.Location = new System.Drawing.Point(6, 57);
            this.pictureBox_PlayerInfo_PlayerSkin.Name = "pictureBox_PlayerInfo_PlayerSkin";
            this.pictureBox_PlayerInfo_PlayerSkin.Size = new System.Drawing.Size(142, 142);
            this.pictureBox_PlayerInfo_PlayerSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PlayerInfo_PlayerSkin.TabIndex = 11;
            this.pictureBox_PlayerInfo_PlayerSkin.TabStop = false;
            // 
            // label_PlayerInfo_UUID
            // 
            this.label_PlayerInfo_UUID.AutoSize = true;
            this.label_PlayerInfo_UUID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerInfo_UUID.Location = new System.Drawing.Point(96, 39);
            this.label_PlayerInfo_UUID.Name = "label_PlayerInfo_UUID";
            this.label_PlayerInfo_UUID.Size = new System.Drawing.Size(14, 17);
            this.label_PlayerInfo_UUID.TabIndex = 10;
            this.label_PlayerInfo_UUID.Text = "x";
            // 
            // label_PlayerInfo_op_UUID
            // 
            this.label_PlayerInfo_op_UUID.AutoSize = true;
            this.label_PlayerInfo_op_UUID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerInfo_op_UUID.Location = new System.Drawing.Point(48, 39);
            this.label_PlayerInfo_op_UUID.Name = "label_PlayerInfo_op_UUID";
            this.label_PlayerInfo_op_UUID.Size = new System.Drawing.Size(42, 17);
            this.label_PlayerInfo_op_UUID.TabIndex = 9;
            this.label_PlayerInfo_op_UUID.Text = "UUID:";
            // 
            // label_PlayerInfo_Name
            // 
            this.label_PlayerInfo_Name.AutoSize = true;
            this.label_PlayerInfo_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerInfo_Name.Location = new System.Drawing.Point(96, 23);
            this.label_PlayerInfo_Name.Name = "label_PlayerInfo_Name";
            this.label_PlayerInfo_Name.Size = new System.Drawing.Size(14, 17);
            this.label_PlayerInfo_Name.TabIndex = 8;
            this.label_PlayerInfo_Name.Text = "x";
            // 
            // label_PlayerInfo_ops_Name
            // 
            this.label_PlayerInfo_ops_Name.AutoSize = true;
            this.label_PlayerInfo_ops_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerInfo_ops_Name.Location = new System.Drawing.Point(44, 22);
            this.label_PlayerInfo_ops_Name.Name = "label_PlayerInfo_ops_Name";
            this.label_PlayerInfo_ops_Name.Size = new System.Drawing.Size(46, 17);
            this.label_PlayerInfo_ops_Name.TabIndex = 7;
            this.label_PlayerInfo_ops_Name.Text = "Name:";
            // 
            // button_PlayerInfo_Search
            // 
            this.button_PlayerInfo_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_PlayerInfo_Search.Location = new System.Drawing.Point(6, 34);
            this.button_PlayerInfo_Search.Name = "button_PlayerInfo_Search";
            this.button_PlayerInfo_Search.Size = new System.Drawing.Size(134, 25);
            this.button_PlayerInfo_Search.TabIndex = 1;
            this.button_PlayerInfo_Search.Text = "Search";
            this.button_PlayerInfo_Search.UseVisualStyleBackColor = true;
            this.button_PlayerInfo_Search.Click += new System.EventHandler(this.button_PlayerInfoSearch_Click);
            // 
            // tabControl_all
            // 
            this.tabControl_all.Controls.Add(this.tabPage_PlayerInfo);
            this.tabControl_all.Controls.Add(this.tabPage_ServerStatus);
            this.tabControl_all.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_all.Location = new System.Drawing.Point(12, 55);
            this.tabControl_all.Name = "tabControl_all";
            this.tabControl_all.SelectedIndex = 0;
            this.tabControl_all.Size = new System.Drawing.Size(589, 278);
            this.tabControl_all.TabIndex = 4;
            // 
            // tabPage_ServerStatus
            // 
            this.tabPage_ServerStatus.Controls.Add(this.richTextBox_ServerStatus);
            this.tabPage_ServerStatus.Controls.Add(this.button_ServerStatus_Ping);
            this.tabPage_ServerStatus.Controls.Add(this.textBox_ServerStatus_in_Port);
            this.tabPage_ServerStatus.Controls.Add(this.comboBox_ServerStatus_PingType);
            this.tabPage_ServerStatus.Controls.Add(this.textBox_ServerStatus_in_IP);
            this.tabPage_ServerStatus.Controls.Add(this.groupBox_ServerStatus);
            this.tabPage_ServerStatus.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ServerStatus.Name = "tabPage_ServerStatus";
            this.tabPage_ServerStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ServerStatus.Size = new System.Drawing.Size(581, 248);
            this.tabPage_ServerStatus.TabIndex = 1;
            this.tabPage_ServerStatus.Text = "ServerStatus";
            this.tabPage_ServerStatus.UseVisualStyleBackColor = true;
            // 
            // button_ServerStatus_Ping
            // 
            this.button_ServerStatus_Ping.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ServerStatus_Ping.Location = new System.Drawing.Point(54, 34);
            this.button_ServerStatus_Ping.Name = "button_ServerStatus_Ping";
            this.button_ServerStatus_Ping.Size = new System.Drawing.Size(69, 25);
            this.button_ServerStatus_Ping.TabIndex = 11;
            this.button_ServerStatus_Ping.Text = "Ping";
            this.button_ServerStatus_Ping.UseVisualStyleBackColor = true;
            this.button_ServerStatus_Ping.Click += new System.EventHandler(this.button_ServerStatus_Ping_Click);
            // 
            // textBox_ServerStatus_in_Port
            // 
            this.textBox_ServerStatus_in_Port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ServerStatus_in_Port.Location = new System.Drawing.Point(6, 35);
            this.textBox_ServerStatus_in_Port.MaxLength = 16;
            this.textBox_ServerStatus_in_Port.Name = "textBox_ServerStatus_in_Port";
            this.textBox_ServerStatus_in_Port.Size = new System.Drawing.Size(42, 23);
            this.textBox_ServerStatus_in_Port.TabIndex = 11;
            // 
            // comboBox_ServerStatus_PingType
            // 
            this.comboBox_ServerStatus_PingType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_ServerStatus_PingType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ServerStatus_PingType.FormattingEnabled = true;
            this.comboBox_ServerStatus_PingType.Items.AddRange(new object[] {
            "Java Ed.",
            "Bedrock Ed."});
            this.comboBox_ServerStatus_PingType.Location = new System.Drawing.Point(54, 34);
            this.comboBox_ServerStatus_PingType.Name = "comboBox_ServerStatus_PingType";
            this.comboBox_ServerStatus_PingType.Size = new System.Drawing.Size(86, 25);
            this.comboBox_ServerStatus_PingType.TabIndex = 9;
            // 
            // textBox_ServerStatus_in_IP
            // 
            this.textBox_ServerStatus_in_IP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ServerStatus_in_IP.Location = new System.Drawing.Point(6, 6);
            this.textBox_ServerStatus_in_IP.MaxLength = 16;
            this.textBox_ServerStatus_in_IP.Name = "textBox_ServerStatus_in_IP";
            this.textBox_ServerStatus_in_IP.Size = new System.Drawing.Size(134, 23);
            this.textBox_ServerStatus_in_IP.TabIndex = 10;
            this.textBox_ServerStatus_in_IP.Text = "TypeIPHere";
            // 
            // groupBox_ServerStatus
            // 
            this.groupBox_ServerStatus.Controls.Add(this.label_IsServerOnline);
            this.groupBox_ServerStatus.Controls.Add(this.label_ServerAddress);
            this.groupBox_ServerStatus.Controls.Add(this.label_op_ServerAddress);
            this.groupBox_ServerStatus.Controls.Add(this.pictureBox_ServerIcon);
            this.groupBox_ServerStatus.Controls.Add(this.label_op_link2);
            this.groupBox_ServerStatus.Controls.Add(this.linkLabel_mcsrvstat);
            this.groupBox_ServerStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ServerStatus.Location = new System.Drawing.Point(146, 6);
            this.groupBox_ServerStatus.Name = "groupBox_ServerStatus";
            this.groupBox_ServerStatus.Size = new System.Drawing.Size(429, 237);
            this.groupBox_ServerStatus.TabIndex = 12;
            this.groupBox_ServerStatus.TabStop = false;
            this.groupBox_ServerStatus.Text = "Result:";
            // 
            // label_IsServerOnline
            // 
            this.label_IsServerOnline.AutoSize = true;
            this.label_IsServerOnline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IsServerOnline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_IsServerOnline.Location = new System.Drawing.Point(78, 22);
            this.label_IsServerOnline.Name = "label_IsServerOnline";
            this.label_IsServerOnline.Size = new System.Drawing.Size(52, 17);
            this.label_IsServerOnline.TabIndex = 9;
            this.label_IsServerOnline.Text = "Waiting";
            // 
            // label_ServerAddress
            // 
            this.label_ServerAddress.AutoSize = true;
            this.label_ServerAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ServerAddress.Location = new System.Drawing.Point(164, 22);
            this.label_ServerAddress.Name = "label_ServerAddress";
            this.label_ServerAddress.Size = new System.Drawing.Size(14, 17);
            this.label_ServerAddress.TabIndex = 8;
            this.label_ServerAddress.Text = "x";
            // 
            // label_op_ServerAddress
            // 
            this.label_op_ServerAddress.AutoSize = true;
            this.label_op_ServerAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_ServerAddress.Location = new System.Drawing.Point(136, 22);
            this.label_op_ServerAddress.Name = "label_op_ServerAddress";
            this.label_op_ServerAddress.Size = new System.Drawing.Size(22, 17);
            this.label_op_ServerAddress.TabIndex = 7;
            this.label_op_ServerAddress.Text = "IP:";
            // 
            // pictureBox_ServerIcon
            // 
            this.pictureBox_ServerIcon.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_ServerIcon.Name = "pictureBox_ServerIcon";
            this.pictureBox_ServerIcon.Size = new System.Drawing.Size(66, 66);
            this.pictureBox_ServerIcon.TabIndex = 6;
            this.pictureBox_ServerIcon.TabStop = false;
            // 
            // label_op_link2
            // 
            this.label_op_link2.AutoSize = true;
            this.label_op_link2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_op_link2.Location = new System.Drawing.Point(293, 0);
            this.label_op_link2.Name = "label_op_link2";
            this.label_op_link2.Size = new System.Drawing.Size(41, 17);
            this.label_op_link2.TabIndex = 5;
            this.label_op_link2.Text = "Using";
            // 
            // richTextBox_ServerStatus
            // 
            this.richTextBox_ServerStatus.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ServerStatus.Location = new System.Drawing.Point(6, 63);
            this.richTextBox_ServerStatus.Name = "richTextBox_ServerStatus";
            this.richTextBox_ServerStatus.ReadOnly = true;
            this.richTextBox_ServerStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox_ServerStatus.Size = new System.Drawing.Size(134, 179);
            this.richTextBox_ServerStatus.TabIndex = 14;
            this.richTextBox_ServerStatus.Text = "";
            // 
            // LookuperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 357);
            this.Controls.Add(this.linkLabel_Github);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_op_designer);
            this.Controls.Add(this.tabControl_all);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LookuperUI";
            this.Text = "Minecraft Player Info Lookuper";
            this.Load += new System.EventHandler(this.LookuperUI_Load);
            this.tabPage_PlayerInfo.ResumeLayout(false);
            this.tabPage_PlayerInfo.PerformLayout();
            this.groupBox_PlayerInfo_Result.ResumeLayout(false);
            this.groupBox_PlayerInfo_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerCape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerInfo_PlayerSkin)).EndInit();
            this.tabControl_all.ResumeLayout(false);
            this.tabPage_ServerStatus.ResumeLayout(false);
            this.tabPage_ServerStatus.PerformLayout();
            this.groupBox_ServerStatus.ResumeLayout(false);
            this.groupBox_ServerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ServerIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_Mojang;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_op_link;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_op_designer;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TabPage tabPage_PlayerInfo;
        private System.Windows.Forms.RichTextBox richTextBox_PlayerInfo_RawInfo;
        internal System.Windows.Forms.TextBox textBox_PlayerInfo_in_Name;
        private System.Windows.Forms.GroupBox groupBox_PlayerInfo_Result;
        private System.Windows.Forms.Button button_PlayerInfo_SaveCape;
        private System.Windows.Forms.PictureBox pictureBox_PlayerInfo_PlayerCape;
        private System.Windows.Forms.Button button_PlayerInfo_SaveSkin;
        private System.Windows.Forms.PictureBox pictureBox_PlayerInfo_PlayerHead;
        private System.Windows.Forms.PictureBox pictureBox_PlayerInfo_PlayerSkin;
        private System.Windows.Forms.Label label_PlayerInfo_UUID;
        private System.Windows.Forms.Label label_PlayerInfo_op_UUID;
        private System.Windows.Forms.Label label_PlayerInfo_Name;
        private System.Windows.Forms.Label label_PlayerInfo_ops_Name;
        private System.Windows.Forms.Button button_PlayerInfo_Search;
        private System.Windows.Forms.TabControl tabControl_all;
        private System.Windows.Forms.TabPage tabPage_ServerStatus;
        private System.Windows.Forms.Button button_ServerStatus_Ping;
        internal System.Windows.Forms.TextBox textBox_ServerStatus_in_Port;
        internal System.Windows.Forms.TextBox textBox_ServerStatus_in_IP;
        private System.Windows.Forms.GroupBox groupBox_ServerStatus;
        private System.Windows.Forms.ComboBox comboBox_ServerStatus_PingType;
        private System.Windows.Forms.Label label_op_link2;
        private System.Windows.Forms.LinkLabel linkLabel_mcsrvstat;
        private System.Windows.Forms.LinkLabel linkLabel_Github;
        private System.Windows.Forms.PictureBox pictureBox_ServerIcon;
        private System.Windows.Forms.Label label_op_ServerAddress;
        private System.Windows.Forms.Label label_ServerAddress;
        private System.Windows.Forms.Label label_IsServerOnline;
        private System.Windows.Forms.RichTextBox richTextBox_ServerStatus;
    }
}

