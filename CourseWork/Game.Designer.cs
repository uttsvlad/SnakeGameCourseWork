
namespace CourseWork
{
  partial class Game
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
      this.speed1 = new System.Windows.Forms.RadioButton();
      this.speed2 = new System.Windows.Forms.RadioButton();
      this.speed3 = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.playB = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.labelscore = new System.Windows.Forms.Label();
      this.wall1 = new System.Windows.Forms.PictureBox();
      this.wall2 = new System.Windows.Forms.PictureBox();
      this.menuB = new System.Windows.Forms.Button();
      this.gameoverscore = new System.Windows.Forms.Label();
      this.gameover = new System.Windows.Forms.PictureBox();
      this.lscore1 = new System.Windows.Forms.Label();
      this.lscore2 = new System.Windows.Forms.Label();
      this.pause = new System.Windows.Forms.PictureBox();
      this.speedClassic = new System.Windows.Forms.RadioButton();
      this.labelbestscore = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
      this.SuspendLayout();
      // 
      // speed1
      // 
      this.speed1.AutoSize = true;
      this.speed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(155)))));
      this.speed1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.speed1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.speed1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
      this.speed1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.speed1.Location = new System.Drawing.Point(565, 301);
      this.speed1.Name = "speed1";
      this.speed1.Size = new System.Drawing.Size(155, 23);
      this.speed1.TabIndex = 0;
      this.speed1.Text = "          Черепаха";
      this.speed1.UseVisualStyleBackColor = false;
      this.speed1.CheckedChanged += new System.EventHandler(this.speed1_CheckedChanged);
      // 
      // speed2
      // 
      this.speed2.AutoSize = true;
      this.speed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(254)))), ((int)(((byte)(136)))));
      this.speed2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.speed2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.speed2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
      this.speed2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.speed2.Location = new System.Drawing.Point(566, 337);
      this.speed2.Name = "speed2";
      this.speed2.Size = new System.Drawing.Size(150, 23);
      this.speed2.TabIndex = 1;
      this.speed2.Text = "                Змея";
      this.speed2.UseVisualStyleBackColor = false;
      this.speed2.CheckedChanged += new System.EventHandler(this.speed2_CheckedChanged);
      // 
      // speed3
      // 
      this.speed3.AutoSize = true;
      this.speed3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(254)))), ((int)(((byte)(134)))));
      this.speed3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.speed3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speed3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.speed3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
      this.speed3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.speed3.Location = new System.Drawing.Point(566, 371);
      this.speed3.Name = "speed3";
      this.speed3.Size = new System.Drawing.Size(150, 23);
      this.speed3.TabIndex = 2;
      this.speed3.Text = "            Кролик";
      this.speed3.UseVisualStyleBackColor = false;
      this.speed3.CheckedChanged += new System.EventHandler(this.speed3_CheckedChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(255)))), ((int)(((byte)(169)))));
      this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(529, 234);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(193, 22);
      this.label1.TabIndex = 4;
      this.label1.Text = "Скорость змейки:";
      // 
      // playB
      // 
      this.playB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
      this.playB.Cursor = System.Windows.Forms.Cursors.Hand;
      this.playB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.playB.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.playB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.playB.Location = new System.Drawing.Point(320, 353);
      this.playB.Name = "playB";
      this.playB.Size = new System.Drawing.Size(98, 38);
      this.playB.TabIndex = 6;
      this.playB.Text = "Играть";
      this.playB.UseVisualStyleBackColor = false;
      this.playB.Click += new System.EventHandler(this.playB_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 200;
      // 
      // labelscore
      // 
      this.labelscore.AutoSize = true;
      this.labelscore.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelscore.Location = new System.Drawing.Point(682, 204);
      this.labelscore.Name = "labelscore";
      this.labelscore.Size = new System.Drawing.Size(38, 32);
      this.labelscore.TabIndex = 7;
      this.labelscore.Text = "Ваш\r\nсчет:\r\n";
      this.labelscore.Visible = false;
      // 
      // wall1
      // 
      this.wall1.BackColor = System.Drawing.Color.Black;
      this.wall1.Location = new System.Drawing.Point(677, -3);
      this.wall1.Name = "wall1";
      this.wall1.Size = new System.Drawing.Size(1, 454);
      this.wall1.TabIndex = 8;
      this.wall1.TabStop = false;
      this.wall1.Visible = false;
      // 
      // wall2
      // 
      this.wall2.BackColor = System.Drawing.Color.Black;
      this.wall2.Location = new System.Drawing.Point(675, 0);
      this.wall2.Name = "wall2";
      this.wall2.Size = new System.Drawing.Size(1, 454);
      this.wall2.TabIndex = 9;
      this.wall2.TabStop = false;
      this.wall2.Visible = false;
      // 
      // menuB
      // 
      this.menuB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(153)))));
      this.menuB.Cursor = System.Windows.Forms.Cursors.Hand;
      this.menuB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuB.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.menuB.Location = new System.Drawing.Point(320, 353);
      this.menuB.Name = "menuB";
      this.menuB.Size = new System.Drawing.Size(98, 38);
      this.menuB.TabIndex = 10;
      this.menuB.Text = "Меню";
      this.menuB.UseVisualStyleBackColor = false;
      this.menuB.Visible = false;
      this.menuB.Click += new System.EventHandler(this.menuB_Click);
      // 
      // gameoverscore
      // 
      this.gameoverscore.AutoSize = true;
      this.gameoverscore.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
      this.gameoverscore.Location = new System.Drawing.Point(281, 302);
      this.gameoverscore.Name = "gameoverscore";
      this.gameoverscore.Size = new System.Drawing.Size(174, 22);
      this.gameoverscore.TabIndex = 11;
      this.gameoverscore.Text = "Ваш результат: ";
      this.gameoverscore.Visible = false;
      // 
      // gameover
      // 
      this.gameover.Image = global::CourseWork.Properties.Resources.gameover3;
      this.gameover.Location = new System.Drawing.Point(248, 79);
      this.gameover.Name = "gameover";
      this.gameover.Size = new System.Drawing.Size(241, 177);
      this.gameover.TabIndex = 12;
      this.gameover.TabStop = false;
      this.gameover.Visible = false;
      // 
      // lscore1
      // 
      this.lscore1.AutoSize = true;
      this.lscore1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lscore1.Location = new System.Drawing.Point(684, 417);
      this.lscore1.Name = "lscore1";
      this.lscore1.Size = new System.Drawing.Size(44, 16);
      this.lscore1.TabIndex = 13;
      this.lscore1.Text = "Пауза";
      this.lscore1.Visible = false;
      // 
      // lscore2
      // 
      this.lscore2.AutoSize = true;
      this.lscore2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lscore2.Location = new System.Drawing.Point(690, 433);
      this.lscore2.Name = "lscore2";
      this.lscore2.Size = new System.Drawing.Size(30, 14);
      this.lscore2.TabIndex = 14;
      this.lscore2.Text = "Esc";
      this.lscore2.Visible = false;
      // 
      // pause
      // 
      this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
      this.pause.Location = new System.Drawing.Point(-5, -3);
      this.pause.Name = "pause";
      this.pause.Size = new System.Drawing.Size(681, 473);
      this.pause.TabIndex = 15;
      this.pause.TabStop = false;
      this.pause.Visible = false;
      // 
      // speedClassic
      // 
      this.speedClassic.AutoSize = true;
      this.speedClassic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(155)))));
      this.speedClassic.Checked = true;
      this.speedClassic.Cursor = System.Windows.Forms.Cursors.Hand;
      this.speedClassic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speedClassic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speedClassic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speedClassic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(16)))));
      this.speedClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.speedClassic.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.speedClassic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.speedClassic.Location = new System.Drawing.Point(566, 265);
      this.speedClassic.Name = "speedClassic";
      this.speedClassic.Size = new System.Drawing.Size(154, 23);
      this.speedClassic.TabIndex = 16;
      this.speedClassic.TabStop = true;
      this.speedClassic.Text = "Динамическая";
      this.speedClassic.UseVisualStyleBackColor = false;
      this.speedClassic.CheckedChanged += new System.EventHandler(this.speedClassic_CheckedChanged);
      // 
      // labelbestscore
      // 
      this.labelbestscore.AutoSize = true;
      this.labelbestscore.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelbestscore.Location = new System.Drawing.Point(682, 0);
      this.labelbestscore.Name = "labelbestscore";
      this.labelbestscore.Size = new System.Drawing.Size(55, 32);
      this.labelbestscore.TabIndex = 17;
      this.labelbestscore.Text = "Лучший\r\nсчет:\r\n";
      this.labelbestscore.Visible = false;
      // 
      // Game
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(153)))));
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(734, 451);
      this.Controls.Add(this.labelbestscore);
      this.Controls.Add(this.speed3);
      this.Controls.Add(this.speed2);
      this.Controls.Add(this.speed1);
      this.Controls.Add(this.speedClassic);
      this.Controls.Add(this.lscore2);
      this.Controls.Add(this.lscore1);
      this.Controls.Add(this.gameover);
      this.Controls.Add(this.gameoverscore);
      this.Controls.Add(this.menuB);
      this.Controls.Add(this.wall2);
      this.Controls.Add(this.wall1);
      this.Controls.Add(this.labelscore);
      this.Controls.Add(this.playB);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pause);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Game";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pudding Snake ";
      ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton speed1;
    private System.Windows.Forms.RadioButton speed2;
    private System.Windows.Forms.RadioButton speed3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button playB;
    private System.Windows.Forms.PictureBox wall1;
    private System.Windows.Forms.PictureBox wall2;
    private System.Windows.Forms.Label gameoverscore;
    private System.Windows.Forms.PictureBox gameover;
    private System.Windows.Forms.Label lscore1;
    private System.Windows.Forms.Label lscore2;
    private System.Windows.Forms.RadioButton speedClassic;
    public System.Windows.Forms.Label labelscore;
    public System.Windows.Forms.Button menuB;
    public System.Windows.Forms.PictureBox pause;
    public System.Windows.Forms.Timer timer1;
    public System.Windows.Forms.Label labelbestscore;
  }
}

