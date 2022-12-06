using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{

    public class Bricks : Actor
    {
      private List<Actor> _segments = new List<Actor>();
      private string _brick;
      
      public Bricks(int x, int y)
      {
        SetImage(Constants.IMAGE_BRICK);
        SetHeight(Constants.BRICK_HEIGHT);
        SetWidth(Constants.BRICK_WIDTH);

        int _x = x;
        int _y = y;
        Point position1 = new Point(_x, _y);
        SetPosition(position1);

        SetVelocity(new Point(0, 0));
      }

      public string getBrick()
      {
        return _brick;
      }

      public void setBrick(string brick)
      {
        _brick = brick;
      }



       
    }
}