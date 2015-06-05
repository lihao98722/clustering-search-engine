using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ClusteringSearchEngine
{
    public partial class MyLabelProc : Label
    {
        public MyLabelProc()
        {
            InitializeComponent();
        }

        public MyLabelProc(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.MouseEnter += new EventHandler(MyLabelProc_MouseEnter);
            this.MouseLeave += new EventHandler(MyLabelProc_MouseLeave);
            //this.Cursor = Cursors.Hand;
        }

        void MyLabelProc_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.BlanchedAlmond;
            //throw new NotImplementedException();
        }

        void MyLabelProc_MouseEnter(object sender, EventArgs e)
        {
            if (((Label)sender).Text != "过程分析" && ((Label)sender).Text != "结果展示")
            {
                this.Cursor = Cursors.Hand;
                this.ForeColor = Color.Salmon;
            }
           
            //throw new NotImplementedException();
        }

        public void ToActive() 
        {
            this.ForeColor = Color.Salmon;
        }

        public void ToInactive()
        {
            this.ForeColor = Color.BlanchedAlmond;
        }

        public bool isActive()
        {
            return (this.ForeColor == Color.Salmon);
        }
    }
}
