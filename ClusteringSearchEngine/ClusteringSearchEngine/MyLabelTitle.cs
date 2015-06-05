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
    public partial class MyLabelTitle : Label
    {
        public MyLabelTitle()
        {
            InitializeComponent();

        }

        public MyLabelTitle(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public MyLabelTitle(string title)
        {
            this.Text = title;
            this.Click += new EventHandler(MyLabelTitle_Click);
        }

        void MyLabelTitle_Click(object sender, EventArgs e)
        {
            foreach (Keyword keyword in Form1.getInstance().getResutlKeywords())
            {
                if (keyword.Title.Equals(this.Text))
                {
                    Form1.getInstance().getWebBrowser().Navigate(keyword.Link);
                    break;
                }
            }
           
            //throw new NotImplementedException();
        }
    }
}
