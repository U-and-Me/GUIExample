using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        int STEP = 20;

        private void 상태증가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStripProgressBar1.Value + STEP > toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
            else
            {
                toolStripProgressBar1.Value += STEP;
            }

            toolStripStatusLabel1.Text = toolStripProgressBar1.Value + "%";
        }

        private void 상태감소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value - STEP < toolStripProgressBar1.Minimum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value -= STEP;
            }

            toolStripStatusLabel1.Text = toolStripProgressBar1.Value + "%";
        }

        private void 라벨변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "상태 라벨 변경";
        }
    }
}
