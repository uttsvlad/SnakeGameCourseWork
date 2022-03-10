using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
  class Fruits
  {
    public Random r = new Random();
    public int frX, frY;
    public bool fl_bonus;
    private int tempX;
    private int tempY;

    private Game Game_;
    public Snake Snake_;
    public PictureBox fruit;
    public PictureBox bonus_fruit;

    public Fruits(Game game)
    {
      Game_ = game;
      fruit = new PictureBox();
      fruit.Size = new Size(Game_.pboxsize, Game_.pboxsize);
      bonus_fruit = new PictureBox();
      bonus_fruit.Size = new Size(Game_.pboxsize, Game_.pboxsize);
    }

    public void GenerateRandomFruit()
    {
      int fr = r.Next(0, 11);
      int bfr = r.Next(0, 10);
      fl_bonus = false;
      switch (fr)
      {
        case 0:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/banana.png");
          break;
        case 1:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/cocount.png");
          break;
        case 2:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/grape.png");
          break;
        case 3:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/lemon.png");
          break;
        case 4:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/mango.png");
          break;
        case 5:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/orange.png");
          break;
        case 6:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/peach.png");
          break;
        case 7:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/plum.png");
          break;
        case 8:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/raspberry.png");
          break;
        case 9:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/strawberry.png");
          break;
        case 10:
          bonus_fruit.Image = System.Drawing.Image.FromFile("../../Resources/bananaBonus.png");
          switch (bfr)
          {
            case 0:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/banana.png");
              break;
            case 1:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/cocount.png");
              break;
            case 2:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/grape.png");
              break;
            case 3:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/lemon.png");
              break;
            case 4:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/mango.png");
              break;
            case 5:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/orange.png");
              break;
            case 6:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/peach.png");
              break;
            case 7:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/plum.png");
              break;
            case 8:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/raspberry.png");
              break;
            case 9:
              fruit.Image = System.Drawing.Image.FromFile("../../Resources/strawberry.png");
              break;
          }
          fl_bonus = true;
          break;
        default:
          fruit.Image = System.Drawing.Image.FromFile("../../Resources/cocount.png");
          break;
      }

      if (fl_bonus == true)
      {
        frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
        tempX = frX % Game_.pboxsize;
        frX -= tempX;
        frY = r.Next(0, Game_.height - Game_.pboxsize);
        tempY = frY % Game_.pboxsize;
        frY -= tempY;
        fruit.Location = new Point(frX, frY);
        M: for (int i = Snake_.score; i >= 0; i--)
        {
          if (Snake_.snake_elems[i].Location.X == frX && Snake_.snake_elems[i].Location.Y == frY)
          {
            frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
            tempX = frX % Game_.pboxsize;
            frX -= tempX;
            frY = r.Next(0, Game_.height - Game_.pboxsize);
            tempY = frY % Game_.pboxsize;
            frY -= tempY;
            fruit.Location = new Point(frX, frY);
            goto M;
          }
        }
        Game_.Controls.Add(fruit);

        frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
        tempX = frX % Game_.pboxsize;
        frX -= tempX;
        frY = r.Next(0, Game_.height - Game_.pboxsize);
        tempY = frY % Game_.pboxsize;
        frY -= tempY;
        bonus_fruit.Location = new Point(frX, frY);
        N: for (int i = Snake_.score; i >= 0; i--)
        {
          if (Snake_.snake_elems[i].Location.X == frX && Snake_.snake_elems[i].Location.Y == frY)
          {
            frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
            tempX = frX % Game_.pboxsize;
            frX -= tempX;
            frY = r.Next(0, Game_.height - Game_.pboxsize);
            tempY = frY % Game_.pboxsize;
            frY -= tempY;
            bonus_fruit.Location = new Point(frX, frY);
            goto N;
          }
        }
        Game_.Controls.Add(bonus_fruit);
      }
      else
      {
        frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
        int tempX = frX % Game_.pboxsize;
        frX -= tempX;
        frY = r.Next(0, Game_.height - Game_.pboxsize);
        int tempY = frY % Game_.pboxsize;
        frY -= tempY;
        fruit.Location = new Point(frX, frY);
        M: for (int i = Snake_.score; i >= 0; i--)
        {
          if (Snake_.snake_elems[i].Location.X == frX && Snake_.snake_elems[i].Location.Y == frY)
          {
            frX = r.Next(0, Game_.width - (Game_.pboxsize * 2));
            tempX = frX % Game_.pboxsize;
            frX -= tempX;
            frY = r.Next(0, Game_.height - Game_.pboxsize);
            tempY = frY % Game_.pboxsize;
            frY -= tempY;
            fruit.Location = new Point(frX, frY);
            goto M;
          }
        }
        Game_.Controls.Add(fruit);
      }
    }
  }
}
