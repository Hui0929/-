using System;

namespace ojMovie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvMovies = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpToday = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCalcPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.片名 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbDisCount = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoFree = new System.Windows.Forms.RadioButton();
            this.tbSeat = new System.Windows.Forms.TabControl();
            this.tpCinema = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpToday.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuy,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1626, 26);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiBuy
            // 
            this.tsmiBuy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiMovies,
            this.toolStripSeparator1,
            this.tsmiSave,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.tsmiBuy.Name = "tsmiBuy";
            this.tsmiBuy.Size = new System.Drawing.Size(56, 22);
            this.tsmiBuy.Text = "购票";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(208, 26);
            this.tsmiNew.Text = "获取新放映列表";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click_1);
            // 
            // tsmiMovies
            // 
            this.tsmiMovies.Name = "tsmiMovies";
            this.tsmiMovies.Size = new System.Drawing.Size(208, 26);
            this.tsmiMovies.Text = "继续销售";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(208, 26);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(208, 26);
            this.tsmiExit.Text = "退出";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(56, 22);
            this.tsmiHelp.Text = "系统";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // tvMovies
            // 
            this.tvMovies.Location = new System.Drawing.Point(15, 18);
            this.tvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.tvMovies.Name = "tvMovies";
            this.tvMovies.Size = new System.Drawing.Size(279, 754);
            this.tvMovies.TabIndex = 1;
            this.tvMovies.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMovies_AfterSelect);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpToday);
            this.tabControl2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl2.Location = new System.Drawing.Point(13, 50);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(329, 842);
            this.tabControl2.TabIndex = 2;
            // 
            // tpToday
            // 
            this.tpToday.Controls.Add(this.tvMovies);
            this.tpToday.Location = new System.Drawing.Point(4, 27);
            this.tpToday.Margin = new System.Windows.Forms.Padding(4);
            this.tpToday.Name = "tpToday";
            this.tpToday.Padding = new System.Windows.Forms.Padding(4);
            this.tpToday.Size = new System.Drawing.Size(321, 811);
            this.tpToday.TabIndex = 0;
            this.tpToday.Text = "放映列表";
            this.tpToday.UseVisualStyleBackColor = true;
            this.tpToday.Click += new System.EventHandler(this.tpToday_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCalcPrice);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblActor);
            this.groupBox1.Controls.Add(this.lblDirector);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picMovie);
            this.groupBox1.Controls.Add(this.lblMovieName);
            this.groupBox1.Controls.Add(this.片名);
            this.groupBox1.Location = new System.Drawing.Point(377, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(758, 288);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // lblCalcPrice
            // 
            this.lblCalcPrice.AutoSize = true;
            this.lblCalcPrice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCalcPrice.ForeColor = System.Drawing.Color.Red;
            this.lblCalcPrice.Location = new System.Drawing.Point(411, 235);
            this.lblCalcPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcPrice.Name = "lblCalcPrice";
            this.lblCalcPrice.Size = new System.Drawing.Size(71, 18);
            this.lblCalcPrice.TabIndex = 14;
            this.lblCalcPrice.Text = "label11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(297, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "优惠价：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.Location = new System.Drawing.Point(411, 194);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 18);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "label11";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(411, 155);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 18);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "label11";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.Location = new System.Drawing.Point(411, 115);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 18);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "label11";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblActor.Location = new System.Drawing.Point(411, 71);
            this.lblActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(71, 18);
            this.lblActor.TabIndex = 9;
            this.lblActor.Text = "label11";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDirector.Location = new System.Drawing.Point(411, 32);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(71, 18);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(297, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(297, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "主演：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(297, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "导演：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(297, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "原票价：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(297, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "放映时间：";
            // 
            // picMovie
            // 
            this.picMovie.BackColor = System.Drawing.SystemColors.Control;
            this.picMovie.Location = new System.Drawing.Point(29, 52);
            this.picMovie.Margin = new System.Windows.Forms.Padding(4);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(171, 215);
            this.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMovie.TabIndex = 2;
            this.picMovie.TabStop = false;
            this.picMovie.Click += new System.EventHandler(this.picMovie_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMovieName.Location = new System.Drawing.Point(135, 26);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(62, 18);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "label1";
            // 
            // 片名
            // 
            this.片名.AutoSize = true;
            this.片名.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.片名.Location = new System.Drawing.Point(27, 26);
            this.片名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.片名.Name = "片名";
            this.片名.Size = new System.Drawing.Size(62, 18);
            this.片名.TabIndex = 0;
            this.片名.Text = "片名：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1307, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNormal);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbDisCount);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.rdoStudent);
            this.groupBox2.Controls.Add(this.rdoFree);
            this.groupBox2.Location = new System.Drawing.Point(1191, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 151);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "特殊票：";
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNormal.Location = new System.Drawing.Point(49, 26);
            this.rdoNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(83, 22);
            this.rdoNormal.TabIndex = 4;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "普通票";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.rdoNormal_CheckedChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomer.Location = new System.Drawing.Point(147, 109);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(132, 27);
            this.txtCustomer.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(55, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "赠送者：";
            // 
            // cmbDisCount
            // 
            this.cmbDisCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDisCount.FormattingEnabled = true;
            this.cmbDisCount.Items.AddRange(new object[] {
            "8",
            "9"});
            this.cmbDisCount.Location = new System.Drawing.Point(147, 62);
            this.cmbDisCount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDisCount.Name = "cmbDisCount";
            this.cmbDisCount.Size = new System.Drawing.Size(132, 25);
            this.cmbDisCount.TabIndex = 7;
            this.cmbDisCount.SelectedIndexChanged += new System.EventHandler(this.cmbDisCount_SelectedIndexChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(41, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "学生折扣：";
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoStudent.Location = new System.Drawing.Point(225, 26);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(4);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(83, 22);
            this.rdoStudent.TabIndex = 6;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "学生票";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // rdoFree
            // 
            this.rdoFree.AutoSize = true;
            this.rdoFree.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoFree.Location = new System.Drawing.Point(147, 26);
            this.rdoFree.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFree.Name = "rdoFree";
            this.rdoFree.Size = new System.Drawing.Size(65, 22);
            this.rdoFree.TabIndex = 5;
            this.rdoFree.TabStop = true;
            this.rdoFree.Text = "赠票";
            this.rdoFree.UseVisualStyleBackColor = true;
            this.rdoFree.CheckedChanged += new System.EventHandler(this.rdoFree_CheckedChanged);
            // 
            // tbSeat
            // 
            this.tbSeat.Controls.Add(this.tpCinema);
            this.tbSeat.Location = new System.Drawing.Point(392, 379);
            this.tbSeat.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.SelectedIndex = 0;
            this.tbSeat.Size = new System.Drawing.Size(1001, 513);
            this.tbSeat.TabIndex = 16;
            // 
            // tpCinema
            // 
            this.tpCinema.Location = new System.Drawing.Point(4, 25);
            this.tpCinema.Margin = new System.Windows.Forms.Padding(4);
            this.tpCinema.Name = "tpCinema";
            this.tpCinema.Padding = new System.Windows.Forms.Padding(4);
            this.tpCinema.Size = new System.Drawing.Size(993, 484);
            this.tpCinema.TabIndex = 0;
            this.tpCinema.Text = "放映厅";
            this.tpCinema.UseVisualStyleBackColor = true;
            this.tpCinema.Click += new System.EventHandler(this.tpCinema_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1626, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSeat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.msMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpToday.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbSeat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void picMovie_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tpToday_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuy;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TreeView tvMovies;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpToday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCalcPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label 片名;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDisCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoFree;
        private System.Windows.Forms.TabControl tbSeat;
        private System.Windows.Forms.TabPage tpCinema;
        private System.Windows.Forms.Label label2;
    }
}

