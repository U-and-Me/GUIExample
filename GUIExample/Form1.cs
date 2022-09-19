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

        GroupBox groupBoxFish;
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

            GroupBox groupBoxPlant = new GroupBox();
            groupBoxFish = new GroupBox();

            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            Button buttonRadio = new Button();

            RadioButton radio4 = new RadioButton();
            RadioButton radio5 = new RadioButton();
            RadioButton radio6 = new RadioButton();
            Button buttonRadio2 = new Button();

            groupBoxPlant.Text = "작물";
            groupBoxFish.Text = "물고기";

            radio1.Text = "감자";
            radio2.Text = "고구마";
            radio3.Text = "토마토";
            buttonRadio.Text = "클릭";

            radio4.Text = "광어";
            radio5.Text = "우럭";
            radio6.Text = "연어";
            buttonRadio2.Text = "클릭";

            groupBoxPlant.Size = new Size(120, 200);
            groupBoxFish.Size = new Size(120, 200);

            groupBoxPlant.Location = new Point(250, 110);
            groupBoxFish.Location = new Point(400, 110);

            radio1.Location = new Point(30, 30);
            radio2.Location = new Point(30, 60);
            radio3.Location = new Point(30, 90);
            buttonRadio.Location = new Point(30, 130);

            radio4.Location = new Point(30, 30);
            radio5.Location = new Point(30, 60);
            radio6.Location = new Point(30, 90);
            buttonRadio2.Location = new Point(30, 130);

            buttonRadio.Click += ButtonRadioClick;
            buttonRadio2.Click += ButtonRadioClick2;

            groupBoxPlant.Controls.Add(radio1);
            groupBoxPlant.Controls.Add(radio2);
            groupBoxPlant.Controls.Add(radio3);
            groupBoxPlant.Controls.Add(buttonRadio);

            groupBoxFish.Controls.Add(radio4);
            groupBoxFish.Controls.Add(radio5);
            groupBoxFish.Controls.Add(radio6);
            groupBoxFish.Controls.Add(buttonRadio2);

            Controls.Add(groupBoxPlant);
            Controls.Add(groupBoxFish);
        }

        private void ButtonRadioClick2(object sender, EventArgs e)
        {
            foreach (var item in groupBoxFish.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        MessageBox.Show(radioButton.Text);
                    }
                 }
            }
        }

        private void ButtonRadioClick(object sender, EventArgs e)
        {
            foreach (var outerItem in Controls)
            {
                if (outerItem is GroupBox) {
                    GroupBox groupBox = (GroupBox)outerItem;
                    if(groupBox.Text == "작물")
                    {
                        foreach(var item in groupBox.Controls)
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
