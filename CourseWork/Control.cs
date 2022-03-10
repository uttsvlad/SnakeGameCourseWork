using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
  class Control
  {
    private int esc_count = 0;
    private bool fl_esc = true;

    private Game Game_;
    private Snake Snake_;

    public Control(Game game, Snake snake)
    {
      Game_ = game;
      Snake_ = snake;
    }

    public void Control_(object sender, KeyEventArgs e)
    {
      e.SuppressKeyPress = true; //Убирает звук ding при нажатии клавиш WSAD
      switch (e.KeyCode.ToString())
      {
        case "Up":
          if (fl_esc == true)
          {
            if (Snake_.dirY == 1) break;
            else
            {
              if (Snake_.dirX == 1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == -1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirY = -1;
              Snake_.dirX = 0;
            }
          }
          break;
        case "Down":
          if (fl_esc == true)
          {
            if (Snake_.dirY == -1) break;
            else
            {
              if (Snake_.dirX == -1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirY = 1;
              Snake_.dirX = 0;
            }
          }
          break;
        case "Left":
          if (fl_esc == true)
          {
            if (Snake_.dirX == 1) break;
            else
            {
              if (Snake_.dirX == 0 && Snake_.dirY == -1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 0 && Snake_.dirY == 1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirX = -1;
              Snake_.dirY = 0;
            }
          }
          break;
        case "Right":
          if (fl_esc == true)
          {
            if (Snake_.dirX == -1) break;
            else
            {
              if (Snake_.dirX == 0 && Snake_.dirY == 1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 0 && Snake_.dirY == -1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirX = 1;
              Snake_.dirY = 0;
            }
          }
          break;
        case "W":
          if (fl_esc == true)
          {
            if (Snake_.dirY == 1) break;
            else
            {
              if (Snake_.dirX == 1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == -1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirY = -1;
              Snake_.dirX = 0;
            }
          }
          break;
        case "S":
          if (fl_esc == true)
          {
            if (Snake_.dirY == -1) break;
            else
            {
              if (Snake_.dirX == -1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 1 && Snake_.dirY == 0)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirY = 1;
              Snake_.dirX = 0;
            }
          }
          break;
        case "A":
          if (fl_esc == true)
          {
            if (Snake_.dirX == 1) break;
            else
            {
              if (Snake_.dirX == 0 && Snake_.dirY == -1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 0 && Snake_.dirY == 1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirX = -1;
              Snake_.dirY = 0;
            }
          }
          break;
        case "D":
          if (fl_esc == true)
          {
            if (Snake_.dirX == -1) break;
            else
            {
              if (Snake_.dirX == 0 && Snake_.dirY == 1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              if (Snake_.dirX == 0 && Snake_.dirY == -1)
              {
                Snake_.snake_elems[0].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Snake_.snake_elems[0].Refresh();
              }
              Snake_.dirX = 1;
              Snake_.dirY = 0;
            }
          }
          break;
        case "Escape":
          if (Game_.menuB.Visible == true)
          {
            break;
          }
          else
          {
            esc_count++;
            if (esc_count % 2 == 0)
            {
              Game_.timer1.Stop();
              Game_.pause.Visible = true;
              fl_esc = false;
            }
            else
            {
              Game_.timer1.Start();
              Game_.pause.Visible = false;
              fl_esc = true;
            }
          }
          break;
      }
    }
  }
}
