using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Diagnostics;

namespace WordCards
{
    public partial class frmWordCards : Form
    {
        WordCollection _WordList = new WordCollection();
        /// <summary>
        /// 單字清單
        /// </summary>
        WordCollection WordList = new WordCollection();

        /// <summary>
        /// Windows Media Player 播放器
        /// </summary>
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        string strWordFile = "WordCards.txt"; // 單字檔名

        /// <summary>
        /// 是否自動播放
        /// </summary>
        bool isPlay = false;
        ToolTip toolTip = null;
        public frmWordCards()
        {
            InitializeComponent();
            toolTip = new ToolTip();

            btnAutoPlay.Text = "";
            btnAutoPlay.FlatStyle = FlatStyle.Flat;
            btnAutoPlay.FlatAppearance.BorderSize = 0;
            btnAutoPlay.BackColor = Color.Transparent;
            btnAutoPlay.Cursor = Cursors.Hand;
            btnAutoPlay.Margin = new Padding(0);
            btnAutoPlay.Padding = new Padding(0);


            btnAutoPlay.Image = ResizeImage(GetImage("play100"), new Size(40, 40));
            UpdatePlayButton();
        }

        void UpdatePlayButton()
        {
            btnAutoPlay.MouseEnter += (s, e) =>
            {
                toolTip.SetToolTip(btnAutoPlay, isPlay ? "停止播放" : "開始播放");
                string imgKey = isPlay ? "stop100" : "play100";
                btnAutoPlay.Image = ResizeImage(GetImage(imgKey), new Size(44, 44));
            };

            btnAutoPlay.MouseLeave += (s, e) =>
            {
                toolTip.SetToolTip(btnAutoPlay, isPlay ? "停止播放" : "開始播放");
                string imgKey = isPlay ? "stop100" : "play100";
                btnAutoPlay.Image = ResizeImage(GetImage(imgKey), new Size(40, 40));
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

        /// <summary>
        /// 顯示單字
        /// </summary>
        /// <param name="word">單字物件</param>
        private void ShowWord(WordItem word)
        {
            txtWord.Text = word.Word;
            txtPhonogram.Text = word.Phonogram;
            txtExplain.Text = word.Explain;
        }

        /// <summary>
        /// 將單字加入到播放清單
        /// </summary>
        private void UpdateWordList()
        {
            lstWordList.BeginUpdate(); // 開始更新

            lstWordList.Items.Clear();

            foreach (WordItem item in this._WordList)
            {
                lstWordList.Items.Add(item);
            }

            lstWordList.EndUpdate(); // 結束更新
        }

        /// <summary>
        /// 播放單字音檔
        /// </summary>
        /// <param name="word">單字物件</param>
        private void PlayWord(WordItem word)
        {
            // 判斷音效檔是否存在
            if (File.Exists(word.SoundPath))
            {
                // 播放單字音檔
                wmp.URL = word.SoundPath;
                wmp.settings.autoStart = false;
                wmp.settings.mute = false;
                wmp.controls.play();
            }
            else
            {
                tsslMessage.Text = $"找無 {word.SoundPath} 音效檔";
            }
        }

        /// <summary>
        /// 播放目前選取的單字
        /// </summary>
        private void PlaySelectedWord()
        {
            // 判斷目前選的項目是否為空
            if (lstWordList.SelectedItem != null)
            {
                // 取得目前選取的單字索引
                int idx = lstWordList.SelectedIndex;

                // 顯示單字
                ShowWord(_WordList[idx]);

                // 播放單字的發音
                PlayWord(_WordList[idx]);
            }
        }

        /// <summary>
        /// 將單字清單的選項移到下一個
        /// </summary>
        private void NextWordList()
        {
            // 將焦點移到單字清單
            lstWordList.Focus();

            // 判斷目前選的下一項是否超過清單的項目數
            if (lstWordList.SelectedIndex + 1 >= lstWordList.Items.Count)
            {
                lstWordList.SelectedIndex = 0; // 如果超過就回到第一項
            }
            else
            {
                lstWordList.SelectedIndex++; // 如果沒有就選擇下一項
            }

            // 計算目前 lstWordList 顯示的行數
            int lstRows = lstWordList.Height / lstWordList.GetItemHeight(0);

            // 如果目前選的項目大於 lstRows / 2
            if (lstWordList.SelectedIndex >= lstRows / 2)
            {
                // 將 lstWordList 的選項保持在中間
                lstWordList.TopIndex = lstWordList.SelectedIndex - lstRows / 2;
            }
        }

        private void txtPhonogram_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExplain_TextChanged(object sender, EventArgs e)
        {

        }

        private void palMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmWordCards_Load(object sender, EventArgs e)
        {
            string[] lines;

            // 若單字檔存在
            if (File.Exists(strWordFile))
            {
                lines = File.ReadAllLines(strWordFile, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show(
                    $"找不到單字檔\n{strWordFile}",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Application.Exit();
                return;
            }

            lstWordList.DrawMode = DrawMode.OwnerDrawFixed;
            lstWordList.ItemHeight = lstWordList.Font.Height + 3;
            // 載入單字檔
            this._WordList.LoadFromStringArray(lines);

            if (this._WordList.Count > 0)
            {
                // 更新單字清單
                UpdateWordList();

                // 顯示第一個單字
                this.ShowWord(this._WordList[0]);

                tsslMessage.Text = $"單字數量：{this._WordList.Count}";
            }
        }

        private void lstWordList_Click(object sender, EventArgs e)
        {
            // 判斷是否自動播放
            if (isPlay == true)
            {
                btnAutoPlay.PerformClick(); // 點擊自動播放按鈕
            }

            // 判斷是否有選取項目
            if (lstWordList.SelectedItem != null)
            {
                // 判斷選取項目是否有內容
                if (lstWordList.SelectedItem.ToString().Length != 0)
                {
                    // 顯示並播放目前選取的單字
                    PlaySelectedWord();
                }
            }
        }

        private void timPlayer_Tick(object sender, EventArgs e)
        {
            // 移到下一個單字
            NextWordList();
            // 顯示並播放目前選取的單字
            PlaySelectedWord();
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            // 將焦點移到單字清單
            lstWordList.Focus();

            // 若目前不是自動播放
            if (isPlay == false)
            {
                //btnAutoPlay.Text = "Stop";
                isPlay = true;
                UpdatePlayButton();
                // 顯示並播放目前選取的單字
                PlaySelectedWord();

                timPlayer.Start();
            }
            else
            {
                //btnAutoPlay.Text = "Play";
                isPlay = false;
                UpdatePlayButton();
                timPlayer.Stop();
            }
        }

        private void frmWordCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isPlay == true)
            {
                return;
            }

            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    // 當按下 Enter 時，播放下一個單字
                    NextWordList();

                    // 顯示並播放目前選取的單字
                    PlaySelectedWord();

                    e.Handled = true;
                    break;

                case (char)Keys.Space:
                    // 當按下 Space 時，重複播放目前單字
                    if (lstWordList.SelectedIndex >= 0)
                    {
                        // 顯示並播放目前選取的單字
                        PlaySelectedWord();
                    }

                    e.Handled = true;
                    break;
            }
        }
        private void frmWordCards_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }

        private void lstWordList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color backColor;

            if (e.Index % 2 == 0)
            {
                backColor = Color.FromArgb(230, 230, 230);
            }
            else
            {
                backColor = Color.White;
            }

            // 如果item被選取，則使用系統的 Highlight 顏色作為背景
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                backColor = SystemColors.Highlight;

            // 繪製背景
            using (SolidBrush backgroundBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            // 取得要繪製的文字
            string text = lstWordList.Items[e.Index].ToString();

            // 文字顏色
            Color foreColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                foreColor = SystemColors.HighlightText;
            }
            else
            {
                foreColor = lstWordList.ForeColor;
            }

            using (SolidBrush textBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstWordList_DoubleClick(object sender, EventArgs e)
        {
            lstWordList.Focus();
            // 目前選取的索引
            int idx = lstWordList.SelectedIndex;
            frmEditWord edit = new frmEditWord(_WordList[idx]);
            DialogResult result = edit.ShowDialog(this);
            // 如果使用者按下儲存按鈕
            if (result == DialogResult.Yes)
            {
                // 顯示並播放目前選取的單字
                PlaySelectedWord();

                // 儲存單字
                _WordList.SaveToFile(strWordFile);

                //顯示儲存完畢
                MessageBox.Show("儲存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
