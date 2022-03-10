using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CourseWork
{
  class Snake
  {
    public int dirX = 1;
    public int dirY = 0;
    public PictureBox[] snake_elems = new PictureBox[151];
    public int score = 0;

    private Game Game_;
    private Fruits Fruits_;

    public Snake(Game game,Fruits fruits)
    {
      Game_ = game;
      Fruits_ = fruits;
    }

    public void DrawSnake()
    {
      snake_elems[0] = new PictureBox();
      snake_elems[0].Location = new Point(0, 0);
      snake_elems[0].Image = System.Drawing.Image.FromFile("../../Resources/snakehead.png");
      snake_elems[0].Size = new Size(Game_.pboxsize, Game_.pboxsize);
      Game_.Controls.Add(snake_elems[0]);
      snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
      snake_elems[0].Refresh();
    }

    public void MoveSnake()
    {
      for (int i = score; i >= 1; i--)
      {
        snake_elems[i].Location = snake_elems[i - 1].Location;
      }
      snake_elems[0].Location = new Point(snake_elems[0].Location.X + dirX * (Game_.pboxsize),
                                          snake_elems[0].Location.Y + dirY * (Game_.pboxsize));
      EatBorder_or_EatSelf();
    }

    public void SnakeEatsFruit()
    {
      if (Fruits_.fl_bonus==true)
      {
        if (snake_elems[0].Location == Fruits_.bonus_fruit.Location)
        {
          int i = 0;
          while (i < 3)
          {
            Game_.labelscore.Text = "Ваш \nсчет:\n" + ++score;
            snake_elems[score] = new PictureBox();
            snake_elems[score].Location = new Point(snake_elems[score - 1].Location.X - Game_.pboxsize * dirX,
                                                    snake_elems[score - 1].Location.Y - Game_.pboxsize * dirY);
            snake_elems[score].Size = new Size(Game_.pboxsize, Game_.pboxsize);
            snake_elems[score].Image = System.Drawing.Image.FromFile("../../Resources/snakebody5.png");
            Game_.Controls.Add(snake_elems[score]);
            i++;
          }
          Game_.Controls.Remove(Fruits_.bonus_fruit);
          Game_.Controls.Remove(Fruits_.fruit);
          Game_.PlusSpeed();
          Fruits_.GenerateRandomFruit();
        }
        else if (snake_elems[0].Location == Fruits_.fruit.Location)
        {
          Game_.labelscore.Text = "Ваш \nсчет:\n" + ++score;
          snake_elems[score] = new PictureBox();
          snake_elems[score].Location = new Point(snake_elems[score - 1].Location.X - Game_.pboxsize * dirX,
                                                  snake_elems[score - 1].Location.Y - Game_.pboxsize * dirY);
          snake_elems[score].Size = new Size(Game_.pboxsize, Game_.pboxsize);
          snake_elems[score].Image = System.Drawing.Image.FromFile("../../Resources/snakebody5.png");
          Game_.Controls.Add(snake_elems[score]);
          Game_.Controls.Remove(Fruits_.bonus_fruit);
          Game_.PlusSpeed();
          Fruits_.GenerateRandomFruit();
        }
      }
      else if (snake_elems[0].Location == Fruits_.fruit.Location)
      {
        Game_.labelscore.Text = "Ваш \nсчет:\n" + ++score;
        snake_elems[score] = new PictureBox();
        snake_elems[score].Location = new Point(snake_elems[score - 1].Location.X - Game_.pboxsize * dirX,
                                                snake_elems[score - 1].Location.Y - Game_.pboxsize * dirY);
        snake_elems[score].Size = new Size(Game_.pboxsize, Game_.pboxsize);
        snake_elems[score].Image = System.Drawing.Image.FromFile("../../Resources/snakebody5.png");
        Game_.Controls.Add(snake_elems[score]);
        Game_.PlusSpeed();
        Fruits_.GenerateRandomFruit();
      }
    }

    private void EatBorder_or_EatSelf()
    {
      if ((snake_elems[0].Location.X < 0) || (snake_elems[0].Location.X > Game_.width - 2 * Game_.pboxsize) ||
          (snake_elems[0].Location.Y < 0) || (snake_elems[0].Location.Y > Game_.height - Game_.pboxsize))
        Game_.Clear();
      for (int i = 1; i <= score; i++)
      {
        if (snake_elems[0].Location == snake_elems[i].Location)
          Game_.Clear();
      }
    }
  }
}
