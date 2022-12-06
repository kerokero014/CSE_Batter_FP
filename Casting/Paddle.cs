using System;

namespace cse210_batter_csharp.Casting
{
    public class Paddle : Actor
    {
        public Paddle(int x, int y)
        {
            SetImage(Constants.IMAGE_PADDLE);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.PADDLE_WIDTH);
            SetHeight(Constants.PADDLE_HEIGHT);
        }
    }
}