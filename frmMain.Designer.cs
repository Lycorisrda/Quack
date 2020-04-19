namespace Quack_
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHrs = new System.Windows.Forms.ComboBox();
            this.chkTimerEnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLogout = new System.Windows.Forms.CheckBox();
            this.cmbTeleportLocation = new System.Windows.Forms.ComboBox();
            this.chkTeleport = new System.Windows.Forms.CheckBox();
            this.cmbMins = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMins);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTimeLeft);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbHrs);
            this.groupBox1.Controls.Add(this.chkTimerEnable);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(403, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(139, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "刷新时间";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "结束时间:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(160, 116);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(56, 16);
            this.lblTimeLeft.TabIndex = 5;
            this.lblTimeLeft.Text = "000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "     分:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "时:";
            // 
            // cmbHrs
            // 
            this.cmbHrs.FormattingEnabled = true;
            this.cmbHrs.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHrs.Location = new System.Drawing.Point(308, 37);
            this.cmbHrs.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHrs.Name = "cmbHrs";
            this.cmbHrs.Size = new System.Drawing.Size(56, 29);
            this.cmbHrs.TabIndex = 1;
            this.cmbHrs.Text = "0";
            // 
            // chkTimerEnable
            // 
            this.chkTimerEnable.AutoSize = true;
            this.chkTimerEnable.Location = new System.Drawing.Point(23, 40);
            this.chkTimerEnable.Margin = new System.Windows.Forms.Padding(5);
            this.chkTimerEnable.Name = "chkTimerEnable";
            this.chkTimerEnable.Size = new System.Drawing.Size(61, 25);
            this.chkTimerEnable.TabIndex = 0;
            this.chkTimerEnable.Text = "启用";
            this.chkTimerEnable.UseVisualStyleBackColor = true;
            this.chkTimerEnable.CheckedChanged += new System.EventHandler(this.chkTimerEnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLogout);
            this.groupBox2.Controls.Add(this.cmbTeleportLocation);
            this.groupBox2.Controls.Add(this.chkTeleport);
            this.groupBox2.Location = new System.Drawing.Point(20, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(403, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结束之后";
            // 
            // chkLogout
            // 
            this.chkLogout.AutoSize = true;
            this.chkLogout.Location = new System.Drawing.Point(23, 116);
            this.chkLogout.Margin = new System.Windows.Forms.Padding(5);
            this.chkLogout.Name = "chkLogout";
            this.chkLogout.Size = new System.Drawing.Size(93, 25);
            this.chkLogout.TabIndex = 9;
            this.chkLogout.Text = "关闭游戏";
            this.chkLogout.UseVisualStyleBackColor = true;
            this.chkLogout.CheckedChanged += new System.EventHandler(this.chkLogout_CheckedChanged);
            // 
            // cmbTeleportLocation
            // 
            this.cmbTeleportLocation.FormattingEnabled = true;
            this.cmbTeleportLocation.Items.AddRange(new object[] {
            "格里达尼亚新街",
            "弯枝牧场",
            "霍桑山寨",
            "石场水车",
            "恬静路营地",
            "秋瓜浮村",
            "利姆萨·罗敏萨下层甲板",
            "乌尔达哈现世回廊",
            "莫拉比造船厂",
            "太阳海岸",
            "葡萄酒港",
            "雨燕塔殖民地",
            "小麦酒港",
            "石绿湖营地",
            "瞭望阵营地",
            "地平关",
            "枯骨营地",
            "小阿拉米格",
            "遗忘绿洲",
            "蓝雾营地",
            "青磷精炼所",
            "巨龙首营地",
            "丧灵钟",
            "盛夏农庄",
            "黑尘驿站",
            "狼狱停船场",
            "部队房屋(海雾村)",
            "部队房屋(薰衣草苗圃)",
            "部队房屋(高脚孤丘)",
            "个人房屋(海雾村)",
            "个人房屋(薰衣草苗圃)",
            "个人房屋(高脚孤丘)",
            "金碟游乐场",
            "伊修加德基础层",
            "隼巢",
            "云顶营地",
            "尊杜集落",
            "螺旋港",
            "田园郡",
            "尾羽集落",
            "不洁三塔",
            "莫古力之家",
            "天极白垩宫"});
            this.cmbTeleportLocation.Location = new System.Drawing.Point(94, 45);
            this.cmbTeleportLocation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTeleportLocation.Name = "cmbTeleportLocation";
            this.cmbTeleportLocation.Size = new System.Drawing.Size(287, 29);
            this.cmbTeleportLocation.TabIndex = 8;
            this.cmbTeleportLocation.SelectedIndexChanged += new System.EventHandler(this.cmbTeleportLocation_SelectedIndexChanged);
            // 
            // chkTeleport
            // 
            this.chkTeleport.AutoSize = true;
            this.chkTeleport.Location = new System.Drawing.Point(23, 47);
            this.chkTeleport.Margin = new System.Windows.Forms.Padding(5);
            this.chkTeleport.Name = "chkTeleport";
            this.chkTeleport.Size = new System.Drawing.Size(61, 25);
            this.chkTeleport.TabIndex = 7;
            this.chkTeleport.Text = "传送";
            this.chkTeleport.UseVisualStyleBackColor = true;
            this.chkTeleport.CheckedChanged += new System.EventHandler(this.chkTeleport_CheckedChanged);
            // 
            // cmbMins
            // 
            this.cmbMins.Location = new System.Drawing.Point(308, 75);
            this.cmbMins.Name = "cmbMins";
            this.cmbMins.Size = new System.Drawing.Size(56, 29);
            this.cmbMins.TabIndex = 8;
            this.cmbMins.Text = "5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(442, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Quack! ...";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTimerEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHrs;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTeleportLocation;
        private System.Windows.Forms.CheckBox chkTeleport;
        private System.Windows.Forms.CheckBox chkLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cmbMins;
    }
}