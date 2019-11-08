using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1SplitContainer;

namespace SplitContainerCollapseDemo
{
    public partial class Form1 : Form
    {
        C1SplitterPanel _active;

Make Bidirectional Collapsible Panel When Two Panels in SpliterContainer

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetActive(c1SplitterPanel2);
        }

        private void c1SplitterPanel1_MouseEnter(object sender, EventArgs e)
        {
            SetActive(c1SplitterPanel1);
        }

        private void c1SplitterPanel2_MouseEnter(object sender, EventArgs e)
        {
            SetActive(c1SplitterPanel2);
        }

        void SetActive(C1SplitterPanel pan)
        {
            if (_active == pan || !c1SplitterPanel1.Visible || !c1SplitterPanel2.Visible)
                return;
            int w1 = c1SplitterPanel1.Width;
            int w2 = c1SplitterPanel2.Width;
            _active = pan;
            c1SplitContainer1.Panels.BeginUpdate();
            c1SplitContainer1.Panels.Remove(pan);
            c1SplitContainer1.Panels.Insert(0, pan);
            c1SplitterPanel1.Width = w1;
            c1SplitterPanel2.Width = w2;
            c1SplitContainer1.Panels.EndUpdate();
        }
    }
}
