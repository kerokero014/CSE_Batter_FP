using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public class Paddle : Actor
    {
       public Paddle(int x, int y)
       {
         SetImage("./Assets/bat.png");
         SetHeight(Constants.PADDLE_HEIGHT);
         SetWidth(Constants.PADDLE_WIDTH);

        int _x = x;
        int _y = y;
        Point position = new Point(_x, _y);
        SetPosition(position);

        SetVelocity(new Point(0, 0));

       }
    }
}