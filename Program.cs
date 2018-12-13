using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.SetWindowSize(80, 25);
      Console.SetBufferSize(80, 25);

      // Отрисовка рамочки
      HorisontalLine topline = new HorisontalLine(0, 78, 0, '+');
      HorisontalLine bottomline = new HorisontalLine(0, 78, 24, '+');
      VerticalLine leftline = new VerticalLine(1, 23, 0, '+');
      VerticalLine rightline = new VerticalLine(1, 24, 78, '+');
      leftline.Draw();
      rightline.Draw();
      topline.Draw();
      bottomline.Draw();

      //Отрисовка точки
      Point p = new Point(4, 5, '*');
      Snake snake = new Snake(p, 4, Direction.RIGTH);
      snake.Draw();

      Console.ReadLine();
    }
  }
}
