using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ClusteringSearchEngine
{
    public partial class MyPanelCenter : Panel
    {
        public MyPanelCenter()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyPanel_MouseDown);
            this.MouseMove += new MouseEventHandler(MyPanel_MouseMove);
            this.MouseUp += new MouseEventHandler(MyPanel_MouseUp);
        }

        public MyPanelCenter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MyPanel_MouseDown);
            this.MouseMove += new MouseEventHandler(MyPanel_MouseMove);
            this.MouseUp += new MouseEventHandler(MyPanel_MouseUp);
        }

        public void ToActive() 
        {
            this.Visible = true;
            this.Location = Form1.getInstance().getPanelSearch().Location;
            this.Size = Form1.getInstance().getPanelSearch().Size;
            
        }

        #region 控制界面变量
        private bool isMouseDown = false;
        private Point point = new Point(-10, -10);
        Form1 form1 = Form1.getInstance();
        private bool isSettingPanelShown = false;
        #endregion

        #region 通过panel移动窗体
        void MyPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            form1.Location = new Point(form1.Location.X + (e.Location.X - point.X),
                form1.Location.Y + (e.Location.Y - point.Y));
        }

        void MyPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (point != e.Location)
                {
                    form1.Location = new Point(form1.Location.X + (e.Location.X - point.X),
                        form1.Location.Y + (e.Location.Y - point.Y));
                    Application.DoEvents();
                }
            }
        }

        void MyPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            point = e.Location;
        }
        #endregion
    }
}
