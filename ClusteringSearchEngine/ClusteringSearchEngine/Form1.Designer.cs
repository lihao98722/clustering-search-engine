namespace ClusteringSearchEngine
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelAdvance = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.panelDatabase = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.labelDatebase = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelDownloadPic = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.labelDownloadPic = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelResult = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.panelWebPage = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelAnalyze = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.label7 = new ClusteringSearchEngine.MyLable(this.components);
            this.panelAnalyzeShow = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.labelBingCount = new System.Windows.Forms.Label();
            this.labelGoogleCount = new System.Windows.Forms.Label();
            this.labelBaiduCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProc = new ClusteringSearchEngine.MyPanel(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdvance = new ClusteringSearchEngine.MyLabelProc(this.components);
            this.labelCapture = new ClusteringSearchEngine.MyLabelProc(this.components);
            this.labelResult = new ClusteringSearchEngine.MyLabelProc(this.components);
            this.labelAnalyze = new ClusteringSearchEngine.MyLabelProc(this.components);
            this.labelSearch = new ClusteringSearchEngine.MyLabelProc(this.components);
            this.panelSearch = new ClusteringSearchEngine.MyPanelCenter(this.components);
            this.labelDoSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelBottom = new ClusteringSearchEngine.MyPanel(this.components);
            this.PanelRight = new ClusteringSearchEngine.MyPanel(this.components);
            this.panelLeft = new ClusteringSearchEngine.MyPanel(this.components);
            this.panelTop = new ClusteringSearchEngine.MyPanel(this.components);
            this.webBrowserForCapture = new System.Windows.Forms.WebBrowser();
            this.labelMin = new ClusteringSearchEngine.MyLable(this.components);
            this.labelQuit = new ClusteringSearchEngine.MyLable(this.components);
            this.panelAdvance.SuspendLayout();
            this.panelDatabase.SuspendLayout();
            this.panelDownloadPic.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelWebPage.SuspendLayout();
            this.panelAnalyze.SuspendLayout();
            this.panelAnalyzeShow.SuspendLayout();
            this.panelProc.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdvance
            // 
            this.panelAdvance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAdvance.Controls.Add(this.panelDatabase);
            this.panelAdvance.Controls.Add(this.panelDownloadPic);
            this.panelAdvance.Location = new System.Drawing.Point(264, 26);
            this.panelAdvance.Name = "panelAdvance";
            this.panelAdvance.Size = new System.Drawing.Size(29, 23);
            this.panelAdvance.TabIndex = 6;
            // 
            // panelDatabase
            // 
            this.panelDatabase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDatabase.Controls.Add(this.textBoxTableName);
            this.panelDatabase.Controls.Add(this.textBoxPw);
            this.panelDatabase.Controls.Add(this.textBoxDBName);
            this.panelDatabase.Controls.Add(this.textBoxAccount);
            this.panelDatabase.Controls.Add(this.labelDatebase);
            this.panelDatabase.Controls.Add(this.label12);
            this.panelDatabase.Controls.Add(this.label);
            this.panelDatabase.Controls.Add(this.label11);
            this.panelDatabase.Controls.Add(this.label13);
            this.panelDatabase.Controls.Add(this.label14);
            this.panelDatabase.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelDatabase.Location = new System.Drawing.Point(0, 168);
            this.panelDatabase.Name = "panelDatabase";
            this.panelDatabase.Size = new System.Drawing.Size(606, 267);
            this.panelDatabase.TabIndex = 5;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(357, 112);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(197, 29);
            this.textBoxTableName.TabIndex = 4;
            this.textBoxTableName.Text = "searchresult";
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(89, 118);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '*';
            this.textBoxPw.Size = new System.Drawing.Size(100, 29);
            this.textBoxPw.TabIndex = 4;
            this.textBoxPw.Text = "root";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Location = new System.Drawing.Point(357, 75);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(197, 29);
            this.textBoxDBName.TabIndex = 4;
            this.textBoxDBName.Text = "clusteringsearchengine";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(89, 83);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(100, 29);
            this.textBoxAccount.TabIndex = 4;
            this.textBoxAccount.Text = "root";
            // 
            // labelDatebase
            // 
            this.labelDatebase.AutoSize = true;
            this.labelDatebase.BackColor = System.Drawing.Color.OrangeRed;
            this.labelDatebase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDatebase.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDatebase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDatebase.Location = new System.Drawing.Point(227, 195);
            this.labelDatebase.Name = "labelDatebase";
            this.labelDatebase.Size = new System.Drawing.Size(52, 27);
            this.labelDatebase.TabIndex = 3;
            this.labelDatebase.Text = "保存";
            this.labelDatebase.Click += new System.EventHandler(this.labelDatebase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "密码";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(293, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 19);
            this.label.TabIndex = 1;
            this.label.Text = "表名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "数据库";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "用户名";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "保存至数据库";
            // 
            // panelDownloadPic
            // 
            this.panelDownloadPic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDownloadPic.Controls.Add(this.labelDownloadPic);
            this.panelDownloadPic.Controls.Add(this.comboBox1);
            this.panelDownloadPic.Controls.Add(this.label10);
            this.panelDownloadPic.Controls.Add(this.label9);
            this.panelDownloadPic.Controls.Add(this.label8);
            this.panelDownloadPic.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelDownloadPic.Location = new System.Drawing.Point(3, 10);
            this.panelDownloadPic.Name = "panelDownloadPic";
            this.panelDownloadPic.Size = new System.Drawing.Size(603, 159);
            this.panelDownloadPic.TabIndex = 5;
            // 
            // labelDownloadPic
            // 
            this.labelDownloadPic.AutoSize = true;
            this.labelDownloadPic.BackColor = System.Drawing.Color.OrangeRed;
            this.labelDownloadPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDownloadPic.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDownloadPic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDownloadPic.Location = new System.Drawing.Point(288, 63);
            this.labelDownloadPic.Name = "labelDownloadPic";
            this.labelDownloadPic.Size = new System.Drawing.Size(52, 27);
            this.labelDownloadPic.TabIndex = 3;
            this.labelDownloadPic.Text = "下载";
            this.labelDownloadPic.Click += new System.EventHandler(this.labelDownloadPic_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "个网页";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "下载前";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "批量下载网页快照";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Gainsboro;
            this.panelResult.Controls.Add(this.panelWebPage);
            this.panelResult.Controls.Add(this.panelTitle);
            this.panelResult.Location = new System.Drawing.Point(212, 26);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(30, 16);
            this.panelResult.TabIndex = 4;
            // 
            // panelWebPage
            // 
            this.panelWebPage.BackColor = System.Drawing.Color.White;
            this.panelWebPage.Controls.Add(this.webBrowser1);
            this.panelWebPage.Location = new System.Drawing.Point(256, 3);
            this.panelWebPage.Name = "panelWebPage";
            this.panelWebPage.Size = new System.Drawing.Size(357, 457);
            this.panelWebPage.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(5, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(349, 454);
            this.webBrowser1.TabIndex = 4;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoScroll = true;
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelTitle.Location = new System.Drawing.Point(3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(24, 10);
            this.panelTitle.TabIndex = 0;
            // 
            // panelAnalyze
            // 
            this.panelAnalyze.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAnalyze.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.panelAnalyze.Controls.Add(this.label7);
            this.panelAnalyze.Controls.Add(this.panelAnalyzeShow);
            this.panelAnalyze.Location = new System.Drawing.Point(183, 26);
            this.panelAnalyze.Name = "panelAnalyze";
            this.panelAnalyze.Size = new System.Drawing.Size(20, 16);
            this.panelAnalyze.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(135, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "获取聚类结果";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panelAnalyzeShow
            // 
            this.panelAnalyzeShow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelAnalyzeShow.BackColor = System.Drawing.Color.Transparent;
            this.panelAnalyzeShow.Controls.Add(this.labelBingCount);
            this.panelAnalyzeShow.Controls.Add(this.labelGoogleCount);
            this.panelAnalyzeShow.Controls.Add(this.labelBaiduCount);
            this.panelAnalyzeShow.Controls.Add(this.label3);
            this.panelAnalyzeShow.Controls.Add(this.label2);
            this.panelAnalyzeShow.Controls.Add(this.label6);
            this.panelAnalyzeShow.Controls.Add(this.label5);
            this.panelAnalyzeShow.Controls.Add(this.label4);
            this.panelAnalyzeShow.Controls.Add(this.label1);
            this.panelAnalyzeShow.Location = new System.Drawing.Point(21, 29);
            this.panelAnalyzeShow.Name = "panelAnalyzeShow";
            this.panelAnalyzeShow.Size = new System.Drawing.Size(323, 248);
            this.panelAnalyzeShow.TabIndex = 2;
            // 
            // labelBingCount
            // 
            this.labelBingCount.AutoSize = true;
            this.labelBingCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBingCount.ForeColor = System.Drawing.Color.Red;
            this.labelBingCount.Location = new System.Drawing.Point(173, 214);
            this.labelBingCount.Name = "labelBingCount";
            this.labelBingCount.Size = new System.Drawing.Size(113, 26);
            this.labelBingCount.TabIndex = 1;
            this.labelBingCount.Text = "BingCount";
            // 
            // labelGoogleCount
            // 
            this.labelGoogleCount.AutoSize = true;
            this.labelGoogleCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGoogleCount.ForeColor = System.Drawing.Color.Red;
            this.labelGoogleCount.Location = new System.Drawing.Point(173, 136);
            this.labelGoogleCount.Name = "labelGoogleCount";
            this.labelGoogleCount.Size = new System.Drawing.Size(138, 26);
            this.labelGoogleCount.TabIndex = 1;
            this.labelGoogleCount.Text = "GoogleCount";
            // 
            // labelBaiduCount
            // 
            this.labelBaiduCount.AutoSize = true;
            this.labelBaiduCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBaiduCount.ForeColor = System.Drawing.Color.Red;
            this.labelBaiduCount.Location = new System.Drawing.Point(173, 56);
            this.labelBaiduCount.Name = "labelBaiduCount";
            this.labelBaiduCount.Size = new System.Drawing.Size(124, 26);
            this.labelBaiduCount.TabIndex = 1;
            this.labelBaiduCount.Text = "BaiduCount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "正在从 Bing 获取结果 . . . . . .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "正在从 Google 获取结果 . . . . . .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "已获取结果条数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "已获取结果条数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "已获取结果条数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "正在从 Baidu 获取结果 . . . . . .";
            // 
            // panelProc
            // 
            this.panelProc.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.panelProc.Controls.Add(this.labelAdvance);
            this.panelProc.Controls.Add(this.labelCapture);
            this.panelProc.Controls.Add(this.labelResult);
            this.panelProc.Controls.Add(this.labelAnalyze);
            this.panelProc.Controls.Add(this.labelSearch);
            this.panelProc.Location = new System.Drawing.Point(12, 31);
            this.panelProc.Name = "panelProc";
            this.panelProc.Size = new System.Drawing.Size(132, 456);
            this.panelProc.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.ForeColor = System.Drawing.Color.Crimson;
            this.labelName.Location = new System.Drawing.Point(201, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(183, 42);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "MyCluster";
            // 
            // labelAdvance
            // 
            this.labelAdvance.AutoSize = true;
            this.labelAdvance.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvance.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAdvance.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelAdvance.Location = new System.Drawing.Point(17, 308);
            this.labelAdvance.Name = "labelAdvance";
            this.labelAdvance.Size = new System.Drawing.Size(90, 21);
            this.labelAdvance.TabIndex = 1;
            this.labelAdvance.Text = "高级功能";
            this.labelAdvance.Click += new System.EventHandler(this.labelAdvance_Click);
            // 
            // labelCapture
            // 
            this.labelCapture.AutoSize = true;
            this.labelCapture.BackColor = System.Drawing.Color.Transparent;
            this.labelCapture.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCapture.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelCapture.Location = new System.Drawing.Point(17, 247);
            this.labelCapture.Name = "labelCapture";
            this.labelCapture.Size = new System.Drawing.Size(90, 21);
            this.labelCapture.TabIndex = 1;
            this.labelCapture.Text = "查看快照";
            this.labelCapture.Click += new System.EventHandler(this.labelCapture_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelResult.Location = new System.Drawing.Point(17, 187);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(90, 21);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "结果展示";
            // 
            // labelAnalyze
            // 
            this.labelAnalyze.AutoSize = true;
            this.labelAnalyze.BackColor = System.Drawing.Color.Transparent;
            this.labelAnalyze.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAnalyze.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelAnalyze.Location = new System.Drawing.Point(17, 123);
            this.labelAnalyze.Name = "labelAnalyze";
            this.labelAnalyze.Size = new System.Drawing.Size(90, 21);
            this.labelAnalyze.TabIndex = 1;
            this.labelAnalyze.Text = "过程分析";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Red;
            this.labelSearch.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSearch.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.labelSearch.Location = new System.Drawing.Point(17, 62);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(90, 21);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "聚类搜索";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSearch.Controls.Add(this.labelName);
            this.panelSearch.Controls.Add(this.labelDoSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelSearch.Location = new System.Drawing.Point(165, 81);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(570, 253);
            this.panelSearch.TabIndex = 3;
            // 
            // labelDoSearch
            // 
            this.labelDoSearch.AutoSize = true;
            this.labelDoSearch.BackColor = System.Drawing.Color.OldLace;
            this.labelDoSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDoSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDoSearch.ForeColor = System.Drawing.Color.Orange;
            this.labelDoSearch.Location = new System.Drawing.Point(241, 182);
            this.labelDoSearch.Name = "labelDoSearch";
            this.labelDoSearch.Size = new System.Drawing.Size(88, 26);
            this.labelDoSearch.TabIndex = 1;
            this.labelDoSearch.Text = "聚类搜索";
            this.labelDoSearch.Click += new System.EventHandler(this.labelDoSearch_Click);
            this.labelDoSearch.MouseEnter += new System.EventHandler(this.labelDoSearch_MouseEnter);
            this.labelDoSearch.MouseLeave += new System.EventHandler(this.labelDoSearch_MouseLeave);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSearch.Location = new System.Drawing.Point(143, 118);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(298, 23);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.panelBottom.Location = new System.Drawing.Point(12, 493);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(770, 16);
            this.panelBottom.TabIndex = 2;
            // 
            // PanelRight
            // 
            this.PanelRight.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.PanelRight.Location = new System.Drawing.Point(772, 23);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(10, 475);
            this.PanelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.panelLeft.Location = new System.Drawing.Point(0, 23);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 475);
            this.panelLeft.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::ClusteringSearchEngine.Properties.Resources.topBackColor;
            this.panelTop.Controls.Add(this.webBrowserForCapture);
            this.panelTop.Controls.Add(this.labelMin);
            this.panelTop.Controls.Add(this.labelQuit);
            this.panelTop.Location = new System.Drawing.Point(0, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(782, 23);
            this.panelTop.TabIndex = 0;
            this.panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            // 
            // webBrowserForCapture
            // 
            this.webBrowserForCapture.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserForCapture.Location = new System.Drawing.Point(504, 0);
            this.webBrowserForCapture.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserForCapture.Name = "webBrowserForCapture";
            this.webBrowserForCapture.ScrollBarsEnabled = false;
            this.webBrowserForCapture.Size = new System.Drawing.Size(20, 20);
            this.webBrowserForCapture.TabIndex = 5;
            this.webBrowserForCapture.Visible = false;
            this.webBrowserForCapture.WebBrowserShortcutsEnabled = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMin.Location = new System.Drawing.Point(735, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 19);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "—";
            this.labelMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.BackColor = System.Drawing.Color.Transparent;
            this.labelQuit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelQuit.Location = new System.Drawing.Point(761, 0);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(21, 22);
            this.labelQuit.TabIndex = 1;
            this.labelQuit.Text = "X";
            this.labelQuit.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.panelAdvance);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelAnalyze);
            this.Controls.Add(this.panelProc);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAdvance.ResumeLayout(false);
            this.panelDatabase.ResumeLayout(false);
            this.panelDatabase.PerformLayout();
            this.panelDownloadPic.ResumeLayout(false);
            this.panelDownloadPic.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelWebPage.ResumeLayout(false);
            this.panelAnalyze.ResumeLayout(false);
            this.panelAnalyze.PerformLayout();
            this.panelAnalyzeShow.ResumeLayout(false);
            this.panelAnalyzeShow.PerformLayout();
            this.panelProc.ResumeLayout(false);
            this.panelProc.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        private MyLable labelQuit;
        private MyLable labelMin;
        private MyPanel panelTop;
        private MyPanel panelLeft;
        private MyPanel panelBottom;
        private MyPanel PanelRight;
        private MyPanelCenter panelSearch;
        private MyPanel panelProc;
        private MyLabelProc labelSearch;
        private MyLabelProc labelAnalyze;
        private MyLabelProc labelAdvance;
        private MyLabelProc labelCapture;
        private MyLabelProc labelResult;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelDoSearch;
        private MyPanelCenter panelAnalyzeShow;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelBingCount;
        private System.Windows.Forms.Label labelGoogleCount;
        private System.Windows.Forms.Label labelBaiduCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MyPanelCenter panelAnalyze;
        private MyPanelCenter panelResult;
        private MyLable label7;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelWebPage;
        private System.Windows.Forms.WebBrowser webBrowserForCapture;
        private MyPanelCenter panelDownloadPic;
        private System.Windows.Forms.Label labelDownloadPic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MyPanelCenter panelAdvance;
        private MyPanelCenter panelDatabase;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label labelDatebase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelName;
    }
}

