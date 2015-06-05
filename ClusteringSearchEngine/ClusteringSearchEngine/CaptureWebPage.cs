using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClusteringSearchEngine
{
    class CaptureWebPage
    {
        private WebBrowser webBrowser1 = null;
        private string saveAddr = "C:\\Users\\Administrator\\Desktop\\";
        private string saveName;
        private string saveFormat = ".png";
        private string fullAddr;
        private int count = 0;
        private bool isTriggered = false; //保证图片只载入一次

        public CaptureWebPage()
        {
            count = 0;
            webBrowser1 = Form1.getInstance().getWebBrowserForCapture();          
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
        }

        public string Capture(string addr,string name, string url)
        {
            isTriggered = true;
            saveAddr = addr;
            saveName = name;
            fullAddr = saveAddr + saveName + saveFormat;
            webBrowser1.Navigate(url);
            GetImage();
            return fullAddr;
        }

        public string Capture(string name, string url)
        {
            isTriggered = true;
            saveName = name;
            fullAddr = saveAddr + saveName + saveFormat;
            webBrowser1.Navigate(url);
            GetImage();
            return fullAddr;
        }

        public string Capture(string url)
        {
            isTriggered = true;
            saveName = (++count).ToString();
            fullAddr = saveAddr + saveName + saveFormat;
            webBrowser1.Navigate(url);
            return fullAddr;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (isTriggered)
            {
                GetImage();
            }
        }

        private void GetImage()
        {
            if (webBrowser1.Document == null) return;
            try
            {
                int scrollHeight = webBrowser1.Document.Body.ScrollRectangle.Height;
                int scrollWidth = webBrowser1.Document.Body.ScrollRectangle.Width;
                webBrowser1.Size = new Size(scrollWidth, scrollHeight);
                Bitmap bm = new Bitmap(scrollWidth, scrollHeight);
                webBrowser1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                bm.Save(fullAddr, System.Drawing.Imaging.ImageFormat.Png);
                bm.Dispose();

                //等图片处理完毕后再启动打开图片的进程
                openImage(fullAddr);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isTriggered = false;
            }
        }

        private void openImage(string picAddr)
        {
            //建立新的系统进程    
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //设置文件名，此处为图片的真实路径+文件名 
            if (System.IO.File.Exists(picAddr))
            {
                process.StartInfo.FileName = picAddr;
            }
            else
                return;
            //此为关键部分。设置进程运行参数，此时为最大化窗口显示图片。    
            process.StartInfo.Arguments = "rundll32.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
            //此项为是否使用Shell执行程序，因系统默认为true，此项也可不设，但若设置必须为true    
            process.StartInfo.UseShellExecute = true;
            //此处可以更改进程所打开窗体的显示样式，可以不设    
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.Start();
            process.Close();
        }
    }
}
