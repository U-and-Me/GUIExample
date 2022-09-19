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

            // 레이블 생성
            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 110)
            };

            Controls.Add(label);

            // 링크 레이블 생성
            LinkLabel linkLabel = new LinkLabel()
            {
                //Text = "네이버",
                Text = "메모장",
                Location = new Point(10, 150)
            };

            // 요소에 이벤트 연결
            linkLabel.Click += LabelClick;

            // 화면에 요소 추가
            Controls.Add(linkLabel);

            // 체크 박스 생성
            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            CheckBox checkBox3 = new CheckBox();
            Button button = new Button();

            // 요소 속성 설정
            checkBox1.Text = "감자";
            checkBox2.Text = "고구마";
            checkBox3.Text = "토마토";
            button.Text = "클릭";

            checkBox1.Location = new Point(120, 100);
            checkBox2.Location = new Point(120, 140);
            checkBox3.Location = new Point(120, 170);
            button.Location = new Point(120, 200);

            // 클릭 이벤트
            button.Click += ButtonClick;

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);

            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            Button buttonRadio = new Button();

            radio1.Text = "감자";
            radio2.Text = "고구마";
            radio3.Text = "토마토";
            buttonRadio.Text = "클릭";

            radio1.Location = new Point(300, 110);
            radio2.Location = new Point(300, 140);
            radio3.Location = new Point(300, 170);
            buttonRadio.Location = new Point(300, 200);

            buttonRadio.Click += ButtonRadioClick;

            Controls.Add(radio1);
            Controls.Add(radio2);
            Controls.Add(radio3);
            Controls.Add(buttonRadio);
        }

        private void ButtonRadioClick(object sender, EventArgs e)
        {
            foreach(var item in Controls)
            {
                if(item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        MessageBox.Show(radioButton.Text);
                    }
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<String> list = new List<string>();

            foreach(var item in Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox) item;

                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            MessageBox.Show(string.Join(",", list));
        }

        private void LabelClick(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://naver.com");
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메모장 정보");
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
