using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
  public partial class Game : Form
  {
    public int width = 750;
    public int height = 490;
    public int pboxsize = 45;
    private int speed = 250;
    private bool fl_speed = true;
    private int bscore;

    private Snake Snake_;
    private Fruits Fruits_;
    private Control Control_;

    public Game()
    {
      InitializeComponent();

      Fruits_ = new Fruits(this);
      Snake_ = new Snake(this,Fruits_);
      Control_ = new Control(this,Snake_);
      Fruits_.Snake_ = Snake_;

      KeyDown += Control_.Control_;
    }

    private void Update(object sender, EventArgs e)
    {
      Snake_.MoveSnake();
      Snake_.SnakeEatsFruit();
    }

    private void NewGame()
    {
      this.BackgroundImage = null;
      wall1.Visible = true;
      wall2.Visible = true;
      labelscore.Visible = true;
      labelscore.Text += Snake_.score;
      labelbestscore.Visible = true;
      labelbestscore.Text += bscore;
      lscore1.Visible = true;
      lscore2.Visible = true;
      playB.Visible = false;
      label1.Visible = false;
      speedClassic.Visible = false;
      speed1.Visible = false;
      speed2.Visible = false;
      speed3.Visible = false;
      playB.Enabled = false;
      label1.Enabled = false;
      speedClassic.Enabled = false;
      speed1.Enabled = false;
      speed2.Enabled = false;
      speed3.Enabled = false;
      if (fl_speed==true) speed = 250;
      timer1.Tick += Update;
      timer1.Interval = speed;
      timer1.Start();
      Bestscore();
    }

    private void RNewGame()
    {
      this.BackgroundImage = System.Drawing.Image.FromFile("../../Resources/background1.png");
      menuB.Visible = false;
      playB.Visible = true;
      label1.Visible = true;
      speedClassic.Visible = true;
      speed1.Visible = true;
      speed2.Visible = true;
      speed3.Visible = true;
      playB.Enabled = true;
      label1.Enabled = true;
      speedClassic.Enabled = true;
      speed1.Enabled = true;
      speed2.Enabled = true;
      speed3.Enabled = true;
      gameoverscore.Visible = false;
      gameover.Visible = false;
      timer1.Tick -= Update;
      Snake_.dirX = 1;
      Snake_.dirY = 0;
      Snake_.score = 0;
      timer1.Stop();
    }

    public void Clear()
    {
      for (int i = Snake_.score; i >= 0; i--)
      {
        Controls.Remove(Snake_.snake_elems[i]);
      }
      Controls.Remove(Fruits_.fruit);
      Controls.Remove(Fruits_.bonus_fruit);
      wall1.Visible = false;
      wall2.Visible = false;
      menuB.Visible = true;
      labelscore.Visible = false;
      labelscore.Text = "Ваш \nсчет:\n";
      labelbestscore.Visible = false;
      lscore1.Visible = false;
      lscore2.Visible = false;
      if (Snake_.score >= bscore)
      {
        Bestscore();
        gameoverscore.Text = $"Ваш результат: {Snake_.score}\n   Новый рекорд! ";
      }
      else gameoverscore.Text = $"Ваш результат: {Snake_.score}";
      gameoverscore.Visible = true;
      gameover.Visible = true;
    }

    private void Bestscore()
    {
      FileStream file_score = new FileStream("../../Resources/best_score.txt", FileMode.Open);
      StreamReader reader = new StreamReader(file_score);
      string buf = reader.ReadToEnd();
      reader.Close();
      bscore = Convert.ToInt32(buf);
      if (Snake_.score > bscore)
      {
        bscore = Snake_.score;
        File.WriteAllText("../../Resources/best_score.txt", Convert.ToString(bscore));
      }
      labelbestscore.Text = $"Лучший \nсчет:\n{bscore}";
    }

    private void playB_Click(object sender, EventArgs e)
    {
      NewGame();
      Snake_.DrawSnake();
      Fruits_.GenerateRandomFruit();
    }

    private void menuB_Click(object sender, EventArgs e)
    {
      RNewGame();
    }

    private void speedClassic_CheckedChanged(object sender, EventArgs e)
    {
      speed = 250;
      fl_speed = true;
    }

    public void PlusSpeed()
    {
      if (fl_speed == true)
      {
        if (Snake_.score % 5 == 0)
        {
          speed -= 10;
          timer1.Interval = speed;
        }
        else if (Snake_.score >= 80)
        {
          speed = 100;
          timer1.Interval = speed;
        }
      }
    }

    private void speed1_CheckedChanged(object sender, EventArgs e)
    {
      speed = 300;
      fl_speed = false;
    }

    private void speed2_CheckedChanged(object sender, EventArgs e)
    {
      speed = 200;
      fl_speed = false;
    }

    private void speed3_CheckedChanged(object sender, EventArgs e)
    {
      speed = 100;
      fl_speed = false;
    }
  }
}