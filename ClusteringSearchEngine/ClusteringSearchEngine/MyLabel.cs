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
    public partial class MyLable : Label
    {
        public MyLable()
        {
            InitializeComponent();
            this.ForeColor = Color.WhiteSmoke;
            this.BackColor = Color.Transparent;
            this.Size = new Size(21, 22);
            this.MouseEnter += new EventHandler(MyLable_MouseEnter);
            this.MouseLeave += new EventHandler(MyLable_MouseLeave);
        }

        public MyLable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.ForeColor = Color.WhiteSmoke;
            this.BackColor = Color.Transparent;
            this.Size = new Size(21, 22);
            this.MouseEnter += new EventHandler(MyLable_MouseEnter);
            this.MouseLeave += new EventHandler(MyLable_MouseLeave);
        }

        void MyLable_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        void MyLable_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }


    }
}
