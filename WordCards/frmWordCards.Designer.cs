namespace WordCards
{
    partial class frmWordCards
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.sssWord.SuspendLayout();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.sssWord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 509);
            this.sssWord.Name = "sssWord";
            this.sssWord.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.sssWord.Size = new System.Drawing.Size(1055, 35);
            this.sssWord.TabIndex = 0;
            this.sssWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(101, 26);
            this.tsslMessage.Text = "Message";
            // 
            // lstWordList
            // 
            this.lstWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 35;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(236, 509);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            this.lstWordList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstWordList_DrawItem);
            this.lstWordList.DoubleClick += new System.EventHandler(this.lstWordList_DoubleClick);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(236, 0);
            this.palMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(819, 509);
            this.palMain.TabIndex = 2;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHelp.ForeColor = System.Drawing.Color.Red;
            this.txtHelp.Location = new System.Drawing.Point(604, 377);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(184, 68);
            this.txtHelp.TabIndex = 6;
            this.txtHelp.Text = "Enter →下一個  Space → 重複";
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAutoPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoPlay.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAutoPlay.Location = new System.Drawing.Point(604, 244);
            this.btnAutoPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(155, 64);
            this.btnAutoPlay.TabIndex = 5;
            this.btnAutoPlay.Text = "Play";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPhonogram.Location = new System.Drawing.Point(26, 103);
            this.txtPhonogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(171, 38);
            this.txtPhonogram.TabIndex = 3;
            this.txtPhonogram.Text = "ˋæbəkəs";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExplain.Location = new System.Drawing.Point(26, 184);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(491, 282);
            this.txtExplain.TabIndex = 2;
            this.txtExplain.Text = "<-us: calculus 小圓石>";
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWord.Location = new System.Drawing.Point(26, 14);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(475, 68);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "abacus";
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            this.timPlayer.Tick += new System.EventHandler(this.timPlayer_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::WordCards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(604, 29);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(155, 172);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 544);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.sssWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1076, 596);
            this.Name = "frmWordCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWordCards_FormClosing);
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Timer timPlayer;
    }
}

