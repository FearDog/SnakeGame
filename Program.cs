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
      Point p1 = new Point(1, 2, '*');
      p1.Draw();

      Point p2 = new Point(4, 5, '#');
      p2.Draw();

      HorisontalLine hline = new HorisontalLine(5, 10, 8, '+');
      hline.Draw();

      VerticalLine vline = new VerticalLine(1, 7, 10, '+');
      vline.Draw();

      Console.ReadLine();
    }
  }
}
