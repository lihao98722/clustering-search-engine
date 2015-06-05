using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClusteringSearchEngine
{
    public partial class Form1 : Form
    {
        #region 控制界面变量
        private Point point = new Point(-10, -10);
        private List<MyLabelTitle> TitleLabels = null;
        #endregion

        #region 提供给外部类使用
        private static Form1 Form1Instance;
        public static Form1 getInstance()
        {
            return Form1Instance;
        }

        public WebBrowser getWebBrowserForCapture()
        {
            return this.webBrowserForCapture;
        }

        public WebBrowser getWebBrowser() 
        {
            return this.webBrowser1;
        }

        public Panel getPanelSearch()
        {
            return this.panelSearch;
        }

        public List<MyLabelTitle> getTitleTables()
        {
            return this.TitleLabels;
        }

        public List<Keyword> getResutlKeywords()
        {
            return this.ResultKeywords;
        }
        #endregion

        #region 搜索引擎变量
        //再次搜索时就能复用对象
        private BaiduSearch baiduSearch = new BaiduSearch();
        private GoogleSearch googleSearch = new GoogleSearch();
        private BingSearch bingSearch = new BingSearch();
        private List<Keyword> BaiduKeywords;
        private List<Keyword> GoogleKeywords;
        private List<Keyword> BingKeywords;
        private List<List<Keyword>> AllListKeywords = new List<List<Keyword>>();
        private List<Keyword> ResultKeywords = null;
        #endregion

        private CaptureWebPage captureWebPage = null;

        public Form1()
        {
            //一定要在InitializeComponent之前赋值，否则在调用getInstance的时候Form1Instance对象为null
            //因为组件的生成在InitializeComponent()之前
            Form1Instance = this; 
            InitializeComponent();
            #region 总布局调整
            this.panelTop.Size = new Size(this.Width, labelQuit.Height);
            this.panelTop.Location = this.Location;
            this.labelQuit.Location = new Point(this.panelTop.Width - this.labelQuit.Width, this.panelTop.Location.Y);
            this.labelMin.Location = new Point(this.labelQuit.Location.X - this.labelMin.Width, this.panelTop.Location.Y);            
            this.panelLeft.Size = new Size(10, this.Height - this.panelTop.Height - 10);
            this.panelLeft.Location = new Point(this.Location.X, this.Location.Y + this.panelTop.Height);
            this.PanelRight.Size = this.panelLeft.Size;
            this.PanelRight.Location = new Point(this.Width - this.PanelRight.Width, this.panelLeft.Location.Y);
            this.panelBottom.Size = new Size(this.Width, this.panelLeft.Width);
            this.panelBottom.Location = new Point(this.Location.X, this.Height - this.panelBottom.Height);
            this.panelProc.Size = new Size(110, this.panelLeft.Height);
            this.panelProc.Location = new Point(this.panelLeft.Location.X + this.panelLeft.Width, this.panelLeft.Location.Y);
            this.panelSearch.Size = new Size(this.Width - this.panelLeft.Width - this.panelProc.Width - this.PanelRight.Width, this.panelProc.Height);
            this.panelSearch.Location = new Point(this.panelProc.Location.X + this.panelProc.Width, this.panelProc.Location.Y);
            this.labelSearch.Location = new Point((this.panelProc.Width - this.labelSearch.Width) / 2, 
                this.labelSearch.Height * 3);
            this.labelAnalyze.Location = new Point(this.labelSearch.Location.X, 
                this.labelSearch.Location.Y + 3 * this.labelSearch.Height);
            this.labelResult.Location = new Point(this.labelSearch.Location.X,
                this.labelAnalyze.Location.Y + 3 * this.labelSearch.Height);
            this.labelCapture.Location = new Point(this.labelSearch.Location.X,
               this.labelResult.Location.Y + 3 * this.labelSearch.Height);
            this.labelAdvance.Location = new Point(this.labelSearch.Location.X,
              this.labelCapture.Location.Y + 3 * this.labelSearch.Height);

            this.labelName.Location = new Point((this.panelSearch.Width - this.labelName.Width) / 2, 100);
            this.textBoxSearch.Location = new Point((this.panelSearch.Width - this.textBoxSearch.Width) / 2, 200);
            this.labelDoSearch.Location = new Point((this.panelSearch.Width - this.labelDoSearch.Width) / 2, 
                this.textBoxSearch.Location.Y + this.textBoxSearch.Height * 3);
            //this.panelAnalyze.Size = this.panelSearch.Size;
            this.panelAnalyzeShow.Location = this.panelLeft.Location;

            this.panelSearch.Visible = true;
            this.panelAnalyze.Visible = this.panelResult.Visible = this.panelAdvance.Visible = false;
            this.label1.Visible = this.label2.Visible = this.label3.Visible = this.label4.Visible = this.label5.Visible
                = this.label6.Visible = false;
            this.labelBaiduCount.Visible = this.labelGoogleCount.Visible = this.labelBingCount.Visible = false;
            #endregion

            //一定要在InitializeComponent以后再new，因为要用到这个Form1的instance去初始化           
            captureWebPage = new CaptureWebPage(); 
        }

        #region 最小化和关闭
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        private void labelDoSearch_MouseEnter(object sender, EventArgs e)
        {
            this.labelDoSearch.ForeColor = Color.Red;
        }

        private void labelDoSearch_MouseLeave(object sender, EventArgs e)
        {
            this.labelDoSearch.ForeColor = Color.Orange;
        }

        private void Reset()
        {
            if (AllListKeywords != null)
                this.AllListKeywords.Clear();
            if (BaiduKeywords != null)
                BaiduKeywords.Clear();
            if (GoogleKeywords != null)
                GoogleKeywords.Clear();
            if (BingKeywords != null)
                BingKeywords.Clear();
            if (TitleLabels != null)
                TitleLabels.Clear();
            if (ResultKeywords != null)
                ResultKeywords.Clear();
            //记得清空Panel上的label控件，否则会重叠
            this.panelTitle.Controls.Clear();
            //this.textBoxSearch.Text = "";
        }

        private void labelDoSearch_Click(object sender, EventArgs e)
        {

            if (this.textBoxSearch.Text == "")
                return;               
            Reset();

            BaiduKeywords = baiduSearch.run(this.textBoxSearch.Text, this.webBrowser1);
            //再搜一次比较保险
            BaiduKeywords = baiduSearch.run(this.textBoxSearch.Text, this.webBrowser1);                   
            GoogleKeywords = googleSearch.run(this.textBoxSearch.Text, this.webBrowser1);         
            BingKeywords = bingSearch.run(this.textBoxSearch.Text, this.webBrowser1);

            ShowAnalyzePanel();
            //CaptureWebPage cwp = new CaptureWebPage();
            //cwp.Capture(BaiduKeywords[0].Title, BaiduKeywords[0].Link);
            AllListKeywords.Add(BaiduKeywords);
            AllListKeywords.Add(GoogleKeywords);
            AllListKeywords.Add(BingKeywords);
            ResultKeywords = ClusterInfomation.ClusterInfo(this.textBoxSearch.Text, AllListKeywords);           
        }

        private void ShowAnalyzePanel() 
        {
            this.panelSearch.Visible = this.panelResult.Visible = this.panelAdvance.Visible = false;
            this.panelAnalyze.Visible = true;
            this.panelAnalyzeShow.Visible = true;
            this.panelAnalyze.ToActive();
            this.panelAnalyzeShow.Location = new Point((this.panelAnalyze.Width - this.panelAnalyzeShow.Width) / 2,
            (this.panelAnalyze.Height - this.panelAnalyzeShow.Height) / 3);
            this.label7.Location = new Point((this.panelAnalyze.Width - this.label7.Width) / 2,
                this.panelAnalyzeShow.Location.Y + this.panelAnalyzeShow.Height + this.label7.Height);
            this.label1.Visible = true;
            if (BaiduKeywords != null)
                this.labelBaiduCount.Text = BaiduKeywords.Count.ToString();
            else
                this.labelBaiduCount.Text = "0";
            this.label4.Visible = this.labelBaiduCount.Visible = true;

            this.label2.Visible = true;
            if (GoogleKeywords != null)
                this.labelGoogleCount.Text = GoogleKeywords.Count.ToString();
            else
                this.labelGoogleCount.Text = "0";
            this.label5.Visible = this.labelGoogleCount.Visible = true;

            this.label3.Visible = true;
            if (BingKeywords != null)
                this.labelBingCount.Text = BingKeywords.Count.ToString();
            else
                this.labelBingCount.Text = "0";
            this.label6.Visible = this.labelBingCount.Visible = true;

            SetCurrentProcColor();
        }

        private void ShowResultPanel()
        {
            this.panelSearch.Visible = this.panelAnalyze.Visible = this.panelAdvance.Visible = false;
            this.panelResult.ToActive();
            this.panelResult.Visible = true;
            this.panelTitle.Size = new Size(250, this.panelResult.Height);
            this.panelTitle.Location = new Point(0, 0);
            CreateTitleLabels();

            this.panelWebPage.Size = new Size(this.panelResult.Width - this.panelTitle.Width,
                this.panelResult.Height);
            this.panelWebPage.Location = new Point(this.panelTitle.Location.X + this.panelTitle.Width, 0);
            this.webBrowser1.Size = this.panelWebPage.Size;
            this.webBrowser1.Location = new Point(0, 0);
            SetCurrentProcColor();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ShowResultPanel();
            if(ResultKeywords != null)
                this.webBrowser1.Navigate(ResultKeywords[0].Link);
            SetCurrentProcColor();
        }

        private void CreateTitleLabels() 
        {
            TitleLabels = new List<MyLabelTitle>();
            MyLabelTitle temp = null;
            MyLabelTitle prev = new MyLabelTitle();
            prev.Location = new Point(0, 0);
            Color color = Color.White;
            foreach (Keyword keyword in ResultKeywords)
            {
                temp = new MyLabelTitle(keyword.Title);
                temp.AutoSize = true;
                temp.BackColor = color == Color.White ? Color.NavajoWhite : Color.White;
                color = temp.BackColor;
                temp.Cursor = Cursors.Hand;
                temp.Font = new Font(this.panelTitle.Font, FontStyle.Regular);
                temp.Location = new Point(0, prev.Location.Y + temp.Height);
                TitleLabels.Add(temp);
                prev = temp;
            }
            this.panelTitle.Controls.AddRange(TitleLabels.ToArray());
        }

        private void labelCapture_Click(object sender, EventArgs e)
        {
            if (this.panelResult.Visible == true) //在结果页面中才能查看快照
            {
                string picAddr = captureWebPage.Capture(this.webBrowser1.Url.ToString());
            }
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            this.textBoxSearch.Text = "";
            this.panelSearch.Visible = true;
            this.panelResult.Visible = this.panelAnalyzeShow.Visible = this.panelAdvance.Visible = false;
            SetCurrentProcColor();
        }

        private void showAdvancePanel()
        {
            this.panelSearch.Visible = this.panelAnalyze.Visible = this.panelResult.Visible = false;
            this.panelAdvance.ToActive();
            this.panelDownloadPic.Size = new Size(this.panelAdvance.Width, 200);
            this.panelDownloadPic.Location = new Point(0, 50);
            this.panelDatabase.Size = new Size(this.panelAdvance.Width, this.panelAdvance.Height / 2);
            this.panelDatabase.Location = new Point(0, this.panelAdvance.Height / 2);
            SetCurrentProcColor();
        }

        private void labelAdvance_Click(object sender, EventArgs e)
        {
            List<int> comboInt = new List<int>();
            if (ResultKeywords != null)
            {
                int i = 0;
                while (i <= ResultKeywords.Count){
                    comboInt.Add(i);
                    i++;
                }
                this.comboBox1.DataSource = comboInt;
            }
            showAdvancePanel();
        }

        //没处理好，没办法保持顺序下载
        private void labelDownloadPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;  
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string savePath = sfd.FileName;
                int num = this.comboBox1.SelectedIndex;
                int index = 0;
                while (index < num)
                {
                    captureWebPage.Capture(savePath, index.ToString(), ResultKeywords[index].Link);
                    index++;
                }

            }                       
        }

        private void labelDatebase_Click(object sender, EventArgs e)
        {
            if (ResultKeywords == null)
                return;
            MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text,
                          "delete from searchresult", null);
            //对ID进行排序，否则insert到数据库会出错
            if (ResultKeywords != null)
            {
                int index = 0;
                while (index < ResultKeywords.Count)
                {
                    ResultKeywords[index].ID = index;
                    index++;
                }
            }

            foreach (Keyword k in ResultKeywords)
            {
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text,
                    "INSERT INTO searchresult VALUES(" + k.ID + ",'" +
                    k.Title + "', '" + k.Link + "')", null);
            }
            String str = "成功添加 " + this.ResultKeywords.Count.ToString() + " 记录添加入数据库！";
            MessageBox.Show(str);
        }

        private void SetCurrentProcColor() 
        {
            if (this.panelSearch.Visible)
            {
                this.labelSearch.BackColor = Color.Red;
                this.labelAnalyze.BackColor = Color.Transparent;
                this.labelResult.BackColor = Color.Transparent;
                this.labelAdvance.BackColor = Color.Transparent;
            }
            if (this.panelAnalyze.Visible)
            {
                this.labelSearch.BackColor = Color.Transparent;
                this.labelAnalyze.BackColor = Color.Red;
                this.labelResult.BackColor = Color.Transparent;
                this.labelAdvance.BackColor = Color.Transparent;
            }
            if (this.panelResult.Visible)
            {
                this.labelSearch.BackColor = Color.Transparent;
                this.labelAnalyze.BackColor = Color.Transparent;
                this.labelResult.BackColor = Color.Red;
                this.labelAdvance.BackColor = Color.Transparent;
            }
            if (this.panelAdvance.Visible)
            {
                this.labelSearch.BackColor = Color.Transparent;
                this.labelAnalyze.BackColor = Color.Transparent;
                this.labelResult.BackColor = Color.Transparent;
                this.labelAdvance.BackColor = Color.Red;
            }
        }
    }
}
