using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCards
{
    public partial class frmEditWord : Form
    {
        ToolTip toolTip = null;
        public WordItem Word { get; set; } = null;
        public frmEditWord(WordItem word)
        {
            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.SetToolTip(btnSave, "儲存");
            btnSave.Enabled = false; // 初始狀態下 disabled 儲存按鈕

            this.Word = word;
            txtWord.Text = word.Word;
            txtPhonogram.Text = word.Phonogram;
            txtSoundPath.Text = word.SoundPath;
            txtExplain.Text = word.Explain;

            btnSave.Text = "";
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Margin = new Padding(0);
            btnSave.Padding = new Padding(0);


            btnSave.Image = ResizeImage(GetImage("save"), new Size(50, 50));
            UpdateSaveButton();

            // 加入 TextChanged 事件處理器，當輸入框內容改變時啟用儲存按鈕
            txtPhonogram.TextChanged += InputChanged;
            txtSoundPath.TextChanged += InputChanged;
            txtExplain.TextChanged += InputChanged;

            // 加入 Enter 和 Leave 事件處理器，改變背景顏色
            txtPhonogram.Enter += Control_Enter;
            txtPhonogram.Leave += Control_Leave;
            txtSoundPath.Enter += Control_Enter;
            txtSoundPath.Leave += Control_Leave;
            txtExplain.Enter += Control_Enter;
            txtExplain.Leave += Control_Leave;

        }
        private void InputChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void Control_Enter(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.LightYellow;
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.White;
        }

        void UpdateSaveButton()
        {
            btnSave.MouseEnter += (s, e) =>
            {
                btnSave.Image = ResizeImage(GetImage("save"), new Size(54, 54));
            };

            btnSave.MouseLeave += (s, e) =>
            {
                btnSave.Image = ResizeImage(GetImage("save"), new Size(50, 50));
            };
        }

        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
        private Image ResizeImage(Image img, Size size)
        {
            return new Bitmap(img, size);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 儲存單字
            Word.Word = txtWord.Text;
            Word.Phonogram = txtPhonogram.Text;
            Word.SoundPath = txtSoundPath.Text;
            Word.Explain = txtExplain.Text;
        }
    }
}
