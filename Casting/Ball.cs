using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    public class Ball : Actor
    {
       public Ball(int x, int y)
        {
            SetImage(Constants.IMAGE_BALL);
            SetHeight(Constants.BALL_HEIGHT);
            SetWidth(Constants.BALL_WIDTH);

            int _x = x;
            int _y = y;
            Point position = new Point(_x, _y);
            SetPosition(position);
            

            SetVelocity(new Point(5, 5));
        }
       
    }
}