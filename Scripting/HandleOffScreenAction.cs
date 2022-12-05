using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
      PhysicsService _pysicsService = new PhysicsService();
      Point _velocity;
      int ballRadius = Constants.BALL_WIDTH / 2;
         public HandleOffScreenAction(PhysicsService physicsService)
        {
          _pysicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
               Actor _ball = cast["balls"][0];
               HandleDirectionActor(_ball);
               
        }
        
        private void HandleDirectionActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();
         
            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            if(x <= 0 || x >= Constants.MAX_X)
            {  
              dx = -dx;
            
            }

            if(y <= 0 || y >= Constants.MAX_Y)
            {
              dy = -dy;

            }

            int newX = (x + dx);
            int newY = (y + dy);

            actor.SetVelocity(new Point(dx, dy));
            actor.SetPosition(new Point(newX, newY));
        }

        

    }
}