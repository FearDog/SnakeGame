using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
  class Walls
  {
    List<Figure> wallList;

    public Walls(int mapWidth, int mapHeight)
    {
      wallList = new List<Figure>();

      // Отрисовка рамочки
      HorisontalLine topline = new HorisontalLine(0, mapWidth - 2, 0, '+');
      HorisontalLine bottomline = new HorisontalLine(0, mapWidth - 2, mapHeight - 1, '+');
      VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, '+');
      VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

      wallList.Add(leftline);
      wallList.Add(rightline);
      wallList.Add(topline);
      wallList.Add(bottomline);
    }

    internal bool IsHit(Figure figure)
    {
      foreach (var wall in wallList)
      {
        if(wall.IsHit(figure))
        {
          return true;
        }
      }
      return false;
    }

    public void Draw()
    {
      foreach(var wall in wallList)
      {
        wall.Draw();
      }
    }
  }
}
