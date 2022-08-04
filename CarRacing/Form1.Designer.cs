namespace CarRacing
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Car = new System.Windows.Forms.PictureBox();
            this.pictureBox_redcar = new System.Windows.Forms.PictureBox();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.pictureBox_money1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_money3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_money2 = new System.Windows.Forms.PictureBox();
            this.label_coins = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_redcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(182, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(182, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 98);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(182, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 98);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(182, 370);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 98);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_Car
            // 
            this.pictureBox_Car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Car.Image")));
            this.pictureBox_Car.Location = new System.Drawing.Point(38, 293);
            this.pictureBox_Car.Name = "pictureBox_Car";
            this.pictureBox_Car.Size = new System.Drawing.Size(93, 116);
            this.pictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Car.TabIndex = 4;
            this.pictureBox_Car.TabStop = false;
            // 
            // pictureBox_redcar
            // 
            this.pictureBox_redcar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_redcar.Image")));
            this.pictureBox_redcar.Location = new System.Drawing.Point(15, 40);
            this.pictureBox_redcar.Name = "pictureBox_redcar";
            this.pictureBox_redcar.Size = new System.Drawing.Size(65, 99);
            this.pictureBox_redcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_redcar.TabIndex = 5;
            this.pictureBox_redcar.TabStop = false;
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.label_gameOver.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Red;
            this.label_gameOver.Location = new System.Drawing.Point(12, 177);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(367, 64);
            this.label_gameOver.TabIndex = 7;
            this.label_gameOver.Text = "Game Over";
            this.label_gameOver.Visible = false;
            // 
            // pictureBox_money1
            // 
            this.pictureBox_money1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money1.Image")));
            this.pictureBox_money1.Location = new System.Drawing.Point(255, 88);
            this.pictureBox_money1.Name = "pictureBox_money1";
            this.pictureBox_money1.Size = new System.Drawing.Size(45, 51);
            this.pictureBox_money1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money1.TabIndex = 8;
            this.pictureBox_money1.TabStop = false;
            // 
            // pictureBox_money3
            // 
            this.pictureBox_money3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money3.Image")));
            this.pictureBox_money3.Location = new System.Drawing.Point(173, 291);
            this.pictureBox_money3.Name = "pictureBox_money3";
            this.pictureBox_money3.Size = new System.Drawing.Size(45, 51);
            this.pictureBox_money3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money3.TabIndex = 9;
            this.pictureBox_money3.TabStop = false;
            // 
            // pictureBox_money2
            // 
            this.pictureBox_money2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money2.Image")));
            this.pictureBox_money2.Location = new System.Drawing.Point(98, 135);
            this.pictureBox_money2.Name = "pictureBox_money2";
            this.pictureBox_money2.Size = new System.Drawing.Size(45, 51);
            this.pictureBox_money2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money2.TabIndex = 10;
            this.pictureBox_money2.TabStop = false;
            // 
            // label_coins
            // 
            this.label_coins.AutoSize = true;
            this.label_coins.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_coins.Location = new System.Drawing.Point(292, 36);
            this.label_coins.Name = "label_coins";
            this.label_coins.Size = new System.Drawing.Size(80, 15);
            this.label_coins.TabIndex = 11;
            this.label_coins.Text = "Coins = 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label_coins);
            this.Controls.Add(this.pictureBox_money2);
            this.Controls.Add(this.pictureBox_money3);
            this.Controls.Add(this.pictureBox_money1);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.pictureBox_redcar);
            this.Controls.Add(this.pictureBox_Car);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_redcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_Car;
        private System.Windows.Forms.PictureBox pictureBox_redcar;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.PictureBox pictureBox_money1;
        private System.Windows.Forms.PictureBox pictureBox_money3;
        private System.Windows.Forms.PictureBox pictureBox_money2;
        private System.Windows.Forms.Label label_coins;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
    }
}

